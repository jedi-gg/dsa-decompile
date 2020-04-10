using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitPromotionTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BBF0", Offset="0xF0BBF0", VA="0xF0BBF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0BC1C", Offset="0xF0BC1C", VA="0xF0BC1C")]
			get
			{
				return new ulong();
			}
		}

		public ulong PromotionCurrencyItem
		{
			[Address(RVA="0xF0BC3C", Offset="0xF0BC3C", VA="0xF0BC3C")]
			get
			{
				return new ulong();
			}
		}

		public int RarityLevelRecipeLength
		{
			[Address(RVA="0xF0BC2C", Offset="0xF0BC2C", VA="0xF0BC2C")]
			get
			{
				return new int();
			}
		}

		public bool UnlockIgnoresCurrencyCost
		{
			[Address(RVA="0xF0BC34", Offset="0xF0BC34", VA="0xF0BC34")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF0BC04", Offset="0xF0BC04", VA="0xF0BC04")]
		public UnitPromotionTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitPromotionTable();
		}

		[Address(RVA="0xF0BBF8", Offset="0xF0BBF8", VA="0xF0BBF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167C5A8", Offset="0x167C5A8", VA="0x167C5A8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x167C56C", Offset="0x167C56C", VA="0x167C56C")]
		public static void AddPromotionCurrencyItem(FlatBufferBuilder builder, ulong promotionCurrencyItem)
		{
		}

		[Address(RVA="0x167C5E4", Offset="0x167C5E4", VA="0x167C5E4")]
		public static void AddRarityLevelRecipe(FlatBufferBuilder builder, VectorOffset rarityLevelRecipeOffset)
		{
		}

		[Address(RVA="0x167C620", Offset="0x167C620", VA="0x167C620")]
		public static void AddUnlockIgnoresCurrencyCost(FlatBufferBuilder builder, bool unlockIgnoresCurrencyCost)
		{
		}

		[Address(RVA="0x167C70C", Offset="0x167C70C", VA="0x167C70C")]
		public static VectorOffset CreateRarityLevelRecipeVector(FlatBufferBuilder builder, Offset<UnitPromotionRecipe>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x167C4DC", Offset="0x167C4DC", VA="0x167C4DC")]
		public static Offset<UnitPromotionTable> CreateUnitPromotionTable(FlatBufferBuilder builder, ulong id = 0L, VectorOffset rarity_level_recipeOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitPromotionTable> Gamedata.UnitPromotionTable::CreateUnitPromotionTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.Boolean,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitPromotionTable> CreateUnitPromotionTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.Boolean,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167C65C", Offset="0x167C65C", VA="0x167C65C")]
		public static Offset<UnitPromotionTable> EndUnitPromotionTable(FlatBufferBuilder builder)
		{
			return new Offset<UnitPromotionTable>();
		}

		[Address(RVA="0x167C840", Offset="0x167C840", VA="0x167C840")]
		public static void FinishUnitPromotionTableBuffer(FlatBufferBuilder builder, Offset<UnitPromotionTable> offset)
		{
		}

		[Address(RVA="0x167C1C4", Offset="0x167C1C4", VA="0x167C1C4")]
		public static UnitPromotionTable GetRootAsUnitPromotionTable(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitPromotionTable();
		}

		[Address(RVA="0x167C1D0", Offset="0x167C1D0", VA="0x167C1D0")]
		public static UnitPromotionTable GetRootAsUnitPromotionTable(FlatBuffers.ByteBuffer _bb, UnitPromotionTable obj)
		{
			return new UnitPromotionTable();
		}

		[Address(RVA="0xF0BC24", Offset="0xF0BC24", VA="0xF0BC24")]
		public UnitPromotionRecipe? RarityLevelRecipe(int j)
		{
			return null;
		}

		[Address(RVA="0x167C804", Offset="0x167C804", VA="0x167C804")]
		public static void StartRarityLevelRecipeVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x167C6DC", Offset="0x167C6DC", VA="0x167C6DC")]
		public static void StartUnitPromotionTable(FlatBufferBuilder builder)
		{
		}
	}
}