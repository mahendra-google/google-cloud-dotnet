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
    using Google.Api.Gax;
    using Google.Cloud.Retail.V2;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSearchServiceClientSnippets
    {
        /// <summary>Snippet for Search</summary>
        public void SearchRequestObject()
        {
            // Snippet: Search(SearchRequest, CallSettings)
            // Create client
            SearchServiceClient searchServiceClient = SearchServiceClient.Create();
            // Initialize request argument(s)
            SearchRequest request = new SearchRequest
            {
                Placement = "",
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Query = "",
                VisitorId = "",
                UserInfo = new UserInfo(),
                Offset = 0,
                Filter = "",
                OrderBy = "",
                FacetSpecs =
                {
                    new SearchRequest.Types.FacetSpec(),
                },
                BoostSpec = new SearchRequest.Types.BoostSpec(),
                QueryExpansionSpec = new SearchRequest.Types.QueryExpansionSpec(),
                VariantRollupKeys = { "", },
                PageCategories = { "", },
                CanonicalFilter = "",
                SearchMode = SearchRequest.Types.SearchMode.Unspecified,
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
                Labels = { { "", "" }, },
                SpellCorrectionSpec = new SearchRequest.Types.SpellCorrectionSpec(),
                Entity = "",
                ConversationalSearchSpec = new SearchRequest.Types.ConversationalSearchSpec(),
                TileNavigationSpec = new SearchRequest.Types.TileNavigationSpec(),
                LanguageCode = "",
                RegionCode = "",
                PlaceId = "",
                UserAttributes =
                {
                    {
                        "",
                        new StringList()
                    },
                },
            };
            // Make the request
            PagedEnumerable<SearchResponse, SearchResponse.Types.SearchResult> response = searchServiceClient.Search(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchResponse.Types.SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchResponse.Types.SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchResponse.Types.SearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchResponse.Types.SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAsync</summary>
        public async Task SearchRequestObjectAsync()
        {
            // Snippet: SearchAsync(SearchRequest, CallSettings)
            // Create client
            SearchServiceClient searchServiceClient = await SearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchRequest request = new SearchRequest
            {
                Placement = "",
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Query = "",
                VisitorId = "",
                UserInfo = new UserInfo(),
                Offset = 0,
                Filter = "",
                OrderBy = "",
                FacetSpecs =
                {
                    new SearchRequest.Types.FacetSpec(),
                },
                BoostSpec = new SearchRequest.Types.BoostSpec(),
                QueryExpansionSpec = new SearchRequest.Types.QueryExpansionSpec(),
                VariantRollupKeys = { "", },
                PageCategories = { "", },
                CanonicalFilter = "",
                SearchMode = SearchRequest.Types.SearchMode.Unspecified,
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
                Labels = { { "", "" }, },
                SpellCorrectionSpec = new SearchRequest.Types.SpellCorrectionSpec(),
                Entity = "",
                ConversationalSearchSpec = new SearchRequest.Types.ConversationalSearchSpec(),
                TileNavigationSpec = new SearchRequest.Types.TileNavigationSpec(),
                LanguageCode = "",
                RegionCode = "",
                PlaceId = "",
                UserAttributes =
                {
                    {
                        "",
                        new StringList()
                    },
                },
            };
            // Make the request
            PagedAsyncEnumerable<SearchResponse, SearchResponse.Types.SearchResult> response = searchServiceClient.SearchAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchResponse.Types.SearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchResponse.Types.SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchResponse.Types.SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchResponse.Types.SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
