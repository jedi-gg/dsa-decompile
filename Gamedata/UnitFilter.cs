using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitFilter : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B890", Offset="0xF0B890", VA="0xF0B890", Slot="5")]
			get
			{
				return null;
			}
		}

		public int CategoriesLength
		{
			[Address(RVA="0xF0B8DC", Offset="0xF0B8DC", VA="0xF0B8DC")]
			get
			{
				return new int();
			}
		}

		public uint GearTier
		{
			[Address(RVA="0xF0B8C4", Offset="0xF0B8C4", VA="0xF0B8C4")]
			get
			{
				return new uint();
			}
		}

		public uint Level
		{
			[Address(RVA="0xF0B8BC", Offset="0xF0B8BC", VA="0xF0B8BC")]
			get
			{
				return new uint();
			}
		}

		public uint Rarity
		{
			[Address(RVA="0xF0B8CC", Offset="0xF0B8CC", VA="0xF0B8CC")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF0B8A4", Offset="0xF0B8A4", VA="0xF0B8A4")]
		public UnitFilter __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitFilter();
		}

		[Address(RVA="0xF0B898", Offset="0xF0B898", VA="0xF0B898", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167A70C", Offset="0x167A70C", VA="0x167A70C")]
		public static void AddCategories(FlatBufferBuilder builder, VectorOffset categoriesOffset)
		{
		}

		[Address(RVA="0x167A784", Offset="0x167A784", VA="0x167A784")]
		public static void AddGearTier(FlatBufferBuilder builder, uint gearTier)
		{
		}

		[Address(RVA="0x167A7C0", Offset="0x167A7C0", VA="0x167A7C0")]
		public static void AddLevel(FlatBufferBuilder builder, uint level)
		{
		}

		[Address(RVA="0x167A748", Offset="0x167A748", VA="0x167A748")]
		public static void AddRarity(FlatBufferBuilder builder, uint rarity)
		{
		}

		[Address(RVA="0xF0B8D4", Offset="0xF0B8D4", VA="0xF0B8D4")]
		public ulong Categories(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x167A8AC", Offset="0x167A8AC", VA="0x167A8AC")]
		public static VectorOffset CreateCategoriesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x167A67C", Offset="0x167A67C", VA="0x167A67C")]
		public static Offset<UnitFilter> CreateUnitFilter(FlatBufferBuilder builder, uint level = 0, uint gear_tier = 0, uint rarity = 0, VectorOffset categoriesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitFilter> Gamedata.UnitFilter::CreateUnitFilter(FlatBuffers.FlatBufferBuilder,System.UInt32,System.UInt32,System.UInt32,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitFilter> CreateUnitFilter(FlatBuffers.FlatBufferBuilder,System.UInt32,System.UInt32,System.UInt32,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167A7FC", Offset="0x167A7FC", VA="0x167A7FC")]
		public static Offset<UnitFilter> EndUnitFilter(FlatBufferBuilder builder)
		{
			return new Offset<UnitFilter>();
		}

		[Address(RVA="0xF0B8E4", Offset="0xF0B8E4", VA="0xF0B8E4")]
		public ArraySegment<byte>? GetCategoriesBytes()
		{
			return null;
		}

		[Address(RVA="0x167A39C", Offset="0x167A39C", VA="0x167A39C")]
		public static UnitFilter GetRootAsUnitFilter(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitFilter();
		}

		[Address(RVA="0x167A3A8", Offset="0x167A3A8", VA="0x167A3A8")]
		public static UnitFilter GetRootAsUnitFilter(FlatBuffers.ByteBuffer _bb, UnitFilter obj)
		{
			return new UnitFilter();
		}

		[Address(RVA="0x167A9A4", Offset="0x167A9A4", VA="0x167A9A4")]
		public static void StartCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x167A87C", Offset="0x167A87C", VA="0x167A87C")]
		public static void StartUnitFilter(FlatBufferBuilder builder)
		{
		}
	}
}