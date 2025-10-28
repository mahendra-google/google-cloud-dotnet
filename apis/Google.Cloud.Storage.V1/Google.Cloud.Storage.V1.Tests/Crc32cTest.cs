// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class Crc32cTest
    {
        private static readonly byte[] ScsiReadCommand =
        {
            0x01, 0xc0, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x14, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x04, 0x00,
            0x00, 0x00, 0x00, 0x14,
            0x00, 0x00, 0x00, 0x18,
            0x28, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        };

        // Samples as per https://github.com/google/guava/blob/master/guava-tests/test/com/google/common/hash/Crc32cHashFunctionTest.java
        public static IEnumerable<object[]> SampleData => new object[][]
        {
            new object[] { Enumerable.Repeat((byte) 0, 32), new byte[] { 0x8a, 0x91, 0x36, 0xaa } },
            new object[] { Enumerable.Repeat((byte) 0xff, 32), new byte[] { 0x62, 0xa8, 0xab, 0x43 } },
            new object[] { Enumerable.Range(0, 32).Select(i => (byte) i), new byte[] { 0x46, 0xdd, 0x79, 0x4e } },
            new object[] { Enumerable.Range(0, 32).Select(i => (byte) (31 - i)), new byte[] { 0x11, 0x3f, 0xdb, 0x5c } },
            new object[] { ScsiReadCommand, new byte[] { 0xd9, 0x96, 0x3a, 0x56 } },
            new object[] { Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog"), new byte[] { 0x22, 0x62, 0x04, 0x04 } },
            new object[] { Encoding.UTF8.GetBytes("123456789"), new byte[] { 0xe3, 0x06, 0x92, 0x83 } },
            new object[] { Encoding.UTF8.GetBytes("1234567890"), new byte[] { 0xf3, 0xdb, 0xd4, 0xfe } },
            new object[] { Encoding.UTF8.GetBytes("23456789"), new byte[] { 0xbf, 0xe9, 0x2a, 0x83 } }
        };

        [Theory]
        [MemberData(nameof(SampleData))]
        public void Hash(IEnumerable<byte> source, byte[] expectedHash)
        {
            var hasher = new Crc32c();
            hasher.UpdateHash(source.ToArray(), 0, source.Count());
            byte[] actualHash = hasher.GetHash();
            Assert.Equal(expectedHash, actualHash);
        }

        [Fact]
        public void CalculateSpeed()
        {
            Console.WriteLine("Starting CRC32C Performance Benchmark for GCS...");
            Console.WriteLine("Running 20 iterations for each block size.");
            Console.WriteLine("Using hardware-accelerated System.IO.Hashing.Crc32c.");
            Console.WriteLine();

            // Define block sizes in bytes
            int[] blockSizes = new int[]
            {
            128 * 1024,   // 128 KiB
            256 * 1024,   // 256 KiB
            512 * 1024,   // 512 KiB
            1 * 1024 * 1024, // 1 MiB
            2 * 1024 * 1024  // 2 MiB
            };

            int iterations = 20;
            var results = new List<BenchmarkResult>();
            var stopwatch = new Stopwatch();

            // --- Warm-up ---
            // Run a single calculation to warm up the JIT compiler
            // and ensure CPU caches are ready.
            byte[] warmUpData = new byte[1024];
            RandomNumberGenerator.Fill(warmUpData);
            var hasher = new Crc32c();
            hasher.UpdateHash(warmUpData.ToArray(), 0, warmUpData.Count());
            //Crc32c.Hash(warmUpData);
            Console.WriteLine("Warm-up complete. Starting benchmarks...");
            Console.WriteLine();

            foreach (int sizeInBytes in blockSizes)
            {
                double totalSeconds = 0;
                long totalBytesProcessed = 0;
                double sizeInKiB = sizeInBytes / 1024.0;

                Console.WriteLine($"Testing Block Size: {FormatSize(sizeInBytes)}...");

                // Create a reusable buffer
                byte[] dataBuffer = new byte[sizeInBytes];

                for (int i = 0; i < iterations; i++)
                {
                    // Fill buffer with random data for each iteration
                    // This prevents caching/optimization on identical data
                    RandomNumberGenerator.Fill(dataBuffer);

                    stopwatch.Restart();

                    // --- This is the core operation being timed ---
                    hasher.UpdateHash(warmUpData.ToArray(), 0, warmUpData.Count());
                    //Crc32c.Hash(dataBuffer);
                    // ---------------------------------------------

                    stopwatch.Stop();

                    totalSeconds += stopwatch.Elapsed.TotalSeconds;
                    totalBytesProcessed += sizeInBytes;
                }

                // Calculate averages
                double avgTimeInSec = totalSeconds / iterations;
                double avgSpeedKiBps = sizeInKiB / avgTimeInSec;

                results.Add(new BenchmarkResult
                {
                    BlockSize = FormatSize(sizeInBytes),
                    AvgTimeSec = avgTimeInSec,
                    AvgSpeedKiBps = avgSpeedKiBps
                });
            }

            // --- Print Results Table ---
            PrintResults(results);
        }

        private static void PrintResults(List<BenchmarkResult> results)
        {
            Console.WriteLine("\n--- Benchmark Results ---");

            // Create table header
            var header = new StringBuilder();
            header.Append("| Block Size | Avg Time (sec)      | Avg Speed (KiB/sec) |");
            Console.WriteLine(header);

            // Create separator
            var separator = new StringBuilder();
            separator.Append("|------------|---------------------|---------------------|");
            Console.WriteLine(separator);

            // Print each result row
            foreach (var res in results)
            {
                Console.WriteLine($"| {res.BlockSize,-10} | {res.AvgTimeSec,-19:F9} | {res.AvgSpeedKiBps,-19:N2} |");
            }
        }
        // Helper function to format bytes into KiB or MiB
        private static string FormatSize(int bytes)
        {
            if (bytes >= 1024 * 1024)
                return $"{bytes / (1024 * 1024)} MiB";
            return $"{bytes / 1024} KiB";
        }

        private class BenchmarkResult
        {
            public string BlockSize { get; set; }
            public double AvgTimeSec { get; set; }
            public double AvgSpeedKiBps { get; set; }
        }
    }
}
