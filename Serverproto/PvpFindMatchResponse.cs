using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpFindMatchResponse : IMessage<PvpFindMatchResponse>, IMessage, IEquatable<PvpFindMatchResponse>, IDeepCloneable<PvpFindMatchResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpFindMatchResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTokenFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerToken_;

		[FieldOffset(Offset="0x0")]
		public const int OpponentFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Player opponent_;

		[FieldOffset(Offset="0x0")]
		public const int BattleServerFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string battleServer_;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string battleId_;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerBattleIdFieldNumber = 8;

		[FieldOffset(Offset="0x40")]
		private ulong playerBattleId_;

		[FieldOffset(Offset="0x0")]
		public const int ResultFieldNumber = 9;

		[FieldOffset(Offset="0x48")]
		private MatchMakerResult result_;

		[FieldOffset(Offset="0x0")]
		public const int MatchIdFieldNumber = 10;

		[FieldOffset(Offset="0x50")]
		private string matchId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092048", Offset="0x1092048")]
		public string BattleId
		{
			[Address(RVA="0x2017354", Offset="0x2017354", VA="0x2017354")]
			get
			{
				return null;
			}
			[Address(RVA="0x201735C", Offset="0x201735C", VA="0x201735C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092038", Offset="0x1092038")]
		public string BattleServer
		{
			[Address(RVA="0x20172DC", Offset="0x20172DC", VA="0x20172DC")]
			get
			{
				return null;
			}
			[Address(RVA="0x20172E4", Offset="0x20172E4", VA="0x20172E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092058", Offset="0x1092058")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x20173CC", Offset="0x20173CC", VA="0x20173CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x20173D4", Offset="0x20173D4", VA="0x20173D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091FF8", Offset="0x1091FF8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2016F74", Offset="0x2016F74", VA="0x2016F74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092088", Offset="0x1092088")]
		public string MatchId
		{
			[Address(RVA="0x2017464", Offset="0x2017464", VA="0x2017464")]
			get
			{
				return null;
			}
			[Address(RVA="0x201746C", Offset="0x201746C", VA="0x201746C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092028", Offset="0x1092028")]
		public Player Opponent
		{
			[Address(RVA="0x20171F4", Offset="0x20171F4", VA="0x20171F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x20171FC", Offset="0x20171FC", VA="0x20171FC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091FE8", Offset="0x1091FE8")]
		public static MessageParser<PvpFindMatchResponse> Parser
		{
			[Address(RVA="0x2016F0C", Offset="0x2016F0C", VA="0x2016F0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092008", Offset="0x1092008")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2017064", Offset="0x2017064", VA="0x2017064", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092068", Offset="0x1092068")]
		public ulong PlayerBattleId
		{
			[Address(RVA="0x2017444", Offset="0x2017444", VA="0x2017444")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201744C", Offset="0x201744C", VA="0x201744C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092018", Offset="0x1092018")]
		public string PlayerToken
		{
			[Address(RVA="0x2017264", Offset="0x2017264", VA="0x2017264")]
			get
			{
				return null;
			}
			[Address(RVA="0x201726C", Offset="0x201726C", VA="0x201726C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092078", Offset="0x1092078")]
		public MatchMakerResult Result
		{
			[Address(RVA="0x2017454", Offset="0x2017454", VA="0x2017454")]
			get
			{
				return new MatchMakerResult();
			}
			[Address(RVA="0x201745C", Offset="0x201745C", VA="0x201745C")]
			set
			{
			}
		}

		[Address(RVA="0x201831C", Offset="0x201831C", VA="0x201831C")]
		static PvpFindMatchResponse()
		{
		}

		[Address(RVA="0x20170C0", Offset="0x20170C0", VA="0x20170C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107626C", Offset="0x107626C")]
		public PvpFindMatchResponse()
		{
		}

		[Address(RVA="0x2017150", Offset="0x2017150", VA="0x2017150")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107627C", Offset="0x107627C")]
		public PvpFindMatchResponse(PvpFindMatchResponse other)
		{
		}

		[Address(RVA="0x2017C70", Offset="0x2017C70", VA="0x2017C70", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10762EC", Offset="0x10762EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2017204", Offset="0x2017204", VA="0x2017204", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107628C", Offset="0x107628C")]
		public PvpFindMatchResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x20174DC", Offset="0x20174DC", VA="0x20174DC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107629C", Offset="0x107629C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2017550", Offset="0x2017550", VA="0x2017550", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10762AC", Offset="0x10762AC")]
		public bool Equals(PvpFindMatchResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2017690", Offset="0x2017690", VA="0x2017690", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10762BC", Offset="0x10762BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2017F40", Offset="0x2017F40", VA="0x2017F40", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10762FC", Offset="0x10762FC")]
		public void MergeFrom(PvpFindMatchResponse other)
		{
		}

		[Address(RVA="0x20180E8", Offset="0x20180E8", VA="0x20180E8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107630C", Offset="0x107630C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2017888", Offset="0x2017888", VA="0x2017888", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10762CC", Offset="0x10762CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x20178F0", Offset="0x20178F0", VA="0x20178F0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10762DC", Offset="0x10762DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EFF8", Offset="0x104EFF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpFindMatchResponse.<>c <>9;

			[Address(RVA="0x20183F4", Offset="0x20183F4", VA="0x20183F4")]
			static <>c()
			{
			}

			[Address(RVA="0x2018458", Offset="0x2018458", VA="0x2018458")]
			public <>c()
			{
			}

			[Address(RVA="0x2018460", Offset="0x2018460", VA="0x2018460")]
			internal PvpFindMatchResponse <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}