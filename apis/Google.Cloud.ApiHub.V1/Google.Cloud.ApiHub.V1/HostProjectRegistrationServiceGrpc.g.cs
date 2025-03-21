// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/apihub/v1/host_project_registration_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
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
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.ApiHub.V1 {
  /// <summary>
  /// This service is used for managing the host project registrations.
  /// </summary>
  public static partial class HostProjectRegistrationService
  {
    static readonly string __ServiceName = "google.cloud.apihub.v1.HostProjectRegistrationService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest> __Marshaller_google_cloud_apihub_v1_CreateHostProjectRegistrationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> __Marshaller_google_cloud_apihub_v1_HostProjectRegistration = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.HostProjectRegistration.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest> __Marshaller_google_cloud_apihub_v1_GetHostProjectRegistrationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest> __Marshaller_google_cloud_apihub_v1_ListHostProjectRegistrationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse> __Marshaller_google_cloud_apihub_v1_ListHostProjectRegistrationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest, global::Google.Cloud.ApiHub.V1.HostProjectRegistration> __Method_CreateHostProjectRegistration = new grpc::Method<global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest, global::Google.Cloud.ApiHub.V1.HostProjectRegistration>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateHostProjectRegistration",
        __Marshaller_google_cloud_apihub_v1_CreateHostProjectRegistrationRequest,
        __Marshaller_google_cloud_apihub_v1_HostProjectRegistration);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest, global::Google.Cloud.ApiHub.V1.HostProjectRegistration> __Method_GetHostProjectRegistration = new grpc::Method<global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest, global::Google.Cloud.ApiHub.V1.HostProjectRegistration>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetHostProjectRegistration",
        __Marshaller_google_cloud_apihub_v1_GetHostProjectRegistrationRequest,
        __Marshaller_google_cloud_apihub_v1_HostProjectRegistration);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest, global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse> __Method_ListHostProjectRegistrations = new grpc::Method<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest, global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListHostProjectRegistrations",
        __Marshaller_google_cloud_apihub_v1_ListHostProjectRegistrationsRequest,
        __Marshaller_google_cloud_apihub_v1_ListHostProjectRegistrationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.ApiHub.V1.HostProjectRegistrationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HostProjectRegistrationService</summary>
    [grpc::BindServiceMethod(typeof(HostProjectRegistrationService), "BindService")]
    public abstract partial class HostProjectRegistrationServiceBase
    {
      /// <summary>
      /// Create a host project registration.
      /// A Google cloud project can be registered as a host project if it is not
      /// attached as a runtime project to another host project.
      /// A project can be registered as a host project only once. Subsequent
      /// register calls for the same project will fail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> CreateHostProjectRegistration(global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get a host project registration.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> GetHostProjectRegistration(global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists host project registrations.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse> ListHostProjectRegistrations(global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HostProjectRegistrationService</summary>
    public partial class HostProjectRegistrationServiceClient : grpc::ClientBase<HostProjectRegistrationServiceClient>
    {
      /// <summary>Creates a new client for HostProjectRegistrationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HostProjectRegistrationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HostProjectRegistrationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HostProjectRegistrationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HostProjectRegistrationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HostProjectRegistrationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create a host project registration.
      /// A Google cloud project can be registered as a host project if it is not
      /// attached as a runtime project to another host project.
      /// A project can be registered as a host project only once. Subsequent
      /// register calls for the same project will fail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.HostProjectRegistration CreateHostProjectRegistration(global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateHostProjectRegistration(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a host project registration.
      /// A Google cloud project can be registered as a host project if it is not
      /// attached as a runtime project to another host project.
      /// A project can be registered as a host project only once. Subsequent
      /// register calls for the same project will fail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.HostProjectRegistration CreateHostProjectRegistration(global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateHostProjectRegistration, null, options, request);
      }
      /// <summary>
      /// Create a host project registration.
      /// A Google cloud project can be registered as a host project if it is not
      /// attached as a runtime project to another host project.
      /// A project can be registered as a host project only once. Subsequent
      /// register calls for the same project will fail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> CreateHostProjectRegistrationAsync(global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateHostProjectRegistrationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a host project registration.
      /// A Google cloud project can be registered as a host project if it is not
      /// attached as a runtime project to another host project.
      /// A project can be registered as a host project only once. Subsequent
      /// register calls for the same project will fail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> CreateHostProjectRegistrationAsync(global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateHostProjectRegistration, null, options, request);
      }
      /// <summary>
      /// Get a host project registration.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.HostProjectRegistration GetHostProjectRegistration(global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHostProjectRegistration(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a host project registration.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.HostProjectRegistration GetHostProjectRegistration(global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetHostProjectRegistration, null, options, request);
      }
      /// <summary>
      /// Get a host project registration.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> GetHostProjectRegistrationAsync(global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHostProjectRegistrationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a host project registration.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.HostProjectRegistration> GetHostProjectRegistrationAsync(global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetHostProjectRegistration, null, options, request);
      }
      /// <summary>
      /// Lists host project registrations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse ListHostProjectRegistrations(global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListHostProjectRegistrations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists host project registrations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse ListHostProjectRegistrations(global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListHostProjectRegistrations, null, options, request);
      }
      /// <summary>
      /// Lists host project registrations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse> ListHostProjectRegistrationsAsync(global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListHostProjectRegistrationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists host project registrations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse> ListHostProjectRegistrationsAsync(global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListHostProjectRegistrations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override HostProjectRegistrationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HostProjectRegistrationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(HostProjectRegistrationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateHostProjectRegistration, serviceImpl.CreateHostProjectRegistration)
          .AddMethod(__Method_GetHostProjectRegistration, serviceImpl.GetHostProjectRegistration)
          .AddMethod(__Method_ListHostProjectRegistrations, serviceImpl.ListHostProjectRegistrations).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, HostProjectRegistrationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateHostProjectRegistration, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.CreateHostProjectRegistrationRequest, global::Google.Cloud.ApiHub.V1.HostProjectRegistration>(serviceImpl.CreateHostProjectRegistration));
      serviceBinder.AddMethod(__Method_GetHostProjectRegistration, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.GetHostProjectRegistrationRequest, global::Google.Cloud.ApiHub.V1.HostProjectRegistration>(serviceImpl.GetHostProjectRegistration));
      serviceBinder.AddMethod(__Method_ListHostProjectRegistrations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsRequest, global::Google.Cloud.ApiHub.V1.ListHostProjectRegistrationsResponse>(serviceImpl.ListHostProjectRegistrations));
    }

  }
}
#endregion
