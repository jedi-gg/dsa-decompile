using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CoopFindMatchRequest : IMessage<CoopFindMatchRequest>, IMessage, IEquatable<CoopFindMatchRequest>, IDeepCloneable<CoopFindMatchRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CoopFindMatchRequest> _parser;

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
		public const int EventIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private EventIdentifier eventId_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092128", Offset="0x1092128")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1092128", Offset="0x1092128")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1EEF9F8", Offset="0x1EEF9F8", VA="0x1EEF9F8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EEFA00", Offset="0x1EEFA00", VA="0x1EEFA00")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092108", Offset="0x1092108")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EEF704", Offset="0x1EEF704", VA="0x1EEF704")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092190", Offset="0x1092190")]
		public EventIdentifier EventId
		{
			[Address(RVA="0x1EEFA18", Offset="0x1EEFA18", VA="0x1EEFA18")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EEFA20", Offset="0x1EEFA20", VA="0x1EEFA20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10921A0", Offset="0x10921A0")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1EEFA98", Offset="0x1EEFA98", VA="0x1EEFA98")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EEFAA0", Offset="0x1EEFAA0", VA="0x1EEFAA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10920F8", Offset="0x10920F8")]
		public static MessageParser<CoopFindMatchRequest> Parser
		{
			[Address(RVA="0x1EEF69C", Offset="0x1EEF69C", VA="0x1EEF69C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092118", Offset="0x1092118")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EEF7F4", Offset="0x1EEF7F4", VA="0x1EEF7F4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092170", Offset="0x1092170")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1EEFA90", Offset="0x1EEFA90", VA="0x1EEFA90")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092180", Offset="0x1092180")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x1EEFA08", Offset="0x1EEFA08", VA="0x1EEFA08")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EEFA10", Offset="0x1EEFA10", VA="0x1EEFA10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092160", Offset="0x1092160")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1EEFA88", Offset="0x1EEFA88", VA="0x1EEFA88")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF05F0", Offset="0x1EF05F0", VA="0x1EF05F0")]
		static CoopFindMatchRequest()
		{
		}

		[Address(RVA="0x1EEF850", Offset="0x1EEF850", VA="0x1EEF850")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107647C", Offset="0x107647C")]
		public CoopFindMatchRequest()
		{
		}

		[Address(RVA="0x1EEF8E0", Offset="0x1EEF8E0", VA="0x1EEF8E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107648C", Offset="0x107648C")]
		public CoopFindMatchRequest(CoopFindMatchRequest other)
		{
		}

		[Address(RVA="0x1EF0010", Offset="0x1EF0010", VA="0x1EF0010", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10764FC", Offset="0x10764FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EEFA28", Offset="0x1EEFA28", VA="0x1EEFA28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107649C", Offset="0x107649C")]
		public CoopFindMatchRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EEFAA8", Offset="0x1EEFAA8", VA="0x1EEFAA8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10764AC", Offset="0x10764AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EEFB1C", Offset="0x1EEFB1C", VA="0x1EEFB1C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10764BC", Offset="0x10764BC")]
		public bool Equals(CoopFindMatchRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EEFC4C", Offset="0x1EEFC4C", VA="0x1EEFC4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10764CC", Offset="0x10764CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF01F4", Offset="0x1EF01F4", VA="0x1EF01F4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107650C", Offset="0x107650C")]
		public void MergeFrom(CoopFindMatchRequest other)
		{
		}

		[Address(RVA="0x1EF03AC", Offset="0x1EF03AC", VA="0x1EF03AC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107651C", Offset="0x107651C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EEFD48", Offset="0x1EEFD48", VA="0x1EEFD48", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10764DC", Offset="0x10764DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EEFDB0", Offset="0x1EEFDB0", VA="0x1EEFDB0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10764EC", Offset="0x10764EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F028", Offset="0x104F028")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CoopFindMatchRequest.<>c <>9;

			[Address(RVA="0x1EF06F8", Offset="0x1EF06F8", VA="0x1EF06F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF075C", Offset="0x1EF075C", VA="0x1EF075C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF0764", Offset="0x1EF0764", VA="0x1EF0764")]
			internal CoopFindMatchRequest <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}