using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SortableItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59120", Offset="0xF59120", VA="0xF59120", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF5914C", Offset="0xF5914C", VA="0xF5914C")]
			get
			{
				return new ulong();
			}
		}

		public InventoryItemType ItemType
		{
			[Address(RVA="0xF59154", Offset="0xF59154", VA="0xF59154")]
			get
			{
				return new InventoryItemType();
			}
		}

		[Address(RVA="0xF59134", Offset="0xF59134", VA="0xF59134")]
		public SortableItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SortableItem();
		}

		[Address(RVA="0xF59128", Offset="0xF59128", VA="0xF59128", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24ECA58", Offset="0x24ECA58", VA="0x24ECA58")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x24ECA94", Offset="0x24ECA94", VA="0x24ECA94")]
		public static void AddItemType(FlatBufferBuilder builder, InventoryItemType itemType)
		{
		}

		[Address(RVA="0x24EC9F0", Offset="0x24EC9F0", VA="0x24EC9F0")]
		public static Offset<SortableItem> CreateSortableItem(FlatBufferBuilder builder, ulong item_id = 0L, InventoryItemType item_type = 0)
		{
			return new Offset<SortableItem>();
		}

		[Address(RVA="0x24ECAD0", Offset="0x24ECAD0", VA="0x24ECAD0")]
		public static Offset<SortableItem> EndSortableItem(FlatBufferBuilder builder)
		{
			return new Offset<SortableItem>();
		}

		[Address(RVA="0x24EC848", Offset="0x24EC848", VA="0x24EC848")]
		public static SortableItem GetRootAsSortableItem(FlatBuffers.ByteBuffer _bb)
		{
			return new SortableItem();
		}

		[Address(RVA="0x24EC854", Offset="0x24EC854", VA="0x24EC854")]
		public static SortableItem GetRootAsSortableItem(FlatBuffers.ByteBuffer _bb, SortableItem obj)
		{
			return new SortableItem();
		}

		[Address(RVA="0x24ECB50", Offset="0x24ECB50", VA="0x24ECB50")]
		public static void StartSortableItem(FlatBufferBuilder builder)
		{
		}
	}
}