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

using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(DockerCommandFixture))]
public class DockerCommandTest
{
    private const string CommonFilesDirectory = "CommonFiles";
    private static readonly string s_dataRoot;
    public static IEnumerable<object[]> Tests { get; }

    private static readonly IDeserializer s_yamlDeserializer = new DeserializerBuilder()
        .WithNamingConvention(CamelCaseNamingConvention.Instance)
        .Build();

    static DockerCommandTest()
    {
        var root = TestEnvironment.FindRepositoryRootDirectory();
        s_dataRoot = Path.Combine(root, "tools", typeof(DockerCommandTest).Assembly.GetName().Name, "ContainerCommands", "DockerTests");
        Tests = Directory.GetDirectories(s_dataRoot)
            .Select(Path.GetFileName)
            .Except([CommonFilesDirectory])
            .Select(p => new object[] { p });
    }

    private readonly DockerCommandFixture _fixture;

    public DockerCommandTest(DockerCommandFixture fixture) => _fixture = fixture;

    [SkippableTheory, MemberData(nameof(Tests))]
    public void DockerTest(string directory)
    {
        _fixture.MaybeSkip();
        var fullDirectory = Path.Combine(s_dataRoot, directory);
        Assert.NotEmpty(fullDirectory);
        var metadataYaml = File.ReadAllText(Path.Combine(fullDirectory, "metadata.yaml"));
        var metadata = s_yamlDeserializer.Deserialize<TestMetadata>(metadataYaml);
        string outputDirectory = CopyTestFiles(fullDirectory, metadata);
        _fixture.RunDocker(metadata.Command, metadata.Args, outputDirectory, metadata.ExpectedExitCode);

        var fileExpectations = metadata.FileExpectations;
        foreach (var expectedPresent in fileExpectations.Present)
        {
            var path = Path.Combine(outputDirectory, expectedPresent);
            Assert.True(Path.Exists(path), $"Path {path} should exist");
        }
        foreach (var expectedAbsent in fileExpectations.Absent)
        {
            var path = Path.Combine(outputDirectory, expectedAbsent);
            Assert.False(Path.Exists(path), $"Path {path} should not exist");
        }
    }

    private string CopyTestFiles(string fullTestDirectory, TestMetadata metadata)
    {
        var outputDirectory = Path.Combine(_fixture.TempTestDirectory, nameof(DockerCommandTest), Path.GetFileName(fullTestDirectory));
        Directory.CreateDirectory(outputDirectory);
        foreach (var subdirectory in Directory.GetDirectories(fullTestDirectory))
        {
            CopyDirectory(subdirectory, Path.Combine(outputDirectory, Path.GetFileName(subdirectory)));
        }
        foreach (var item in metadata.CommonFiles)
        {
            var source = Path.Combine(s_dataRoot, CommonFilesDirectory, item.Source);

            // Handle global.json separately: always copy it from the repo root.
            if (item.Source == "global.json")
            {
                source = Path.Combine(TestEnvironment.FindRepositoryRootDirectory(), "global.json");
            }
            var target = Path.Combine(outputDirectory, item.Target);
            if (Directory.Exists(source))
            {
                CopyDirectory(source, target);
            }
            else
            {
                var targetDirectory = Path.GetDirectoryName(target);
                Directory.CreateDirectory(targetDirectory);
                File.Copy(source, target);
            }
        }
        return outputDirectory;

        void CopyDirectory(string source, string target)
        {
            Directory.CreateDirectory(target);
            foreach (var file in Directory.GetFiles(source))
            {
                File.Copy(file, Path.Combine(target, Path.GetFileName(file)));
            }
            foreach (var directory in Directory.GetDirectories(source))
            {
                CopyDirectory(directory, Path.Combine(target, Path.GetFileName(directory)));
            }
        }
    }

    private class TestMetadata
    {
        /// <summary>
        /// The container command to run
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// The arguments to the container command
        /// </summary>
        public string[] Args { get; set; } = [];

    /// <summary>
    /// The expected exit code of the Docker command. (Defaults to 0, for success.)
    /// </summary>
        public int ExpectedExitCode { get; set; }

        /// <summary>
        /// Files/directories to copy from the CommonFiles directory
        /// </summary>
        public List<FileCopy> CommonFiles { get; set; } = [];

        /// <summary>
        /// Expectations of the files after the test
        /// </summary>
        public FileExpectations FileExpectations { get; set; } = new();
    }

    public class FileExpectations
    {
        public List<string> Present { get; set; } = [];
        public List<string> Absent { get; set; } = [];
    }

    private class FileCopy
    {
        public string Source { get; set; }
        public string Target { get; set; }
    }

    private enum Expectation
    {
        Absent,
        Present
    }
}
