using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarBattle : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43CF4", Offset="0xF43CF4", VA="0xF43CF4", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EnvironmentsLength
		{
			[Address(RVA="0xF43D30", Offset="0xF43D30", VA="0xF43D30")]
			get
			{
				return new int();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF43D20", Offset="0xF43D20", VA="0xF43D20")]
			get
			{
				return new ulong();
			}
		}

		public int MutatorsLength
		{
			[Address(RVA="0xF43D60", Offset="0xF43D60", VA="0xF43D60")]
			get
			{
				return new int();
			}
		}

		public string PlayerEncounter
		{
			[Address(RVA="0xF43D38", Offset="0xF43D38", VA="0xF43D38")]
			get
			{
				return null;
			}
		}

		public BattleRuleset Ruleset
		{
			[Address(RVA="0xF43D50", Offset="0xF43D50", VA="0xF43D50")]
			get
			{
				return new BattleRuleset();
			}
		}

		[Address(RVA="0xF43D08", Offset="0xF43D08", VA="0xF43D08")]
		public ClubWarBattle __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarBattle();
		}

		[Address(RVA="0xF43CFC", Offset="0xF43CFC", VA="0xF43CFC", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2325850", Offset="0x2325850", VA="0x2325850")]
		public static void AddEnvironments(FlatBufferBuilder builder, VectorOffset environmentsOffset)
		{
		}

		[Address(RVA="0x232579C", Offset="0x232579C", VA="0x232579C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x23257D8", Offset="0x23257D8", VA="0x23257D8")]
		public static void AddMutators(FlatBufferBuilder builder, VectorOffset mutatorsOffset)
		{
		}

		[Address(RVA="0x2325814", Offset="0x2325814", VA="0x2325814")]
		public static void AddPlayerEncounter(FlatBufferBuilder builder, StringOffset playerEncounterOffset)
		{
		}

		[Address(RVA="0x232588C", Offset="0x232588C", VA="0x232588C")]
		public static void AddRuleset(FlatBufferBuilder builder, BattleRuleset ruleset)
		{
		}

		[Address(RVA="0x23256FC", Offset="0x23256FC", VA="0x23256FC")]
		public static Offset<ClubWarBattle> CreateClubWarBattle(FlatBufferBuilder builder, ulong id = 0L, VectorOffset environmentsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubWarBattle> Gamedata.ClubWarBattle::CreateClubWarBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.BattleRuleset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubWarBattle> CreateClubWarBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.BattleRuleset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2325978", Offset="0x2325978", VA="0x2325978")]
		public static VectorOffset CreateEnvironmentsVector(FlatBufferBuilder builder, Offset<ClubWarBattleEnvironmentWeight>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2325AAC", Offset="0x2325AAC", VA="0x2325AAC")]
		public static VectorOffset CreateMutatorsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23258C8", Offset="0x23258C8", VA="0x23258C8")]
		public static Offset<ClubWarBattle> EndClubWarBattle(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarBattle>();
		}

		[Address(RVA="0xF43D28", Offset="0xF43D28", VA="0xF43D28")]
		public ClubWarBattleEnvironmentWeight? Environments(int j)
		{
			return null;
		}

		[Address(RVA="0x2325BE0", Offset="0x2325BE0", VA="0x2325BE0")]
		public static void FinishClubWarBattleBuffer(FlatBufferBuilder builder, Offset<ClubWarBattle> offset)
		{
		}

		[Address(RVA="0xF43D68", Offset="0xF43D68", VA="0xF43D68")]
		public ArraySegment<byte>? GetMutatorsBytes()
		{
			return null;
		}

		[Address(RVA="0xF43D40", Offset="0xF43D40", VA="0xF43D40")]
		public ArraySegment<byte>? GetPlayerEncounterBytes()
		{
			return null;
		}

		[Address(RVA="0x2325308", Offset="0x2325308", VA="0x2325308")]
		public static ClubWarBattle GetRootAsClubWarBattle(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarBattle();
		}

		[Address(RVA="0x2325314", Offset="0x2325314", VA="0x2325314")]
		public static ClubWarBattle GetRootAsClubWarBattle(FlatBuffers.ByteBuffer _bb, ClubWarBattle obj)
		{
			return new ClubWarBattle();
		}

		[Address(RVA="0xF43D58", Offset="0xF43D58", VA="0xF43D58")]
		public ulong Mutators(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x2325948", Offset="0x2325948", VA="0x2325948")]
		public static void StartClubWarBattle(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2325A70", Offset="0x2325A70", VA="0x2325A70")]
		public static void StartEnvironmentsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2325BA4", Offset="0x2325BA4", VA="0x2325BA4")]
		public static void StartMutatorsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}