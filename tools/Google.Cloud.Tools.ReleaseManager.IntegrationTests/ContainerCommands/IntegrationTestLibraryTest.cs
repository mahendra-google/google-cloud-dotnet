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
using Google.Cloud.Tools.ReleaseManager.ContainerCommands;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(ContainerCommandFixture))]
public class IntegrationTestLibraryTest
{
    private readonly ContainerCommandFixture _fixture;

    public IntegrationTestLibraryTest(ContainerCommandFixture fixture) => _fixture = fixture;

    [Fact]
    public void SinglePackage()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Google.Test.V1", "Google.Test.V2");
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddScriptMocks();

        var command = new IntegrationTestLibraryCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}",
            "--library-id=Google.Test.V1");
        Assert.Equal(0, command.Execute(options));

        AssertScriptArguments(codeRepo, "Google.Test.V1");
    }

    [Fact]
    public void AllPackages()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Google.Test.V1", "Google.Test.V2");
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddScriptMocks();

        var command = new IntegrationTestLibraryCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}");
        Assert.Equal(0, command.Execute(options));

        AssertScriptArguments(codeRepo, "Google.Test.V1", "Google.Test.V2");
    }

    [Fact]
    public void PackageGroup()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Google.Test.V1", "Google.Test.V2", "Google.Other.V1");
        var group = new PackageGroup
        {
            DisplayName = "Test build library",
            Id = "Google.Test",
            PackageIds = { "Google.Test.V1", "Google.Test.V2" }
        };
        catalog.PackageGroups.Add(group);
        catalog["Google.Test.V1"].PackageGroup = group;
        catalog["Google.Test.V2"].PackageGroup = group;
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddScriptMocks();

        var command = new IntegrationTestLibraryCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}",
            "--library-id=Google.Test");
        Assert.Equal(0, command.Execute(options));

        AssertScriptArguments(codeRepo, "Google.Test.V1", "Google.Test.V2");
    }

    [Fact]
    public void WithRetry()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Google.Test.V1", "Google.Test.V2", "Google.Fail.V1");
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddScriptMocks();

        var command = new IntegrationTestLibraryCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}");

        var exception = Assert.Throws<Exception>(() => command.Execute(options));
        Assert.Contains("exit code 1", exception.Message, StringComparison.OrdinalIgnoreCase);

        AssertScriptOutput(codeRepo,
            "integration-tests-start", "Google.Test.V1", "Google.Test.V2", "Google.Fail.V1",
            "integration-tests-start", "--retry",
            "integration-tests-start", "--retry");
    }

    private void AssertScriptArguments(TestRepo repo, params string[] args) =>
        AssertScriptOutput(repo, ["integration-tests-start", .. args, "integration-tests-end"]);

    private void AssertScriptOutput(TestRepo repo, params string[] expectedOutput)
    {
        repo.AssertExist("runintegrationtests.sh.result.txt");
        Assert.Equal(expectedOutput, File.ReadAllLines(Path.Combine(repo.Directory, "runintegrationtests.sh.result.txt")));
    }
}
