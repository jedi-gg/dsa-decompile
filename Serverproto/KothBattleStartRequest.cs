using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleStartRequest : IMessage<KothBattleStartRequest>, IMessage, IEquatable<KothBattleStartRequest>, IDeepCloneable<KothBattleStartRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleStartRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int OpponentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string opponentId_;

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
		public const int OpponentRankFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong opponentRank_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong leaderUnit_;

		[FieldOffset(Offset="0x0")]
		public const int OpponentSquadUnitsFieldNumber = 7;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ulong> _repeated_opponentSquadUnits_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<ulong> opponentSquadUnits_;

		[FieldOffset(Offset="0x0")]
		public const int OpponentSquadSpellsFieldNumber = 8;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<ulong> _repeated_opponentSquadSpells_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<ulong> opponentSquadSpells_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093240", Offset="0x1093240")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9B264", Offset="0x1A9B264", VA="0x1A9B264")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10932B0", Offset="0x10932B0")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1A9B6C4", Offset="0x1A9B6C4", VA="0x1A9B6C4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9B6CC", Offset="0x1A9B6CC", VA="0x1A9B6CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093260", Offset="0x1093260")]
		public string OpponentId
		{
			[Address(RVA="0x1A9B62C", Offset="0x1A9B62C", VA="0x1A9B62C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9B634", Offset="0x1A9B634", VA="0x1A9B634")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10932A0", Offset="0x10932A0")]
		public ulong OpponentRank
		{
			[Address(RVA="0x1A9B6B4", Offset="0x1A9B6B4", VA="0x1A9B6B4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9B6BC", Offset="0x1A9B6BC", VA="0x1A9B6BC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10932D0", Offset="0x10932D0")]
		public RepeatedField<ulong> OpponentSquadSpells
		{
			[Address(RVA="0x1A9B6DC", Offset="0x1A9B6DC", VA="0x1A9B6DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10932C0", Offset="0x10932C0")]
		public RepeatedField<ulong> OpponentSquadUnits
		{
			[Address(RVA="0x1A9B6D4", Offset="0x1A9B6D4", VA="0x1A9B6D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093230", Offset="0x1093230")]
		public static MessageParser<KothBattleStartRequest> Parser
		{
			[Address(RVA="0x1A9B1FC", Offset="0x1A9B1FC", VA="0x1A9B1FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093250", Offset="0x1093250")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9B354", Offset="0x1A9B354", VA="0x1A9B354", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093280", Offset="0x1093280")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1A9B6AC", Offset="0x1A9B6AC", VA="0x1A9B6AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093290", Offset="0x1093290")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x1A9B5BC", Offset="0x1A9B5BC", VA="0x1A9B5BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9B5C4", Offset="0x1A9B5C4", VA="0x1A9B5C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093270", Offset="0x1093270")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1A9B6A4", Offset="0x1A9B6A4", VA="0x1A9B6A4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A9C474", Offset="0x1A9C474", VA="0x1A9C474")]
		static KothBattleStartRequest()
		{
		}

		[Address(RVA="0x1A9B3B0", Offset="0x1A9B3B0", VA="0x1A9B3B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107841C", Offset="0x107841C")]
		public KothBattleStartRequest()
		{
		}

		[Address(RVA="0x1A9B480", Offset="0x1A9B480", VA="0x1A9B480")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107842C", Offset="0x107842C")]
		public KothBattleStartRequest(KothBattleStartRequest other)
		{
		}

		[Address(RVA="0x1A9BDA4", Offset="0x1A9BDA4", VA="0x1A9BDA4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107849C", Offset="0x107849C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9B5CC", Offset="0x1A9B5CC", VA="0x1A9B5CC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107843C", Offset="0x107843C")]
		public KothBattleStartRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9B6E4", Offset="0x1A9B6E4", VA="0x1A9B6E4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107844C", Offset="0x107844C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9B758", Offset="0x1A9B758", VA="0x1A9B758", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107845C", Offset="0x107845C")]
		public bool Equals(KothBattleStartRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9B8D4", Offset="0x1A9B8D4", VA="0x1A9B8D4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107846C", Offset="0x107846C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A9C020", Offset="0x1A9C020", VA="0x1A9C020", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10784AC", Offset="0x10784AC")]
		public void MergeFrom(KothBattleStartRequest other)
		{
		}

		[Address(RVA="0x1A9C1B8", Offset="0x1A9C1B8", VA="0x1A9C1B8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10784BC", Offset="0x10784BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9BA4C", Offset="0x1A9BA4C", VA="0x1A9BA4C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107847C", Offset="0x107847C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9BAB4", Offset="0x1A9BAB4", VA="0x1A9BAB4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107848C", Offset="0x107848C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F308", Offset="0x104F308")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleStartRequest.<>c <>9;

			[Address(RVA="0x1A9C5AC", Offset="0x1A9C5AC", VA="0x1A9C5AC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9C610", Offset="0x1A9C610", VA="0x1A9C610")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9C618", Offset="0x1A9C618", VA="0x1A9C618")]
			internal KothBattleStartRequest <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}