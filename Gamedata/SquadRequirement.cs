using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SquadRequirement : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A448", Offset="0xF3A448", VA="0xF3A448", Slot="5")]
			get
			{
				return null;
			}
		}

		public UnitFilter? RequiredUnitFilter
		{
			[Address(RVA="0xF3A4B4", Offset="0xF3A4B4", VA="0xF3A4B4")]
			get
			{
				return null;
			}
		}

		public uint RequiredUnitFilterCount
		{
			[Address(RVA="0xF3A4BC", Offset="0xF3A4BC", VA="0xF3A4BC")]
			get
			{
				return new uint();
			}
		}

		public int SpellsLength
		{
			[Address(RVA="0xF3A49C", Offset="0xF3A49C", VA="0xF3A49C")]
			get
			{
				return new int();
			}
		}

		public int UnitsLength
		{
			[Address(RVA="0xF3A47C", Offset="0xF3A47C", VA="0xF3A47C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3A45C", Offset="0xF3A45C", VA="0xF3A45C")]
		public SquadRequirement __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SquadRequirement();
		}

		[Address(RVA="0xF3A450", Offset="0xF3A450", VA="0xF3A450", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DE698", Offset="0x22DE698", VA="0x22DE698")]
		public static void AddRequiredUnitFilter(FlatBufferBuilder builder, Offset<UnitFilter> requiredUnitFilterOffset)
		{
		}

		[Address(RVA="0x22DE65C", Offset="0x22DE65C", VA="0x22DE65C")]
		public static void AddRequiredUnitFilterCount(FlatBufferBuilder builder, uint requiredUnitFilterCount)
		{
		}

		[Address(RVA="0x22DE6D4", Offset="0x22DE6D4", VA="0x22DE6D4")]
		public static void AddSpells(FlatBufferBuilder builder, VectorOffset spellsOffset)
		{
		}

		[Address(RVA="0x22DE710", Offset="0x22DE710", VA="0x22DE710")]
		public static void AddUnits(FlatBufferBuilder builder, VectorOffset unitsOffset)
		{
		}

		[Address(RVA="0x22DE930", Offset="0x22DE930", VA="0x22DE930")]
		public static VectorOffset CreateSpellsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DE5CC", Offset="0x22DE5CC", VA="0x22DE5CC")]
		public static Offset<SquadRequirement> CreateSquadRequirement(FlatBufferBuilder builder, VectorOffset unitsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SquadRequirement> Gamedata.SquadRequirement::CreateSquadRequirement(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.Offset`1<Gamedata.UnitFilter>,System.UInt32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SquadRequirement> CreateSquadRequirement(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.Offset<Gamedata.UnitFilter>,System.UInt32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DE7FC", Offset="0x22DE7FC", VA="0x22DE7FC")]
		public static VectorOffset CreateUnitsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DE74C", Offset="0x22DE74C", VA="0x22DE74C")]
		public static Offset<SquadRequirement> EndSquadRequirement(FlatBufferBuilder builder)
		{
			return new Offset<SquadRequirement>();
		}

		[Address(RVA="0x22DE218", Offset="0x22DE218", VA="0x22DE218")]
		public static SquadRequirement GetRootAsSquadRequirement(FlatBuffers.ByteBuffer _bb)
		{
			return new SquadRequirement();
		}

		[Address(RVA="0x22DE224", Offset="0x22DE224", VA="0x22DE224")]
		public static SquadRequirement GetRootAsSquadRequirement(FlatBuffers.ByteBuffer _bb, SquadRequirement obj)
		{
			return new SquadRequirement();
		}

		[Address(RVA="0xF3A4A4", Offset="0xF3A4A4", VA="0xF3A4A4")]
		public ArraySegment<byte>? GetSpellsBytes()
		{
			return null;
		}

		[Address(RVA="0xF3A484", Offset="0xF3A484", VA="0xF3A484")]
		public ArraySegment<byte>? GetUnitsBytes()
		{
			return null;
		}

		[Address(RVA="0xF3A494", Offset="0xF3A494", VA="0xF3A494")]
		public ulong Spells(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x22DEA28", Offset="0x22DEA28", VA="0x22DEA28")]
		public static void StartSpellsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22DE7CC", Offset="0x22DE7CC", VA="0x22DE7CC")]
		public static void StartSquadRequirement(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x22DE8F4", Offset="0x22DE8F4", VA="0x22DE8F4")]
		public static void StartUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF3A474", Offset="0xF3A474", VA="0xF3A474")]
		public ulong Units(int j)
		{
			return new ulong();
		}
	}
}