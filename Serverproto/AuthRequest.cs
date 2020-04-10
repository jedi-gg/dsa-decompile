using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AuthRequest : IMessage<AuthRequest>, IMessage, IEquatable<AuthRequest>, IDeepCloneable<AuthRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AuthRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AuthTypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.AuthType authType_;

		[FieldOffset(Offset="0x0")]
		public const int AuthIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string authId_;

		[FieldOffset(Offset="0x0")]
		public const int TimezoneFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string timezone_;

		[FieldOffset(Offset="0x0")]
		public const int UtcOffsetSecondsFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private int utcOffsetSeconds_;

		[FieldOffset(Offset="0x0")]
		public const int ClientAppVersionFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string clientAppVersion_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10916E0", Offset="0x10916E0")]
		public string AuthId
		{
			[Address(RVA="0x160D3AC", Offset="0x160D3AC", VA="0x160D3AC")]
			get
			{
				return null;
			}
			[Address(RVA="0x160D3B4", Offset="0x160D3B4", VA="0x160D3B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10916D0", Offset="0x10916D0")]
		public Serverproto.AuthType AuthType
		{
			[Address(RVA="0x160D39C", Offset="0x160D39C", VA="0x160D39C")]
			get
			{
				return new Serverproto.AuthType();
			}
			[Address(RVA="0x160D3A4", Offset="0x160D3A4", VA="0x160D3A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091710", Offset="0x1091710")]
		public string ClientAppVersion
		{
			[Address(RVA="0x160D4AC", Offset="0x160D4AC", VA="0x160D4AC")]
			get
			{
				return null;
			}
			[Address(RVA="0x160D4B4", Offset="0x160D4B4", VA="0x160D4B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10916B0", Offset="0x10916B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x160D0C8", Offset="0x160D0C8", VA="0x160D0C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10916A0", Offset="0x10916A0")]
		public static MessageParser<AuthRequest> Parser
		{
			[Address(RVA="0x160B114", Offset="0x160B114", VA="0x160B114")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10916C0", Offset="0x10916C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x160D1B4", Offset="0x160D1B4", VA="0x160D1B4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10916F0", Offset="0x10916F0")]
		public string Timezone
		{
			[Address(RVA="0x160D424", Offset="0x160D424", VA="0x160D424")]
			get
			{
				return null;
			}
			[Address(RVA="0x160D42C", Offset="0x160D42C", VA="0x160D42C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091700", Offset="0x1091700")]
		public int UtcOffsetSeconds
		{
			[Address(RVA="0x160D49C", Offset="0x160D49C", VA="0x160D49C")]
			get
			{
				return new int();
			}
			[Address(RVA="0x160D4A4", Offset="0x160D4A4", VA="0x160D4A4")]
			set
			{
			}
		}

		[Address(RVA="0x160DE38", Offset="0x160DE38", VA="0x160DE38")]
		static AuthRequest()
		{
		}

		[Address(RVA="0x160D210", Offset="0x160D210", VA="0x160D210")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107534C", Offset="0x107534C")]
		public AuthRequest()
		{
		}

		[Address(RVA="0x160D26C", Offset="0x160D26C", VA="0x160D26C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107535C", Offset="0x107535C")]
		public AuthRequest(AuthRequest other)
		{
		}

		[Address(RVA="0x160DA44", Offset="0x160DA44", VA="0x160DA44", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10753CC", Offset="0x10753CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160D33C", Offset="0x160D33C", VA="0x160D33C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107536C", Offset="0x107536C")]
		public AuthRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x160D524", Offset="0x160D524", VA="0x160D524", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107537C", Offset="0x107537C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160D598", Offset="0x160D598", VA="0x160D598", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107538C", Offset="0x107538C")]
		public bool Equals(AuthRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x160D644", Offset="0x160D644", VA="0x160D644", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107539C", Offset="0x107539C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x160DC20", Offset="0x160DC20", VA="0x160DC20", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10753DC", Offset="0x10753DC")]
		public void MergeFrom(AuthRequest other)
		{
		}

		[Address(RVA="0x160DCFC", Offset="0x160DCFC", VA="0x160DCFC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10753EC", Offset="0x10753EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160D794", Offset="0x160D794", VA="0x160D794", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10753AC", Offset="0x10753AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160D7FC", Offset="0x160D7FC", VA="0x160D7FC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10753BC", Offset="0x10753BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EE98", Offset="0x104EE98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AuthRequest.<>c <>9;

			[Address(RVA="0x160DF10", Offset="0x160DF10", VA="0x160DF10")]
			static <>c()
			{
			}

			[Address(RVA="0x160DF74", Offset="0x160DF74", VA="0x160DF74")]
			public <>c()
			{
			}

			[Address(RVA="0x160DF7C", Offset="0x160DF7C", VA="0x160DF7C")]
			internal AuthRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}