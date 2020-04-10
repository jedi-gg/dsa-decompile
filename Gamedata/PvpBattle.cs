using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PvpBattle : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57FE8", Offset="0xF57FE8", VA="0xF57FE8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EnvironmentsLength
		{
			[Address(RVA="0xF58024", Offset="0xF58024", VA="0xF58024")]
			get
			{
				return new int();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58014", Offset="0xF58014", VA="0xF58014")]
			get
			{
				return new ulong();
			}
		}

		public ulong IntroCinematicOverride
		{
			[Address(RVA="0xF5806C", Offset="0xF5806C", VA="0xF5806C")]
			get
			{
				return new ulong();
			}
		}

		public int MutatorsLength
		{
			[Address(RVA="0xF58054", Offset="0xF58054", VA="0xF58054")]
			get
			{
				return new int();
			}
		}

		public string PlayerEncounter
		{
			[Address(RVA="0xF5802C", Offset="0xF5802C", VA="0xF5802C")]
			get
			{
				return null;
			}
		}

		public BattleRuleset Ruleset
		{
			[Address(RVA="0xF58044", Offset="0xF58044", VA="0xF58044")]
			get
			{
				return new BattleRuleset();
			}
		}

		[Address(RVA="0xF57FFC", Offset="0xF57FFC", VA="0xF57FFC")]
		public PvpBattle __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PvpBattle();
		}

		[Address(RVA="0xF57FF0", Offset="0xF57FF0", VA="0xF57FF0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E2518", Offset="0x24E2518", VA="0x24E2518")]
		public static void AddEnvironments(FlatBufferBuilder builder, VectorOffset environmentsOffset)
		{
		}

		[Address(RVA="0x24E2464", Offset="0x24E2464", VA="0x24E2464")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E2428", Offset="0x24E2428", VA="0x24E2428")]
		public static void AddIntroCinematicOverride(FlatBufferBuilder builder, ulong introCinematicOverride)
		{
		}

		[Address(RVA="0x24E24A0", Offset="0x24E24A0", VA="0x24E24A0")]
		public static void AddMutators(FlatBufferBuilder builder, VectorOffset mutatorsOffset)
		{
		}

		[Address(RVA="0x24E24DC", Offset="0x24E24DC", VA="0x24E24DC")]
		public static void AddPlayerEncounter(FlatBufferBuilder builder, StringOffset playerEncounterOffset)
		{
		}

		[Address(RVA="0x24E2554", Offset="0x24E2554", VA="0x24E2554")]
		public static void AddRuleset(FlatBufferBuilder builder, BattleRuleset ruleset)
		{
		}

		[Address(RVA="0x24E2640", Offset="0x24E2640", VA="0x24E2640")]
		public static VectorOffset CreateEnvironmentsVector(FlatBufferBuilder builder, Offset<PvpBattleEnvironmentWeight>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E2774", Offset="0x24E2774", VA="0x24E2774")]
		public static VectorOffset CreateMutatorsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E2370", Offset="0x24E2370", VA="0x24E2370")]
		public static Offset<PvpBattle> CreatePvpBattle(FlatBufferBuilder builder, ulong id = 0L, VectorOffset environmentsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PvpBattle> Gamedata.PvpBattle::CreatePvpBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.BattleRuleset,FlatBuffers.VectorOffset,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PvpBattle> CreatePvpBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.BattleRuleset,FlatBuffers.VectorOffset,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E2590", Offset="0x24E2590", VA="0x24E2590")]
		public static Offset<PvpBattle> EndPvpBattle(FlatBufferBuilder builder)
		{
			return new Offset<PvpBattle>();
		}

		[Address(RVA="0xF5801C", Offset="0xF5801C", VA="0xF5801C")]
		public PvpBattleEnvironmentWeight? Environments(int j)
		{
			return null;
		}

		[Address(RVA="0x24E28A8", Offset="0x24E28A8", VA="0x24E28A8")]
		public static void FinishPvpBattleBuffer(FlatBufferBuilder builder, Offset<PvpBattle> offset)
		{
		}

		[Address(RVA="0xF5805C", Offset="0xF5805C", VA="0xF5805C")]
		public ArraySegment<byte>? GetMutatorsBytes()
		{
			return null;
		}

		[Address(RVA="0xF58034", Offset="0xF58034", VA="0xF58034")]
		public ArraySegment<byte>? GetPlayerEncounterBytes()
		{
			return null;
		}

		[Address(RVA="0x24E1F10", Offset="0x24E1F10", VA="0x24E1F10")]
		public static PvpBattle GetRootAsPvpBattle(FlatBuffers.ByteBuffer _bb)
		{
			return new PvpBattle();
		}

		[Address(RVA="0x24E1F1C", Offset="0x24E1F1C", VA="0x24E1F1C")]
		public static PvpBattle GetRootAsPvpBattle(FlatBuffers.ByteBuffer _bb, PvpBattle obj)
		{
			return new PvpBattle();
		}

		[Address(RVA="0xF5804C", Offset="0xF5804C", VA="0xF5804C")]
		public ulong Mutators(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24E2738", Offset="0x24E2738", VA="0x24E2738")]
		public static void StartEnvironmentsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E286C", Offset="0x24E286C", VA="0x24E286C")]
		public static void StartMutatorsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E2610", Offset="0x24E2610", VA="0x24E2610")]
		public static void StartPvpBattle(FlatBufferBuilder builder)
		{
		}
	}
}