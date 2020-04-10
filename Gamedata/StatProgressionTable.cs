using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StatProgressionTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A628", Offset="0xF3A628", VA="0xF3A628", Slot="5")]
			get
			{
				return null;
			}
		}

		public int GrowthAtRarityLength
		{
			[Address(RVA="0xF3A664", Offset="0xF3A664", VA="0xF3A664")]
			get
			{
				return new int();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3A654", Offset="0xF3A654", VA="0xF3A654")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF3A63C", Offset="0xF3A63C", VA="0xF3A63C")]
		public StatProgressionTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StatProgressionTable();
		}

		[Address(RVA="0xF3A630", Offset="0xF3A630", VA="0xF3A630", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DF604", Offset="0x22DF604", VA="0x22DF604")]
		public static void AddGrowthAtRarity(FlatBufferBuilder builder, VectorOffset growthAtRarityOffset)
		{
		}

		[Address(RVA="0x22DF5C8", Offset="0x22DF5C8", VA="0x22DF5C8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22DF6F0", Offset="0x22DF6F0", VA="0x22DF6F0")]
		public static VectorOffset CreateGrowthAtRarityVector(FlatBufferBuilder builder, Offset<StatProgressionTableData>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DF560", Offset="0x22DF560", VA="0x22DF560")]
		public static Offset<StatProgressionTable> CreateStatProgressionTable(FlatBufferBuilder builder, ulong id = 0L, VectorOffset growth_at_rarityOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StatProgressionTable> Gamedata.StatProgressionTable::CreateStatProgressionTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StatProgressionTable> CreateStatProgressionTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DF640", Offset="0x22DF640", VA="0x22DF640")]
		public static Offset<StatProgressionTable> EndStatProgressionTable(FlatBufferBuilder builder)
		{
			return new Offset<StatProgressionTable>();
		}

		[Address(RVA="0x22DF824", Offset="0x22DF824", VA="0x22DF824")]
		public static void FinishStatProgressionTableBuffer(FlatBufferBuilder builder, Offset<StatProgressionTable> offset)
		{
		}

		[Address(RVA="0x22DF300", Offset="0x22DF300", VA="0x22DF300")]
		public static StatProgressionTable GetRootAsStatProgressionTable(FlatBuffers.ByteBuffer _bb)
		{
			return new StatProgressionTable();
		}

		[Address(RVA="0x22DF30C", Offset="0x22DF30C", VA="0x22DF30C")]
		public static StatProgressionTable GetRootAsStatProgressionTable(FlatBuffers.ByteBuffer _bb, StatProgressionTable obj)
		{
			return new StatProgressionTable();
		}

		[Address(RVA="0xF3A65C", Offset="0xF3A65C", VA="0xF3A65C")]
		public StatProgressionTableData? GrowthAtRarity(int j)
		{
			return null;
		}

		[Address(RVA="0x22DF7E8", Offset="0x22DF7E8", VA="0x22DF7E8")]
		public static void StartGrowthAtRarityVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22DF6C0", Offset="0x22DF6C0", VA="0x22DF6C0")]
		public static void StartStatProgressionTable(FlatBufferBuilder builder)
		{
		}
	}
}