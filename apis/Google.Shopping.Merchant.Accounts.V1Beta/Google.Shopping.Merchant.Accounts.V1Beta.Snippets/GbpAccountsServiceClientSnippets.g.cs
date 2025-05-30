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
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGbpAccountsServiceClientSnippets
    {
        /// <summary>Snippet for ListGbpAccounts</summary>
        public void ListGbpAccountsRequestObject()
        {
            // Snippet: ListGbpAccounts(ListGbpAccountsRequest, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = GbpAccountsServiceClient.Create();
            // Initialize request argument(s)
            ListGbpAccountsRequest request = new ListGbpAccountsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListGbpAccountsResponse, GbpAccount> response = gbpAccountsServiceClient.ListGbpAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GbpAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGbpAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GbpAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GbpAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GbpAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGbpAccountsAsync</summary>
        public async Task ListGbpAccountsRequestObjectAsync()
        {
            // Snippet: ListGbpAccountsAsync(ListGbpAccountsRequest, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = await GbpAccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGbpAccountsRequest request = new ListGbpAccountsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> response = gbpAccountsServiceClient.ListGbpAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GbpAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGbpAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GbpAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GbpAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GbpAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGbpAccounts</summary>
        public void ListGbpAccounts()
        {
            // Snippet: ListGbpAccounts(string, string, int?, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = GbpAccountsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListGbpAccountsResponse, GbpAccount> response = gbpAccountsServiceClient.ListGbpAccounts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GbpAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGbpAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GbpAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GbpAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GbpAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGbpAccountsAsync</summary>
        public async Task ListGbpAccountsAsync()
        {
            // Snippet: ListGbpAccountsAsync(string, string, int?, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = await GbpAccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> response = gbpAccountsServiceClient.ListGbpAccountsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GbpAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGbpAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GbpAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GbpAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GbpAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGbpAccounts</summary>
        public void ListGbpAccountsResourceNames()
        {
            // Snippet: ListGbpAccounts(AccountName, string, int?, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = GbpAccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListGbpAccountsResponse, GbpAccount> response = gbpAccountsServiceClient.ListGbpAccounts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GbpAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGbpAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GbpAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GbpAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GbpAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGbpAccountsAsync</summary>
        public async Task ListGbpAccountsResourceNamesAsync()
        {
            // Snippet: ListGbpAccountsAsync(AccountName, string, int?, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = await GbpAccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> response = gbpAccountsServiceClient.ListGbpAccountsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GbpAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGbpAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GbpAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GbpAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GbpAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LinkGbpAccount</summary>
        public void LinkGbpAccountRequestObject()
        {
            // Snippet: LinkGbpAccount(LinkGbpAccountRequest, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = GbpAccountsServiceClient.Create();
            // Initialize request argument(s)
            LinkGbpAccountRequest request = new LinkGbpAccountRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                GbpEmail = "",
            };
            // Make the request
            LinkGbpAccountResponse response = gbpAccountsServiceClient.LinkGbpAccount(request);
            // End snippet
        }

        /// <summary>Snippet for LinkGbpAccountAsync</summary>
        public async Task LinkGbpAccountRequestObjectAsync()
        {
            // Snippet: LinkGbpAccountAsync(LinkGbpAccountRequest, CallSettings)
            // Additional: LinkGbpAccountAsync(LinkGbpAccountRequest, CancellationToken)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = await GbpAccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LinkGbpAccountRequest request = new LinkGbpAccountRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                GbpEmail = "",
            };
            // Make the request
            LinkGbpAccountResponse response = await gbpAccountsServiceClient.LinkGbpAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LinkGbpAccount</summary>
        public void LinkGbpAccount()
        {
            // Snippet: LinkGbpAccount(string, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = GbpAccountsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            LinkGbpAccountResponse response = gbpAccountsServiceClient.LinkGbpAccount(parent);
            // End snippet
        }

        /// <summary>Snippet for LinkGbpAccountAsync</summary>
        public async Task LinkGbpAccountAsync()
        {
            // Snippet: LinkGbpAccountAsync(string, CallSettings)
            // Additional: LinkGbpAccountAsync(string, CancellationToken)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = await GbpAccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            LinkGbpAccountResponse response = await gbpAccountsServiceClient.LinkGbpAccountAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for LinkGbpAccount</summary>
        public void LinkGbpAccountResourceNames()
        {
            // Snippet: LinkGbpAccount(AccountName, CallSettings)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = GbpAccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            LinkGbpAccountResponse response = gbpAccountsServiceClient.LinkGbpAccount(parent);
            // End snippet
        }

        /// <summary>Snippet for LinkGbpAccountAsync</summary>
        public async Task LinkGbpAccountResourceNamesAsync()
        {
            // Snippet: LinkGbpAccountAsync(AccountName, CallSettings)
            // Additional: LinkGbpAccountAsync(AccountName, CancellationToken)
            // Create client
            GbpAccountsServiceClient gbpAccountsServiceClient = await GbpAccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            LinkGbpAccountResponse response = await gbpAccountsServiceClient.LinkGbpAccountAsync(parent);
            // End snippet
        }
    }
}
