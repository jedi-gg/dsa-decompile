using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PvpRank : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58148", Offset="0xF58148", VA="0xF58148", Slot="5")]
			get
			{
				return null;
			}
		}

		public int FallbackLoseStreak
		{
			[Address(RVA="0xF581E4", Offset="0xF581E4", VA="0xF581E4")]
			get
			{
				return new int();
			}
		}

		public string Icon
		{
			[Address(RVA="0xF581CC", Offset="0xF581CC", VA="0xF581CC")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58174", Offset="0xF58174", VA="0xF58174")]
			get
			{
				return new ulong();
			}
		}

		public int LevelMatchingRangeUp
		{
			[Address(RVA="0xF581F4", Offset="0xF581F4", VA="0xF581F4")]
			get
			{
				return new int();
			}
		}

		public ulong LootForLoss
		{
			[Address(RVA="0xF581BC", Offset="0xF581BC", VA="0xF581BC")]
			get
			{
				return new ulong();
			}
		}

		public ulong LootForWin
		{
			[Address(RVA="0xF581B4", Offset="0xF581B4", VA="0xF581B4")]
			get
			{
				return new ulong();
			}
		}

		public ulong MinScore
		{
			[Address(RVA="0xF58194", Offset="0xF58194", VA="0xF58194")]
			get
			{
				return new ulong();
			}
		}

		public int PointsForLoss
		{
			[Address(RVA="0xF581A4", Offset="0xF581A4", VA="0xF581A4")]
			get
			{
				return new int();
			}
		}

		public int PointsForWin
		{
			[Address(RVA="0xF5819C", Offset="0xF5819C", VA="0xF5819C")]
			get
			{
				return new int();
			}
		}

		public string RankNameKey
		{
			[Address(RVA="0xF5817C", Offset="0xF5817C", VA="0xF5817C")]
			get
			{
				return null;
			}
		}

		public ulong ScoreAfterSeasonReset
		{
			[Address(RVA="0xF581AC", Offset="0xF581AC", VA="0xF581AC")]
			get
			{
				return new ulong();
			}
		}

		public ulong SeasonPayoutInboxMsg
		{
			[Address(RVA="0xF581EC", Offset="0xF581EC", VA="0xF581EC")]
			get
			{
				return new ulong();
			}
		}

		public ulong WeeklyPayoutInboxMsg
		{
			[Address(RVA="0xF581C4", Offset="0xF581C4", VA="0xF581C4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5815C", Offset="0xF5815C", VA="0xF5815C")]
		public PvpRank __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PvpRank();
		}

		[Address(RVA="0xF58150", Offset="0xF58150", VA="0xF58150", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E354C", Offset="0x24E354C", VA="0x24E354C")]
		public static void AddFallbackLoseStreak(FlatBufferBuilder builder, int fallbackLoseStreak)
		{
		}

		[Address(RVA="0x24E3588", Offset="0x24E3588", VA="0x24E3588")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x24E34D4", Offset="0x24E34D4", VA="0x24E34D4")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E3510", Offset="0x24E3510", VA="0x24E3510")]
		public static void AddLevelMatchingRangeUp(FlatBufferBuilder builder, int levelMatchingRangeUp)
		{
		}

		[Address(RVA="0x24E33E4", Offset="0x24E33E4", VA="0x24E33E4")]
		public static void AddLootForLoss(FlatBufferBuilder builder, ulong lootForLoss)
		{
		}

		[Address(RVA="0x24E3420", Offset="0x24E3420", VA="0x24E3420")]
		public static void AddLootForWin(FlatBufferBuilder builder, ulong lootForWin)
		{
		}

		[Address(RVA="0x24E3498", Offset="0x24E3498", VA="0x24E3498")]
		public static void AddMinScore(FlatBufferBuilder builder, ulong minScore)
		{
		}

		[Address(RVA="0x24E35C4", Offset="0x24E35C4", VA="0x24E35C4")]
		public static void AddPointsForLoss(FlatBufferBuilder builder, int pointsForLoss)
		{
		}

		[Address(RVA="0x24E3600", Offset="0x24E3600", VA="0x24E3600")]
		public static void AddPointsForWin(FlatBufferBuilder builder, int pointsForWin)
		{
		}

		[Address(RVA="0x24E363C", Offset="0x24E363C", VA="0x24E363C")]
		public static void AddRankNameKey(FlatBufferBuilder builder, StringOffset rankNameKeyOffset)
		{
		}

		[Address(RVA="0x24E345C", Offset="0x24E345C", VA="0x24E345C")]
		public static void AddScoreAfterSeasonReset(FlatBufferBuilder builder, ulong scoreAfterSeasonReset)
		{
		}

		[Address(RVA="0x24E336C", Offset="0x24E336C", VA="0x24E336C")]
		public static void AddSeasonPayoutInboxMsg(FlatBufferBuilder builder, ulong seasonPayoutInboxMsg)
		{
		}

		[Address(RVA="0x24E33A8", Offset="0x24E33A8", VA="0x24E33A8")]
		public static void AddWeeklyPayoutInboxMsg(FlatBufferBuilder builder, ulong weeklyPayoutInboxMsg)
		{
		}

		[Address(RVA="0x24E3230", Offset="0x24E3230", VA="0x24E3230")]
		public static Offset<PvpRank> CreatePvpRank(FlatBufferBuilder builder, ulong id = 0L, StringOffset rank_name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PvpRank> Gamedata.PvpRank::CreatePvpRank(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.UInt64,System.Int32,System.Int32,System.UInt64,System.UInt64,System.UInt64,System.UInt64,FlatBuffers.StringOffset,System.Int32,System.UInt64,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PvpRank> CreatePvpRank(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.UInt64,System.Int32,System.Int32,System.UInt64,System.UInt64,System.UInt64,System.UInt64,FlatBuffers.StringOffset,System.Int32,System.UInt64,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E3678", Offset="0x24E3678", VA="0x24E3678")]
		public static Offset<PvpRank> EndPvpRank(FlatBufferBuilder builder)
		{
			return new Offset<PvpRank>();
		}

		[Address(RVA="0x24E3728", Offset="0x24E3728", VA="0x24E3728")]
		public static void FinishPvpRankBuffer(FlatBufferBuilder builder, Offset<PvpRank> offset)
		{
		}

		[Address(RVA="0xF581D4", Offset="0xF581D4", VA="0xF581D4")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF58184", Offset="0xF58184", VA="0xF58184")]
		public ArraySegment<byte>? GetRankNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24E2C18", Offset="0x24E2C18", VA="0x24E2C18")]
		public static PvpRank GetRootAsPvpRank(FlatBuffers.ByteBuffer _bb)
		{
			return new PvpRank();
		}

		[Address(RVA="0x24E2C24", Offset="0x24E2C24", VA="0x24E2C24")]
		public static PvpRank GetRootAsPvpRank(FlatBuffers.ByteBuffer _bb, PvpRank obj)
		{
			return new PvpRank();
		}

		[Address(RVA="0x24E36F8", Offset="0x24E36F8", VA="0x24E36F8")]
		public static void StartPvpRank(FlatBufferBuilder builder)
		{
		}
	}
}