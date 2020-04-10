using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellFilter : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF593B8", Offset="0xF593B8", VA="0xF593B8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int CategoriesLength
		{
			[Address(RVA="0xF593F4", Offset="0xF593F4", VA="0xF593F4")]
			get
			{
				return new int();
			}
		}

		public uint Level
		{
			[Address(RVA="0xF593E4", Offset="0xF593E4", VA="0xF593E4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF593CC", Offset="0xF593CC", VA="0xF593CC")]
		public SpellFilter __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellFilter();
		}

		[Address(RVA="0xF593C0", Offset="0xF593C0", VA="0xF593C0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EE438", Offset="0x24EE438", VA="0x24EE438")]
		public static void AddCategories(FlatBufferBuilder builder, VectorOffset categoriesOffset)
		{
		}

		[Address(RVA="0x24EE474", Offset="0x24EE474", VA="0x24EE474")]
		public static void AddLevel(FlatBufferBuilder builder, uint level)
		{
		}

		[Address(RVA="0xF593EC", Offset="0xF593EC", VA="0xF593EC")]
		public ulong Categories(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24EE560", Offset="0x24EE560", VA="0x24EE560")]
		public static VectorOffset CreateCategoriesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24EE3D0", Offset="0x24EE3D0", VA="0x24EE3D0")]
		public static Offset<SpellFilter> CreateSpellFilter(FlatBufferBuilder builder, uint level = 0, VectorOffset categoriesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SpellFilter> Gamedata.SpellFilter::CreateSpellFilter(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SpellFilter> CreateSpellFilter(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EE4B0", Offset="0x24EE4B0", VA="0x24EE4B0")]
		public static Offset<SpellFilter> EndSpellFilter(FlatBufferBuilder builder)
		{
			return new Offset<SpellFilter>();
		}

		[Address(RVA="0xF593FC", Offset="0xF593FC", VA="0xF593FC")]
		public ArraySegment<byte>? GetCategoriesBytes()
		{
			return null;
		}

		[Address(RVA="0x24EE1C0", Offset="0x24EE1C0", VA="0x24EE1C0")]
		public static SpellFilter GetRootAsSpellFilter(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellFilter();
		}

		[Address(RVA="0x24EE1CC", Offset="0x24EE1CC", VA="0x24EE1CC")]
		public static SpellFilter GetRootAsSpellFilter(FlatBuffers.ByteBuffer _bb, SpellFilter obj)
		{
			return new SpellFilter();
		}

		[Address(RVA="0x24EE658", Offset="0x24EE658", VA="0x24EE658")]
		public static void StartCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24EE530", Offset="0x24EE530", VA="0x24EE530")]
		public static void StartSpellFilter(FlatBufferBuilder builder)
		{
		}
	}
}