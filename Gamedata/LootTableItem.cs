using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LootTableItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56778", Offset="0xF56778", VA="0xF56778", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint CountMax
		{
			[Address(RVA="0xF567BC", Offset="0xF567BC", VA="0xF567BC")]
			get
			{
				return new uint();
			}
		}

		public uint CountMin
		{
			[Address(RVA="0xF567B4", Offset="0xF567B4", VA="0xF567B4")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF567AC", Offset="0xF567AC", VA="0xF567AC")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF567A4", Offset="0xF567A4", VA="0xF567A4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF5678C", Offset="0xF5678C", VA="0xF5678C")]
		public LootTableItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableItem();
		}

		[Address(RVA="0xF56780", Offset="0xF56780", VA="0xF56780", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D4524", Offset="0x24D4524", VA="0x24D4524")]
		public static void AddCountMax(FlatBufferBuilder builder, uint countMax)
		{
		}

		[Address(RVA="0x24D4560", Offset="0x24D4560", VA="0x24D4560")]
		public static void AddCountMin(FlatBufferBuilder builder, uint countMin)
		{
		}

		[Address(RVA="0x24D44E8", Offset="0x24D44E8", VA="0x24D44E8")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x24D459C", Offset="0x24D459C", VA="0x24D459C")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24D4458", Offset="0x24D4458", VA="0x24D4458")]
		public static Offset<LootTableItem> CreateLootTableItem(FlatBufferBuilder builder, float weight = 0f, ulong item_id = 0L, uint count_min = 0, uint count_max = 0)
		{
			return new Offset<LootTableItem>();
		}

		[Address(RVA="0x24D45E0", Offset="0x24D45E0", VA="0x24D45E0")]
		public static Offset<LootTableItem> EndLootTableItem(FlatBufferBuilder builder)
		{
			return new Offset<LootTableItem>();
		}

		[Address(RVA="0x24D41DC", Offset="0x24D41DC", VA="0x24D41DC")]
		public static LootTableItem GetRootAsLootTableItem(FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableItem();
		}

		[Address(RVA="0x24D41E8", Offset="0x24D41E8", VA="0x24D41E8")]
		public static LootTableItem GetRootAsLootTableItem(FlatBuffers.ByteBuffer _bb, LootTableItem obj)
		{
			return new LootTableItem();
		}

		[Address(RVA="0x24D4660", Offset="0x24D4660", VA="0x24D4660")]
		public static void StartLootTableItem(FlatBufferBuilder builder)
		{
		}
	}
}