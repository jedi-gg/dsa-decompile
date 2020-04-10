using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LootTableSelector : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56810", Offset="0xF56810", VA="0xF56810", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong LootTableId
		{
			[Address(RVA="0xF56844", Offset="0xF56844", VA="0xF56844")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF5683C", Offset="0xF5683C", VA="0xF5683C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF56824", Offset="0xF56824", VA="0xF56824")]
		public LootTableSelector __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableSelector();
		}

		[Address(RVA="0xF56818", Offset="0xF56818", VA="0xF56818", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D48AC", Offset="0x24D48AC", VA="0x24D48AC")]
		public static void AddLootTableId(FlatBufferBuilder builder, ulong lootTableId)
		{
		}

		[Address(RVA="0x24D48E8", Offset="0x24D48E8", VA="0x24D48E8")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24D4844", Offset="0x24D4844", VA="0x24D4844")]
		public static Offset<LootTableSelector> CreateLootTableSelector(FlatBufferBuilder builder, float weight = 0f, ulong loot_table_id = 0L)
		{
			return new Offset<LootTableSelector>();
		}

		[Address(RVA="0x24D492C", Offset="0x24D492C", VA="0x24D492C")]
		public static Offset<LootTableSelector> EndLootTableSelector(FlatBufferBuilder builder)
		{
			return new Offset<LootTableSelector>();
		}

		[Address(RVA="0x24D4698", Offset="0x24D4698", VA="0x24D4698")]
		public static LootTableSelector GetRootAsLootTableSelector(FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableSelector();
		}

		[Address(RVA="0x24D46A4", Offset="0x24D46A4", VA="0x24D46A4")]
		public static LootTableSelector GetRootAsLootTableSelector(FlatBuffers.ByteBuffer _bb, LootTableSelector obj)
		{
			return new LootTableSelector();
		}

		[Address(RVA="0x24D49AC", Offset="0x24D49AC", VA="0x24D49AC")]
		public static void StartLootTableSelector(FlatBufferBuilder builder)
		{
		}
	}
}