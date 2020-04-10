using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LootTableUnit : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF569E0", Offset="0xF569E0", VA="0xF569E0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong UnitId
		{
			[Address(RVA="0xF56A14", Offset="0xF56A14", VA="0xF56A14")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF56A0C", Offset="0xF56A0C", VA="0xF56A0C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF569F4", Offset="0xF569F4", VA="0xF569F4")]
		public LootTableUnit __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableUnit();
		}

		[Address(RVA="0xF569E8", Offset="0xF569E8", VA="0xF569E8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D5BD8", Offset="0x24D5BD8", VA="0x24D5BD8")]
		public static void AddUnitId(FlatBufferBuilder builder, ulong unitId)
		{
		}

		[Address(RVA="0x24D5C14", Offset="0x24D5C14", VA="0x24D5C14")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24D5B70", Offset="0x24D5B70", VA="0x24D5B70")]
		public static Offset<LootTableUnit> CreateLootTableUnit(FlatBufferBuilder builder, float weight = 0f, ulong unit_id = 0L)
		{
			return new Offset<LootTableUnit>();
		}

		[Address(RVA="0x24D5C58", Offset="0x24D5C58", VA="0x24D5C58")]
		public static Offset<LootTableUnit> EndLootTableUnit(FlatBufferBuilder builder)
		{
			return new Offset<LootTableUnit>();
		}

		[Address(RVA="0x24D59DC", Offset="0x24D59DC", VA="0x24D59DC")]
		public static LootTableUnit GetRootAsLootTableUnit(FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableUnit();
		}

		[Address(RVA="0x24D59E8", Offset="0x24D59E8", VA="0x24D59E8")]
		public static LootTableUnit GetRootAsLootTableUnit(FlatBuffers.ByteBuffer _bb, LootTableUnit obj)
		{
			return new LootTableUnit();
		}

		[Address(RVA="0x24D5CD8", Offset="0x24D5CD8", VA="0x24D5CD8")]
		public static void StartLootTableUnit(FlatBufferBuilder builder)
		{
		}
	}
}