using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentSlotItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58EA0", Offset="0xF58EA0", VA="0xF58EA0", Slot="5")]
			get
			{
				return null;
			}
		}

		public float CostDiscountPercent
		{
			[Address(RVA="0xF58EFC", Offset="0xF58EFC", VA="0xF58EFC")]
			get
			{
				return new float();
			}
		}

		public ulong CostItem
		{
			[Address(RVA="0xF58EEC", Offset="0xF58EEC", VA="0xF58EEC")]
			get
			{
				return new ulong();
			}
		}

		public uint CountMax
		{
			[Address(RVA="0xF58EE4", Offset="0xF58EE4", VA="0xF58EE4")]
			get
			{
				return new uint();
			}
		}

		public uint CountMin
		{
			[Address(RVA="0xF58EDC", Offset="0xF58EDC", VA="0xF58EDC")]
			get
			{
				return new uint();
			}
		}

		public ulong Item
		{
			[Address(RVA="0xF58ED4", Offset="0xF58ED4", VA="0xF58ED4")]
			get
			{
				return new ulong();
			}
		}

		public ulong StoreItemDef
		{
			[Address(RVA="0xF58EF4", Offset="0xF58EF4", VA="0xF58EF4")]
			get
			{
				return new ulong();
			}
		}

		public float Weight
		{
			[Address(RVA="0xF58ECC", Offset="0xF58ECC", VA="0xF58ECC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF58EB4", Offset="0xF58EB4", VA="0xF58EB4")]
		public ShipmentSlotItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentSlotItem();
		}

		[Address(RVA="0xF58EA8", Offset="0xF58EA8", VA="0xF58EA8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EB144", Offset="0x24EB144", VA="0x24EB144")]
		public static void AddCostDiscountPercent(FlatBufferBuilder builder, float costDiscountPercent)
		{
		}

		[Address(RVA="0x24EB0CC", Offset="0x24EB0CC", VA="0x24EB0CC")]
		public static void AddCostItem(FlatBufferBuilder builder, ulong costItem)
		{
		}

		[Address(RVA="0x24EB188", Offset="0x24EB188", VA="0x24EB188")]
		public static void AddCountMax(FlatBufferBuilder builder, uint countMax)
		{
		}

		[Address(RVA="0x24EB1C4", Offset="0x24EB1C4", VA="0x24EB1C4")]
		public static void AddCountMin(FlatBufferBuilder builder, uint countMin)
		{
		}

		[Address(RVA="0x24EB108", Offset="0x24EB108", VA="0x24EB108")]
		public static void AddItem(FlatBufferBuilder builder, ulong item)
		{
		}

		[Address(RVA="0x24EB090", Offset="0x24EB090", VA="0x24EB090")]
		public static void AddStoreItemDef(FlatBufferBuilder builder, ulong storeItemDef)
		{
		}

		[Address(RVA="0x24EB200", Offset="0x24EB200", VA="0x24EB200")]
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
		}

		[Address(RVA="0x24EAFC8", Offset="0x24EAFC8", VA="0x24EAFC8")]
		public static Offset<ShipmentSlotItem> CreateShipmentSlotItem(FlatBufferBuilder builder, float weight = 0f, ulong item = 0L, uint count_min = 0, uint count_max = 0, ulong cost_item = 0L, ulong store_item_def = 0L, float cost_discount_percent = 0f)
		{
			return new Offset<ShipmentSlotItem>();
		}

		[Address(RVA="0x24EB244", Offset="0x24EB244", VA="0x24EB244")]
		public static Offset<ShipmentSlotItem> EndShipmentSlotItem(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentSlotItem>();
		}

		[Address(RVA="0x24EAC20", Offset="0x24EAC20", VA="0x24EAC20")]
		public static ShipmentSlotItem GetRootAsShipmentSlotItem(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentSlotItem();
		}

		[Address(RVA="0x24EAC2C", Offset="0x24EAC2C", VA="0x24EAC2C")]
		public static ShipmentSlotItem GetRootAsShipmentSlotItem(FlatBuffers.ByteBuffer _bb, ShipmentSlotItem obj)
		{
			return new ShipmentSlotItem();
		}

		[Address(RVA="0x24EB2C4", Offset="0x24EB2C4", VA="0x24EB2C4")]
		public static void StartShipmentSlotItem(FlatBufferBuilder builder)
		{
		}
	}
}