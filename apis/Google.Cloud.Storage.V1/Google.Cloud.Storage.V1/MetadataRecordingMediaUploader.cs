// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Download;
using Google.Apis.Services;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Requests.BatchRequest;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// CustomMediaUpload subclass which populates an <see cref="Apis.Storage.v1.Data.Object"/> instance
/// from the headers it sees on a successful response. Note: if this ever becomes public,
/// we should put more effort into naming it carefully.
/// </summary>
internal class ContentMetadataRecordingMediaUploader : CustomMediaUpload
{
    private const string ETagHeader = "ETag";
    private const string GenerationHeader = "X-Goog-Generation";
    private const string MetagenerationHeader = "X-Goog-Metageneration";
    private const string HashHeader = "X-Goog-Hash";
    private const string ContentTypeHeader = "Content-Type";

    // The hashes are comma-separated...
    private static readonly char[] HashToElementSplitter = new[] { ',' };
    // ... and each hash is a key=value pair
    private static readonly char[] HashKeyValueSplitter = new[] { '=' };
    private readonly HttpResponseMessage _response = new HttpResponseMessage();

    /// <summary>Constructs a new uploader with the given client service.</summary>
    /// <param name="stream"></param>
    /// <param name="contentType"></param>
    /// <param name="service">The client service.</param>
    /// <param name="body"></param>
    /// <param name="bucket"></param>

    internal ContentMetadataRecordingMediaUploader(IClientService service, Apis.Storage.v1.Data.Object body, string bucket,
            Stream stream, string contentType)
            : base(service, body, bucket, stream, contentType)
    {
        Body = body;
        ProcessMetadataHeaders(_response.Headers, _response.Content.Headers);
    }


        private void ProcessMetadataHeaders(HttpResponseHeaders headers, HttpContentHeaders contentHeaders)
    {
        Body.Generation = MaybeParse(GetFirstHeaderOrNull(GenerationHeader));
        Body.Metageneration = MaybeParse(GetFirstHeaderOrNull(MetagenerationHeader));
        Body.ETag = GetFirstHeaderOrNull(ETagHeader);
        var hashes = GetFirstHeaderOrNull(HashHeader) ?? "";
        // The hash header returns multiple comma-separated hashes.
        var hashesByKey = hashes.Split(HashToElementSplitter)
            .Where(hash => hash.Contains('='))
            .Select(hash => hash.Split(HashKeyValueSplitter, 2))
            .ToDictionary(bits => bits[0], bits => bits[1]);
        Body.Crc32c = hashesByKey.TryGetValue("crc32c", out string crc32c) ? crc32c : null;
        Body.Md5Hash = hashesByKey.TryGetValue("md5", out string md5) ? md5 : null;
        Body.ContentType = contentHeaders.ContentType?.ToString();

        string GetFirstHeaderOrNull(string headerName) =>
            headers.TryGetValues(headerName, out var values) ? values.FirstOrDefault() : null;

        long? MaybeParse(string text) =>
            text is null || !long.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out var value)
            ? (long?) null
            : value;
    }
}
