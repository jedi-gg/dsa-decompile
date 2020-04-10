using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarBattleStartResponse : IMessage<ClubWarBattleStartResponse>, IMessage, IEquatable<ClubWarBattleStartResponse>, IDeepCloneable<ClubWarBattleStartResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarBattleStartResponse> _parser;

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

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093530", Offset="0x1093530")]
		public string BattleId
		{
			[Address(RVA="0x1B1CC24", Offset="0x1B1CC24", VA="0x1B1CC24")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1CC2C", Offset="0x1B1CC2C", VA="0x1B1CC2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093520", Offset="0x1093520")]
		public string BattleServer
		{
			[Address(RVA="0x1B1CBAC", Offset="0x1B1CBAC", VA="0x1B1CBAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1CBB4", Offset="0x1B1CBB4", VA="0x1B1CBB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10934E0", Offset="0x10934E0")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x1B1CAAC", Offset="0x1B1CAAC", VA="0x1B1CAAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1CAB4", Offset="0x1B1CAB4", VA="0x1B1CAB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10934C0", Offset="0x10934C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1C798", Offset="0x1B1C798", VA="0x1B1C798")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093550", Offset="0x1093550")]
		public string MatchId
		{
			[Address(RVA="0x1B1CCAC", Offset="0x1B1CCAC", VA="0x1B1CCAC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1CCB4", Offset="0x1B1CCB4", VA="0x1B1CCB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093510", Offset="0x1093510")]
		public Player Opponent
		{
			[Address(RVA="0x1B1CA3C", Offset="0x1B1CA3C", VA="0x1B1CA3C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1CA44", Offset="0x1B1CA44", VA="0x1B1CA44")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10934B0", Offset="0x10934B0")]
		public static MessageParser<ClubWarBattleStartResponse> Parser
		{
			[Address(RVA="0x1B1C730", Offset="0x1B1C730", VA="0x1B1C730")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10934D0", Offset="0x10934D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1C888", Offset="0x1B1C888", VA="0x1B1C888", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10934F0", Offset="0x10934F0")]
		public ulong PlayerId
		{
			[Address(RVA="0x1B1CB24", Offset="0x1B1CB24", VA="0x1B1CB24")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B1CB2C", Offset="0x1B1CB2C", VA="0x1B1CB2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093500", Offset="0x1093500")]
		public string PlayerToken
		{
			[Address(RVA="0x1B1CB34", Offset="0x1B1CB34", VA="0x1B1CB34")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1CB3C", Offset="0x1B1CB3C", VA="0x1B1CB3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093540", Offset="0x1093540")]
		public MatchMakerResult Result
		{
			[Address(RVA="0x1B1CC9C", Offset="0x1B1CC9C", VA="0x1B1CC9C")]
			get
			{
				return new MatchMakerResult();
			}
			[Address(RVA="0x1B1CCA4", Offset="0x1B1CCA4", VA="0x1B1CCA4")]
			set
			{
			}
		}

		[Address(RVA="0x1B1DB64", Offset="0x1B1DB64", VA="0x1B1DB64")]
		static ClubWarBattleStartResponse()
		{
		}

		[Address(RVA="0x1B1C8E4", Offset="0x1B1C8E4", VA="0x1B1C8E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107878C", Offset="0x107878C")]
		public ClubWarBattleStartResponse()
		{
		}

		[Address(RVA="0x1B1C970", Offset="0x1B1C970", VA="0x1B1C970")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107879C", Offset="0x107879C")]
		public ClubWarBattleStartResponse(ClubWarBattleStartResponse other)
		{
		}

		[Address(RVA="0x1B1D4B8", Offset="0x1B1D4B8", VA="0x1B1D4B8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107880C", Offset="0x107880C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1CA4C", Offset="0x1B1CA4C", VA="0x1B1CA4C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10787AC", Offset="0x10787AC")]
		public ClubWarBattleStartResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1CD24", Offset="0x1B1CD24", VA="0x1B1CD24", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10787BC", Offset="0x10787BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1CD98", Offset="0x1B1CD98", VA="0x1B1CD98", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10787CC", Offset="0x10787CC")]
		public bool Equals(ClubWarBattleStartResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1CED8", Offset="0x1B1CED8", VA="0x1B1CED8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10787DC", Offset="0x10787DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1D788", Offset="0x1B1D788", VA="0x1B1D788", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107881C", Offset="0x107881C")]
		public void MergeFrom(ClubWarBattleStartResponse other)
		{
		}

		[Address(RVA="0x1B1D930", Offset="0x1B1D930", VA="0x1B1D930", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107882C", Offset="0x107882C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1D0D0", Offset="0x1B1D0D0", VA="0x1B1D0D0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10787EC", Offset="0x10787EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1D138", Offset="0x1B1D138", VA="0x1B1D138", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10787FC", Offset="0x10787FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F358", Offset="0x104F358")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarBattleStartResponse.<>c <>9;

			[Address(RVA="0x1B1DC3C", Offset="0x1B1DC3C", VA="0x1B1DC3C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1DCA0", Offset="0x1B1DCA0", VA="0x1B1DCA0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1DCA8", Offset="0x1B1DCA8", VA="0x1B1DCA8")]
			internal ClubWarBattleStartResponse <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}