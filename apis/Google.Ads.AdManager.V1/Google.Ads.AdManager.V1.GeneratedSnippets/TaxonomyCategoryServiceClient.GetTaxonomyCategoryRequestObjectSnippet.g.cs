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
    // [START admanager_v1_generated_TaxonomyCategoryService_GetTaxonomyCategory_sync]
    using Google.Ads.AdManager.V1;

    public sealed partial class GeneratedTaxonomyCategoryServiceClientSnippets
    {
        /// <summary>Snippet for GetTaxonomyCategory</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetTaxonomyCategoryRequestObject()
        {
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            GetTaxonomyCategoryRequest request = new GetTaxonomyCategoryRequest
            {
                TaxonomyCategoryName = TaxonomyCategoryName.FromNetworkCodeTaxonomyCategory("[NETWORK_CODE]", "[TAXONOMY_CATEGORY]"),
            };
            // Make the request
            TaxonomyCategory response = taxonomyCategoryServiceClient.GetTaxonomyCategory(request);
        }
    }
    // [END admanager_v1_generated_TaxonomyCategoryService_GetTaxonomyCategory_sync]
}
