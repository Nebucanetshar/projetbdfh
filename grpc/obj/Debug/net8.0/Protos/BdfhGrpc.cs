// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/bdfh.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace grpc {
  public static partial class Do
  {
    static readonly string __ServiceName = "bdfh.Do";

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
    static readonly grpc::Marshaller<global::grpc.CreateRequest> __Marshaller_bdfh_CreateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.CreateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.CreateResponse> __Marshaller_bdfh_CreateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.CreateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.ReadRequest> __Marshaller_bdfh_ReadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.ReadRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.ReadResponse> __Marshaller_bdfh_ReadResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.ReadResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.GetAllRequest> __Marshaller_bdfh_GetAllRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.GetAllRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.GetAllResponse> __Marshaller_bdfh_GetAllResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.GetAllResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.DeleteRequest> __Marshaller_bdfh_DeleteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.DeleteRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.DeleteResponse> __Marshaller_bdfh_DeleteResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.DeleteResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.UpdateRequest> __Marshaller_bdfh_UpdateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.UpdateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.UpdateResponse> __Marshaller_bdfh_UpdateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.UpdateResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.CreateRequest, global::grpc.CreateResponse> __Method_DoCreate = new grpc::Method<global::grpc.CreateRequest, global::grpc.CreateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoCreate",
        __Marshaller_bdfh_CreateRequest,
        __Marshaller_bdfh_CreateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.ReadRequest, global::grpc.ReadResponse> __Method_DoRead = new grpc::Method<global::grpc.ReadRequest, global::grpc.ReadResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoRead",
        __Marshaller_bdfh_ReadRequest,
        __Marshaller_bdfh_ReadResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.GetAllRequest, global::grpc.GetAllResponse> __Method_DoList = new grpc::Method<global::grpc.GetAllRequest, global::grpc.GetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoList",
        __Marshaller_bdfh_GetAllRequest,
        __Marshaller_bdfh_GetAllResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.DeleteRequest, global::grpc.DeleteResponse> __Method_DoDelete = new grpc::Method<global::grpc.DeleteRequest, global::grpc.DeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoDelete",
        __Marshaller_bdfh_DeleteRequest,
        __Marshaller_bdfh_DeleteResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.UpdateRequest, global::grpc.UpdateResponse> __Method_DoUpdate = new grpc::Method<global::grpc.UpdateRequest, global::grpc.UpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoUpdate",
        __Marshaller_bdfh_UpdateRequest,
        __Marshaller_bdfh_UpdateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::grpc.BdfhReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Do</summary>
    [grpc::BindServiceMethod(typeof(Do), "BindService")]
    public abstract partial class DoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::grpc.CreateResponse> DoCreate(global::grpc.CreateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::grpc.ReadResponse> DoRead(global::grpc.ReadRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::grpc.GetAllResponse> DoList(global::grpc.GetAllRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::grpc.DeleteResponse> DoDelete(global::grpc.DeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::grpc.UpdateResponse> DoUpdate(global::grpc.UpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(DoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DoCreate, serviceImpl.DoCreate)
          .AddMethod(__Method_DoRead, serviceImpl.DoRead)
          .AddMethod(__Method_DoList, serviceImpl.DoList)
          .AddMethod(__Method_DoDelete, serviceImpl.DoDelete)
          .AddMethod(__Method_DoUpdate, serviceImpl.DoUpdate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DoCreate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpc.CreateRequest, global::grpc.CreateResponse>(serviceImpl.DoCreate));
      serviceBinder.AddMethod(__Method_DoRead, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpc.ReadRequest, global::grpc.ReadResponse>(serviceImpl.DoRead));
      serviceBinder.AddMethod(__Method_DoList, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpc.GetAllRequest, global::grpc.GetAllResponse>(serviceImpl.DoList));
      serviceBinder.AddMethod(__Method_DoDelete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpc.DeleteRequest, global::grpc.DeleteResponse>(serviceImpl.DoDelete));
      serviceBinder.AddMethod(__Method_DoUpdate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpc.UpdateRequest, global::grpc.UpdateResponse>(serviceImpl.DoUpdate));
    }

  }
}
#endregion