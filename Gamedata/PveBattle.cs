using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PveBattle : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int AllyUnitsLength
		{
			[Address(RVA="0xF57D74", Offset="0xF57D74", VA="0xF57D74")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57CF0", Offset="0xF57CF0", VA="0xF57CF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EncountersLength
		{
			[Address(RVA="0xF57D3C", Offset="0xF57D3C", VA="0xF57D3C")]
			get
			{
				return new int();
			}
		}

		public int EnvironmentsLength
		{
			[Address(RVA="0xF57D2C", Offset="0xF57D2C", VA="0xF57D2C")]
			get
			{
				return new int();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF57D1C", Offset="0xF57D1C", VA="0xF57D1C")]
			get
			{
				return new ulong();
			}
		}

		public ulong IntroCinematicOverride
		{
			[Address(RVA="0xF57D7C", Offset="0xF57D7C", VA="0xF57D7C")]
			get
			{
				return new ulong();
			}
		}

		public int MutatorsLength
		{
			[Address(RVA="0xF57D54", Offset="0xF57D54", VA="0xF57D54")]
			get
			{
				return new int();
			}
		}

		public BattleRuleset Ruleset
		{
			[Address(RVA="0xF57D44", Offset="0xF57D44", VA="0xF57D44")]
			get
			{
				return new BattleRuleset();
			}
		}

		[Address(RVA="0xF57D04", Offset="0xF57D04", VA="0xF57D04")]
		public PveBattle __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattle();
		}

		[Address(RVA="0xF57CF8", Offset="0xF57CF8", VA="0xF57CF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E0604", Offset="0x24E0604", VA="0x24E0604")]
		public static void AddAllyUnits(FlatBufferBuilder builder, VectorOffset allyUnitsOffset)
		{
		}

		[Address(RVA="0x24E067C", Offset="0x24E067C", VA="0x24E067C")]
		public static void AddEncounters(FlatBufferBuilder builder, VectorOffset encountersOffset)
		{
		}

		[Address(RVA="0x24E06B8", Offset="0x24E06B8", VA="0x24E06B8")]
		public static void AddEnvironments(FlatBufferBuilder builder, VectorOffset environmentsOffset)
		{
		}

		[Address(RVA="0x24E05C8", Offset="0x24E05C8", VA="0x24E05C8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E058C", Offset="0x24E058C", VA="0x24E058C")]
		public static void AddIntroCinematicOverride(FlatBufferBuilder builder, ulong introCinematicOverride)
		{
		}

		[Address(RVA="0x24E0640", Offset="0x24E0640", VA="0x24E0640")]
		public static void AddMutators(FlatBufferBuilder builder, VectorOffset mutatorsOffset)
		{
		}

		[Address(RVA="0x24E06F4", Offset="0x24E06F4", VA="0x24E06F4")]
		public static void AddRuleset(FlatBufferBuilder builder, BattleRuleset ruleset)
		{
		}

		[Address(RVA="0xF57D6C", Offset="0xF57D6C", VA="0xF57D6C")]
		public AllyUnit? AllyUnits(int j)
		{
			return null;
		}

		[Address(RVA="0x24E0B7C", Offset="0x24E0B7C", VA="0x24E0B7C")]
		public static VectorOffset CreateAllyUnitsVector(FlatBufferBuilder builder, Offset<AllyUnit>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E0914", Offset="0x24E0914", VA="0x24E0914")]
		public static VectorOffset CreateEncountersVector(FlatBufferBuilder builder, Offset<PveBattleEncounter>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E07E0", Offset="0x24E07E0", VA="0x24E07E0")]
		public static VectorOffset CreateEnvironmentsVector(FlatBufferBuilder builder, Offset<PveBattleEnvironmentWeight>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E0A48", Offset="0x24E0A48", VA="0x24E0A48")]
		public static VectorOffset CreateMutatorsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E04C4", Offset="0x24E04C4", VA="0x24E04C4")]
		public static Offset<PveBattle> CreatePveBattle(FlatBufferBuilder builder, ulong id = 0L, VectorOffset environmentsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PveBattle> Gamedata.PveBattle::CreatePveBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,Gamedata.BattleRuleset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PveBattle> CreatePveBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,Gamedata.BattleRuleset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0xF57D34", Offset="0xF57D34", VA="0xF57D34")]
		public PveBattleEncounter? Encounters(int j)
		{
			return null;
		}

		[Address(RVA="0x24E0730", Offset="0x24E0730", VA="0x24E0730")]
		public static Offset<PveBattle> EndPveBattle(FlatBufferBuilder builder)
		{
			return new Offset<PveBattle>();
		}

		[Address(RVA="0xF57D24", Offset="0xF57D24", VA="0xF57D24")]
		public PveBattleEnvironmentWeight? Environments(int j)
		{
			return null;
		}

		[Address(RVA="0x24E0CB0", Offset="0x24E0CB0", VA="0x24E0CB0")]
		public static void FinishPveBattleBuffer(FlatBufferBuilder builder, Offset<PveBattle> offset)
		{
		}

		[Address(RVA="0xF57D5C", Offset="0xF57D5C", VA="0xF57D5C")]
		public ArraySegment<byte>? GetMutatorsBytes()
		{
			return null;
		}

		[Address(RVA="0x24DFE70", Offset="0x24DFE70", VA="0x24DFE70")]
		public static PveBattle GetRootAsPveBattle(FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattle();
		}

		[Address(RVA="0x24DFE7C", Offset="0x24DFE7C", VA="0x24DFE7C")]
		public static PveBattle GetRootAsPveBattle(FlatBuffers.ByteBuffer _bb, PveBattle obj)
		{
			return new PveBattle();
		}

		[Address(RVA="0xF57D4C", Offset="0xF57D4C", VA="0xF57D4C")]
		public ulong Mutators(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24E0C74", Offset="0x24E0C74", VA="0x24E0C74")]
		public static void StartAllyUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E0A0C", Offset="0x24E0A0C", VA="0x24E0A0C")]
		public static void StartEncountersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E08D8", Offset="0x24E08D8", VA="0x24E08D8")]
		public static void StartEnvironmentsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E0B40", Offset="0x24E0B40", VA="0x24E0B40")]
		public static void StartMutatorsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E07B0", Offset="0x24E07B0", VA="0x24E07B0")]
		public static void StartPveBattle(FlatBufferBuilder builder)
		{
		}
	}
}