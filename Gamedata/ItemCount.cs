using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ItemCount : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5AC68", Offset="0xF5AC68", VA="0xF5AC68", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF5AC9C", Offset="0xF5AC9C", VA="0xF5AC9C")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF5AC94", Offset="0xF5AC94", VA="0xF5AC94")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5AC7C", Offset="0xF5AC7C", VA="0xF5AC7C")]
		public ItemCount __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ItemCount();
		}

		[Address(RVA="0xF5AC70", Offset="0xF5AC70", VA="0xF5AC70", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25188F0", Offset="0x25188F0", VA="0x25188F0")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x25188B4", Offset="0x25188B4", VA="0x25188B4")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x251884C", Offset="0x251884C", VA="0x251884C")]
		public static Offset<ItemCount> CreateItemCount(FlatBufferBuilder builder, ulong item_id = 0L, uint count = 0)
		{
			return new Offset<ItemCount>();
		}

		[Address(RVA="0x251892C", Offset="0x251892C", VA="0x251892C")]
		public static Offset<ItemCount> EndItemCount(FlatBufferBuilder builder)
		{
			return new Offset<ItemCount>();
		}

		[Address(RVA="0x25186BC", Offset="0x25186BC", VA="0x25186BC")]
		public static ItemCount GetRootAsItemCount(FlatBuffers.ByteBuffer _bb)
		{
			return new ItemCount();
		}

		[Address(RVA="0x25186C8", Offset="0x25186C8", VA="0x25186C8")]
		public static ItemCount GetRootAsItemCount(FlatBuffers.ByteBuffer _bb, ItemCount obj)
		{
			return new ItemCount();
		}

		[Address(RVA="0x25189AC", Offset="0x25189AC", VA="0x25189AC")]
		public static void StartItemCount(FlatBufferBuilder builder)
		{
		}
	}
}