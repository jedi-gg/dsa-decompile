using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitTrainingRecipe : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C1C8", Offset="0xF0C1C8", VA="0xF0C1C8", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint CurrencyCost
		{
			[Address(RVA="0xF0C1FC", Offset="0xF0C1FC", VA="0xF0C1FC")]
			get
			{
				return new uint();
			}
		}

		public uint XpAmount
		{
			[Address(RVA="0xF0C1F4", Offset="0xF0C1F4", VA="0xF0C1F4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF0C1DC", Offset="0xF0C1DC", VA="0xF0C1DC")]
		public UnitTrainingRecipe __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitTrainingRecipe();
		}

		[Address(RVA="0xF0C1D0", Offset="0xF0C1D0", VA="0xF0C1D0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167F5EC", Offset="0x167F5EC", VA="0x167F5EC")]
		public static void AddCurrencyCost(FlatBufferBuilder builder, uint currencyCost)
		{
		}

		[Address(RVA="0x167F628", Offset="0x167F628", VA="0x167F628")]
		public static void AddXpAmount(FlatBufferBuilder builder, uint xpAmount)
		{
		}

		[Address(RVA="0x167F584", Offset="0x167F584", VA="0x167F584")]
		public static Offset<UnitTrainingRecipe> CreateUnitTrainingRecipe(FlatBufferBuilder builder, uint xp_amount = 0, uint currency_cost = 0)
		{
			return new Offset<UnitTrainingRecipe>();
		}

		[Address(RVA="0x167F664", Offset="0x167F664", VA="0x167F664")]
		public static Offset<UnitTrainingRecipe> EndUnitTrainingRecipe(FlatBufferBuilder builder)
		{
			return new Offset<UnitTrainingRecipe>();
		}

		[Address(RVA="0x167F3E0", Offset="0x167F3E0", VA="0x167F3E0")]
		public static UnitTrainingRecipe GetRootAsUnitTrainingRecipe(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitTrainingRecipe();
		}

		[Address(RVA="0x167F3EC", Offset="0x167F3EC", VA="0x167F3EC")]
		public static UnitTrainingRecipe GetRootAsUnitTrainingRecipe(FlatBuffers.ByteBuffer _bb, UnitTrainingRecipe obj)
		{
			return new UnitTrainingRecipe();
		}

		[Address(RVA="0x167F6E4", Offset="0x167F6E4", VA="0x167F6E4")]
		public static void StartUnitTrainingRecipe(FlatBufferBuilder builder)
		{
		}
	}
}