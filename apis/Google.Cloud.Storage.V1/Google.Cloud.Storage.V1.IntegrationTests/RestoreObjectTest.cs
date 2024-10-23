// Copyright 2024 Google Inc. All Rights Reserved.
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
using System.Threading.Tasks;
using Xunit;
using static Google.Protobuf.Compiler.CodeGeneratorResponse.Types;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class RestoreObjectTest
    {
        private readonly StorageFixture _fixture;

        public RestoreObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task RestoresObject()
        {
            // We upload and delete an object on the soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.SoftDeleteBucket, IdGenerator.FromGuid(prefix: "restore-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            await _fixture.Client.DeleteObjectAsync(uploaded);

            // And now we can restore it.
            await _fixture.Client.RestoreObjectAsync(_fixture.SoftDeleteBucket, uploaded.Name, uploaded.Generation.Value);

            var restored = await _fixture.Client.GetObjectAsync(_fixture.SoftDeleteBucket, uploaded.Name);
            Assert.Equal(_fixture.SoftDeleteBucket, restored.Bucket);
            Assert.Equal(uploaded.Name, restored.Name);
            Assert.Equal((ulong) _fixture.SmallContent.Length, restored.Size);
            Assert.Null(restored.SoftDeleteTimeDateTimeOffset);
        }


        [Fact]
        public async Task RestoresObjectUsingRestoreToken()
        {
            // We upload and delete an object on the hns soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-restore-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            await _fixture.Client.DeleteObjectAsync(uploaded);

            // And now we get only soft deleted in hns bucket
            var hnsSoftDeleted = await _fixture.Client.GetObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = uploaded.Generation });
            var restoreOptions= new RestoreObjectOptions { RestoreToken = hnsSoftDeleted.RestoreToken };
            // And now we can restore it using restore token along with combination of other mandatory parameters.
            await _fixture.Client.RestoreObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name, uploaded.Generation.Value, options : restoreOptions);

            var restored = await _fixture.Client.GetObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name);
            Assert.Equal(_fixture.HnsSoftDeleteBucket, restored.Bucket);
            Assert.Equal(uploaded.Name, restored.Name);
            Assert.Equal((ulong) _fixture.SmallContent.Length, restored.Size);
            Assert.NotNull(hnsSoftDeleted.RestoreToken);
        }

        [Fact]
        public async Task RestoresObjectWithoutUsingRestoreToken()
        {
            // We upload and delete an object on the hns soft delete bucket.
            var uploaded = await _fixture.Client.UploadObjectAsync(_fixture.HnsSoftDeleteBucket, IdGenerator.FromGuid(prefix: "hns-restore-soft-delete"), "text/plain", new MemoryStream(_fixture.SmallContent));
            await _fixture.Client.DeleteObjectAsync(uploaded);

            // And now we get only soft deleted in hns bucket
            var hnsSoftDeleted = await _fixture.Client.GetObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = uploaded.Generation });
            // And now we can restore it without using restore token.
            await _fixture.Client.RestoreObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name, uploaded.Generation.Value);

            var restored = await _fixture.Client.GetObjectAsync(_fixture.HnsSoftDeleteBucket, uploaded.Name);
            Assert.Equal(_fixture.HnsSoftDeleteBucket, restored.Bucket);
            Assert.Equal(uploaded.Name, restored.Name);
            Assert.Equal((ulong) _fixture.SmallContent.Length, restored.Size);
            Assert.Equal(hnsSoftDeleted.Generation.Value , uploaded.Generation.Value);
        }
    }
}
