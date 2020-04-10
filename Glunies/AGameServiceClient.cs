using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public abstract class AGameServiceClient : ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x10641DC", Offset="0x10641DC")]
		[FieldOffset(Offset="0x10")]
		protected DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x10641EC", Offset="0x10641EC")]
		[FieldOffset(Offset="0x18")]
		private BootstrapConfig _bootstrapConfig;

		[Attribute(Name="InjectAttribute", RVA="0x10641FC", Offset="0x10641FC")]
		[FieldOffset(Offset="0x20")]
		private Procrastinator _procrastinator;

		[Attribute(Name="InjectAttribute", RVA="0x106420C", Offset="0x106420C")]
		[FieldOffset(Offset="0x28")]
		private GameServiceManager _gameServiceManager;

		[Attribute(Name="InjectAttribute", RVA="0x106421C", Offset="0x106421C")]
		[FieldOffset(Offset="0x30")]
		private GamedataManager _gamedataManager;

		[Attribute(Name="InjectAttribute", RVA="0x106422C", Offset="0x106422C")]
		[FieldOffset(Offset="0x38")]
		private IGameServiceTransport _transport;

		[Attribute(Name="InjectAttribute", RVA="0x106423C", Offset="0x106423C")]
		[FieldOffset(Offset="0x40")]
		private IGameServiceTransport _httpTransport;

		[FieldOffset(Offset="0x0")]
		private readonly static Dictionary<string, uint> s_timeoutOverrides;

		[FieldOffset(Offset="0x48")]
		private Dictionary<string, List<DCachedResponse>> _responseCaches;

		public LogCategory LogCategory
		{
			[Address(RVA="0x14F5F74", Offset="0x14F5F74", VA="0x14F5F74", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x14F65F0", Offset="0x14F65F0", VA="0x14F65F0")]
		static AGameServiceClient()
		{
		}

		[Address(RVA="0x14F6580", Offset="0x14F6580", VA="0x14F6580")]
		protected AGameServiceClient()
		{
		}

		[Address(RVA="0x14F6258", Offset="0x14F6258", VA="0x14F6258")]
		protected void CacheResponse(string rpcName, IMessage request, IMessage response, CacheSettings settings)
		{
		}

		[Address(RVA="0x19A1264", Offset="0x19A1264", VA="0x19A1264")]
		public void Call<TRequest, TResponse>(string rpcName, TRequest requestProtoObject, Action<TResponse> serviceSuccess, Action<TResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Glunies.AGameServiceClient::Call(System.String,TRequest,System.Action`1<TResponse>,System.Action`1<TResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Call(System.String,TRequest,System.Action<TResponse>,System.Action<TResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14F63FC", Offset="0x14F63FC", VA="0x14F63FC")]
		private void CleanResponseCache(string rpcName, int numToKeep)
		{
		}

		[Address(RVA="0x14F5F80", Offset="0x14F5F80", VA="0x14F5F80")]
		public void ClearCaches()
		{
		}

		[Address(RVA="0x14F5FE0", Offset="0x14F5FE0", VA="0x14F5FE0")]
		public void ExpireResponseCache(string rpcName)
		{
		}

		[Address(RVA="0x14F6084", Offset="0x14F6084", VA="0x14F6084")]
		protected void HandleFailure(Action<long> callback, long errorCode, ResponseEnvelope responseEnvelope)
		{
		}

		[Address(RVA="0x19A1408", Offset="0x19A1408", VA="0x19A1408")]
		private void InternalCall<TRequest, TResponse>(string rpcName, TRequest requestProtoObject, Action<TResponse> serviceSuccess, Action<TResponse> success, Action<long> failure, Func<bool> silence, Action done, Action<bool> gameServiceManagerNotifyComplete)
		where TRequest : IMessage
		where TResponse : IMessage, new()
		{
		}

		[Address(RVA="0x14F5F7C", Offset="0x14F5F7C", VA="0x14F5F7C")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x1F6469C", Offset="0x1F6469C", VA="0x1F6469C")]
		protected bool TryGetCachedResponse<TResponse>(string rpcName, IMessage request, out TResponse response)
		where TResponse : IMessage
		{
			response = default(TResponse);
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F98", Offset="0x1050F98")]
		private sealed class <>c__DisplayClass4_0<TRequest, TResponse>
		where TRequest : IMessage
		where TResponse : IMessage, new()
		{
			[FieldOffset(Offset="0x0")]
			public AGameServiceClient <>4__this;

			[FieldOffset(Offset="0x0")]
			public Func<bool> silence;

			[FieldOffset(Offset="0x0")]
			public Action<long> failure;

			[FieldOffset(Offset="0x0")]
			public Action done;

			[FieldOffset(Offset="0x0")]
			public string rpcName;

			[FieldOffset(Offset="0x0")]
			public TRequest requestProtoObject;

			[FieldOffset(Offset="0x0")]
			public Action<TResponse> serviceSuccess;

			[FieldOffset(Offset="0x0")]
			public Action<TResponse> success;

			[Address(RVA="0x1BFF160", Offset="0x1BFF160", VA="0x1BFF160")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1BFF18C", Offset="0x1BFF18C", VA="0x1BFF18C")]
			internal void <Call>b__0(Action<bool> gameServiceManagerNotifyComplete, bool autoFail)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050FA8", Offset="0x1050FA8")]
		private sealed class <>c__DisplayClass4_1<TResponse, TRequest>
		where TResponse : IMessage, new()
		where TRequest : IMessage
		{
			[FieldOffset(Offset="0x0")]
			public Action<bool> gameServiceManagerNotifyComplete;

			[FieldOffset(Offset="0x0")]
			public TResponse cachedResponse;

			[FieldOffset(Offset="0x0")]
			public AGameServiceClient.<>c__DisplayClass4_0<TRequest, TResponse> CS$<>8__locals1;

			[Address(RVA="0x1BFF3B0", Offset="0x1BFF3B0", VA="0x1BFF3B0")]
			public <>c__DisplayClass4_1()
			{
			}

			[Address(RVA="0x1BFF3DC", Offset="0x1BFF3DC", VA="0x1BFF3DC")]
			internal void <Call>b__1()
			{
			}

			[Address(RVA="0x1BFF520", Offset="0x1BFF520", VA="0x1BFF520")]
			internal void <Call>b__2()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050FB8", Offset="0x1050FB8")]
		private sealed class <>c__DisplayClass6_0<TRequest, TResponse>
		where TRequest : IMessage
		where TResponse : IMessage, new()
		{
			[FieldOffset(Offset="0x0")]
			public Func<bool> silence;

			[FieldOffset(Offset="0x0")]
			public AGameServiceClient <>4__this;

			[FieldOffset(Offset="0x0")]
			public string rpcName;

			[FieldOffset(Offset="0x0")]
			public TRequest requestProtoObject;

			[FieldOffset(Offset="0x0")]
			public Action<TResponse> serviceSuccess;

			[FieldOffset(Offset="0x0")]
			public Action<TResponse> success;

			[FieldOffset(Offset="0x0")]
			public Action<long> failure;

			[FieldOffset(Offset="0x0")]
			public Action done;

			[FieldOffset(Offset="0x0")]
			public Action<bool> gameServiceManagerNotifyComplete;

			[Address(RVA="0x1BFF64C", Offset="0x1BFF64C", VA="0x1BFF64C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x1BFF678", Offset="0x1BFF678", VA="0x1BFF678")]
			internal void <InternalCall>b__0(ResponseEnvelope response)
			{
			}

			[Address(RVA="0x1BFFA74", Offset="0x1BFFA74", VA="0x1BFFA74")]
			internal void <InternalCall>b__1(long errorCode, ResponseEnvelope response)
			{
			}
		}
	}
}