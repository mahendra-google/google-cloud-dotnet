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

using Google.Cloud.ClientTesting;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class GetObjectTest
    {
        private readonly StorageFixture _fixture;

        public GetObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Simple()
        {
            var obj = _fixture.Client.GetObject(_fixture.ReadBucket, _fixture.SmallObject);
            Assert.Equal(_fixture.ReadBucket, obj.Bucket);
            Assert.Equal(_fixture.SmallObject, obj.Name);
            Assert.Equal((ulong) _fixture.SmallContent.Length, obj.Size);
            // Default doesn't get ACLs
            Assert.Null(obj.Acl);
        }

        [Fact]
        public void FullProjection()
        {
            var obj = _fixture.Client.GetObject(_fixture.ReadBucket, _fixture.SmallObject,
                new GetObjectOptions { Projection = Projection.Full });
            Assert.Equal(_fixture.ReadBucket, obj.Bucket);
            Assert.Equal(_fixture.SmallObject, obj.Name);
            Assert.Equal((ulong)_fixture.SmallContent.Length, obj.Size);
            Assert.NotNull(obj.Acl);
        }

        [Fact]
        public void SpecifyGeneration()
        {
            var bucket = _fixture.ReadBucket;
            var name = _fixture.SmallThenLargeObject;
            // Fetch them via the list operation to start with
            var objects = _fixture.Client
                .ListObjects(bucket, name, new ListObjectsOptions { Versions = true })
                .OrderBy(x => x.Generation)
                .ToList();

            Assert.Equal(2, objects.Count);
            // Fetch them by generation, and check that sizes match (but change by generation)
            var o1 = _fixture.Client.GetObject(bucket, name, new GetObjectOptions { Generation = objects[0].Generation });
            var o2 = _fixture.Client.GetObject(bucket, name, new GetObjectOptions { Generation = objects[1].Generation });

            Assert.Equal((ulong) _fixture.SmallContent.Length, o1.Size);
            Assert.Equal((ulong) _fixture.LargeContent.Length, o2.Size);
        }

        [Fact]
        public async Task GetSoftDeleted()
        {
            // We upload and delete an object on the soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            await _fixture.Client.DeleteObjectAsync(uploaded);

            // And now we get it, only soft deleted
            var softDeleted = await _fixture.Client.GetObjectAsync(_fixture.SoftDeleteBucket, uploaded.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = uploaded.Generation });

            Assert.Equal(_fixture.SoftDeleteBucket, softDeleted.Bucket);
            Assert.Equal(uploaded.Name, softDeleted.Name);
            Assert.Equal((ulong) _fixture.SmallContent.Length, softDeleted.Size);
            Assert.NotNull(softDeleted.SoftDeleteTimeDateTimeOffset);
        }

        [Fact]
        public async Task CheckRestoreTokenForHnsSoftDeleted()
        {
            // We upload and delete an object on the hns soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            await _fixture.Client.DeleteObjectAsync(uploaded);

            // And now we get only soft deleted in hns bucket
            var hnsSoftDeleted = await _fixture.Client.GetObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = uploaded.Generation });
            Assert.NotNull(hnsSoftDeleted.RestoreToken);
        }
        [Fact]
        public async Task CheckRestoreTokenForNonHnsSoftDeleted()
        {
            // We upload and delete an object on the soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            await _fixture.Client.DeleteObjectAsync(uploaded);

            // And now we get only soft deleted in soft delete bucket
            var softDeleted = await _fixture.Client.GetObjectAsync(_fixture.SoftDeleteBucket, uploaded.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = uploaded.Generation });
            Assert.Null(softDeleted.RestoreToken);
        }

        [Fact]
        private async Task CheckRestoreTokenForHnsNotSoftDeleted()
        {
            // We upload one object on the hns soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            // And now we get object in hns soft delete bucket
            var nonSoftDeleted = await _fixture.Client.GetObjectAsync(_fixture.HnsSoftDeleteBucket,uploaded.Name);
            Assert.Null(nonSoftDeleted.RestoreToken);
        }

        [Fact]
        private async Task CheckRestoreTokenForNonHnsNotSoftDeleted()
        {
            // We upload one object on the soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "get-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            // And now we get object in soft delete bucket
            var nonSoftDeleted = await _fixture.Client.GetObjectAsync(_fixture.SoftDeleteBucket,uploaded.Name);
            Assert.Null(nonSoftDeleted.RestoreToken);
        }
    }
}
