using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonBattleStartRequest : IMessage<ClubDungeonBattleStartRequest>, IMessage, IEquatable<ClubDungeonBattleStartRequest>, IDeepCloneable<ClubDungeonBattleStartRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonBattleStartRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSaveFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private BattleSquadSaveInfo squadSave_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10930F0", Offset="0x10930F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4E0D4", Offset="0x1A4E0D4", VA="0x1A4E0D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093140", Offset="0x1093140")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1A4E404", Offset="0x1A4E404", VA="0x1A4E404")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A4E40C", Offset="0x1A4E40C", VA="0x1A4E40C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10930E0", Offset="0x10930E0")]
		public static MessageParser<ClubDungeonBattleStartRequest> Parser
		{
			[Address(RVA="0x1A4E06C", Offset="0x1A4E06C", VA="0x1A4E06C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093100", Offset="0x1093100")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4E1C4", Offset="0x1A4E1C4", VA="0x1A4E1C4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093120", Offset="0x1093120")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1A4E3FC", Offset="0x1A4E3FC", VA="0x1A4E3FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093130", Offset="0x1093130")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x1A4E384", Offset="0x1A4E384", VA="0x1A4E384")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4E38C", Offset="0x1A4E38C", VA="0x1A4E38C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093110", Offset="0x1093110")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1A4E3F4", Offset="0x1A4E3F4", VA="0x1A4E3F4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4ECB0", Offset="0x1A4ECB0", VA="0x1A4ECB0")]
		static ClubDungeonBattleStartRequest()
		{
		}

		[Address(RVA="0x1A4E220", Offset="0x1A4E220", VA="0x1A4E220")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107815C", Offset="0x107815C")]
		public ClubDungeonBattleStartRequest()
		{
		}

		[Address(RVA="0x1A4E2B0", Offset="0x1A4E2B0", VA="0x1A4E2B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107816C", Offset="0x107816C")]
		public ClubDungeonBattleStartRequest(ClubDungeonBattleStartRequest other)
		{
		}

		[Address(RVA="0x1A4E86C", Offset="0x1A4E86C", VA="0x1A4E86C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10781DC", Offset="0x10781DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4E394", Offset="0x1A4E394", VA="0x1A4E394", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107817C", Offset="0x107817C")]
		public ClubDungeonBattleStartRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4E414", Offset="0x1A4E414", VA="0x1A4E414", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107818C", Offset="0x107818C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4E488", Offset="0x1A4E488", VA="0x1A4E488", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107819C", Offset="0x107819C")]
		public bool Equals(ClubDungeonBattleStartRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4E590", Offset="0x1A4E590", VA="0x1A4E590", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10781AC", Offset="0x10781AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4E9D4", Offset="0x1A4E9D4", VA="0x1A4E9D4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10781EC", Offset="0x10781EC")]
		public void MergeFrom(ClubDungeonBattleStartRequest other)
		{
		}

		[Address(RVA="0x1A4EAEC", Offset="0x1A4EAEC", VA="0x1A4EAEC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10781FC", Offset="0x10781FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4E654", Offset="0x1A4E654", VA="0x1A4E654", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10781BC", Offset="0x10781BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4E6BC", Offset="0x1A4E6BC", VA="0x1A4E6BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10781CC", Offset="0x10781CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F2C8", Offset="0x104F2C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonBattleStartRequest.<>c <>9;

			[Address(RVA="0x1A4EDB8", Offset="0x1A4EDB8", VA="0x1A4EDB8")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4EE1C", Offset="0x1A4EE1C", VA="0x1A4EE1C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4EE24", Offset="0x1A4EE24", VA="0x1A4EE24")]
			internal ClubDungeonBattleStartRequest <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}