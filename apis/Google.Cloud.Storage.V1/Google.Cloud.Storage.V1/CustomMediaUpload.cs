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
        private readonly Crc32cHashInterceptor _interceptor;
        private readonly IClientService _service;
        private readonly HashingStream _hashingStream;

        public CustomMediaUpload(IClientService service, Apis.Storage.v1.Data.Object body, string bucket,
            Stream stream, string contentType, UploadObjectOptions options)
            : base(service, body, bucket, new HashingStream(stream), contentType)
        {
            _service = service;
            var validationMode = options?.UploadValidationMode ?? UploadObjectOptions.DefaultValidationMode;
            _hashingStream = (HashingStream) ContentStream;
            _interceptor = new Crc32cHashInterceptor(this, _hashingStream, _service, validationMode);
            _service?.HttpClient?.MessageHandler?.AddExecuteInterceptor(_interceptor);
        }

        internal new ResumableUploadOptions Options => base.Options;

        private sealed class Crc32cHashInterceptor : IHttpExecuteInterceptor
        {
            private const string GoogleHashHeader = "x-goog-hash";
            private readonly IClientService _service;
            private readonly CustomMediaUpload _mediaUpload;
            private Uri _uploadUri;
            private readonly UploadValidationMode _validationMode;
            private readonly HashingStream _hashingStream;

            public Crc32cHashInterceptor(CustomMediaUpload mediaUpload, HashingStream hashingStream, IClientService service, UploadValidationMode validationMode)
            {
                _hashingStream = hashingStream;
                _service = service;
                _mediaUpload = mediaUpload;
                _validationMode = validationMode;
                _mediaUpload.UploadSessionData += OnSessionData;
                _mediaUpload.ProgressChanged += OnProgressChanged;
            }

            public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (_uploadUri != null && !_uploadUri.Equals(request.RequestUri))
                {
                    return Task.CompletedTask;
                }

                if (request.Method == System.Net.Http.HttpMethod.Put && request.Content?.Headers.Contains("Content-Range") is true)
                {
                    var rangeHeader = request.Content.Headers.GetValues("Content-Range").First();

                    if (IsFinalChunk(rangeHeader))
                    {
                        if (_validationMode != UploadValidationMode.None)
                        {
                            var calculatedHash = _hashingStream.GetBase64Hash();
                            request.Headers.TryAddWithoutValidation(GoogleHashHeader, $"crc32c={calculatedHash}");
                        }                      
                    }
                }
                return Task.CompletedTask;
            }

            private void OnSessionData(IUploadSessionData data)
            {
                _uploadUri = data.UploadUri;
                _mediaUpload.UploadSessionData -= OnSessionData;
            }

            private void OnProgressChanged(IUploadProgress progress)
            {
                if (progress.Status is UploadStatus.Completed or UploadStatus.Failed)
                {
                    // Clean up when upload is finished.
                    _service?.HttpClient?.MessageHandler?.RemoveExecuteInterceptor(this);
                    _mediaUpload.ProgressChanged -= OnProgressChanged;
                }
            }

            private bool IsFinalChunk(string rangeHeader)
            {
                // Expected format: "bytes {start}-{end}/{total}" or "bytes */{total}" for the final request.
                // We are interested in the final chunk of a known-size upload.
                const string prefix = "bytes ";
                if (!rangeHeader.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                ReadOnlySpan<char> span = rangeHeader.AsSpan(prefix.Length);
                int slashIndex = span.IndexOf('/');
                if (slashIndex == -1)
                {
                    return false;
                }

                var totalSpan = span.Slice(slashIndex + 1);
                if (totalSpan.IsEmpty || totalSpan[0] == '*')
                {
                    return false;
                }

                if (!long.TryParse(totalSpan.ToString(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out long totalSize))
                {
                    return false;
                }

                var rangeSpan = span.Slice(0, slashIndex);
                int dashIndex = rangeSpan.IndexOf('-');
                if (dashIndex == -1)
                {
                    return false;
                }

                var endByteSpan = rangeSpan.Slice(dashIndex + 1);
                if (!long.TryParse(endByteSpan.ToString(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out long endByte))
                {
                    return false;
                }

                // If endByte is the last byte of the file, it's the final chunk.
                return (endByte + 1) == totalSize;
            }
        }

        private sealed class HashingStream : Stream
        {
            private readonly Stream _stream;
            private readonly Crc32c _hasher = new();

            public HashingStream(Stream stream) => _stream = stream;

            public override int Read(byte[] buffer, int offset, int count)
            {
                int bytesRead = _stream.Read(buffer, offset, count);
                if (bytesRead > 0)
                {
                    _hasher.UpdateHash(buffer, offset, bytesRead);
                }
                return bytesRead;
            }

            public string GetBase64Hash() => Convert.ToBase64String(_hasher.GetHash());
            public override bool CanRead => _stream.CanRead;
            public override bool CanSeek => _stream.CanSeek;
            public override bool CanWrite => _stream.CanWrite;
            public override long Length => _stream.Length;
            public override long Position { get => _stream.Position; set => _stream.Position = value; }
            public override void Flush() => _stream.Flush();
            public override long Seek(long offset, SeekOrigin origin) => _stream.Seek(offset, origin);
            public override void SetLength(long value) => _stream.SetLength(value);
            public override void Write(byte[] buffer, int offset, int count) => _stream.Write(buffer, offset, count);
        }
    }
}
