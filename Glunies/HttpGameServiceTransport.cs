using Il2CppDummyDll;
using Serverproto;
using System;

namespace Glunies
{
	public class HttpGameServiceTransport : IGameServiceTransport, ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x10642A0", Offset="0x10642A0")]
		[FieldOffset(Offset="0x10")]
		private BootstrapConfig _bootstrapConfig;

		[Attribute(Name="InjectAttribute", RVA="0x10642B0", Offset="0x10642B0")]
		[FieldOffset(Offset="0x18")]
		private HttpService _httpService;

		[Attribute(Name="InjectAttribute", RVA="0x10642C0", Offset="0x10642C0")]
		[FieldOffset(Offset="0x20")]
		private Core _coreService;

		[FieldOffset(Offset="0x28")]
		private string _authToken;

		[FieldOffset(Offset="0x30")]
		private Serverproto.AuthType _authType;

		private string Glunies.IGameServiceTransport.AuthToken
		{
			[Address(RVA="0x142770C", Offset="0x142770C", VA="0x142770C", Slot="4")]
			get
			{
				return null;
			}
		}

		private Serverproto.AuthType Glunies.IGameServiceTransport.AuthType
		{
			[Address(RVA="0x1427714", Offset="0x1427714", VA="0x1427714", Slot="5")]
			get
			{
				return new Serverproto.AuthType();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x1427704", Offset="0x1427704", VA="0x1427704", Slot="11")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1427F28", Offset="0x1427F28", VA="0x1427F28")]
		public HttpGameServiceTransport()
		{
		}

		[Address(RVA="0x1427B38", Offset="0x1427B38", VA="0x1427B38")]
		private string GetRpcUrl(string rpcName)
		{
			return null;
		}

		[Address(RVA="0x14279BC", Offset="0x14279BC", VA="0x14279BC", Slot="10")]
		private void Glunies.IGameServiceTransport.Call(RequestEnvelope requestProtoObject, Action<ResponseEnvelope> success, Action<long, ResponseEnvelope> failure, uint timeoutOverrideS)
		{
		}

		[Address(RVA="0x142771C", Offset="0x142771C", VA="0x142771C", Slot="6")]
		private void Glunies.IGameServiceTransport.Initialize(Serverproto.AuthType authType, string authId, string timezone, Action<bool> completed)
		{
		}

		[Address(RVA="0x14279B0", Offset="0x14279B0", VA="0x14279B0", Slot="7")]
		private void Glunies.IGameServiceTransport.Reconnect()
		{
		}

		[Address(RVA="0x14279B4", Offset="0x14279B4", VA="0x14279B4", Slot="8")]
		private void Glunies.IGameServiceTransport.Shutdown()
		{
		}

		[Address(RVA="0x14279B8", Offset="0x14279B8", VA="0x14279B8", Slot="9")]
		private void Glunies.IGameServiceTransport.TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050FF8", Offset="0x1050FF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HttpGameServiceTransport.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<bool> <>9__6_2;

			[Address(RVA="0x1427F30", Offset="0x1427F30", VA="0x1427F30")]
			static <>c()
			{
			}

			[Address(RVA="0x1427F94", Offset="0x1427F94", VA="0x1427F94")]
			public <>c()
			{
			}

			[Address(RVA="0x1427F9C", Offset="0x1427F9C", VA="0x1427F9C")]
			internal bool <Glunies.IGameServiceTransport.Initialize>b__6_2()
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051008", Offset="0x1051008")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpGameServiceTransport <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<ResponseEnvelope> success;

			[FieldOffset(Offset="0x20")]
			public Action<long, ResponseEnvelope> failure;

			[Address(RVA="0x1427B30", Offset="0x1427B30", VA="0x1427B30")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x1427FA4", Offset="0x1427FA4", VA="0x1427FA4")]
			internal void <Glunies.IGameServiceTransport.Call>b__0(byte[] data)
			{
			}

			[Address(RVA="0x14281B8", Offset="0x14281B8", VA="0x14281B8")]
			internal void <Glunies.IGameServiceTransport.Call>b__1(long errorCode, byte[] data)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050FE8", Offset="0x1050FE8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpGameServiceTransport <>4__this;

			[FieldOffset(Offset="0x18")]
			public Serverproto.AuthType authType;

			[FieldOffset(Offset="0x20")]
			public Action<bool> completed;

			[Address(RVA="0x14279A8", Offset="0x14279A8", VA="0x14279A8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x1428344", Offset="0x1428344", VA="0x1428344")]
			internal void <Glunies.IGameServiceTransport.Initialize>b__0(AuthResponse response)
			{
			}

			[Address(RVA="0x1428400", Offset="0x1428400", VA="0x1428400")]
			internal void <Glunies.IGameServiceTransport.Initialize>b__1(long errorCode)
			{
			}
		}
	}
}