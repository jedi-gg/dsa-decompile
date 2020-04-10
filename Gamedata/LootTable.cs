using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LootTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF566E8", Offset="0xF566E8", VA="0xF566E8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF56714", Offset="0xF56714", VA="0xF56714")]
			get
			{
				return new ulong();
			}
		}

		public int SlotsLength
		{
			[Address(RVA="0xF56724", Offset="0xF56724", VA="0xF56724")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF566FC", Offset="0xF566FC", VA="0xF566FC")]
		public LootTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LootTable();
		}

		[Address(RVA="0xF566F0", Offset="0xF566F0", VA="0xF566F0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D3F44", Offset="0x24D3F44", VA="0x24D3F44")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24D3F80", Offset="0x24D3F80", VA="0x24D3F80")]
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
		}

		[Address(RVA="0x24D3EDC", Offset="0x24D3EDC", VA="0x24D3EDC")]
		public static Offset<LootTable> CreateLootTable(FlatBufferBuilder builder, ulong id = 0L, VectorOffset slotsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LootTable> Gamedata.LootTable::CreateLootTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LootTable> CreateLootTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D406C", Offset="0x24D406C", VA="0x24D406C")]
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, Offset<LootTableSlot>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D3FBC", Offset="0x24D3FBC", VA="0x24D3FBC")]
		public static Offset<LootTable> EndLootTable(FlatBufferBuilder builder)
		{
			return new Offset<LootTable>();
		}

		[Address(RVA="0x24D41A0", Offset="0x24D41A0", VA="0x24D41A0")]
		public static void FinishLootTableBuffer(FlatBufferBuilder builder, Offset<LootTable> offset)
		{
		}

		[Address(RVA="0x24D3C7C", Offset="0x24D3C7C", VA="0x24D3C7C")]
		public static LootTable GetRootAsLootTable(FlatBuffers.ByteBuffer _bb)
		{
			return new LootTable();
		}

		[Address(RVA="0x24D3C88", Offset="0x24D3C88", VA="0x24D3C88")]
		public static LootTable GetRootAsLootTable(FlatBuffers.ByteBuffer _bb, LootTable obj)
		{
			return new LootTable();
		}

		[Address(RVA="0xF5671C", Offset="0xF5671C", VA="0xF5671C")]
		public LootTableSlot? Slots(int j)
		{
			return null;
		}

		[Address(RVA="0x24D403C", Offset="0x24D403C", VA="0x24D403C")]
		public static void StartLootTable(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D4164", Offset="0x24D4164", VA="0x24D4164")]
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}