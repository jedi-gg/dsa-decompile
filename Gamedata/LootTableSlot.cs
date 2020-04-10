using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LootTableSlot : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56898", Offset="0xF56898", VA="0xF56898", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ItemsLength
		{
			[Address(RVA="0xF568DC", Offset="0xF568DC", VA="0xF568DC")]
			get
			{
				return new int();
			}
		}

		public int LootTablesLength
		{
			[Address(RVA="0xF568CC", Offset="0xF568CC", VA="0xF568CC")]
			get
			{
				return new int();
			}
		}

		public int SpellsLength
		{
			[Address(RVA="0xF568FC", Offset="0xF568FC", VA="0xF568FC")]
			get
			{
				return new int();
			}
		}

		public int UnitsLength
		{
			[Address(RVA="0xF568EC", Offset="0xF568EC", VA="0xF568EC")]
			get
			{
				return new int();
			}
		}

		public bool VipExclusive
		{
			[Address(RVA="0xF56904", Offset="0xF56904", VA="0xF56904")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF568AC", Offset="0xF568AC", VA="0xF568AC")]
		public LootTableSlot __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableSlot();
		}

		[Address(RVA="0xF568A0", Offset="0xF568A0", VA="0xF568A0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D506C", Offset="0x24D506C", VA="0x24D506C")]
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
		}

		[Address(RVA="0x24D50A8", Offset="0x24D50A8", VA="0x24D50A8")]
		public static void AddLootTables(FlatBufferBuilder builder, VectorOffset lootTablesOffset)
		{
		}

		[Address(RVA="0x24D4FF4", Offset="0x24D4FF4", VA="0x24D4FF4")]
		public static void AddSpells(FlatBufferBuilder builder, VectorOffset spellsOffset)
		{
		}

		[Address(RVA="0x24D5030", Offset="0x24D5030", VA="0x24D5030")]
		public static void AddUnits(FlatBufferBuilder builder, VectorOffset unitsOffset)
		{
		}

		[Address(RVA="0x24D50E4", Offset="0x24D50E4", VA="0x24D50E4")]
		public static void AddVipExclusive(FlatBufferBuilder builder, bool vipExclusive)
		{
		}

		[Address(RVA="0x24D5304", Offset="0x24D5304", VA="0x24D5304")]
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<LootTableItem>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D4F54", Offset="0x24D4F54", VA="0x24D4F54")]
		public static Offset<LootTableSlot> CreateLootTableSlot(FlatBufferBuilder builder, VectorOffset loot_tablesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LootTableSlot> Gamedata.LootTableSlot::CreateLootTableSlot(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LootTableSlot> CreateLootTableSlot(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D51D0", Offset="0x24D51D0", VA="0x24D51D0")]
		public static VectorOffset CreateLootTablesVector(FlatBufferBuilder builder, Offset<LootTableSelector>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D556C", Offset="0x24D556C", VA="0x24D556C")]
		public static VectorOffset CreateSpellsVector(FlatBufferBuilder builder, Offset<LootTableSpell>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D5438", Offset="0x24D5438", VA="0x24D5438")]
		public static VectorOffset CreateUnitsVector(FlatBufferBuilder builder, Offset<LootTableUnit>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D5120", Offset="0x24D5120", VA="0x24D5120")]
		public static Offset<LootTableSlot> EndLootTableSlot(FlatBufferBuilder builder)
		{
			return new Offset<LootTableSlot>();
		}

		[Address(RVA="0x24D49E4", Offset="0x24D49E4", VA="0x24D49E4")]
		public static LootTableSlot GetRootAsLootTableSlot(FlatBuffers.ByteBuffer _bb)
		{
			return new LootTableSlot();
		}

		[Address(RVA="0x24D49F0", Offset="0x24D49F0", VA="0x24D49F0")]
		public static LootTableSlot GetRootAsLootTableSlot(FlatBuffers.ByteBuffer _bb, LootTableSlot obj)
		{
			return new LootTableSlot();
		}

		[Address(RVA="0xF568D4", Offset="0xF568D4", VA="0xF568D4")]
		public LootTableItem? Items(int j)
		{
			return null;
		}

		[Address(RVA="0xF568C4", Offset="0xF568C4", VA="0xF568C4")]
		public LootTableSelector? LootTables(int j)
		{
			return null;
		}

		[Address(RVA="0xF568F4", Offset="0xF568F4", VA="0xF568F4")]
		public LootTableSpell? Spells(int j)
		{
			return null;
		}

		[Address(RVA="0x24D53FC", Offset="0x24D53FC", VA="0x24D53FC")]
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D51A0", Offset="0x24D51A0", VA="0x24D51A0")]
		public static void StartLootTableSlot(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D52C8", Offset="0x24D52C8", VA="0x24D52C8")]
		public static void StartLootTablesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D5664", Offset="0x24D5664", VA="0x24D5664")]
		public static void StartSpellsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D5530", Offset="0x24D5530", VA="0x24D5530")]
		public static void StartUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF568E4", Offset="0xF568E4", VA="0xF568E4")]
		public LootTableUnit? Units(int j)
		{
			return null;
		}
	}
}