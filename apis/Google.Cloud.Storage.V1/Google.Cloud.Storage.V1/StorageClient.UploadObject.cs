// Copyright 2015 Google Inc. All Rights Reserved.
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

using Google.Apis.Storage.v1;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Creates an instance which is capable of starting a resumable upload for an object.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="ObjectsResource.InsertMediaUpload"/> which can be used to upload the object.</returns>
        /// <seealso cref="UploadObject(Object,Stream,UploadObjectOptions,IProgress{IUploadProgress})"/>
        public virtual ObjectsResource.InsertMediaUpload CreateObjectUploader(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an instance which is capable of starting a resumable upload for an object.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name
        /// and bucket populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="ObjectsResource.InsertMediaUpload"/> which can be used to upload the object.</returns>
        /// <seealso cref="UploadObject(Object,Stream,UploadObjectOptions,IProgress{IUploadProgress})"/>
        public virtual ObjectsResource.InsertMediaUpload CreateObjectUploader(
            Object destination,
            Stream source,
            UploadObjectOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Object UploadObject(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Task<Object> UploadObjectAsync(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name
        /// and bucket populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Object UploadObject(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name
        /// and bucket populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Task<Object> UploadObjectAsync(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initiates an upload session, optionally specifying the length of the content to be uploaded.
        /// The resulting URI can be used with <see cref="ResumableUpload.CreateFromUploadUri"/>.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name
        /// and bucket populated.</param>
        /// <param name="contentLength">The length of the content to upload later. This may be null, in which
        /// case any length of content may be uploaded. If the value is non-null, it must be strictly positive
        /// (not zero), and the content uploaded later must be exactly this length.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Uri"/> to use in order to upload the content.</returns>
        public virtual Task<Uri> InitiateUploadSessionAsync(
            Object destination,
            long? contentLength,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Initiates an upload session, optionally specifying the length of the content to be uploaded.
        /// The resulting URI can be used with <see cref="ResumableUpload.CreateFromUploadUri"/>.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="contentLength">The length of the content to upload later. This may be null, in which
        /// case any length of content may be uploaded. If the value is non-null, it must be strictly positive
        /// (not zero), and the content uploaded later must be exactly this length.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Uri"/> to use in order to upload the content.</returns>
        public virtual Task<Uri> InitiateUploadSessionAsync(
            string bucket,
            string objectName,
            string contentType,
            long? contentLength,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Uploads a discrete chunk of data to an active resumable upload session.
        /// </summary>
        /// <remarks>
        /// Non-final chunks (<paramref name="isFinalChunk"/> is <c>false</c>) must have a byte length that is an 
        /// exact multiple of 256 KiB (262,144 bytes). The final chunk may be of arbitrary length.
        /// When <paramref name="rangeStart"/> is not specified, the current committed byte offset is queried from 
        /// the server first before sending the chunk.
        /// </remarks>
        /// <param name="uploadUri">The resumable upload session URI. Must not be null.</param>
        /// <param name="chunkStream">The stream containing data for this chunk. Must not be null.</param>
        /// <param name="isFinalChunk"><c>true</c> if this chunk concludes the upload; <c>false</c> if more chunks follow.</param>
        /// <param name="totalKnownSize">The total size of the object if known upfront, or <c>null</c> if unknown.</param>
        /// <param name="rangeStart">
        /// The starting byte offset for this chunk.
        /// <para>
        /// Passing an explicit offset avoids an extra <c>QueryUploadStatus</c> call:
        /// <list type="bullet">
        /// <item><description>Pass <c>0</c> for the initial chunk.</description></item>
        /// <item><description>Pass the current offset if it is already tracked by the caller.</description></item>
        /// </list>
        /// If <c>null</c>, the method queries the upload status to retrieve the current offset.
        /// </para>
        /// </param>
        /// <returns>The <see cref="IUploadProgress"/> of the chunk upload.</returns>
        public virtual IUploadProgress UploadChunk(
            Uri uploadUri,
            Stream chunkStream,
            bool isFinalChunk,
            long? totalKnownSize = null,
            long? rangeStart = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Uploads a discrete chunk of data to an active resumable upload session.
        /// </summary>
        /// <remarks>
        /// Non-final chunks (<paramref name="isFinalChunk"/> is <c>false</c>) must have a byte length that is an 
        /// exact multiple of 256 KiB (262,144 bytes). The final chunk may be of arbitrary length.
        /// When <paramref name="rangeStart"/> is not specified, the current committed byte offset is queried from 
        /// the server first before sending the chunk.
        /// </remarks>
        /// <param name="uploadUri">The resumable upload session URI. Must not be null.</param>
        /// <param name="chunkStream">The stream containing data for this chunk. Must not be null.</param>
        /// <param name="isFinalChunk"><c>true</c> if this chunk concludes the upload; <c>false</c> if more chunks follow.</param>
        /// <param name="totalKnownSize">The total size of the object if known upfront, or <c>null</c> if unknown.</param>
        /// <param name="rangeStart">
        /// The starting byte offset for this chunk.
        /// <para>
        /// Passing an explicit offset avoids an extra <c>QueryUploadStatusAsync</c> call:
        /// <list type="bullet">
        /// <item><description>Pass <c>0</c> for the initial chunk.</description></item>
        /// <item><description>Pass the current offset if it is already tracked by the caller.</description></item>
        /// </list>
        /// If <c>null</c>, the method queries the upload status to retrieve the current offset.
        /// </para>
        /// </param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, returning the <see cref="IUploadProgress"/> of the chunk upload.</returns>
        public virtual Task<IUploadProgress> UploadChunkAsync(
            Uri uploadUri,
            Stream chunkStream,
            bool isFinalChunk,
            long? totalKnownSize = null,
            long? rangeStart = null,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Finalizes an active resumable upload session where all data bytes have already been uploaded
        /// in intermediate chunks.
        /// </summary>
        /// <param name="uploadUri">The resumable upload session URI. Must not be null.</param>
        /// <param name="totalSize">The total size of the uploaded object in bytes. Must be non-negative.</param>
        /// <returns>The <see cref="IUploadProgress"/> of the finalized upload.</returns>
        public virtual IUploadProgress FinalizeUpload(
            Uri uploadUri,
            long totalSize) =>
            throw new NotImplementedException();

        /// <summary>
        /// Finalizes an active resumable upload session where all data bytes have already been uploaded
        /// in intermediate chunks.
        /// </summary>
        /// <param name="uploadUri">The resumable upload session URI. Must not be null.</param>
        /// <param name="totalSize">The total size of the uploaded object in bytes. Must be non-negative.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, returning the <see cref="IUploadProgress"/> of the finalized upload.</returns>
        public virtual Task<IUploadProgress> FinalizeUploadAsync(
            Uri uploadUri,
            long totalSize,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Queries the current upload status and committed byte offset of an active resumable upload session.
        /// </summary>
        /// <remarks>
        /// The returned <see cref="IUploadProgress"/> indicates the state of the upload session:
        /// <list type="bullet">
        /// <item><description><see cref="UploadStatus.Uploading"/> if the session is still in progress, with <see cref="IUploadProgress.BytesSent"/> set to the number of bytes committed to the server so far.</description></item>
        /// <item><description><see cref="UploadStatus.Completed"/> if the upload session has already been finalized on the server.</description></item>
        /// <item><description><see cref="UploadStatus.Failed"/> if an error occurred while querying the session, with <see cref="IUploadProgress.Exception"/> containing the cause of the failure.</description></item>
        /// </list>
        /// </remarks>
        /// <param name="uploadUri">The resumable upload session URI. Must not be null.</param>
        /// <returns>The <see cref="IUploadProgress"/> representing the current state of the upload session.</returns>
        public virtual IUploadProgress QueryUploadStatus(
            Uri uploadUri) =>
            throw new NotImplementedException();

        /// <summary>
        /// Queries the current upload status and committed byte offset of an active resumable upload session asynchronously.
        /// </summary>
        /// <remarks>
        /// The returned <see cref="IUploadProgress"/> indicates the state of the upload session:
        /// <list type="bullet">
        /// <item><description><see cref="UploadStatus.Uploading"/> if the session is still in progress, with <see cref="IUploadProgress.BytesSent"/> set to the number of bytes committed to the server so far.</description></item>
        /// <item><description><see cref="UploadStatus.Completed"/> if the upload session has already been finalized on the server.</description></item>
        /// <item><description><see cref="UploadStatus.Failed"/> if an error occurred while querying the session, with <see cref="IUploadProgress.Exception"/> containing the cause of the failure.</description></item>
        /// </list>
        /// </remarks>
        /// <param name="uploadUri">The resumable upload session URI. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, returning the <see cref="IUploadProgress"/>
        /// representing the current state of the upload session.
        /// </returns>
        public virtual Task<IUploadProgress> QueryUploadStatusAsync(
            Uri uploadUri,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();
    }
}
