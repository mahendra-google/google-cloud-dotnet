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

#pragma warning disable CS8981

namespace Google.Cloud.AIPlatform.V1
{
    public partial class VertexRagStore
    {
        public partial class Types
        {
            public partial class RagResource
            {
                /// <summary>
                /// <see cref="RagCorpusName"/>-typed view over the <see cref="RagCorpus"/> resource name property.
                /// </summary>
                public RagCorpusName RagCorpusAsRagCorpusName
                {
                    get => string.IsNullOrEmpty(RagCorpus) ? null : RagCorpusName.Parse(RagCorpus, allowUnparsed: true);
                    set => RagCorpus = value?.ToString() ?? "";
                }
            }
        }
    }
}
