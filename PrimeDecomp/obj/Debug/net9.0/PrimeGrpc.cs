// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: prime.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PrimeDecomp {
  public static partial class PrimeCalculatorService
  {
    static readonly string __ServiceName = "prime.PrimeCalculatorService";

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
    static readonly grpc::Marshaller<global::PrimeDecomp.PrimeRequest> __Marshaller_prime_PrimeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PrimeDecomp.PrimeRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PrimeDecomp.PrimeResponse> __Marshaller_prime_PrimeResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PrimeDecomp.PrimeResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PrimeDecomp.LongNumberRequest> __Marshaller_prime_LongNumberRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PrimeDecomp.LongNumberRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PrimeDecomp.LongNumberResponse> __Marshaller_prime_LongNumberResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PrimeDecomp.LongNumberResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PrimeDecomp.PrimeRequest, global::PrimeDecomp.PrimeResponse> __Method_DecomposeIntoPrimes = new grpc::Method<global::PrimeDecomp.PrimeRequest, global::PrimeDecomp.PrimeResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "DecomposeIntoPrimes",
        __Marshaller_prime_PrimeRequest,
        __Marshaller_prime_PrimeResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PrimeDecomp.LongNumberRequest, global::PrimeDecomp.LongNumberResponse> __Method_ComputeAverage = new grpc::Method<global::PrimeDecomp.LongNumberRequest, global::PrimeDecomp.LongNumberResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ComputeAverage",
        __Marshaller_prime_LongNumberRequest,
        __Marshaller_prime_LongNumberResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PrimeDecomp.PrimeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PrimeCalculatorService</summary>
    [grpc::BindServiceMethod(typeof(PrimeCalculatorService), "BindService")]
    public abstract partial class PrimeCalculatorServiceBase
    {
      /// <summary>
      /// server streaming 
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task DecomposeIntoPrimes(global::PrimeDecomp.PrimeRequest request, grpc::IServerStreamWriter<global::PrimeDecomp.PrimeResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PrimeDecomp.LongNumberResponse> ComputeAverage(grpc::IAsyncStreamReader<global::PrimeDecomp.LongNumberRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PrimeCalculatorServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DecomposeIntoPrimes, serviceImpl.DecomposeIntoPrimes)
          .AddMethod(__Method_ComputeAverage, serviceImpl.ComputeAverage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PrimeCalculatorServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DecomposeIntoPrimes, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::PrimeDecomp.PrimeRequest, global::PrimeDecomp.PrimeResponse>(serviceImpl.DecomposeIntoPrimes));
      serviceBinder.AddMethod(__Method_ComputeAverage, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::PrimeDecomp.LongNumberRequest, global::PrimeDecomp.LongNumberResponse>(serviceImpl.ComputeAverage));
    }

  }
}
#endregion
