// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Tools.Common;
using Google.Protobuf.WellKnownTypes;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Temporary command to create a pipeline-state.json file for the new production pipeline,
/// based on what's already in the API catalog and the existing pipeline-state.json.
/// This command can be removed when the production pipeline is up and running,
/// as that will maintain the state itself.
/// </summary>
public sealed class CreatePipelineStateCommand : CommandBase
{
    private const string SourceLinkPrefix = "Source-Link: https://github.com/googleapis/googleapis/commit/";
    private const string AutomationLevelAutomatic = "AUTOMATION_LEVEL_AUTOMATIC";
    private const string AutomationLevelBlocked = "AUTOMATION_LEVEL_BLOCKED";


    public CreatePipelineStateCommand()
    : base("create-pipeline-state", "Create a pipeline state file for testing the new production pipeline", "googleapis")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var catalog = ApiCatalog.Load(RootLayout);
        var previousState = PipelineState.Load(RootLayout);

        using var repo = new Repository(RootLayout.RepositoryRoot);
        using var googleapisRepo = new Repository(args[0]);
        var state = new PipelineState
        {
            ImageTag = "latest",
            CommonLibrarySourcePaths = { "Directory.Packages.props" }
        };
        var tagsByName = repo.Tags.ToDictionary(t => t.FriendlyName);

        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Fetching commmits with a source link.");
        var googleApisCommits = repo.Commits
            .Where(GitHelpers.CreateCommitPredicateForPathPrefix("apis/"))
            .Where(c => c.Message.Contains(SourceLinkPrefix, StringComparison.Ordinal))
            .ToList();
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Fetched {googleApisCommits.Count} commmits.");

        state.IgnoredApiPaths.AddRange(previousState.IgnoredApiPaths);
        foreach (var api in catalog.Apis)
        {
            MaybeAddApiLibrary(api);
        }
        foreach (var packageGroup in catalog.PackageGroups)
        {
            AddPackageGroupLibrary(packageGroup);
        }

        RespectPreviousOrdering();

        // Avoid serializing empty lists. There may be a better way of doing this...
        foreach (var library in state.Libraries)
        {
            if (library.ApiPaths.Count == 0)
            {
                library.ApiPaths = null;
            }
        }

        state.Save(RootLayout);
        return 0;

        void MaybeAddApiLibrary(ApiMetadata api)
        {
            // Package groups are handled later
            if (api.PackageGroup is not null)
            {
                return;
            }
            var released = !api.Version.EndsWith("00");
            var library = new LibraryState
            {
                Id = api.Id,
                CurrentVersion = released ? api.Version : null,
                ReleaseTimestamp = FormatTimestamp(GetLastReleaseTimestamp(api)),
                GenerationAutomationLevel = AutomationLevelAutomatic,
                ReleaseAutomationLevel = api.BlockRelease is not null || !released ? AutomationLevelBlocked : AutomationLevelAutomatic
            };
            if (api.ProtoPath is string path)
            {
                library.ApiPaths.Add(path);
            }
            library.SourcePaths.Add($"apis/{api.Id}/{api.Id}");
            PopulateLastGeneratedCommit(library);
            state.Libraries.Add(library);
        }

        void AddPackageGroupLibrary(PackageGroup packageGroup)
        {
            var packages = packageGroup.PackageIds.Select(id => catalog[id]).ToList();
            var timestamp = GetLastReleaseTimestamp(packages[0]);
            var library = new LibraryState
            {
                Id = packageGroup.Id,
                CurrentVersion = packages[0].Version,
                ReleaseTimestamp = FormatTimestamp(GetLastReleaseTimestamp(packages[0])),
                GenerationAutomationLevel = AutomationLevelAutomatic,
                ReleaseAutomationLevel = packages.Any(p => p.BlockRelease is not null) ? AutomationLevelBlocked : AutomationLevelAutomatic
            };
            library.ApiPaths.AddRange(packages.Select(p => p.ProtoPath).OfType<string>());
            library.SourcePaths.AddRange(packages.Select(p => $"apis/{p.Id}/{p.Id}"));
            PopulateLastGeneratedCommit(library);
            state.Libraries.Add(library);
        }

        void PopulateLastGeneratedCommit(LibraryState library)
        {
            var lastGeneratedCommit = library.SourcePaths
                .Select(p => GetCommitForPath(googleApisCommits, p))
                .OfType<Commit>()
                .Select(GetGoogleApisCommit)
                .Where(pair => pair.hash is not null)
                .OrderByDescending(pair => pair.dotnetCommitTimestamp)
                .FirstOrDefault()
                .hash;
            // proto-only APIs don't have any OwlBot-generated commits.
            // Find the last commit 
            if (lastGeneratedCommit is null && library.ApiPaths.Count == 1)
            {
                lastGeneratedCommit = GetCommitForPath(googleapisRepo.Commits, library.ApiPaths[0])?.Sha;
            }
            // If the same library already exists in the current state,
            // and if it is later than what we'd populate, keep it. (This happens if Librarian generates
            // the library due to a new API commit, but the commit doesn't affect the generated library.)
            var previousLibrary = previousState.Libraries.FirstOrDefault(lib => lib.Id == library.Id);
            if (previousLibrary?.LastGeneratedCommit is string previousStateCommit && previousStateCommit != lastGeneratedCommit)
            {
                if (lastGeneratedCommit is null)
                {
                    lastGeneratedCommit = previousStateCommit;
                }
                else
                {
                    var previousStateCommitObj = googleapisRepo.Lookup<Commit>(previousStateCommit);
                    var lastGeneratedCommitObj = googleapisRepo.Lookup<Commit>(lastGeneratedCommit);
                    if (previousStateCommitObj.GetDate() > lastGeneratedCommitObj.GetDate())
                    {
                        lastGeneratedCommit = previousStateCommit;
                    }
                }
            }

            library.LastGeneratedCommit = lastGeneratedCommit;

            (string hash, DateTimeOffset dotnetCommitTimestamp) GetGoogleApisCommit(Commit commit)
            {
                var message = commit.Message;
                var sourceLinkIndex = message.IndexOf(SourceLinkPrefix);
                // Commit hashes are always 40 characters long.
                var hash = message.Substring(sourceLinkIndex + SourceLinkPrefix.Length, 40);
                return (hash, commit.GetDate());
            }
        }

        DateTimeOffset? GetLastReleaseTimestamp(ApiMetadata api)
        {
            var expectedTag = $"{api.Id}-{api.Version}";
            var tag = tagsByName.GetValueOrDefault(expectedTag);
            return tag?.GetDate();
        }

        string FormatTimestamp(DateTimeOffset? timestamp) =>
            timestamp is null ? null : Timestamp.FromDateTimeOffset(timestamp.Value).ToString().Trim('"');

        void RespectPreviousOrdering()
        {
            var previousStateLibraryIds = previousState.Libraries.Select(lib => lib.Id).ToList();

            var libraries = state.Libraries.ToList();
            state.Libraries.Clear();
            // The cast to uint turns -1 into uint.MaxValue, so we end up with any libraries not in the previous state
            // at the end.
            state.Libraries.AddRange(libraries.OrderBy(lib => (uint) previousStateLibraryIds.IndexOf(lib.Id)));
        }
    }

    private static Commit GetCommitForPath(IEnumerable<Commit> commits, string path)
    {
        var predicate = GitHelpers.CreateCommitPredicateForPathPrefix(path);
        return commits.Where(predicate).FirstOrDefault();
    }
}
