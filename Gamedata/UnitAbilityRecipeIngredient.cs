using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitAbilityRecipeIngredient : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B680", Offset="0xF0B680", VA="0xF0B680", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF0B6B4", Offset="0xF0B6B4", VA="0xF0B6B4")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF0B6AC", Offset="0xF0B6AC", VA="0xF0B6AC")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0B694", Offset="0xF0B694", VA="0xF0B694")]
		public UnitAbilityRecipeIngredient __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityRecipeIngredient();
		}

		[Address(RVA="0xF0B688", Offset="0xF0B688", VA="0xF0B688", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1679534", Offset="0x1679534", VA="0x1679534")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x16794F8", Offset="0x16794F8", VA="0x16794F8")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x1679490", Offset="0x1679490", VA="0x1679490")]
		public static Offset<UnitAbilityRecipeIngredient> CreateUnitAbilityRecipeIngredient(FlatBufferBuilder builder, ulong item_id = 0L, uint count = 0)
		{
			return new Offset<UnitAbilityRecipeIngredient>();
		}

		[Address(RVA="0x1679570", Offset="0x1679570", VA="0x1679570")]
		public static Offset<UnitAbilityRecipeIngredient> EndUnitAbilityRecipeIngredient(FlatBufferBuilder builder)
		{
			return new Offset<UnitAbilityRecipeIngredient>();
		}

		[Address(RVA="0x1679300", Offset="0x1679300", VA="0x1679300")]
		public static UnitAbilityRecipeIngredient GetRootAsUnitAbilityRecipeIngredient(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityRecipeIngredient();
		}

		[Address(RVA="0x167930C", Offset="0x167930C", VA="0x167930C")]
		public static UnitAbilityRecipeIngredient GetRootAsUnitAbilityRecipeIngredient(FlatBuffers.ByteBuffer _bb, UnitAbilityRecipeIngredient obj)
		{
			return new UnitAbilityRecipeIngredient();
		}

		[Address(RVA="0x16795F0", Offset="0x16795F0", VA="0x16795F0")]
		public static void StartUnitAbilityRecipeIngredient(FlatBufferBuilder builder)
		{
		}
	}
}