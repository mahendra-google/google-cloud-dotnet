// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START assuredworkloads_v1beta1_generated_AssuredWorkloadsService_CreateWorkload_async]
    using Google.Cloud.AssuredWorkloads.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAssuredWorkloadsServiceClientSnippets
    {
        /// <summary>Snippet for CreateWorkloadAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateWorkloadRequestObjectAsync()
        {
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkloadRequest request = new CreateWorkloadRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Workload = new Workload(),
                ExternalId = "",
            };
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = await assuredWorkloadsServiceClient.CreateWorkloadAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = await assuredWorkloadsServiceClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END assuredworkloads_v1beta1_generated_AssuredWorkloadsService_CreateWorkload_async]
}
