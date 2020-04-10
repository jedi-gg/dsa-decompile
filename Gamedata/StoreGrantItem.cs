using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreGrantItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3AC50", Offset="0xF3AC50", VA="0xF3AC50", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint CountMax
		{
			[Address(RVA="0xF3AC94", Offset="0xF3AC94", VA="0xF3AC94")]
			get
			{
				return new uint();
			}
		}

		public uint CountMin
		{
			[Address(RVA="0xF3AC8C", Offset="0xF3AC8C", VA="0xF3AC8C")]
			get
			{
				return new uint();
			}
		}

		public ulong Item
		{
			[Address(RVA="0xF3AC84", Offset="0xF3AC84", VA="0xF3AC84")]
			get
			{
				return new ulong();
			}
		}

		public bool MonteCarlo
		{
			[Address(RVA="0xF3AC9C", Offset="0xF3AC9C", VA="0xF3AC9C")]
			get
			{
				return new bool();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF3AC7C", Offset="0xF3AC7C", VA="0xF3AC7C")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF3AC64", Offset="0xF3AC64", VA="0xF3AC64")]
		public StoreGrantItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreGrantItem();
		}

		[Address(RVA="0xF3AC58", Offset="0xF3AC58", VA="0xF3AC58", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E7134", Offset="0x22E7134", VA="0x22E7134")]
		public static void AddCountMax(FlatBufferBuilder builder, uint countMax)
		{
		}

		[Address(RVA="0x22E7170", Offset="0x22E7170", VA="0x22E7170")]
		public static void AddCountMin(FlatBufferBuilder builder, uint countMin)
		{
		}

		[Address(RVA="0x22E70F8", Offset="0x22E70F8", VA="0x22E70F8")]
		public static void AddItem(FlatBufferBuilder builder, ulong item)
		{
		}

		[Address(RVA="0x22E71F0", Offset="0x22E71F0", VA="0x22E71F0")]
		public static void AddMonteCarlo(FlatBufferBuilder builder, bool monteCarlo)
		{
		}

		[Address(RVA="0x22E71AC", Offset="0x22E71AC", VA="0x22E71AC")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x22E7050", Offset="0x22E7050", VA="0x22E7050")]
		public static Offset<StoreGrantItem> CreateStoreGrantItem(FlatBufferBuilder builder, float weight = 0f, ulong item = 0L, uint count_min = 0, uint count_max = 0, bool monte_carlo = false)
		{
			return new Offset<StoreGrantItem>();
		}

		[Address(RVA="0x22E722C", Offset="0x22E722C", VA="0x22E722C")]
		public static Offset<StoreGrantItem> EndStoreGrantItem(FlatBufferBuilder builder)
		{
			return new Offset<StoreGrantItem>();
		}

		[Address(RVA="0x22E6D88", Offset="0x22E6D88", VA="0x22E6D88")]
		public static StoreGrantItem GetRootAsStoreGrantItem(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreGrantItem();
		}

		[Address(RVA="0x22E6D94", Offset="0x22E6D94", VA="0x22E6D94")]
		public static StoreGrantItem GetRootAsStoreGrantItem(FlatBuffers.ByteBuffer _bb, StoreGrantItem obj)
		{
			return new StoreGrantItem();
		}

		[Address(RVA="0x22E72AC", Offset="0x22E72AC", VA="0x22E72AC")]
		public static void StartStoreGrantItem(FlatBufferBuilder builder)
		{
		}
	}
}