using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleStartResponse : IMessage<KothBattleStartResponse>, IMessage, IEquatable<KothBattleStartResponse>, IDeepCloneable<KothBattleStartResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleStartResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong playerId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTokenFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string playerToken_;

		[FieldOffset(Offset="0x0")]
		public const int OpponentFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private Player opponent_;

		[FieldOffset(Offset="0x0")]
		public const int BattleServerFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string battleServer_;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string battleId_;

		[FieldOffset(Offset="0x0")]
		public const int ResultFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private MatchMakerResult result_;

		[FieldOffset(Offset="0x0")]
		public const int MatchIdFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private string matchId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093360", Offset="0x1093360")]
		public string BattleId
		{
			[Address(RVA="0x1A9CB64", Offset="0x1A9CB64", VA="0x1A9CB64")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9CB6C", Offset="0x1A9CB6C", VA="0x1A9CB6C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093350", Offset="0x1093350")]
		public string BattleServer
		{
			[Address(RVA="0x1A9CAEC", Offset="0x1A9CAEC", VA="0x1A9CAEC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9CAF4", Offset="0x1A9CAF4", VA="0x1A9CAF4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093310", Offset="0x1093310")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1A9C9EC", Offset="0x1A9C9EC", VA="0x1A9C9EC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9C9F4", Offset="0x1A9C9F4", VA="0x1A9C9F4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10932F0", Offset="0x10932F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9C6D8", Offset="0x1A9C6D8", VA="0x1A9C6D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093380", Offset="0x1093380")]
		public string MatchId
		{
			[Address(RVA="0x1A9CBEC", Offset="0x1A9CBEC", VA="0x1A9CBEC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9CBF4", Offset="0x1A9CBF4", VA="0x1A9CBF4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093340", Offset="0x1093340")]
		public Player Opponent
		{
			[Address(RVA="0x1A9C97C", Offset="0x1A9C97C", VA="0x1A9C97C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9C984", Offset="0x1A9C984", VA="0x1A9C984")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10932E0", Offset="0x10932E0")]
		public static MessageParser<KothBattleStartResponse> Parser
		{
			[Address(RVA="0x1A9C670", Offset="0x1A9C670", VA="0x1A9C670")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093300", Offset="0x1093300")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9C7C8", Offset="0x1A9C7C8", VA="0x1A9C7C8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093320", Offset="0x1093320")]
		public ulong PlayerId
		{
			[Address(RVA="0x1A9CA64", Offset="0x1A9CA64", VA="0x1A9CA64")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9CA6C", Offset="0x1A9CA6C", VA="0x1A9CA6C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093330", Offset="0x1093330")]
		public string PlayerToken
		{
			[Address(RVA="0x1A9CA74", Offset="0x1A9CA74", VA="0x1A9CA74")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9CA7C", Offset="0x1A9CA7C", VA="0x1A9CA7C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093370", Offset="0x1093370")]
		public MatchMakerResult Result
		{
			[Address(RVA="0x1A9CBDC", Offset="0x1A9CBDC", VA="0x1A9CBDC")]
			get
			{
				return new MatchMakerResult();
			}
			[Address(RVA="0x1A9CBE4", Offset="0x1A9CBE4", VA="0x1A9CBE4")]
			set
			{
			}
		}

		[Address(RVA="0x1A9DAA4", Offset="0x1A9DAA4", VA="0x1A9DAA4")]
		static KothBattleStartResponse()
		{
		}

		[Address(RVA="0x1A9C824", Offset="0x1A9C824", VA="0x1A9C824")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10784CC", Offset="0x10784CC")]
		public KothBattleStartResponse()
		{
		}

		[Address(RVA="0x1A9C8B0", Offset="0x1A9C8B0", VA="0x1A9C8B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10784DC", Offset="0x10784DC")]
		public KothBattleStartResponse(KothBattleStartResponse other)
		{
		}

		[Address(RVA="0x1A9D3F8", Offset="0x1A9D3F8", VA="0x1A9D3F8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107854C", Offset="0x107854C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9C98C", Offset="0x1A9C98C", VA="0x1A9C98C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10784EC", Offset="0x10784EC")]
		public KothBattleStartResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9CC64", Offset="0x1A9CC64", VA="0x1A9CC64", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10784FC", Offset="0x10784FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9CCD8", Offset="0x1A9CCD8", VA="0x1A9CCD8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107850C", Offset="0x107850C")]
		public bool Equals(KothBattleStartResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9CE18", Offset="0x1A9CE18", VA="0x1A9CE18", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107851C", Offset="0x107851C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A9D6C8", Offset="0x1A9D6C8", VA="0x1A9D6C8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107855C", Offset="0x107855C")]
		public void MergeFrom(KothBattleStartResponse other)
		{
		}

		[Address(RVA="0x1A9D870", Offset="0x1A9D870", VA="0x1A9D870", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107856C", Offset="0x107856C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9D010", Offset="0x1A9D010", VA="0x1A9D010", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107852C", Offset="0x107852C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9D078", Offset="0x1A9D078", VA="0x1A9D078", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107853C", Offset="0x107853C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F318", Offset="0x104F318")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleStartResponse.<>c <>9;

			[Address(RVA="0x1A9DB7C", Offset="0x1A9DB7C", VA="0x1A9DB7C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9DBE0", Offset="0x1A9DBE0", VA="0x1A9DBE0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9DBE8", Offset="0x1A9DBE8", VA="0x1A9DBE8")]
			internal KothBattleStartResponse <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}