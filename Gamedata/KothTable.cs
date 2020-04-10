using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF562B0", Offset="0xF562B0", VA="0xF562B0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF562DC", Offset="0xF562DC", VA="0xF562DC")]
			get
			{
				return new ulong();
			}
		}

		public int RankDataLength
		{
			[Address(RVA="0xF562EC", Offset="0xF562EC", VA="0xF562EC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF562C4", Offset="0xF562C4", VA="0xF562C4")]
		public KothTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothTable();
		}

		[Address(RVA="0xF562B8", Offset="0xF562B8", VA="0xF562B8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D1FA8", Offset="0x24D1FA8", VA="0x24D1FA8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24D1FE4", Offset="0x24D1FE4", VA="0x24D1FE4")]
		public static void AddRankData(FlatBufferBuilder builder, VectorOffset rankDataOffset)
		{
		}

		[Address(RVA="0x24D1F40", Offset="0x24D1F40", VA="0x24D1F40")]
		public static Offset<KothTable> CreateKothTable(FlatBufferBuilder builder, ulong id = 0L, VectorOffset rank_dataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.KothTable> Gamedata.KothTable::CreateKothTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.KothTable> CreateKothTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D20D0", Offset="0x24D20D0", VA="0x24D20D0")]
		public static VectorOffset CreateRankDataVector(FlatBufferBuilder builder, Offset<KothRankData>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D2020", Offset="0x24D2020", VA="0x24D2020")]
		public static Offset<KothTable> EndKothTable(FlatBufferBuilder builder)
		{
			return new Offset<KothTable>();
		}

		[Address(RVA="0x24D2204", Offset="0x24D2204", VA="0x24D2204")]
		public static void FinishKothTableBuffer(FlatBufferBuilder builder, Offset<KothTable> offset)
		{
		}

		[Address(RVA="0x24D1CD4", Offset="0x24D1CD4", VA="0x24D1CD4")]
		public static KothTable GetRootAsKothTable(FlatBuffers.ByteBuffer _bb)
		{
			return new KothTable();
		}

		[Address(RVA="0x24D1CE0", Offset="0x24D1CE0", VA="0x24D1CE0")]
		public static KothTable GetRootAsKothTable(FlatBuffers.ByteBuffer _bb, KothTable obj)
		{
			return new KothTable();
		}

		[Address(RVA="0xF562E4", Offset="0xF562E4", VA="0xF562E4")]
		public KothRankData? RankData(int j)
		{
			return null;
		}

		[Address(RVA="0x24D20A0", Offset="0x24D20A0", VA="0x24D20A0")]
		public static void StartKothTable(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D21C8", Offset="0x24D21C8", VA="0x24D21C8")]
		public static void StartRankDataVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}