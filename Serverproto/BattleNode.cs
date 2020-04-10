using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleNode : IMessage<BattleNode>, IMessage, IEquatable<BattleNode>, IDeepCloneable<BattleNode>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleNode> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int LockedKeyFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string lockedKey_;

		[FieldOffset(Offset="0x0")]
		public const int PossibleRewardsFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_possibleRewards_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ItemCount> possibleRewards_;

		[FieldOffset(Offset="0x0")]
		public const int BattleRestrictionFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong battleRestriction_;

		[FieldOffset(Offset="0x0")]
		public const int EntryCostIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong entryCostId_;

		[FieldOffset(Offset="0x0")]
		public const int EntryCostCountFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong entryCostCount_;

		[FieldOffset(Offset="0x0")]
		public const int PossibleEnemiesFieldNumber = 8;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<EnemyUnitPreview> _repeated_possibleEnemies_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<EnemyUnitPreview> possibleEnemies_;

		[FieldOffset(Offset="0x0")]
		public const int EnemyStatsFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private UnitStatOverride enemyStats_;

		[FieldOffset(Offset="0x0")]
		public const int UnitBonusRestrictionFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private ulong unitBonusRestriction_;

		[FieldOffset(Offset="0x0")]
		public const int PossibleRewardRangesFieldNumber = 11;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ItemCountRange> _repeated_possibleRewardRanges_codec;

		[FieldOffset(Offset="0x68")]
		private readonly RepeatedField<ItemCountRange> possibleRewardRanges_;

		[FieldOffset(Offset="0x0")]
		public const int RecommendedDescriptionFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private string recommendedDescription_;

		[FieldOffset(Offset="0x0")]
		public const int ShowBonusLootLabelFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private bool showBonusLootLabel_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094108", Offset="0x1094108")]
		public ulong BattleRestriction
		{
			[Address(RVA="0x203D0FC", Offset="0x203D0FC", VA="0x203D0FC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x203D104", Offset="0x203D104", VA="0x203D104")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10940B0", Offset="0x10940B0")]
		public string Description
		{
			[Address(RVA="0x203D004", Offset="0x203D004", VA="0x203D004")]
			get
			{
				return null;
			}
			[Address(RVA="0x203D00C", Offset="0x203D00C", VA="0x203D00C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094080", Offset="0x1094080")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x203CB6C", Offset="0x203CB6C", VA="0x203CB6C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094148", Offset="0x1094148")]
		public UnitStatOverride EnemyStats
		{
			[Address(RVA="0x203CF1C", Offset="0x203CF1C", VA="0x203CF1C")]
			get
			{
				return null;
			}
			[Address(RVA="0x203CF24", Offset="0x203CF24", VA="0x203CF24")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094128", Offset="0x1094128")]
		public ulong EntryCostCount
		{
			[Address(RVA="0x203D11C", Offset="0x203D11C", VA="0x203D11C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x203D124", Offset="0x203D124", VA="0x203D124")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094118", Offset="0x1094118")]
		public ulong EntryCostId
		{
			[Address(RVA="0x203D10C", Offset="0x203D10C", VA="0x203D10C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x203D114", Offset="0x203D114", VA="0x203D114")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10940C0", Offset="0x10940C0")]
		public string LockedKey
		{
			[Address(RVA="0x203D07C", Offset="0x203D07C", VA="0x203D07C")]
			get
			{
				return null;
			}
			[Address(RVA="0x203D084", Offset="0x203D084", VA="0x203D084")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10940A0", Offset="0x10940A0")]
		public string Name
		{
			[Address(RVA="0x203CF8C", Offset="0x203CF8C", VA="0x203CF8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x203CF94", Offset="0x203CF94", VA="0x203CF94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094070", Offset="0x1094070")]
		public static MessageParser<BattleNode> Parser
		{
			[Address(RVA="0x203CB04", Offset="0x203CB04", VA="0x203CB04")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094090", Offset="0x1094090")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x203CC5C", Offset="0x203CC5C", VA="0x203CC5C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094138", Offset="0x1094138")]
		public RepeatedField<EnemyUnitPreview> PossibleEnemies
		{
			[Address(RVA="0x203D12C", Offset="0x203D12C", VA="0x203D12C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094168", Offset="0x1094168")]
		public RepeatedField<ItemCountRange> PossibleRewardRanges
		{
			[Address(RVA="0x203D144", Offset="0x203D144", VA="0x203D144")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10940D0", Offset="0x10940D0")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10940D0", Offset="0x10940D0")]
		public RepeatedField<ItemCount> PossibleRewards
		{
			[Address(RVA="0x203D0F4", Offset="0x203D0F4", VA="0x203D0F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094178", Offset="0x1094178")]
		public string RecommendedDescription
		{
			[Address(RVA="0x203D14C", Offset="0x203D14C", VA="0x203D14C")]
			get
			{
				return null;
			}
			[Address(RVA="0x203D154", Offset="0x203D154", VA="0x203D154")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094188", Offset="0x1094188")]
		public bool ShowBonusLootLabel
		{
			[Address(RVA="0x203D1C4", Offset="0x203D1C4", VA="0x203D1C4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x203D1CC", Offset="0x203D1CC", VA="0x203D1CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094158", Offset="0x1094158")]
		public ulong UnitBonusRestriction
		{
			[Address(RVA="0x203D134", Offset="0x203D134", VA="0x203D134")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x203D13C", Offset="0x203D13C", VA="0x203D13C")]
			set
			{
			}
		}

		[Address(RVA="0x203E604", Offset="0x203E604", VA="0x203E604")]
		static BattleNode()
		{
		}

		[Address(RVA="0x203CCB8", Offset="0x203CCB8", VA="0x203CCB8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10798BC", Offset="0x10798BC")]
		public BattleNode()
		{
		}

		[Address(RVA="0x203CD98", Offset="0x203CD98", VA="0x203CD98")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10798CC", Offset="0x10798CC")]
		public BattleNode(BattleNode other)
		{
		}

		[Address(RVA="0x203DC50", Offset="0x203DC50", VA="0x203DC50", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107993C", Offset="0x107993C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x203CF2C", Offset="0x203CF2C", VA="0x203CF2C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10798DC", Offset="0x10798DC")]
		public BattleNode Clone()
		{
			return null;
		}

		[Address(RVA="0x203D1D8", Offset="0x203D1D8", VA="0x203D1D8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10798EC", Offset="0x10798EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x203D24C", Offset="0x203D24C", VA="0x203D24C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10798FC", Offset="0x10798FC")]
		public bool Equals(BattleNode other)
		{
			return new bool();
		}

		[Address(RVA="0x203D420", Offset="0x203D420", VA="0x203D420", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107990C", Offset="0x107990C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x203E054", Offset="0x203E054", VA="0x203E054", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107994C", Offset="0x107994C")]
		public void MergeFrom(BattleNode other)
		{
		}

		[Address(RVA="0x203E278", Offset="0x203E278", VA="0x203E278", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107995C", Offset="0x107995C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x203D6A4", Offset="0x203D6A4", VA="0x203D6A4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107991C", Offset="0x107991C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x203D70C", Offset="0x203D70C", VA="0x203D70C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107992C", Offset="0x107992C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F528", Offset="0x104F528")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleNode.<>c <>9;

			[Address(RVA="0x1DBD9CC", Offset="0x1DBD9CC", VA="0x1DBD9CC")]
			static <>c()
			{
			}

			[Address(RVA="0x1DBDA30", Offset="0x1DBDA30", VA="0x1DBDA30")]
			public <>c()
			{
			}

			[Address(RVA="0x1DBDA38", Offset="0x1DBDA38", VA="0x1DBDA38")]
			internal BattleNode <.cctor>b__85_0()
			{
				return null;
			}
		}
	}
}