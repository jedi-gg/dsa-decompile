using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitAbilityRecipe : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B5F8", Offset="0xF0B5F8", VA="0xF0B5F8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int IngredientsLength
		{
			[Address(RVA="0xF0B62C", Offset="0xF0B62C", VA="0xF0B62C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0B60C", Offset="0xF0B60C", VA="0xF0B60C")]
		public UnitAbilityRecipe __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityRecipe();
		}

		[Address(RVA="0xF0B600", Offset="0xF0B600", VA="0xF0B600", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x16790D8", Offset="0x16790D8", VA="0x16790D8")]
		public static void AddIngredients(FlatBufferBuilder builder, VectorOffset ingredientsOffset)
		{
		}

		[Address(RVA="0x16791C4", Offset="0x16791C4", VA="0x16791C4")]
		public static VectorOffset CreateIngredientsVector(FlatBufferBuilder builder, Offset<UnitAbilityRecipeIngredient>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1679088", Offset="0x1679088", VA="0x1679088")]
		public static Offset<UnitAbilityRecipe> CreateUnitAbilityRecipe(FlatBufferBuilder builder, VectorOffset ingredientsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitAbilityRecipe> Gamedata.UnitAbilityRecipe::CreateUnitAbilityRecipe(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitAbilityRecipe> CreateUnitAbilityRecipe(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1679114", Offset="0x1679114", VA="0x1679114")]
		public static Offset<UnitAbilityRecipe> EndUnitAbilityRecipe(FlatBufferBuilder builder)
		{
			return new Offset<UnitAbilityRecipe>();
		}

		[Address(RVA="0x1678EAC", Offset="0x1678EAC", VA="0x1678EAC")]
		public static UnitAbilityRecipe GetRootAsUnitAbilityRecipe(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityRecipe();
		}

		[Address(RVA="0x1678EB8", Offset="0x1678EB8", VA="0x1678EB8")]
		public static UnitAbilityRecipe GetRootAsUnitAbilityRecipe(FlatBuffers.ByteBuffer _bb, UnitAbilityRecipe obj)
		{
			return new UnitAbilityRecipe();
		}

		[Address(RVA="0xF0B624", Offset="0xF0B624", VA="0xF0B624")]
		public UnitAbilityRecipeIngredient? Ingredients(int j)
		{
			return null;
		}

		[Address(RVA="0x16792BC", Offset="0x16792BC", VA="0x16792BC")]
		public static void StartIngredientsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1679194", Offset="0x1679194", VA="0x1679194")]
		public static void StartUnitAbilityRecipe(FlatBufferBuilder builder)
		{
		}
	}
}