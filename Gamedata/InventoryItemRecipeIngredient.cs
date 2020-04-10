using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct InventoryItemRecipeIngredient : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5ABE0", Offset="0xF5ABE0", VA="0xF5ABE0", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF5AC14", Offset="0xF5AC14", VA="0xF5AC14")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF5AC0C", Offset="0xF5AC0C", VA="0xF5AC0C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5ABF4", Offset="0xF5ABF4", VA="0xF5ABF4")]
		public InventoryItemRecipeIngredient __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new InventoryItemRecipeIngredient();
		}

		[Address(RVA="0xF5ABE8", Offset="0xF5ABE8", VA="0xF5ABE8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25185C8", Offset="0x25185C8", VA="0x25185C8")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x251858C", Offset="0x251858C", VA="0x251858C")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x2518524", Offset="0x2518524", VA="0x2518524")]
		public static Offset<InventoryItemRecipeIngredient> CreateInventoryItemRecipeIngredient(FlatBufferBuilder builder, ulong item_id = 0L, uint count = 0)
		{
			return new Offset<InventoryItemRecipeIngredient>();
		}

		[Address(RVA="0x2518604", Offset="0x2518604", VA="0x2518604")]
		public static Offset<InventoryItemRecipeIngredient> EndInventoryItemRecipeIngredient(FlatBufferBuilder builder)
		{
			return new Offset<InventoryItemRecipeIngredient>();
		}

		[Address(RVA="0x2518394", Offset="0x2518394", VA="0x2518394")]
		public static InventoryItemRecipeIngredient GetRootAsInventoryItemRecipeIngredient(FlatBuffers.ByteBuffer _bb)
		{
			return new InventoryItemRecipeIngredient();
		}

		[Address(RVA="0x25183A0", Offset="0x25183A0", VA="0x25183A0")]
		public static InventoryItemRecipeIngredient GetRootAsInventoryItemRecipeIngredient(FlatBuffers.ByteBuffer _bb, InventoryItemRecipeIngredient obj)
		{
			return new InventoryItemRecipeIngredient();
		}

		[Address(RVA="0x2518684", Offset="0x2518684", VA="0x2518684")]
		public static void StartInventoryItemRecipeIngredient(FlatBufferBuilder builder)
		{
		}
	}
}