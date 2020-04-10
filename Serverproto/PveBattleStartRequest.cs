using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PveBattleStartRequest : IMessage<PveBattleStartRequest>, IMessage, IEquatable<PveBattleStartRequest>, IDeepCloneable<PveBattleStartRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PveBattleStartRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSaveFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private BattleSquadSaveInfo squadSave_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E18", Offset="0x1091E18")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x2014810", Offset="0x2014810", VA="0x2014810")]
			get
			{
				return null;
			}
			[Address(RVA="0x2014818", Offset="0x2014818", VA="0x2014818")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091DF8", Offset="0x1091DF8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2014530", Offset="0x2014530", VA="0x2014530")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E58", Offset="0x1091E58")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x20148A0", Offset="0x20148A0", VA="0x20148A0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x20148A8", Offset="0x20148A8", VA="0x20148A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091DE8", Offset="0x1091DE8")]
		public static MessageParser<PveBattleStartRequest> Parser
		{
			[Address(RVA="0x20144C8", Offset="0x20144C8", VA="0x20144C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E08", Offset="0x1091E08")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2014620", Offset="0x2014620", VA="0x2014620", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E38", Offset="0x1091E38")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x2014898", Offset="0x2014898", VA="0x2014898")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E48", Offset="0x1091E48")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x2014820", Offset="0x2014820", VA="0x2014820")]
			get
			{
				return null;
			}
			[Address(RVA="0x2014828", Offset="0x2014828", VA="0x2014828")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E28", Offset="0x1091E28")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x2014890", Offset="0x2014890", VA="0x2014890")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x20152A0", Offset="0x20152A0", VA="0x20152A0")]
		static PveBattleStartRequest()
		{
		}

		[Address(RVA="0x201467C", Offset="0x201467C", VA="0x201467C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075EFC", Offset="0x1075EFC")]
		public PveBattleStartRequest()
		{
		}

		[Address(RVA="0x201470C", Offset="0x201470C", VA="0x201470C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F0C", Offset="0x1075F0C")]
		public PveBattleStartRequest(PveBattleStartRequest other)
		{
		}

		[Address(RVA="0x2014D94", Offset="0x2014D94", VA="0x2014D94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F7C", Offset="0x1075F7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2014830", Offset="0x2014830", VA="0x2014830", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F1C", Offset="0x1075F1C")]
		public PveBattleStartRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x20148B0", Offset="0x20148B0", VA="0x20148B0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F2C", Offset="0x1075F2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2014924", Offset="0x2014924", VA="0x2014924", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F3C", Offset="0x1075F3C")]
		public bool Equals(PveBattleStartRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2014A40", Offset="0x2014A40", VA="0x2014A40", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F4C", Offset="0x1075F4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2014F3C", Offset="0x2014F3C", VA="0x2014F3C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F8C", Offset="0x1075F8C")]
		public void MergeFrom(PveBattleStartRequest other)
		{
		}

		[Address(RVA="0x20150A4", Offset="0x20150A4", VA="0x20150A4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F9C", Offset="0x1075F9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2014B24", Offset="0x2014B24", VA="0x2014B24", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F5C", Offset="0x1075F5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2014B8C", Offset="0x2014B8C", VA="0x2014B8C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075F6C", Offset="0x1075F6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EFA8", Offset="0x104EFA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PveBattleStartRequest.<>c <>9;

			[Address(RVA="0x20153A8", Offset="0x20153A8", VA="0x20153A8")]
			static <>c()
			{
			}

			[Address(RVA="0x201540C", Offset="0x201540C", VA="0x201540C")]
			public <>c()
			{
			}

			[Address(RVA="0x2015414", Offset="0x2015414", VA="0x2015414")]
			internal PveBattleStartRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}