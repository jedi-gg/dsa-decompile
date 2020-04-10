using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellSpawnableAdd : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong AddUnitDef
		{
			[Address(RVA="0xF3A2BC", Offset="0xF3A2BC", VA="0xF3A2BC")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A290", Offset="0xF3A290", VA="0xF3A290", Slot="5")]
			get
			{
				return null;
			}
		}

		public sbyte MaxCount
		{
			[Address(RVA="0xF3A2C4", Offset="0xF3A2C4", VA="0xF3A2C4")]
			get
			{
				return new sbyte();
			}
		}

		public UnitStats? Stats
		{
			[Address(RVA="0xF3A2CC", Offset="0xF3A2CC", VA="0xF3A2CC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF3A2A4", Offset="0xF3A2A4", VA="0xF3A2A4")]
		public SpellSpawnableAdd __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellSpawnableAdd();
		}

		[Address(RVA="0xF3A298", Offset="0xF3A298", VA="0xF3A298", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DD858", Offset="0x22DD858", VA="0x22DD858")]
		public static void AddAddUnitDef(FlatBufferBuilder builder, ulong addUnitDef)
		{
		}

		[Address(RVA="0x22DD8D0", Offset="0x22DD8D0", VA="0x22DD8D0")]
		public static void AddMaxCount(FlatBufferBuilder builder, sbyte maxCount)
		{
		}

		[Address(RVA="0x22DD894", Offset="0x22DD894", VA="0x22DD894")]
		public static void AddStats(FlatBufferBuilder builder, Offset<UnitStats> statsOffset)
		{
		}

		[Address(RVA="0x22DD7E0", Offset="0x22DD7E0", VA="0x22DD7E0")]
		public static Offset<SpellSpawnableAdd> CreateSpellSpawnableAdd(FlatBufferBuilder builder, ulong add_unit_def = 0L, sbyte max_count = 0, Offset<UnitStats> statsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SpellSpawnableAdd> Gamedata.SpellSpawnableAdd::CreateSpellSpawnableAdd(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,FlatBuffers.Offset`1<Gamedata.UnitStats>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SpellSpawnableAdd> CreateSpellSpawnableAdd(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,FlatBuffers.Offset<Gamedata.UnitStats>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DD90C", Offset="0x22DD90C", VA="0x22DD90C")]
		public static Offset<SpellSpawnableAdd> EndSpellSpawnableAdd(FlatBufferBuilder builder)
		{
			return new Offset<SpellSpawnableAdd>();
		}

		[Address(RVA="0x22DD568", Offset="0x22DD568", VA="0x22DD568")]
		public static SpellSpawnableAdd GetRootAsSpellSpawnableAdd(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellSpawnableAdd();
		}

		[Address(RVA="0x22DD574", Offset="0x22DD574", VA="0x22DD574")]
		public static SpellSpawnableAdd GetRootAsSpellSpawnableAdd(FlatBuffers.ByteBuffer _bb, SpellSpawnableAdd obj)
		{
			return new SpellSpawnableAdd();
		}

		[Address(RVA="0x22DD98C", Offset="0x22DD98C", VA="0x22DD98C")]
		public static void StartSpellSpawnableAdd(FlatBufferBuilder builder)
		{
		}
	}
}