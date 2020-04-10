using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellLevelRecipe : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A180", Offset="0xF3A180", VA="0xF3A180", Slot="5")]
			get
			{
				return null;
			}
		}

		public int IngredientsLength
		{
			[Address(RVA="0xF3A1B4", Offset="0xF3A1B4", VA="0xF3A1B4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3A194", Offset="0xF3A194", VA="0xF3A194")]
		public SpellLevelRecipe __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevelRecipe();
		}

		[Address(RVA="0xF3A188", Offset="0xF3A188", VA="0xF3A188", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DD018", Offset="0x22DD018", VA="0x22DD018")]
		public static void AddIngredients(FlatBufferBuilder builder, VectorOffset ingredientsOffset)
		{
		}

		[Address(RVA="0x22DD104", Offset="0x22DD104", VA="0x22DD104")]
		public static VectorOffset CreateIngredientsVector(FlatBufferBuilder builder, Offset<SpellLevelRecipeIngredient>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DCFC8", Offset="0x22DCFC8", VA="0x22DCFC8")]
		public static Offset<SpellLevelRecipe> CreateSpellLevelRecipe(FlatBufferBuilder builder, VectorOffset ingredientsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SpellLevelRecipe> Gamedata.SpellLevelRecipe::CreateSpellLevelRecipe(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SpellLevelRecipe> CreateSpellLevelRecipe(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DD054", Offset="0x22DD054", VA="0x22DD054")]
		public static Offset<SpellLevelRecipe> EndSpellLevelRecipe(FlatBufferBuilder builder)
		{
			return new Offset<SpellLevelRecipe>();
		}

		[Address(RVA="0x22DCDD4", Offset="0x22DCDD4", VA="0x22DCDD4")]
		public static SpellLevelRecipe GetRootAsSpellLevelRecipe(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevelRecipe();
		}

		[Address(RVA="0x22DCDE0", Offset="0x22DCDE0", VA="0x22DCDE0")]
		public static SpellLevelRecipe GetRootAsSpellLevelRecipe(FlatBuffers.ByteBuffer _bb, SpellLevelRecipe obj)
		{
			return new SpellLevelRecipe();
		}

		[Address(RVA="0xF3A1AC", Offset="0xF3A1AC", VA="0xF3A1AC")]
		public SpellLevelRecipeIngredient? Ingredients(int j)
		{
			return null;
		}

		[Address(RVA="0x22DD1FC", Offset="0x22DD1FC", VA="0x22DD1FC")]
		public static void StartIngredientsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22DD0D4", Offset="0x22DD0D4", VA="0x22DD0D4")]
		public static void StartSpellLevelRecipe(FlatBufferBuilder builder)
		{
		}
	}
}