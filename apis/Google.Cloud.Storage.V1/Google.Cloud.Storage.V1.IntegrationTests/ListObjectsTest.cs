// Copyright 2015 Google Inc. All Rights Reserved.
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

using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class ListObjectsTest
    {
        private readonly StorageFixture _fixture;

        public ListObjectsTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(null)]
        [InlineData(4)]
        public async Task AllObjects(int? pageSize)
        {
            var options = new ListObjectsOptions { PageSize = pageSize };
            await AssertObjects(null, options, _fixture.ReadBucketObjects.ToArray());
        }

        [Fact]
        public void ResumeWithPageToken()
        {
            string bucket = _fixture.ReadBucket;
            var client = _fixture.Client;
            var totalCount = _fixture.ReadBucketObjects.Count();
            // We want to check that when reading the remained, we still need to paginate.
            // (If we had a bug that always used the original page token, we'd end up in an infinite loop.)
            Assert.True(totalCount > 4, "Must have more than 4 objects for pagination test");
            var firstPage = client.ListObjects(bucket).ReadPage(2);
            Assert.NotNull(firstPage.NextPageToken);

            var options = new ListObjectsOptions { PageSize = 2, PageToken = firstPage.NextPageToken };
            var remainder = client.ListObjects(bucket, prefix: null, options).ToList();
            Assert.Equal(totalCount - 2, remainder.Count);
        }

        // Note: this test unfortunately relies on the test data, but in a way which is hard to make "safe"
        // using the fixture.
        [Theory]
        [InlineData(null, "small.txt,large.txt,small_then_large.txt")]
        [InlineData("la", "large.txt")]
        [InlineData("a/", "a/o1.txt,a/o2.txt")]
        [InlineData("a/x/", "a/x/o3.txt,a/x/o4.txt")]
        [InlineData("missing/", "")]
        public async Task PrefixAndDelimiter(string prefix, string expectedNames)
        {
            var options = new ListObjectsOptions { Delimiter = "/" };
            await AssertObjects(prefix, options, expectedNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }

        [Theory]
        [InlineData("la*", "large.txt")]
        [InlineData("a/*.txt", "a/o1.txt", "a/o2.txt")]
        [InlineData("a/x/*.txt", "a/x/o3.txt", "a/x/o4.txt")]
        public void MatchGlob(string globPattern, params string[] expectedNames)
        {
            var options = new ListObjectsOptions { MatchGlob = globPattern };
            IEnumerable<Object> actual = _fixture.Client.ListObjects(_fixture.ReadBucket, prefix: null, options);
            AssertObjectNames(actual, expectedNames);
        }

        [Fact]
        public async Task CancellationTokenRespected()
        {
            var cts = new CancellationTokenSource();
            var task = _fixture.Client.ListObjectsAsync(_fixture.ReadBucket, null).ToListAsync(cts.Token);
            cts.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(task.AsTask);
        }

        [Fact]
        public async Task MultipleVersions()
        {
            var name = _fixture.SmallThenLargeObject;

            // List the versions separately
            await AssertObjects(name, new ListObjectsOptions { Versions = true }, name, name);
            // Explicitly don't list the versions separately
            await AssertObjects(name, new ListObjectsOptions { Versions = false }, name);
            // Implicitly don't list the versions separately (the API default)
            await AssertObjects(name, null, name);
        }

        [Fact]
        public void PartialResponses()
        {
            var options = new ListObjectsOptions { Fields = "items(name,contentType),nextPageToken" };
            var objects = _fixture.Client.ListObjects(_fixture.ReadBucket, options: options).ToList();
            foreach (var obj in objects)
            {
                // These fields are requested
                Assert.NotNull(obj.Name);
                Assert.NotNull(obj.ContentType);
                // These are not
                Assert.Null(obj.ContentEncoding);
                Assert.Null(obj.ContentDisposition);
            }
        }

        private async Task AssertObjects(string prefix, ListObjectsOptions options, params string[] expectedNames)
        {
            IEnumerable<Object> actual = _fixture.Client.ListObjects(_fixture.ReadBucket, prefix, options);
            AssertObjectNames(actual, expectedNames);
            actual = await _fixture.Client.ListObjectsAsync(_fixture.ReadBucket, prefix, options).ToListAsync();
            AssertObjectNames(actual, expectedNames);
        }

        private void AssertObjectNames(IEnumerable<Object> actualObjects, string[] expectedNames)
        {
            var actualNames = actualObjects.Select(x => x.Name).OrderBy(x => x).ToList();
            Assert.Equal(expectedNames.OrderBy(x => x), actualNames);
        }

        [Fact]
        public async Task CheckRestoreTokenForHnsSoftDeleted()
        {
            // We upload multiple objects and delete objects from the hns soft delete bucket.
            var uploadedSmall = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            var uploadedLarge = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-get-soft-delete"), "text/plain", new MemoryStream(_fixture.LargeContent));
            await _fixture.Client.DeleteObjectAsync(uploadedSmall);
            await _fixture.Client.DeleteObjectAsync(uploadedLarge);
            var options = new ListObjectsOptions { SoftDeletedOnly = true };
            // And now we get it, only soft deleted objects in hns bucket
            var hnsSoftDeleted = await _fixture.Client.ListObjectsAsync(_fixture.HnsSoftDeleteBucket, options: options).ToListAsync();

            foreach (var obj in hnsSoftDeleted)
            {
              Assert.NotNull(obj.RestoreToken);
            }
        }

        [Fact]
        public async Task CheckRestoreTokenForNonHnsSoftDeleted()
        {
            // We upload multiple objects and delete objects from the soft delete bucket.
            var uploadedSmall = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            var uploadedLarge = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.LargeContent));
            await _fixture.Client.DeleteObjectAsync(uploadedSmall);
            await _fixture.Client.DeleteObjectAsync(uploadedLarge);
            var options = new ListObjectsOptions { SoftDeletedOnly = true };
            // And now we get it, only soft deleted objects in soft delete bucket
            var softDeleted = await _fixture.Client.ListObjectsAsync(_fixture.SoftDeleteBucket, options: options).ToListAsync();

            foreach (var obj in softDeleted)
            {
                Assert.Null(obj.RestoreToken);
            }
        }

        [Fact]
        public async Task CheckRestoreTokenForHnsNotSoftDeleted()
        {
            // We upload multiple objects on the hns soft delete bucket.
            var uploadedSmall = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            var uploadedLarge = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-get-soft-delete"), "text/plain", new MemoryStream(_fixture.LargeContent));
            // And now we get all objects in hns soft delete bucket
            var listObjects = await _fixture.Client.ListObjectsAsync(_fixture.HnsSoftDeleteBucket).ToListAsync();

            foreach (var obj in listObjects)
            {
                Assert.Null(obj.RestoreToken);
            }
        }

        [Fact]
        public async Task CheckRestoreTokenForNonHnsNotSoftDeleted()
        {
            // We upload multiple objects on the soft delete bucket.
            var uploadedSmall = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            var uploadedLarge = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.LargeContent));
            // And now we get all objects in soft delete bucket
            var listObjects = await _fixture.Client.ListObjectsAsync(_fixture.SoftDeleteBucket).ToListAsync();

            foreach (var obj in listObjects)
            {
                Assert.Null(obj.RestoreToken);
            }
        }
    }
}
