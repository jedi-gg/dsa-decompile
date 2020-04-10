using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct GearSlotTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A340", Offset="0xF5A340", VA="0xF5A340", Slot="5")]
			get
			{
				return null;
			}
		}

		public GearSlotTableData? Data
		{
			[Address(RVA="0xF5A374", Offset="0xF5A374", VA="0xF5A374")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5A36C", Offset="0xF5A36C", VA="0xF5A36C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5A354", Offset="0xF5A354", VA="0xF5A354")]
		public GearSlotTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTable();
		}

		[Address(RVA="0xF5A348", Offset="0xF5A348", VA="0xF5A348", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2512C80", Offset="0x2512C80", VA="0x2512C80")]
		public static void AddData(FlatBufferBuilder builder, Offset<GearSlotTableData> dataOffset)
		{
		}

		[Address(RVA="0x2512C44", Offset="0x2512C44", VA="0x2512C44")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2512BDC", Offset="0x2512BDC", VA="0x2512BDC")]
		public static Offset<GearSlotTable> CreateGearSlotTable(FlatBufferBuilder builder, ulong id = 0L, Offset<GearSlotTableData> dataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.GearSlotTable> Gamedata.GearSlotTable::CreateGearSlotTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.GearSlotTableData>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.GearSlotTable> CreateGearSlotTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.GearSlotTableData>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2512CBC", Offset="0x2512CBC", VA="0x2512CBC")]
		public static Offset<GearSlotTable> EndGearSlotTable(FlatBufferBuilder builder)
		{
			return new Offset<GearSlotTable>();
		}

		[Address(RVA="0x2512D6C", Offset="0x2512D6C", VA="0x2512D6C")]
		public static void FinishGearSlotTableBuffer(FlatBufferBuilder builder, Offset<GearSlotTable> offset)
		{
		}

		[Address(RVA="0x25129D8", Offset="0x25129D8", VA="0x25129D8")]
		public static GearSlotTable GetRootAsGearSlotTable(FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTable();
		}

		[Address(RVA="0x25129E4", Offset="0x25129E4", VA="0x25129E4")]
		public static GearSlotTable GetRootAsGearSlotTable(FlatBuffers.ByteBuffer _bb, GearSlotTable obj)
		{
			return new GearSlotTable();
		}

		[Address(RVA="0x2512D3C", Offset="0x2512D3C", VA="0x2512D3C")]
		public static void StartGearSlotTable(FlatBufferBuilder builder)
		{
		}
	}
}