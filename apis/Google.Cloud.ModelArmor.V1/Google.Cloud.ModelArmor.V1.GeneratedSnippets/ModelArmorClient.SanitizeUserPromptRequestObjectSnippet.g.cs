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
    // [START modelarmor_v1_generated_ModelArmor_SanitizeUserPrompt_sync]
    using Google.Cloud.ModelArmor.V1;

    public sealed partial class GeneratedModelArmorClientSnippets
    {
        /// <summary>Snippet for SanitizeUserPrompt</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void SanitizeUserPromptRequestObject()
        {
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            SanitizeUserPromptRequest request = new SanitizeUserPromptRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                UserPromptData = new DataItem(),
                MultiLanguageDetectionMetadata = new MultiLanguageDetectionMetadata(),
            };
            // Make the request
            SanitizeUserPromptResponse response = modelArmorClient.SanitizeUserPrompt(request);
        }
    }
    // [END modelarmor_v1_generated_ModelArmor_SanitizeUserPrompt_sync]
}
