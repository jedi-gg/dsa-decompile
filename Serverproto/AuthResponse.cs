using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AuthResponse : IMessage<AuthResponse>, IMessage, IEquatable<AuthResponse>, IDeepCloneable<AuthResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AuthResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AuthTokenFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string authToken_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.Player player_;

		[FieldOffset(Offset="0x0")]
		public const int AccountIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string accountId_;

		[FieldOffset(Offset="0x0")]
		public const int SyncTimeFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong syncTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091770", Offset="0x1091770")]
		public string AccountId
		{
			[Address(RVA="0x160E2E4", Offset="0x160E2E4", VA="0x160E2E4")]
			get
			{
				return null;
			}
			[Address(RVA="0x160E2EC", Offset="0x160E2EC", VA="0x160E2EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091750", Offset="0x1091750")]
		public string AuthToken
		{
			[Address(RVA="0x160E26C", Offset="0x160E26C", VA="0x160E26C")]
			get
			{
				return null;
			}
			[Address(RVA="0x160E274", Offset="0x160E274", VA="0x160E274")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091730", Offset="0x1091730")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x160DFD4", Offset="0x160DFD4", VA="0x160DFD4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091720", Offset="0x1091720")]
		public static MessageParser<AuthResponse> Parser
		{
			[Address(RVA="0x160B17C", Offset="0x160B17C", VA="0x160B17C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091740", Offset="0x1091740")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x160E0C0", Offset="0x160E0C0", VA="0x160E0C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091760", Offset="0x1091760")]
		public Serverproto.Player Player
		{
			[Address(RVA="0x160E1FC", Offset="0x160E1FC", VA="0x160E1FC")]
			get
			{
				return null;
			}
			[Address(RVA="0x160E204", Offset="0x160E204", VA="0x160E204")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091780", Offset="0x1091780")]
		public ulong SyncTime
		{
			[Address(RVA="0x160E35C", Offset="0x160E35C", VA="0x160E35C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x160E364", Offset="0x160E364", VA="0x160E364")]
			set
			{
			}
		}

		[Address(RVA="0x160EBD4", Offset="0x160EBD4", VA="0x160EBD4")]
		static AuthResponse()
		{
		}

		[Address(RVA="0x160E11C", Offset="0x160E11C", VA="0x160E11C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10753FC", Offset="0x10753FC")]
		public AuthResponse()
		{
		}

		[Address(RVA="0x160E178", Offset="0x160E178", VA="0x160E178")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107540C", Offset="0x107540C")]
		public AuthResponse(AuthResponse other)
		{
		}

		[Address(RVA="0x160E7C4", Offset="0x160E7C4", VA="0x160E7C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107547C", Offset="0x107547C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160E20C", Offset="0x160E20C", VA="0x160E20C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107541C", Offset="0x107541C")]
		public AuthResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x160E36C", Offset="0x160E36C", VA="0x160E36C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107542C", Offset="0x107542C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x160E3E0", Offset="0x160E3E0", VA="0x160E3E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107543C", Offset="0x107543C")]
		public bool Equals(AuthResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x160E47C", Offset="0x160E47C", VA="0x160E47C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107544C", Offset="0x107544C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x160E950", Offset="0x160E950", VA="0x160E950", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107548C", Offset="0x107548C")]
		public void MergeFrom(AuthResponse other)
		{
		}

		[Address(RVA="0x160EA68", Offset="0x160EA68", VA="0x160EA68", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107549C", Offset="0x107549C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x160E584", Offset="0x160E584", VA="0x160E584", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107545C", Offset="0x107545C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160E5EC", Offset="0x160E5EC", VA="0x160E5EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107546C", Offset="0x107546C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EEA8", Offset="0x104EEA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AuthResponse.<>c <>9;

			[Address(RVA="0x160ECAC", Offset="0x160ECAC", VA="0x160ECAC")]
			static <>c()
			{
			}

			[Address(RVA="0x160ED10", Offset="0x160ED10", VA="0x160ED10")]
			public <>c()
			{
			}

			[Address(RVA="0x160ED18", Offset="0x160ED18", VA="0x160ED18")]
			internal AuthResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}