using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PveBattleEncounter : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong BattleCinematic
		{
			[Address(RVA="0xF57E3C", Offset="0xF57E3C", VA="0xF57E3C")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57DD0", Offset="0xF57DD0", VA="0xF57DD0", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Cinematic
		{
			[Address(RVA="0xF57E24", Offset="0xF57E24", VA="0xF57E24")]
			get
			{
				return null;
			}
		}

		public string Encounter
		{
			[Address(RVA="0xF57DFC", Offset="0xF57DFC", VA="0xF57DFC")]
			get
			{
				return null;
			}
		}

		public int SquadsLength
		{
			[Address(RVA="0xF57E1C", Offset="0xF57E1C", VA="0xF57E1C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF57DE4", Offset="0xF57DE4", VA="0xF57DE4")]
		public PveBattleEncounter __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattleEncounter();
		}

		[Address(RVA="0xF57DD8", Offset="0xF57DD8", VA="0xF57DD8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E1074", Offset="0x24E1074", VA="0x24E1074")]
		public static void AddBattleCinematic(FlatBufferBuilder builder, ulong battleCinematic)
		{
		}

		[Address(RVA="0x24E10B0", Offset="0x24E10B0", VA="0x24E10B0")]
		public static void AddCinematic(FlatBufferBuilder builder, StringOffset cinematicOffset)
		{
		}

		[Address(RVA="0x24E1128", Offset="0x24E1128", VA="0x24E1128")]
		public static void AddEncounter(FlatBufferBuilder builder, StringOffset encounterOffset)
		{
		}

		[Address(RVA="0x24E10EC", Offset="0x24E10EC", VA="0x24E10EC")]
		public static void AddSquads(FlatBufferBuilder builder, VectorOffset squadsOffset)
		{
		}

		[Address(RVA="0x24E0FE4", Offset="0x24E0FE4", VA="0x24E0FE4")]
		public static Offset<PveBattleEncounter> CreatePveBattleEncounter(FlatBufferBuilder builder, StringOffset encounterOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PveBattleEncounter> Gamedata.PveBattleEncounter::CreatePveBattleEncounter(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PveBattleEncounter> CreatePveBattleEncounter(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E1214", Offset="0x24E1214", VA="0x24E1214")]
		public static VectorOffset CreateSquadsVector(FlatBufferBuilder builder, Offset<PveBattleSquad>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E1164", Offset="0x24E1164", VA="0x24E1164")]
		public static Offset<PveBattleEncounter> EndPveBattleEncounter(FlatBufferBuilder builder)
		{
			return new Offset<PveBattleEncounter>();
		}

		[Address(RVA="0xF57E2C", Offset="0xF57E2C", VA="0xF57E2C")]
		public ArraySegment<byte>? GetCinematicBytes()
		{
			return null;
		}

		[Address(RVA="0xF57E04", Offset="0xF57E04", VA="0xF57E04")]
		public ArraySegment<byte>? GetEncounterBytes()
		{
			return null;
		}

		[Address(RVA="0x24E0CEC", Offset="0x24E0CEC", VA="0x24E0CEC")]
		public static PveBattleEncounter GetRootAsPveBattleEncounter(FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattleEncounter();
		}

		[Address(RVA="0x24E0CF8", Offset="0x24E0CF8", VA="0x24E0CF8")]
		public static PveBattleEncounter GetRootAsPveBattleEncounter(FlatBuffers.ByteBuffer _bb, PveBattleEncounter obj)
		{
			return new PveBattleEncounter();
		}

		[Address(RVA="0xF57E14", Offset="0xF57E14", VA="0xF57E14")]
		public PveBattleSquad? Squads(int j)
		{
			return null;
		}

		[Address(RVA="0x24E11E4", Offset="0x24E11E4", VA="0x24E11E4")]
		public static void StartPveBattleEncounter(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24E130C", Offset="0x24E130C", VA="0x24E130C")]
		public static void StartSquadsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}