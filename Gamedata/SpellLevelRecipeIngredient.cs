using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellLevelRecipeIngredient : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A208", Offset="0xF3A208", VA="0xF3A208", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF3A23C", Offset="0xF3A23C", VA="0xF3A23C")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF3A234", Offset="0xF3A234", VA="0xF3A234")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF3A21C", Offset="0xF3A21C", VA="0xF3A21C")]
		public SpellLevelRecipeIngredient __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevelRecipeIngredient();
		}

		[Address(RVA="0xF3A210", Offset="0xF3A210", VA="0xF3A210", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DD474", Offset="0x22DD474", VA="0x22DD474")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x22DD438", Offset="0x22DD438", VA="0x22DD438")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x22DD3D0", Offset="0x22DD3D0", VA="0x22DD3D0")]
		public static Offset<SpellLevelRecipeIngredient> CreateSpellLevelRecipeIngredient(FlatBufferBuilder builder, ulong item_id = 0L, uint count = 0)
		{
			return new Offset<SpellLevelRecipeIngredient>();
		}

		[Address(RVA="0x22DD4B0", Offset="0x22DD4B0", VA="0x22DD4B0")]
		public static Offset<SpellLevelRecipeIngredient> EndSpellLevelRecipeIngredient(FlatBufferBuilder builder)
		{
			return new Offset<SpellLevelRecipeIngredient>();
		}

		[Address(RVA="0x22DD240", Offset="0x22DD240", VA="0x22DD240")]
		public static SpellLevelRecipeIngredient GetRootAsSpellLevelRecipeIngredient(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevelRecipeIngredient();
		}

		[Address(RVA="0x22DD24C", Offset="0x22DD24C", VA="0x22DD24C")]
		public static SpellLevelRecipeIngredient GetRootAsSpellLevelRecipeIngredient(FlatBuffers.ByteBuffer _bb, SpellLevelRecipeIngredient obj)
		{
			return new SpellLevelRecipeIngredient();
		}

		[Address(RVA="0x22DD530", Offset="0x22DD530", VA="0x22DD530")]
		public static void StartSpellLevelRecipeIngredient(FlatBufferBuilder builder)
		{
		}
	}
}