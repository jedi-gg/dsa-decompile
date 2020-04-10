using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreItemCost : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3ACF0", Offset="0xF3ACF0", VA="0xF3ACF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF3AD24", Offset="0xF3AD24", VA="0xF3AD24")]
			get
			{
				return new uint();
			}
		}

		public ulong Item
		{
			[Address(RVA="0xF3AD1C", Offset="0xF3AD1C", VA="0xF3AD1C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF3AD04", Offset="0xF3AD04", VA="0xF3AD04")]
		public StoreItemCost __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreItemCost();
		}

		[Address(RVA="0xF3ACF8", Offset="0xF3ACF8", VA="0xF3ACF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E7530", Offset="0x22E7530", VA="0x22E7530")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x22E74F4", Offset="0x22E74F4", VA="0x22E74F4")]
		public static void AddItem(FlatBufferBuilder builder, ulong item)
		{
		}

		[Address(RVA="0x22E748C", Offset="0x22E748C", VA="0x22E748C")]
		public static Offset<StoreItemCost> CreateStoreItemCost(FlatBufferBuilder builder, ulong item = 0L, uint count = 0)
		{
			return new Offset<StoreItemCost>();
		}

		[Address(RVA="0x22E756C", Offset="0x22E756C", VA="0x22E756C")]
		public static Offset<StoreItemCost> EndStoreItemCost(FlatBufferBuilder builder)
		{
			return new Offset<StoreItemCost>();
		}

		[Address(RVA="0x22E72E4", Offset="0x22E72E4", VA="0x22E72E4")]
		public static StoreItemCost GetRootAsStoreItemCost(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreItemCost();
		}

		[Address(RVA="0x22E72F0", Offset="0x22E72F0", VA="0x22E72F0")]
		public static StoreItemCost GetRootAsStoreItemCost(FlatBuffers.ByteBuffer _bb, StoreItemCost obj)
		{
			return new StoreItemCost();
		}

		[Address(RVA="0x22E75EC", Offset="0x22E75EC", VA="0x22E75EC")]
		public static void StartStoreItemCost(FlatBufferBuilder builder)
		{
		}
	}
}