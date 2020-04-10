using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleBootstrapRequest : IMessage<BattleBootstrapRequest>, IMessage, IEquatable<BattleBootstrapRequest>, IDeepCloneable<BattleBootstrapRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleBootstrapRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string battleId_;

		[FieldOffset(Offset="0x0")]
		public const int BattleScriptFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ByteString battleScript_;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int GamedataVersionFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string gamedataVersion_;

		[FieldOffset(Offset="0x0")]
		public const int EndBattleAuthTokenFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string endBattleAuthToken_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTokensFieldNumber = 6;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleBootstrapRequestPlayer> _repeated_playerTokens_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<BattleBootstrapRequestPlayer> playerTokens_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10928B0", Offset="0x10928B0")]
		public string BattleId
		{
			[Address(RVA="0x1E6F86C", Offset="0x1E6F86C", VA="0x1E6F86C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6F874", Offset="0x1E6F874", VA="0x1E6F874")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10928C0", Offset="0x10928C0")]
		public ByteString BattleScript
		{
			[Address(RVA="0x1E6F8E4", Offset="0x1E6F8E4", VA="0x1E6F8E4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6F8EC", Offset="0x1E6F8EC", VA="0x1E6F8EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10928D0", Offset="0x10928D0")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1E6F95C", Offset="0x1E6F95C", VA="0x1E6F95C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6F964", Offset="0x1E6F964", VA="0x1E6F964")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092890", Offset="0x1092890")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E6F4D8", Offset="0x1E6F4D8", VA="0x1E6F4D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10928F0", Offset="0x10928F0")]
		public string EndBattleAuthToken
		{
			[Address(RVA="0x1E6FA4C", Offset="0x1E6FA4C", VA="0x1E6FA4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6FA54", Offset="0x1E6FA54", VA="0x1E6FA54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10928E0", Offset="0x10928E0")]
		public string GamedataVersion
		{
			[Address(RVA="0x1E6F9D4", Offset="0x1E6F9D4", VA="0x1E6F9D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E6F9DC", Offset="0x1E6F9DC", VA="0x1E6F9DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092880", Offset="0x1092880")]
		public static MessageParser<BattleBootstrapRequest> Parser
		{
			[Address(RVA="0x1E6F470", Offset="0x1E6F470", VA="0x1E6F470")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10928A0", Offset="0x10928A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E6F5C8", Offset="0x1E6F5C8", VA="0x1E6F5C8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092900", Offset="0x1092900")]
		public RepeatedField<BattleBootstrapRequestPlayer> PlayerTokens
		{
			[Address(RVA="0x1E6FAC4", Offset="0x1E6FAC4", VA="0x1E6FAC4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1E70788", Offset="0x1E70788", VA="0x1E70788")]
		static BattleBootstrapRequest()
		{
		}

		[Address(RVA="0x1E6F624", Offset="0x1E6F624", VA="0x1E6F624")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F7C", Offset="0x1076F7C")]
		public BattleBootstrapRequest()
		{
		}

		[Address(RVA="0x1E6F6E4", Offset="0x1E6F6E4", VA="0x1E6F6E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F8C", Offset="0x1076F8C")]
		public BattleBootstrapRequest(BattleBootstrapRequest other)
		{
		}

		[Address(RVA="0x1E701C8", Offset="0x1E701C8", VA="0x1E701C8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076FFC", Offset="0x1076FFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E6F80C", Offset="0x1E6F80C", VA="0x1E6F80C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076F9C", Offset="0x1076F9C")]
		public BattleBootstrapRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1E6FACC", Offset="0x1E6FACC", VA="0x1E6FACC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076FAC", Offset="0x1076FAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E6FB40", Offset="0x1E6FB40", VA="0x1E6FB40", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076FBC", Offset="0x1076FBC")]
		public bool Equals(BattleBootstrapRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1E6FCA8", Offset="0x1E6FCA8", VA="0x1E6FCA8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076FCC", Offset="0x1076FCC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E70440", Offset="0x1E70440", VA="0x1E70440", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107700C", Offset="0x107700C")]
		public void MergeFrom(BattleBootstrapRequest other)
		{
		}

		[Address(RVA="0x1E705AC", Offset="0x1E705AC", VA="0x1E705AC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107701C", Offset="0x107701C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E6FE6C", Offset="0x1E6FE6C", VA="0x1E6FE6C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076FDC", Offset="0x1076FDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E6FED4", Offset="0x1E6FED4", VA="0x1E6FED4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076FEC", Offset="0x1076FEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F128", Offset="0x104F128")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleBootstrapRequest.<>c <>9;

			[Address(RVA="0x1E70910", Offset="0x1E70910", VA="0x1E70910")]
			static <>c()
			{
			}

			[Address(RVA="0x1E70974", Offset="0x1E70974", VA="0x1E70974")]
			public <>c()
			{
			}

			[Address(RVA="0x1E7097C", Offset="0x1E7097C", VA="0x1E7097C")]
			internal BattleBootstrapRequest <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}