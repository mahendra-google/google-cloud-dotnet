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

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Google.Cloud.ClientTesting
{
    public static class FileStreamExtensions
    {
        /// <summary>
        /// Gets the actual, absolute path for the file associated with the FileStream handle.
        /// </summary>
        /// <param name="fileStream">The FileStream to query.</param>
        /// <returns>The full, resolved path, or null if it cannot be determined.</returns>
        public static string GetActualPath(this FileStream fileStream)
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return GetPathWindows(fileStream.SafeFileHandle);
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                    RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return GetPathLinuxOrOsx(fileStream.SafeFileHandle);
                }
            }
            catch (Exception)
            {
                // Handle or log errors, e.g., permission denied
            }

            // Fallback or for unsupported platforms
            return null;
        }

        // --- Windows Implementation ---

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int GetFinalPathNameByHandle(
            SafeFileHandle hFile,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszFilePath,
            int cchFilePath,
            int dwFlags);

        private const int FILE_NAME_NORMALIZED = 0x0;
        private const int VOLUME_NAME_DOS = 0x0; // Use this for "C:\" style paths

        private static string GetPathWindows(SafeFileHandle handle)
        {
            var builder = new StringBuilder(1024); // MAX_PATH is 260, but let's be safe

            // Use 0 for dwFlags to get the default (normalized) path.
            // Or use VOLUME_NAME_DOS to ensure "C:\..." format.
            int result = GetFinalPathNameByHandle(handle, builder, builder.Capacity, VOLUME_NAME_DOS);

            if (result == 0)
            {
                // Failed
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            // The result includes the terminating null, but StringBuilder doesn't.
            // The path returned by GetFinalPathNameByHandle is prefixed with "\\?\"
            // (the "long path" syntax). We need to remove this for normal use.
            string path = builder.ToString();
            if (path.StartsWith(@"\\?\"))
            {
                return path.Substring(4);
            }

            return path;
        }

        // --- Linux & macOS Implementation ---

        [DllImport("libc", SetLastError = true, CharSet = CharSet.Ansi)]
        private static extern int readlink(
            string pathname,
            StringBuilder buf,
            int bufsiz);

        private static string GetPathLinuxOrOsx(SafeFileHandle handle)
        {
            // On Unix, the file descriptor (handle) is an integer.
            int fd = handle.DangerousGetHandle().ToInt32();

            // The path to the symlink for this process's file descriptor
            string symlinkPath = $"/proc/self/fd/{fd}";

            var builder = new StringBuilder(1024);
            int result = readlink(symlinkPath, builder, builder.Capacity);

            if (result == -1)
            {
                // Failed
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            // readlink doesn't null-terminate the string in the buffer
            return builder.ToString(0, result);
        }
    }
}
