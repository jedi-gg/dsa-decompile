using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitTrainingTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C250", Offset="0xF0C250", VA="0xF0C250", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0C27C", Offset="0xF0C27C", VA="0xF0C27C")]
			get
			{
				return new ulong();
			}
		}

		public int LevelRecipeLength
		{
			[Address(RVA="0xF0C28C", Offset="0xF0C28C", VA="0xF0C28C")]
			get
			{
				return new int();
			}
		}

		public ulong TrainingCurrencyItem
		{
			[Address(RVA="0xF0C29C", Offset="0xF0C29C", VA="0xF0C29C")]
			get
			{
				return new ulong();
			}
		}

		public ulong TrainingMaterial
		{
			[Address(RVA="0xF0C294", Offset="0xF0C294", VA="0xF0C294")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0C264", Offset="0xF0C264", VA="0xF0C264")]
		public UnitTrainingTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitTrainingTable();
		}

		[Address(RVA="0xF0C258", Offset="0xF0C258", VA="0xF0C258", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167FB44", Offset="0x167FB44", VA="0x167FB44")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x167FB80", Offset="0x167FB80", VA="0x167FB80")]
		public static void AddLevelRecipe(FlatBufferBuilder builder, VectorOffset levelRecipeOffset)
		{
		}

		[Address(RVA="0x167FACC", Offset="0x167FACC", VA="0x167FACC")]
		public static void AddTrainingCurrencyItem(FlatBufferBuilder builder, ulong trainingCurrencyItem)
		{
		}

		[Address(RVA="0x167FB08", Offset="0x167FB08", VA="0x167FB08")]
		public static void AddTrainingMaterial(FlatBufferBuilder builder, ulong trainingMaterial)
		{
		}

		[Address(RVA="0x167FC6C", Offset="0x167FC6C", VA="0x167FC6C")]
		public static VectorOffset CreateLevelRecipeVector(FlatBufferBuilder builder, Offset<UnitTrainingRecipe>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x167FA3C", Offset="0x167FA3C", VA="0x167FA3C")]
		public static Offset<UnitTrainingTable> CreateUnitTrainingTable(FlatBufferBuilder builder, ulong id = 0L, VectorOffset level_recipeOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitTrainingTable> Gamedata.UnitTrainingTable::CreateUnitTrainingTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.UInt64,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitTrainingTable> CreateUnitTrainingTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.UInt64,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167FBBC", Offset="0x167FBBC", VA="0x167FBBC")]
		public static Offset<UnitTrainingTable> EndUnitTrainingTable(FlatBufferBuilder builder)
		{
			return new Offset<UnitTrainingTable>();
		}

		[Address(RVA="0x167FDA0", Offset="0x167FDA0", VA="0x167FDA0")]
		public static void FinishUnitTrainingTableBuffer(FlatBufferBuilder builder, Offset<UnitTrainingTable> offset)
		{
		}

		[Address(RVA="0x167F71C", Offset="0x167F71C", VA="0x167F71C")]
		public static UnitTrainingTable GetRootAsUnitTrainingTable(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitTrainingTable();
		}

		[Address(RVA="0x167F728", Offset="0x167F728", VA="0x167F728")]
		public static UnitTrainingTable GetRootAsUnitTrainingTable(FlatBuffers.ByteBuffer _bb, UnitTrainingTable obj)
		{
			return new UnitTrainingTable();
		}

		[Address(RVA="0xF0C284", Offset="0xF0C284", VA="0xF0C284")]
		public UnitTrainingRecipe? LevelRecipe(int j)
		{
			return null;
		}

		[Address(RVA="0x167FD64", Offset="0x167FD64", VA="0x167FD64")]
		public static void StartLevelRecipeVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x167FC3C", Offset="0x167FC3C", VA="0x167FC3C")]
		public static void StartUnitTrainingTable(FlatBufferBuilder builder)
		{
		}
	}
}