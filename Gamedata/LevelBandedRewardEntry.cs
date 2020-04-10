using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LevelBandedRewardEntry : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF564F0", Offset="0xF564F0", VA="0xF564F0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong LootTable
		{
			[Address(RVA="0xF5651C", Offset="0xF5651C", VA="0xF5651C")]
			get
			{
				return new ulong();
			}
		}

		public int MinLevel
		{
			[Address(RVA="0xF56524", Offset="0xF56524", VA="0xF56524")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF56504", Offset="0xF56504", VA="0xF56504")]
		public LevelBandedRewardEntry __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedRewardEntry();
		}

		[Address(RVA="0xF564F8", Offset="0xF564F8", VA="0xF564F8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D30E4", Offset="0x24D30E4", VA="0x24D30E4")]
		public static void AddLootTable(FlatBufferBuilder builder, ulong lootTable)
		{
		}

		[Address(RVA="0x24D3120", Offset="0x24D3120", VA="0x24D3120")]
		public static void AddMinLevel(FlatBufferBuilder builder, int minLevel)
		{
		}

		[Address(RVA="0x24D307C", Offset="0x24D307C", VA="0x24D307C")]
		public static Offset<LevelBandedRewardEntry> CreateLevelBandedRewardEntry(FlatBufferBuilder builder, ulong loot_table = 0L, int min_level = 0)
		{
			return new Offset<LevelBandedRewardEntry>();
		}

		[Address(RVA="0x24D315C", Offset="0x24D315C", VA="0x24D315C")]
		public static Offset<LevelBandedRewardEntry> EndLevelBandedRewardEntry(FlatBufferBuilder builder)
		{
			return new Offset<LevelBandedRewardEntry>();
		}

		[Address(RVA="0x24D2EEC", Offset="0x24D2EEC", VA="0x24D2EEC")]
		public static LevelBandedRewardEntry GetRootAsLevelBandedRewardEntry(FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedRewardEntry();
		}

		[Address(RVA="0x24D2EF8", Offset="0x24D2EF8", VA="0x24D2EF8")]
		public static LevelBandedRewardEntry GetRootAsLevelBandedRewardEntry(FlatBuffers.ByteBuffer _bb, LevelBandedRewardEntry obj)
		{
			return new LevelBandedRewardEntry();
		}

		[Address(RVA="0x24D31DC", Offset="0x24D31DC", VA="0x24D31DC")]
		public static void StartLevelBandedRewardEntry(FlatBufferBuilder builder)
		{
		}
	}
}