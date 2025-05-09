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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.BeyondCorp.ClientGateways.V1
{
    /// <summary>Settings for <see cref="ClientGatewaysServiceClient"/> instances.</summary>
    public sealed partial class ClientGatewaysServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ClientGatewaysServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ClientGatewaysServiceSettings"/>.</returns>
        public static ClientGatewaysServiceSettings GetDefault() => new ClientGatewaysServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ClientGatewaysServiceSettings"/> object with default settings.
        /// </summary>
        public ClientGatewaysServiceSettings()
        {
        }

        private ClientGatewaysServiceSettings(ClientGatewaysServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListClientGatewaysSettings = existing.ListClientGatewaysSettings;
            GetClientGatewaySettings = existing.GetClientGatewaySettings;
            CreateClientGatewaySettings = existing.CreateClientGatewaySettings;
            CreateClientGatewayOperationsSettings = existing.CreateClientGatewayOperationsSettings.Clone();
            DeleteClientGatewaySettings = existing.DeleteClientGatewaySettings;
            DeleteClientGatewayOperationsSettings = existing.DeleteClientGatewayOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ClientGatewaysServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientGatewaysServiceClient.ListClientGateways</c> and
        /// <c>ClientGatewaysServiceClient.ListClientGatewaysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClientGatewaysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientGatewaysServiceClient.GetClientGateway</c> and <c>ClientGatewaysServiceClient.GetClientGatewayAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClientGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientGatewaysServiceClient.CreateClientGateway</c> and
        /// <c>ClientGatewaysServiceClient.CreateClientGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClientGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClientGatewaysServiceClient.CreateClientGateway</c> and
        /// <c>ClientGatewaysServiceClient.CreateClientGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateClientGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientGatewaysServiceClient.DeleteClientGateway</c> and
        /// <c>ClientGatewaysServiceClient.DeleteClientGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClientGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClientGatewaysServiceClient.DeleteClientGateway</c> and
        /// <c>ClientGatewaysServiceClient.DeleteClientGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteClientGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ClientGatewaysServiceSettings"/> object.</returns>
        public ClientGatewaysServiceSettings Clone() => new ClientGatewaysServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ClientGatewaysServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ClientGatewaysServiceClientBuilder : gaxgrpc::ClientBuilderBase<ClientGatewaysServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ClientGatewaysServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ClientGatewaysServiceClientBuilder() : base(ClientGatewaysServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ClientGatewaysServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ClientGatewaysServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ClientGatewaysServiceClient Build()
        {
            ClientGatewaysServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ClientGatewaysServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ClientGatewaysServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ClientGatewaysServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ClientGatewaysServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ClientGatewaysServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ClientGatewaysServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ClientGatewaysServiceClient.ChannelPool;
    }

    /// <summary>ClientGatewaysService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The ClientGatewaysService exposes the following resources:
    /// 
    /// * Client Gateways, named as follows:
    /// `projects/{project_id}/locations/{location_id}/clientGateways/{client_gateway_id}`.
    /// </remarks>
    public abstract partial class ClientGatewaysServiceClient
    {
        /// <summary>
        /// The default endpoint for the ClientGatewaysService service, which is a host of "beyondcorp.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "beyondcorp.googleapis.com:443";

        /// <summary>The default ClientGatewaysService scopes.</summary>
        /// <remarks>
        /// The default ClientGatewaysService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ClientGatewaysService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ClientGatewaysServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ClientGatewaysServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ClientGatewaysServiceClient"/>.</returns>
        public static stt::Task<ClientGatewaysServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ClientGatewaysServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ClientGatewaysServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ClientGatewaysServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ClientGatewaysServiceClient"/>.</returns>
        public static ClientGatewaysServiceClient Create() => new ClientGatewaysServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ClientGatewaysServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ClientGatewaysServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ClientGatewaysServiceClient"/>.</returns>
        internal static ClientGatewaysServiceClient Create(grpccore::CallInvoker callInvoker, ClientGatewaysServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ClientGatewaysService.ClientGatewaysServiceClient grpcClient = new ClientGatewaysService.ClientGatewaysServiceClient(callInvoker);
            return new ClientGatewaysServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ClientGatewaysService client</summary>
        public virtual ClientGatewaysService.ClientGatewaysServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ClientGateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGateways(ListClientGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ClientGateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGatewaysAsync(ListClientGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientGatewaysRequest.
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
        /// <returns>A pageable sequence of <see cref="ClientGateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGateways(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientGatewaysRequest request = new ListClientGatewaysRequest
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
            return ListClientGateways(request, callSettings);
        }

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientGatewaysRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ClientGateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGatewaysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientGatewaysRequest request = new ListClientGatewaysRequest
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
            return ListClientGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientGatewaysRequest.
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
        /// <returns>A pageable sequence of <see cref="ClientGateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGateways(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientGatewaysRequest request = new ListClientGatewaysRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListClientGateways(request, callSettings);
        }

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientGatewaysRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ClientGateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGatewaysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientGatewaysRequest request = new ListClientGatewaysRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListClientGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientGateway GetClientGateway(GetClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientGateway> GetClientGatewayAsync(GetClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientGateway> GetClientGatewayAsync(GetClientGatewayRequest request, st::CancellationToken cancellationToken) =>
            GetClientGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientGateway GetClientGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientGateway(new GetClientGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientGateway> GetClientGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientGatewayAsync(new GetClientGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientGateway> GetClientGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            GetClientGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientGateway GetClientGateway(ClientGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientGateway(new GetClientGatewayRequest
            {
                ClientGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientGateway> GetClientGatewayAsync(ClientGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientGatewayAsync(new GetClientGatewayRequest
            {
                ClientGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientGateway> GetClientGatewayAsync(ClientGatewayName name, st::CancellationToken cancellationToken) =>
            GetClientGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientGateway, ClientGatewayOperationMetadata> CreateClientGateway(CreateClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(CreateClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(CreateClientGatewayRequest request, st::CancellationToken cancellationToken) =>
            CreateClientGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateClientGateway</c>.</summary>
        public virtual lro::OperationsClient CreateClientGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateClientGateway</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ClientGateway, ClientGatewayOperationMetadata> PollOnceCreateClientGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientGateway, ClientGatewayOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClientGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateClientGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> PollOnceCreateClientGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientGateway, ClientGatewayOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClientGatewayOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientGateway">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientGatewayId">
        /// Optional. User-settable client gateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientGateway, ClientGatewayOperationMetadata> CreateClientGateway(string parent, ClientGateway clientGateway, string clientGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientGateway(new CreateClientGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientGatewayId = clientGatewayId ?? "",
                ClientGateway = gax::GaxPreconditions.CheckNotNull(clientGateway, nameof(clientGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientGateway">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientGatewayId">
        /// Optional. User-settable client gateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(string parent, ClientGateway clientGateway, string clientGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientGatewayAsync(new CreateClientGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientGatewayId = clientGatewayId ?? "",
                ClientGateway = gax::GaxPreconditions.CheckNotNull(clientGateway, nameof(clientGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientGateway">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientGatewayId">
        /// Optional. User-settable client gateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(string parent, ClientGateway clientGateway, string clientGatewayId, st::CancellationToken cancellationToken) =>
            CreateClientGatewayAsync(parent, clientGateway, clientGatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientGateway">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientGatewayId">
        /// Optional. User-settable client gateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientGateway, ClientGatewayOperationMetadata> CreateClientGateway(gagr::LocationName parent, ClientGateway clientGateway, string clientGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientGateway(new CreateClientGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientGatewayId = clientGatewayId ?? "",
                ClientGateway = gax::GaxPreconditions.CheckNotNull(clientGateway, nameof(clientGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientGateway">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientGatewayId">
        /// Optional. User-settable client gateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(gagr::LocationName parent, ClientGateway clientGateway, string clientGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientGatewayAsync(new CreateClientGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientGatewayId = clientGatewayId ?? "",
                ClientGateway = gax::GaxPreconditions.CheckNotNull(clientGateway, nameof(clientGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientGateway">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientGatewayId">
        /// Optional. User-settable client gateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(gagr::LocationName parent, ClientGateway clientGateway, string clientGatewayId, st::CancellationToken cancellationToken) =>
            CreateClientGatewayAsync(parent, clientGateway, clientGatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClientGatewayOperationMetadata> DeleteClientGateway(DeleteClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(DeleteClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(DeleteClientGatewayRequest request, st::CancellationToken cancellationToken) =>
            DeleteClientGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteClientGateway</c>.</summary>
        public virtual lro::OperationsClient DeleteClientGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteClientGateway</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, ClientGatewayOperationMetadata> PollOnceDeleteClientGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClientGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteClientGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> PollOnceDeleteClientGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClientGatewayOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClientGatewayOperationMetadata> DeleteClientGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientGateway(new DeleteClientGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientGatewayAsync(new DeleteClientGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClientGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClientGatewayOperationMetadata> DeleteClientGateway(ClientGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientGateway(new DeleteClientGatewayRequest
            {
                ClientGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(ClientGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientGatewayAsync(new DeleteClientGatewayRequest
            {
                ClientGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(ClientGatewayName name, st::CancellationToken cancellationToken) =>
            DeleteClientGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ClientGatewaysService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The ClientGatewaysService exposes the following resources:
    /// 
    /// * Client Gateways, named as follows:
    /// `projects/{project_id}/locations/{location_id}/clientGateways/{client_gateway_id}`.
    /// </remarks>
    public sealed partial class ClientGatewaysServiceClientImpl : ClientGatewaysServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListClientGatewaysRequest, ListClientGatewaysResponse> _callListClientGateways;

        private readonly gaxgrpc::ApiCall<GetClientGatewayRequest, ClientGateway> _callGetClientGateway;

        private readonly gaxgrpc::ApiCall<CreateClientGatewayRequest, lro::Operation> _callCreateClientGateway;

        private readonly gaxgrpc::ApiCall<DeleteClientGatewayRequest, lro::Operation> _callDeleteClientGateway;

        /// <summary>
        /// Constructs a client wrapper for the ClientGatewaysService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ClientGatewaysServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ClientGatewaysServiceClientImpl(ClientGatewaysService.ClientGatewaysServiceClient grpcClient, ClientGatewaysServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ClientGatewaysServiceSettings effectiveSettings = settings ?? ClientGatewaysServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateClientGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClientGatewayOperationsSettings, logger);
            DeleteClientGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClientGatewayOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListClientGateways = clientHelper.BuildApiCall<ListClientGatewaysRequest, ListClientGatewaysResponse>("ListClientGateways", grpcClient.ListClientGatewaysAsync, grpcClient.ListClientGateways, effectiveSettings.ListClientGatewaysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClientGateways);
            Modify_ListClientGatewaysApiCall(ref _callListClientGateways);
            _callGetClientGateway = clientHelper.BuildApiCall<GetClientGatewayRequest, ClientGateway>("GetClientGateway", grpcClient.GetClientGatewayAsync, grpcClient.GetClientGateway, effectiveSettings.GetClientGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetClientGateway);
            Modify_GetClientGatewayApiCall(ref _callGetClientGateway);
            _callCreateClientGateway = clientHelper.BuildApiCall<CreateClientGatewayRequest, lro::Operation>("CreateClientGateway", grpcClient.CreateClientGatewayAsync, grpcClient.CreateClientGateway, effectiveSettings.CreateClientGatewaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateClientGateway);
            Modify_CreateClientGatewayApiCall(ref _callCreateClientGateway);
            _callDeleteClientGateway = clientHelper.BuildApiCall<DeleteClientGatewayRequest, lro::Operation>("DeleteClientGateway", grpcClient.DeleteClientGatewayAsync, grpcClient.DeleteClientGateway, effectiveSettings.DeleteClientGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteClientGateway);
            Modify_DeleteClientGatewayApiCall(ref _callDeleteClientGateway);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListClientGatewaysApiCall(ref gaxgrpc::ApiCall<ListClientGatewaysRequest, ListClientGatewaysResponse> call);

        partial void Modify_GetClientGatewayApiCall(ref gaxgrpc::ApiCall<GetClientGatewayRequest, ClientGateway> call);

        partial void Modify_CreateClientGatewayApiCall(ref gaxgrpc::ApiCall<CreateClientGatewayRequest, lro::Operation> call);

        partial void Modify_DeleteClientGatewayApiCall(ref gaxgrpc::ApiCall<DeleteClientGatewayRequest, lro::Operation> call);

        partial void OnConstruction(ClientGatewaysService.ClientGatewaysServiceClient grpcClient, ClientGatewaysServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ClientGatewaysService client</summary>
        public override ClientGatewaysService.ClientGatewaysServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListClientGatewaysRequest(ref ListClientGatewaysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClientGatewayRequest(ref GetClientGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClientGatewayRequest(ref CreateClientGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClientGatewayRequest(ref DeleteClientGatewayRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ClientGateway"/> resources.</returns>
        public override gax::PagedEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGateways(ListClientGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClientGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClientGatewaysRequest, ListClientGatewaysResponse, ClientGateway>(_callListClientGateways, request, callSettings);
        }

        /// <summary>
        /// Lists ClientGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ClientGateway"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> ListClientGatewaysAsync(ListClientGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClientGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClientGatewaysRequest, ListClientGatewaysResponse, ClientGateway>(_callListClientGateways, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClientGateway GetClientGateway(GetClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClientGatewayRequest(ref request, ref callSettings);
            return _callGetClientGateway.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClientGateway> GetClientGatewayAsync(GetClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClientGatewayRequest(ref request, ref callSettings);
            return _callGetClientGateway.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateClientGateway</c>.</summary>
        public override lro::OperationsClient CreateClientGatewayOperationsClient { get; }

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ClientGateway, ClientGatewayOperationMetadata> CreateClientGateway(CreateClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<ClientGateway, ClientGatewayOperationMetadata>(_callCreateClientGateway.Sync(request, callSettings), CreateClientGatewayOperationsClient);
        }

        /// <summary>
        /// Creates a new ClientGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ClientGateway, ClientGatewayOperationMetadata>> CreateClientGatewayAsync(CreateClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<ClientGateway, ClientGatewayOperationMetadata>(await _callCreateClientGateway.Async(request, callSettings).ConfigureAwait(false), CreateClientGatewayOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteClientGateway</c>.</summary>
        public override lro::OperationsClient DeleteClientGatewayOperationsClient { get; }

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, ClientGatewayOperationMetadata> DeleteClientGateway(DeleteClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClientGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>(_callDeleteClientGateway.Sync(request, callSettings), DeleteClientGatewayOperationsClient);
        }

        /// <summary>
        /// Deletes a single ClientGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>> DeleteClientGatewayAsync(DeleteClientGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClientGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ClientGatewayOperationMetadata>(await _callDeleteClientGateway.Async(request, callSettings).ConfigureAwait(false), DeleteClientGatewayOperationsClient);
        }
    }

    public partial class ListClientGatewaysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClientGatewaysResponse : gaxgrpc::IPageResponse<ClientGateway>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ClientGateway> GetEnumerator() => ClientGateways.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ClientGatewaysService
    {
        public partial class ClientGatewaysServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class ClientGatewaysService
    {
        public partial class ClientGatewaysServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
