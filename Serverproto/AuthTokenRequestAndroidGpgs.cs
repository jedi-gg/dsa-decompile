using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AuthTokenRequestAndroidGpgs : IMessage<AuthTokenRequestAndroidGpgs>, IMessage, IEquatable<AuthTokenRequestAndroidGpgs>, IDeepCloneable<AuthTokenRequestAndroidGpgs>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AuthTokenRequestAndroidGpgs> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[FieldOffset(Offset="0x0")]
		public const int AuthCodeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string authCode_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10917D0", Offset="0x10917D0")]
		public string AuthCode
		{
			[Address(RVA="0x1610918", Offset="0x1610918", VA="0x1610918")]
			get
			{
				return null;
			}
			[Address(RVA="0x1610920", Offset="0x1610920", VA="0x1610920")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10917A0", Offset="0x10917A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x16106DC", Offset="0x16106DC", VA="0x16106DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091790", Offset="0x1091790")]
		public static MessageParser<AuthTokenRequestAndroidGpgs> Parser
		{
			[Address(RVA="0x160B1E4", Offset="0x160B1E4", VA="0x160B1E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10917B0", Offset="0x10917B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x16107C8", Offset="0x16107C8", VA="0x16107C8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10917C0", Offset="0x10917C0")]
		public string PlayerId
		{
			[Address(RVA="0x16108A0", Offset="0x16108A0", VA="0x16108A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x16108A8", Offset="0x16108A8", VA="0x16108A8")]
			set
			{
			}
		}

		[Address(RVA="0x1610EA4", Offset="0x1610EA4", VA="0x1610EA4")]
		static AuthTokenRequestAndroidGpgs()
		{
		}

		[Address(RVA="0x1610038", Offset="0x1610038", VA="0x1610038")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10754AC", Offset="0x10754AC")]
		public AuthTokenRequestAndroidGpgs()
		{
		}

		[Address(RVA="0x1610824", Offset="0x1610824", VA="0x1610824")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10754BC", Offset="0x10754BC")]
		public AuthTokenRequestAndroidGpgs(AuthTokenRequestAndroidGpgs other)
		{
		}

		[Address(RVA="0x1610CDC", Offset="0x1610CDC", VA="0x1610CDC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107552C", Offset="0x107552C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160EFE4", Offset="0x160EFE4", VA="0x160EFE4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10754CC", Offset="0x10754CC")]
		public AuthTokenRequestAndroidGpgs Clone()
		{
			return null;
		}

		[Address(RVA="0x1610990", Offset="0x1610990", VA="0x1610990", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10754DC", Offset="0x10754DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1610A04", Offset="0x1610A04", VA="0x1610A04", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10754EC", Offset="0x10754EC")]
		public bool Equals(AuthTokenRequestAndroidGpgs other)
		{
			return new bool();
		}

		[Address(RVA="0x1610A7C", Offset="0x1610A7C", VA="0x1610A7C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10754FC", Offset="0x10754FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1610090", Offset="0x1610090", VA="0x1610090", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107553C", Offset="0x107553C")]
		public void MergeFrom(AuthTokenRequestAndroidGpgs other)
		{
		}

		[Address(RVA="0x1610DF0", Offset="0x1610DF0", VA="0x1610DF0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107554C", Offset="0x107554C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1610B4C", Offset="0x1610B4C", VA="0x1610B4C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107550C", Offset="0x107550C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1610BB4", Offset="0x1610BB4", VA="0x1610BB4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107551C", Offset="0x107551C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EEB8", Offset="0x104EEB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AuthTokenRequestAndroidGpgs.<>c <>9;

			[Address(RVA="0x1610F7C", Offset="0x1610F7C", VA="0x1610F7C")]
			static <>c()
			{
			}

			[Address(RVA="0x1610FE0", Offset="0x1610FE0", VA="0x1610FE0")]
			public <>c()
			{
			}

			[Address(RVA="0x1610FE8", Offset="0x1610FE8", VA="0x1610FE8")]
			internal AuthTokenRequestAndroidGpgs <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}