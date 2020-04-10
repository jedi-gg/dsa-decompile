using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct InventoryItemRecipe : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5AB58", Offset="0xF5AB58", VA="0xF5AB58", Slot="5")]
			get
			{
				return null;
			}
		}

		public int IngredientsLength
		{
			[Address(RVA="0xF5AB8C", Offset="0xF5AB8C", VA="0xF5AB8C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5AB6C", Offset="0xF5AB6C", VA="0xF5AB6C")]
		public InventoryItemRecipe __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new InventoryItemRecipe();
		}

		[Address(RVA="0xF5AB60", Offset="0xF5AB60", VA="0xF5AB60", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x251816C", Offset="0x251816C", VA="0x251816C")]
		public static void AddIngredients(FlatBufferBuilder builder, VectorOffset ingredientsOffset)
		{
		}

		[Address(RVA="0x2518258", Offset="0x2518258", VA="0x2518258")]
		public static VectorOffset CreateIngredientsVector(FlatBufferBuilder builder, Offset<InventoryItemRecipeIngredient>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x251811C", Offset="0x251811C", VA="0x251811C")]
		public static Offset<InventoryItemRecipe> CreateInventoryItemRecipe(FlatBufferBuilder builder, VectorOffset ingredientsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.InventoryItemRecipe> Gamedata.InventoryItemRecipe::CreateInventoryItemRecipe(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.InventoryItemRecipe> CreateInventoryItemRecipe(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x25181A8", Offset="0x25181A8", VA="0x25181A8")]
		public static Offset<InventoryItemRecipe> EndInventoryItemRecipe(FlatBufferBuilder builder)
		{
			return new Offset<InventoryItemRecipe>();
		}

		[Address(RVA="0x2517F40", Offset="0x2517F40", VA="0x2517F40")]
		public static InventoryItemRecipe GetRootAsInventoryItemRecipe(FlatBuffers.ByteBuffer _bb)
		{
			return new InventoryItemRecipe();
		}

		[Address(RVA="0x2517F4C", Offset="0x2517F4C", VA="0x2517F4C")]
		public static InventoryItemRecipe GetRootAsInventoryItemRecipe(FlatBuffers.ByteBuffer _bb, InventoryItemRecipe obj)
		{
			return new InventoryItemRecipe();
		}

		[Address(RVA="0xF5AB84", Offset="0xF5AB84", VA="0xF5AB84")]
		public InventoryItemRecipeIngredient? Ingredients(int j)
		{
			return null;
		}

		[Address(RVA="0x2518350", Offset="0x2518350", VA="0x2518350")]
		public static void StartIngredientsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2518228", Offset="0x2518228", VA="0x2518228")]
		public static void StartInventoryItemRecipe(FlatBufferBuilder builder)
		{
		}
	}
}