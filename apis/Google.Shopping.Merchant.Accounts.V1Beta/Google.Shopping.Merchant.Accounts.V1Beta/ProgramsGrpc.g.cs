// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/merchant/accounts/v1beta/programs.proto
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

namespace Google.Shopping.Merchant.Accounts.V1Beta {
  /// <summary>
  /// Service for program management.
  ///
  /// Programs provide a mechanism for adding functionality to merchant accounts. A
  /// typical example of this is the [Free product
  /// listings](https://support.google.com/merchants/topic/9240261?ref_topic=7257954,7259405,&amp;sjid=796648681813264022-EU)
  /// program, which enables products from a merchant's store to be shown across
  /// Google for free.
  ///
  /// This service exposes methods to retrieve a merchant's
  /// participation in all available programs, in addition to methods for
  /// explicitly enabling or disabling participation in each program.
  /// </summary>
  public static partial class ProgramsService
  {
    static readonly string __ServiceName = "google.shopping.merchant.accounts.v1beta.ProgramsService";

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
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest> __Marshaller_google_shopping_merchant_accounts_v1beta_GetProgramRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> __Marshaller_google_shopping_merchant_accounts_v1beta_Program = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Accounts.V1Beta.Program.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest> __Marshaller_google_shopping_merchant_accounts_v1beta_ListProgramsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse> __Marshaller_google_shopping_merchant_accounts_v1beta_ListProgramsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest> __Marshaller_google_shopping_merchant_accounts_v1beta_EnableProgramRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest> __Marshaller_google_shopping_merchant_accounts_v1beta_DisableProgramRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program> __Method_GetProgram = new grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProgram",
        __Marshaller_google_shopping_merchant_accounts_v1beta_GetProgramRequest,
        __Marshaller_google_shopping_merchant_accounts_v1beta_Program);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse> __Method_ListPrograms = new grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPrograms",
        __Marshaller_google_shopping_merchant_accounts_v1beta_ListProgramsRequest,
        __Marshaller_google_shopping_merchant_accounts_v1beta_ListProgramsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program> __Method_EnableProgram = new grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EnableProgram",
        __Marshaller_google_shopping_merchant_accounts_v1beta_EnableProgramRequest,
        __Marshaller_google_shopping_merchant_accounts_v1beta_Program);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program> __Method_DisableProgram = new grpc::Method<global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DisableProgram",
        __Marshaller_google_shopping_merchant_accounts_v1beta_DisableProgramRequest,
        __Marshaller_google_shopping_merchant_accounts_v1beta_Program);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Merchant.Accounts.V1Beta.ProgramsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProgramsService</summary>
    [grpc::BindServiceMethod(typeof(ProgramsService), "BindService")]
    public abstract partial class ProgramsServiceBase
    {
      /// <summary>
      /// Retrieves the specified program for the account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> GetProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves all programs for the account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse> ListPrograms(global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Enable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> EnableProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Disable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> DisableProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProgramsService</summary>
    public partial class ProgramsServiceClient : grpc::ClientBase<ProgramsServiceClient>
    {
      /// <summary>Creates a new client for ProgramsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProgramsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProgramsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProgramsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProgramsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProgramsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the specified program for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.Program GetProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProgram(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified program for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.Program GetProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProgram, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified program for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> GetProgramAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProgramAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified program for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> GetProgramAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProgram, null, options, request);
      }
      /// <summary>
      /// Retrieves all programs for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse ListPrograms(global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPrograms(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves all programs for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse ListPrograms(global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPrograms, null, options, request);
      }
      /// <summary>
      /// Retrieves all programs for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse> ListProgramsAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListProgramsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves all programs for the account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse> ListProgramsAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPrograms, null, options, request);
      }
      /// <summary>
      /// Enable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.Program EnableProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnableProgram(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Enable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.Program EnableProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EnableProgram, null, options, request);
      }
      /// <summary>
      /// Enable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> EnableProgramAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnableProgramAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Enable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> EnableProgramAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EnableProgram, null, options, request);
      }
      /// <summary>
      /// Disable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.Program DisableProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DisableProgram(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Disable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Accounts.V1Beta.Program DisableProgram(global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DisableProgram, null, options, request);
      }
      /// <summary>
      /// Disable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> DisableProgramAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DisableProgramAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Disable participation in the specified program for the account. Executing
      /// this method requires admin access.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Accounts.V1Beta.Program> DisableProgramAsync(global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DisableProgram, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProgramsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProgramsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProgramsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProgram, serviceImpl.GetProgram)
          .AddMethod(__Method_ListPrograms, serviceImpl.ListPrograms)
          .AddMethod(__Method_EnableProgram, serviceImpl.EnableProgram)
          .AddMethod(__Method_DisableProgram, serviceImpl.DisableProgram).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProgramsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProgram, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Accounts.V1Beta.GetProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program>(serviceImpl.GetProgram));
      serviceBinder.AddMethod(__Method_ListPrograms, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.ListProgramsResponse>(serviceImpl.ListPrograms));
      serviceBinder.AddMethod(__Method_EnableProgram, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Accounts.V1Beta.EnableProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program>(serviceImpl.EnableProgram));
      serviceBinder.AddMethod(__Method_DisableProgram, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Accounts.V1Beta.DisableProgramRequest, global::Google.Shopping.Merchant.Accounts.V1Beta.Program>(serviceImpl.DisableProgram));
    }

  }
}
#endregion
