// Copyright 2025 Google Inc. All Rights Reserved.
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

using Google.Apis.Download;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Subclass of <see cref="MediaDownloader"/> which (potentially) validates the data it receives
    /// against a CRC32c hash set in the header.
    /// </summary>
    internal sealed class HashValidatingUploader : ContentMetadataRecordingMediaUploader
    {
        internal const string StoredContentEncodingHeaderName = "x-goog-hash";

        private readonly UploadValidationMode _mode;

        public System.Func<HttpResponseMessage, StreamInterceptor> ResponseStreamInterceptorProvider { get; }

        private string _crc32cHashBase64;
        private Crc32c _hasher;

        /// <summary>Constructs a new uploader with the given client service.</summary>
        internal HashValidatingUploader(IClientService service, Object body, string bucket,
            Stream stream, string contentType, UploadValidationMode mode)
            : base(service, body, bucket, stream, contentType)
        {
            _mode = mode;
            ResponseStreamInterceptorProvider = CreateInterceptor;
        }

        private StreamInterceptor CreateInterceptor(HttpResponseMessage response)
        {
            _crc32cHashBase64 = null;
            _hasher = null;

            switch (_mode)
            {
                case UploadValidationMode.ThrowOnly:
                    return PrepareForHashing();
                case UploadValidationMode.None:
                    return null;
                case UploadValidationMode.DeleteAndThrow:
                    bool decompressedByServer =
                        response.Headers.TryGetValues(StoredContentEncodingHeaderName, out var storedContentEncoding) &&
                        storedContentEncoding.FirstOrDefault() == "gzip" &&
                        response.Content?.Headers?.ContentEncoding?.FirstOrDefault() != "gzip";
                    return decompressedByServer ? null : PrepareForHashing();
                default:
                    return null;
            }

            StreamInterceptor PrepareForHashing()
            {
                IEnumerable<string> values;
                if (response.Headers.TryGetValues(Crc32c.HashHeaderName, out values))
                {
                    string prefix = Crc32c.HashName + "=";
                    foreach (var value in values.SelectMany(v => v.Split(',')))
                    {
                        if (value.StartsWith(prefix))
                        {
                            _hasher = new Crc32c();
                            _crc32cHashBase64 = value.Substring(prefix.Length);
                            return _hasher.UpdateHash;
                        }
                    }
                }
                // The mode indicates that we'd like to validate the hash, but we don't have one to validate.
                // (We could potentially have a mode of "fail if there isn't a hash to validate", in the future,
                // but for the moment we just ignore it.)
                return null;
            }
        }

        //protected override void Upload()
        //{
        //    base.Upload();

        //    if (_crc32cHashBase64 != null)
        //    {
        //        string actualHash = System.Convert.ToBase64String(_hasher.GetHash());
        //        if (actualHash != _crc32cHashBase64)
        //        {
        //            throw new IOException($"Incorrect hash: expected '{_crc32cHashBase64}' (base64), was '{actualHash}' (base64)");
        //        }
        //    }
        //}
    }
}
