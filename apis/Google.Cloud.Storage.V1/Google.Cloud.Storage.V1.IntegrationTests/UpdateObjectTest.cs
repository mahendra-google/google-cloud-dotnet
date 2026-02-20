// Copyright 2016 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.IO;
using Xunit;
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class UpdateObjectTest
    {
        private readonly StorageFixture _fixture;

        public UpdateObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Success()
        {
            var client = _fixture.Client;
            var obj = client.UploadObject(_fixture.SingleVersionBucket, IdGenerator.FromGuid(), null,
                new MemoryStream(_fixture.SmallContent));
            obj.Metadata = new Dictionary<string, string> { { "key", "value" } };
            var updated = client.UpdateObject(obj);
            Assert.Equal("value", updated.Metadata["key"]);
        }

        [Fact]
        public void UpdateObject_WithObjectContext()
        {
            var client = _fixture.Client;
            var source = GenerateData(100);
            var custom = new Dictionary<string, ObjectCustomContextPayload>
            {
                    { "project_id", new ObjectCustomContextPayload { Value = "apollo-11" } },

                    { "environment", new ObjectCustomContextPayload { Value = "production" } },

                    { "cost_center", new ObjectCustomContextPayload { Value = "engineering-884" } }
            };

            var destination = new Object
            {
                Bucket = _fixture.MultiVersionBucket,
                Name = IdGenerator.FromGuid(),
                ContentType = "test/type",
                ContentDisposition = "attachment",
                Metadata = new Dictionary<string, string> { { "x", "y" } },
                Contexts = new Object.ContextsData { Custom = custom }
            };

            _fixture.Client.UploadObject(destination, source);

            var modifiedCustom = new Dictionary<string, ObjectCustomContextPayload>
            {
                    { "project_id", new ObjectCustomContextPayload { Value = "apollo-121" } },

                    { "environment", new ObjectCustomContextPayload { Value = "production2" } },

                    { "cost_center", new ObjectCustomContextPayload { Value = "engineering-88444" } }
            };


            var modifiedDestination = new Object
            {
                Bucket = _fixture.MultiVersionBucket,
                Name = destination.Name,
                Contexts = new Object.ContextsData { Custom = modifiedCustom }
            };
            var updated = client.UpdateObject(modifiedDestination);
            Assert.NotNull(updated.Contexts.Custom);
            Assert.Equal(updated.Contexts.Custom.Count, custom.Count);
        }
    }
}
