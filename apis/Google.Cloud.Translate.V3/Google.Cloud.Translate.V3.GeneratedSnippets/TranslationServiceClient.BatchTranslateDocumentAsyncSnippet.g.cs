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
    // [START translate_v3_generated_TranslationService_BatchTranslateDocument_async_flattened]
    using Google.Cloud.Translate.V3;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTranslationServiceClientSnippets
    {
        /// <summary>Snippet for BatchTranslateDocumentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchTranslateDocumentAsync()
        {
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string sourceLanguageCode = "";
            IEnumerable<string> targetLanguageCodes = new string[] { "", };
            IEnumerable<BatchDocumentInputConfig> inputConfigs = new BatchDocumentInputConfig[]
            {
                new BatchDocumentInputConfig(),
            };
            BatchDocumentOutputConfig outputConfig = new BatchDocumentOutputConfig();
            // Make the request
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> response = await translationServiceClient.BatchTranslateDocumentAsync(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchTranslateDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> retrievedResponse = await translationServiceClient.PollOnceBatchTranslateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchTranslateDocumentResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END translate_v3_generated_TranslationService_BatchTranslateDocument_async_flattened]
}
