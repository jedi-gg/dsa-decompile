using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct AllyUnit : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public bool AffectsStarRating
		{
			[Address(RVA="0xF09DB4", Offset="0xF09DB4", VA="0xF09DB4")]
			get
			{
				return new bool();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09D70", Offset="0xF09D70", VA="0xF09D70", Slot="5")]
			get
			{
				return null;
			}
		}

		public sbyte SpawnIndex
		{
			[Address(RVA="0xF09DAC", Offset="0xF09DAC", VA="0xF09DAC")]
			get
			{
				return new sbyte();
			}
		}

		public UnitStatOverride? Stats
		{
			[Address(RVA="0xF09DA4", Offset="0xF09DA4", VA="0xF09DA4")]
			get
			{
				return null;
			}
		}

		public ulong Unit
		{
			[Address(RVA="0xF09D9C", Offset="0xF09D9C", VA="0xF09D9C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF09D84", Offset="0xF09D84", VA="0xF09D84")]
		public AllyUnit __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new AllyUnit();
		}

		[Address(RVA="0xF09D78", Offset="0xF09D78", VA="0xF09D78", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EE59C", Offset="0x15EE59C", VA="0x15EE59C")]
		public static void AddAffectsStarRating(FlatBufferBuilder builder, bool affectsStarRating)
		{
		}

		[Address(RVA="0x15EE5D8", Offset="0x15EE5D8", VA="0x15EE5D8")]
		public static void AddSpawnIndex(FlatBufferBuilder builder, sbyte spawnIndex)
		{
		}

		[Address(RVA="0x15EE560", Offset="0x15EE560", VA="0x15EE560")]
		public static void AddStats(FlatBufferBuilder builder, Offset<UnitStatOverride> statsOffset)
		{
		}

		[Address(RVA="0x15EE524", Offset="0x15EE524", VA="0x15EE524")]
		public static void AddUnit(FlatBufferBuilder builder, ulong unit)
		{
		}

		[Address(RVA="0x15EE494", Offset="0x15EE494", VA="0x15EE494")]
		public static Offset<AllyUnit> CreateAllyUnit(FlatBufferBuilder builder, ulong unit = 0L, Offset<UnitStatOverride> statsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.AllyUnit> Gamedata.AllyUnit::CreateAllyUnit(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.UnitStatOverride>,System.SByte,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.AllyUnit> CreateAllyUnit(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.UnitStatOverride>,System.SByte,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EE614", Offset="0x15EE614", VA="0x15EE614")]
		public static Offset<AllyUnit> EndAllyUnit(FlatBufferBuilder builder)
		{
			return new Offset<AllyUnit>();
		}

		[Address(RVA="0x15EE1B8", Offset="0x15EE1B8", VA="0x15EE1B8")]
		public static AllyUnit GetRootAsAllyUnit(FlatBuffers.ByteBuffer _bb)
		{
			return new AllyUnit();
		}

		[Address(RVA="0x15EE1C4", Offset="0x15EE1C4", VA="0x15EE1C4")]
		public static AllyUnit GetRootAsAllyUnit(FlatBuffers.ByteBuffer _bb, AllyUnit obj)
		{
			return new AllyUnit();
		}

		[Address(RVA="0x15EE694", Offset="0x15EE694", VA="0x15EE694")]
		public static void StartAllyUnit(FlatBufferBuilder builder)
		{
		}
	}
}