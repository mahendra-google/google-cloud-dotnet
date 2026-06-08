// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.ObjectsResource;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Upload subclass which allows us to modify headers, for customer-supplied encryption keys.
    /// </summary>
    internal sealed class CustomMediaUpload : InsertMediaUpload
    {
        private readonly HashingStream _hashingStream;
        private const string GoogleHashHeader = "x-goog-hash";
        private readonly CustomMediaUpload _mediaUpload;
        public CustomMediaUpload(IClientService service, Apis.Storage.v1.Data.Object body, string bucket,
            Stream stream, string contentType, UploadObjectOptions options)
            : base(service, body, bucket, options?.UploadValidationMode != UploadValidationMode.None ? new HashingStream(stream) : stream, contentType)
        {
            var validationMode = options?.UploadValidationMode ?? UploadObjectOptions.DefaultValidationMode;
            if (validationMode != UploadValidationMode.None)
            {
                _hashingStream = ContentStream as HashingStream;
                var calculatedHash = _hashingStream.GetBase64Hash();
                this.LastRequestExecuting += OnLastRequestExecuting;

            }
        }

        internal new ResumableUploadOptions Options => base.Options;

        private void OnLastRequestExecuting(HttpRequestMessage request)
        {
            var calculatedHash = _hashingStream.GetBase64Hash();
            if (!request.Headers.Contains("x-goog-hash"))
            {
                request.Headers.Add(GoogleHashHeader, $"crc32c={calculatedHash}");
            }
        }

        internal sealed class HashingStream : Stream
        {
            private readonly Stream _stream;
            private readonly Crc32c _hasher;
            private long _maxPositionHashed = 0;

            public HashingStream(Stream stream)
            {
                _stream = stream;
                _hasher = new Crc32c();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                long startingPos = _stream.Position;
                int bytesRead = _stream.Read(buffer, offset, count);
                ProcessBytes(buffer, offset, bytesRead, startingPos);
                return bytesRead;
            }

            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                long startingPos = _stream.Position;
                int bytesRead = await _stream.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                ProcessBytes(buffer, offset, bytesRead, startingPos);
                return bytesRead;
            }

            private void ProcessBytes(byte[] buffer, int offset, int bytesRead, long startingPos)
            {
                if (bytesRead <= 0) return;

                // Only hash bytes that are beyond the furthest point we've already hashed.
                // This handles the rewind and re-read scenario during retries.
                if (startingPos + bytesRead > _maxPositionHashed)
                {
                    long newBytesStart = Math.Max(startingPos, _maxPositionHashed);
                    int actuallyNewCount = (int) ((startingPos + bytesRead) - newBytesStart);
                    int bufferOffset = offset + (int) (newBytesStart - startingPos);

                    _hasher.UpdateHash(buffer, bufferOffset, actuallyNewCount);
                    _maxPositionHashed = startingPos + bytesRead;
                }
            }

            public override long Position
            {
                get => _stream.Position;
                set => _stream.Position = value;
            }

            public override long Seek(long offset, SeekOrigin origin) => _stream.Seek(offset, origin);
            public string GetBase64Hash() => Convert.ToBase64String(_hasher.GetHash());
            public override bool CanRead => _stream.CanRead;
            public override bool CanSeek => _stream.CanSeek;
            public override bool CanWrite => _stream.CanWrite;
            public override long Length => _stream.Length;
            public override void Flush() => _stream.Flush();
            public override void SetLength(long value) => _stream.SetLength(value);
            public override void Write(byte[] buffer, int offset, int count) => _stream.Write(buffer, offset, count);
        }
    }
}
