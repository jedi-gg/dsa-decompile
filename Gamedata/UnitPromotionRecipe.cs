using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitPromotionRecipe : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BB68", Offset="0xF0BB68", VA="0xF0BB68", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint CurrencyCost
		{
			[Address(RVA="0xF0BB9C", Offset="0xF0BB9C", VA="0xF0BB9C")]
			get
			{
				return new uint();
			}
		}

		public uint PromotionMaterialCount
		{
			[Address(RVA="0xF0BB94", Offset="0xF0BB94", VA="0xF0BB94")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF0BB7C", Offset="0xF0BB7C", VA="0xF0BB7C")]
		public UnitPromotionRecipe __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitPromotionRecipe();
		}

		[Address(RVA="0xF0BB70", Offset="0xF0BB70", VA="0xF0BB70", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167C094", Offset="0x167C094", VA="0x167C094")]
		public static void AddCurrencyCost(FlatBufferBuilder builder, uint currencyCost)
		{
		}

		[Address(RVA="0x167C0D0", Offset="0x167C0D0", VA="0x167C0D0")]
		public static void AddPromotionMaterialCount(FlatBufferBuilder builder, uint promotionMaterialCount)
		{
		}

		[Address(RVA="0x167C02C", Offset="0x167C02C", VA="0x167C02C")]
		public static Offset<UnitPromotionRecipe> CreateUnitPromotionRecipe(FlatBufferBuilder builder, uint promotion_material_count = 0, uint currency_cost = 0)
		{
			return new Offset<UnitPromotionRecipe>();
		}

		[Address(RVA="0x167C10C", Offset="0x167C10C", VA="0x167C10C")]
		public static Offset<UnitPromotionRecipe> EndUnitPromotionRecipe(FlatBufferBuilder builder)
		{
			return new Offset<UnitPromotionRecipe>();
		}

		[Address(RVA="0x167BE88", Offset="0x167BE88", VA="0x167BE88")]
		public static UnitPromotionRecipe GetRootAsUnitPromotionRecipe(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitPromotionRecipe();
		}

		[Address(RVA="0x167BE94", Offset="0x167BE94", VA="0x167BE94")]
		public static UnitPromotionRecipe GetRootAsUnitPromotionRecipe(FlatBuffers.ByteBuffer _bb, UnitPromotionRecipe obj)
		{
			return new UnitPromotionRecipe();
		}

		[Address(RVA="0x167C18C", Offset="0x167C18C", VA="0x167C18C")]
		public static void StartUnitPromotionRecipe(FlatBufferBuilder builder)
		{
		}
	}
}