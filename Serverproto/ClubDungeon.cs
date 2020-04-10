using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeon : IMessage<ClubDungeon>, IMessage, IEquatable<ClubDungeon>, IDeepCloneable<ClubDungeon>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeon> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MapsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubDungeonMap> _repeated_maps_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubDungeonMap> maps_;

		[FieldOffset(Offset="0x0")]
		public const int ExpireTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong expireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int EndTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong endTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int RewardGroupsFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ClubDungeonRewardGroup> _repeated_rewardGroups_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ClubDungeonRewardGroup> rewardGroups_;

		[FieldOffset(Offset="0x0")]
		public const int ActiveBonusDescriptorFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private BattleNodeOverrideDescriptor activeBonusDescriptor_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10955F0", Offset="0x10955F0")]
		public BattleNodeOverrideDescriptor ActiveBonusDescriptor
		{
			[Address(RVA="0x1A4BE98", Offset="0x1A4BE98", VA="0x1A4BE98")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4BEA0", Offset="0x1A4BEA0", VA="0x1A4BEA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095590", Offset="0x1095590")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4BBD0", Offset="0x1A4BBD0", VA="0x1A4BBD0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10955D0", Offset="0x10955D0")]
		public ulong EndTimestamp
		{
			[Address(RVA="0x1A4BF20", Offset="0x1A4BF20", VA="0x1A4BF20")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A4BF28", Offset="0x1A4BF28", VA="0x1A4BF28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10955C0", Offset="0x10955C0")]
		public ulong ExpireTimestamp
		{
			[Address(RVA="0x1A4BF10", Offset="0x1A4BF10", VA="0x1A4BF10")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A4BF18", Offset="0x1A4BF18", VA="0x1A4BF18")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10955B0", Offset="0x10955B0")]
		public RepeatedField<ClubDungeonMap> Maps
		{
			[Address(RVA="0x1A4BF08", Offset="0x1A4BF08", VA="0x1A4BF08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095580", Offset="0x1095580")]
		public static MessageParser<ClubDungeon> Parser
		{
			[Address(RVA="0x1A4BB68", Offset="0x1A4BB68", VA="0x1A4BB68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10955A0", Offset="0x10955A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4BCC0", Offset="0x1A4BCC0", VA="0x1A4BCC0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10955E0", Offset="0x10955E0")]
		public RepeatedField<ClubDungeonRewardGroup> RewardGroups
		{
			[Address(RVA="0x1A4BF30", Offset="0x1A4BF30", VA="0x1A4BF30")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4CA2C", Offset="0x1A4CA2C", VA="0x1A4CA2C")]
		static ClubDungeon()
		{
		}

		[Address(RVA="0x1A4BD1C", Offset="0x1A4BD1C", VA="0x1A4BD1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C5CC", Offset="0x107C5CC")]
		public ClubDungeon()
		{
		}

		[Address(RVA="0x1A4BDB4", Offset="0x1A4BDB4", VA="0x1A4BDB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C5DC", Offset="0x107C5DC")]
		public ClubDungeon(ClubDungeon other)
		{
		}

		[Address(RVA="0x1A4C430", Offset="0x1A4C430", VA="0x1A4C430", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C64C", Offset="0x107C64C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4BEA8", Offset="0x1A4BEA8", VA="0x1A4BEA8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C5EC", Offset="0x107C5EC")]
		public ClubDungeon Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4BF38", Offset="0x1A4BF38", VA="0x1A4BF38", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C5FC", Offset="0x107C5FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4BFAC", Offset="0x1A4BFAC", VA="0x1A4BFAC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C60C", Offset="0x107C60C")]
		public bool Equals(ClubDungeon other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4C0C0", Offset="0x1A4C0C0", VA="0x1A4C0C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C61C", Offset="0x107C61C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4C8F8", Offset="0x1A4C8F8", VA="0x1A4C8F8")]
		public ulong GetNodeId(int mapIndex, int nodeIndex)
		{
			return new ulong();
		}

		[Address(RVA="0x1A4C5EC", Offset="0x1A4C5EC", VA="0x1A4C5EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C65C", Offset="0x107C65C")]
		public void MergeFrom(ClubDungeon other)
		{
		}

		[Address(RVA="0x1A4C710", Offset="0x1A4C710", VA="0x1A4C710", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C66C", Offset="0x107C66C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4C1A0", Offset="0x1A4C1A0", VA="0x1A4C1A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C62C", Offset="0x107C62C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4C208", Offset="0x1A4C208", VA="0x1A4C208", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C63C", Offset="0x107C63C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F938", Offset="0x104F938")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeon.<>c <>9;

			[Address(RVA="0x1A4CC00", Offset="0x1A4CC00", VA="0x1A4CC00")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4CC64", Offset="0x1A4CC64", VA="0x1A4CC64")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4CC6C", Offset="0x1A4CC6C", VA="0x1A4CC6C")]
			internal ClubDungeon <.cctor>b__46_0()
			{
				return null;
			}
		}
	}
}