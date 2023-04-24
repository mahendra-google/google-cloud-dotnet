// Copyright 2023 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.DiscoveryEngine.V1Beta.Snippets
{
    // [START discoveryengine_v1beta_generated_SchemaService_DeleteSchema_async_flattened_resourceNames]
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSchemaServiceClientSnippets
    {
        /// <summary>Snippet for DeleteSchemaAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task DeleteSchemaResourceNamesAsync()
        {
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]");
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = await schemaServiceClient.DeleteSchemaAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceDeleteSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END discoveryengine_v1beta_generated_SchemaService_DeleteSchema_async_flattened_resourceNames]
}