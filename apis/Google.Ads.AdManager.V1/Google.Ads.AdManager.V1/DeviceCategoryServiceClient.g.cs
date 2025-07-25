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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="DeviceCategoryServiceClient"/> instances.</summary>
    public sealed partial class DeviceCategoryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeviceCategoryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeviceCategoryServiceSettings"/>.</returns>
        public static DeviceCategoryServiceSettings GetDefault() => new DeviceCategoryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DeviceCategoryServiceSettings"/> object with default settings.
        /// </summary>
        public DeviceCategoryServiceSettings()
        {
        }

        private DeviceCategoryServiceSettings(DeviceCategoryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDeviceCategorySettings = existing.GetDeviceCategorySettings;
            ListDeviceCategoriesSettings = existing.ListDeviceCategoriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeviceCategoryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceCategoryServiceClient.GetDeviceCategory</c> and
        /// <c>DeviceCategoryServiceClient.GetDeviceCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeviceCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceCategoryServiceClient.ListDeviceCategories</c> and
        /// <c>DeviceCategoryServiceClient.ListDeviceCategoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceCategoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeviceCategoryServiceSettings"/> object.</returns>
        public DeviceCategoryServiceSettings Clone() => new DeviceCategoryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeviceCategoryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DeviceCategoryServiceClientBuilder : gaxgrpc::ClientBuilderBase<DeviceCategoryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeviceCategoryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeviceCategoryServiceClientBuilder() : base(DeviceCategoryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeviceCategoryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeviceCategoryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeviceCategoryServiceClient Build()
        {
            DeviceCategoryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeviceCategoryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeviceCategoryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeviceCategoryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeviceCategoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeviceCategoryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeviceCategoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeviceCategoryServiceClient.ChannelPool;
    }

    /// <summary>DeviceCategoryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DeviceCategory` objects.
    /// </remarks>
    public abstract partial class DeviceCategoryServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeviceCategoryService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default DeviceCategoryService scopes.</summary>
        /// <remarks>
        /// The default DeviceCategoryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeviceCategoryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeviceCategoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DeviceCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeviceCategoryServiceClient"/>.</returns>
        public static stt::Task<DeviceCategoryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeviceCategoryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeviceCategoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DeviceCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeviceCategoryServiceClient"/>.</returns>
        public static DeviceCategoryServiceClient Create() => new DeviceCategoryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeviceCategoryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeviceCategoryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeviceCategoryServiceClient"/>.</returns>
        internal static DeviceCategoryServiceClient Create(grpccore::CallInvoker callInvoker, DeviceCategoryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeviceCategoryService.DeviceCategoryServiceClient grpcClient = new DeviceCategoryService.DeviceCategoryServiceClient(callInvoker);
            return new DeviceCategoryServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC DeviceCategoryService client</summary>
        public virtual DeviceCategoryService.DeviceCategoryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceCategory GetDeviceCategory(GetDeviceCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCategory> GetDeviceCategoryAsync(GetDeviceCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCategory> GetDeviceCategoryAsync(GetDeviceCategoryRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCategory.
        /// Format: `networks/{network_code}/deviceCategories/{device_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceCategory GetDeviceCategory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCategory(new GetDeviceCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCategory.
        /// Format: `networks/{network_code}/deviceCategories/{device_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCategory> GetDeviceCategoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCategoryAsync(new GetDeviceCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCategory.
        /// Format: `networks/{network_code}/deviceCategories/{device_category_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCategory> GetDeviceCategoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeviceCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCategory.
        /// Format: `networks/{network_code}/deviceCategories/{device_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceCategory GetDeviceCategory(DeviceCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCategory(new GetDeviceCategoryRequest
            {
                DeviceCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCategory.
        /// Format: `networks/{network_code}/deviceCategories/{device_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCategory> GetDeviceCategoryAsync(DeviceCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCategoryAsync(new GetDeviceCategoryRequest
            {
                DeviceCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCategory.
        /// Format: `networks/{network_code}/deviceCategories/{device_category_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCategory> GetDeviceCategoryAsync(DeviceCategoryName name, st::CancellationToken cancellationToken) =>
            GetDeviceCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategories(ListDeviceCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategoriesAsync(ListDeviceCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCategories.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCategoriesRequest request = new ListDeviceCategoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceCategories(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCategories.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCategoriesRequest request = new ListDeviceCategoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceCategoriesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCategories.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategories(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCategoriesRequest request = new ListDeviceCategoriesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceCategories(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCategories.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategoriesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCategoriesRequest request = new ListDeviceCategoriesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceCategoriesAsync(request, callSettings);
        }
    }

    /// <summary>DeviceCategoryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DeviceCategory` objects.
    /// </remarks>
    public sealed partial class DeviceCategoryServiceClientImpl : DeviceCategoryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDeviceCategoryRequest, DeviceCategory> _callGetDeviceCategory;

        private readonly gaxgrpc::ApiCall<ListDeviceCategoriesRequest, ListDeviceCategoriesResponse> _callListDeviceCategories;

        /// <summary>
        /// Constructs a client wrapper for the DeviceCategoryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeviceCategoryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeviceCategoryServiceClientImpl(DeviceCategoryService.DeviceCategoryServiceClient grpcClient, DeviceCategoryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeviceCategoryServiceSettings effectiveSettings = settings ?? DeviceCategoryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDeviceCategory = clientHelper.BuildApiCall<GetDeviceCategoryRequest, DeviceCategory>("GetDeviceCategory", grpcClient.GetDeviceCategoryAsync, grpcClient.GetDeviceCategory, effectiveSettings.GetDeviceCategorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeviceCategory);
            Modify_GetDeviceCategoryApiCall(ref _callGetDeviceCategory);
            _callListDeviceCategories = clientHelper.BuildApiCall<ListDeviceCategoriesRequest, ListDeviceCategoriesResponse>("ListDeviceCategories", grpcClient.ListDeviceCategoriesAsync, grpcClient.ListDeviceCategories, effectiveSettings.ListDeviceCategoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeviceCategories);
            Modify_ListDeviceCategoriesApiCall(ref _callListDeviceCategories);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDeviceCategoryApiCall(ref gaxgrpc::ApiCall<GetDeviceCategoryRequest, DeviceCategory> call);

        partial void Modify_ListDeviceCategoriesApiCall(ref gaxgrpc::ApiCall<ListDeviceCategoriesRequest, ListDeviceCategoriesResponse> call);

        partial void OnConstruction(DeviceCategoryService.DeviceCategoryServiceClient grpcClient, DeviceCategoryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeviceCategoryService client</summary>
        public override DeviceCategoryService.DeviceCategoryServiceClient GrpcClient { get; }

        partial void Modify_GetDeviceCategoryRequest(ref GetDeviceCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceCategoriesRequest(ref ListDeviceCategoriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceCategory GetDeviceCategory(GetDeviceCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceCategoryRequest(ref request, ref callSettings);
            return _callGetDeviceCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `DeviceCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceCategory> GetDeviceCategoryAsync(GetDeviceCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceCategoryRequest(ref request, ref callSettings);
            return _callGetDeviceCategory.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceCategory"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategories(ListDeviceCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeviceCategoriesRequest, ListDeviceCategoriesResponse, DeviceCategory>(_callListDeviceCategories, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCategory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> ListDeviceCategoriesAsync(ListDeviceCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeviceCategoriesRequest, ListDeviceCategoriesResponse, DeviceCategory>(_callListDeviceCategories, request, callSettings);
        }
    }

    public partial class ListDeviceCategoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeviceCategoriesResponse : gaxgrpc::IPageResponse<DeviceCategory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeviceCategory> GetEnumerator() => DeviceCategories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
