using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ActivityBattleFilter : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09BA8", Offset="0xF09BA8", VA="0xF09BA8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ExplicitCampaignsLength
		{
			[Address(RVA="0xF09C1C", Offset="0xF09C1C", VA="0xF09C1C")]
			get
			{
				return new int();
			}
		}

		public bool InCampaignCoop
		{
			[Address(RVA="0xF09BDC", Offset="0xF09BDC", VA="0xF09BDC")]
			get
			{
				return new bool();
			}
		}

		public bool InCampaignSingle
		{
			[Address(RVA="0xF09BD4", Offset="0xF09BD4", VA="0xF09BD4")]
			get
			{
				return new bool();
			}
		}

		public bool InClubDungeon
		{
			[Address(RVA="0xF09BF4", Offset="0xF09BF4", VA="0xF09BF4")]
			get
			{
				return new bool();
			}
		}

		public bool InClubWar
		{
			[Address(RVA="0xF09C0C", Offset="0xF09C0C", VA="0xF09C0C")]
			get
			{
				return new bool();
			}
		}

		public bool InEvents
		{
			[Address(RVA="0xF09BFC", Offset="0xF09BFC", VA="0xF09BFC")]
			get
			{
				return new bool();
			}
		}

		public bool InKoth
		{
			[Address(RVA="0xF09C04", Offset="0xF09C04", VA="0xF09C04")]
			get
			{
				return new bool();
			}
		}

		public bool InPvpArena
		{
			[Address(RVA="0xF09BE4", Offset="0xF09BE4", VA="0xF09BE4")]
			get
			{
				return new bool();
			}
		}

		public bool InTower
		{
			[Address(RVA="0xF09BEC", Offset="0xF09BEC", VA="0xF09BEC")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF09BBC", Offset="0xF09BBC", VA="0xF09BBC")]
		public ActivityBattleFilter __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ActivityBattleFilter();
		}

		[Address(RVA="0xF09BB0", Offset="0xF09BB0", VA="0xF09BB0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15ED88C", Offset="0x15ED88C", VA="0x15ED88C")]
		public static void AddExplicitCampaigns(FlatBufferBuilder builder, VectorOffset explicitCampaignsOffset)
		{
		}

		[Address(RVA="0x15EDA30", Offset="0x15EDA30", VA="0x15EDA30")]
		public static void AddInCampaignCoop(FlatBufferBuilder builder, bool inCampaignCoop)
		{
		}

		[Address(RVA="0x15EDA6C", Offset="0x15EDA6C", VA="0x15EDA6C")]
		public static void AddInCampaignSingle(FlatBufferBuilder builder, bool inCampaignSingle)
		{
		}

		[Address(RVA="0x15ED97C", Offset="0x15ED97C", VA="0x15ED97C")]
		public static void AddInClubDungeon(FlatBufferBuilder builder, bool inClubDungeon)
		{
		}

		[Address(RVA="0x15ED8C8", Offset="0x15ED8C8", VA="0x15ED8C8")]
		public static void AddInClubWar(FlatBufferBuilder builder, bool inClubWar)
		{
		}

		[Address(RVA="0x15ED940", Offset="0x15ED940", VA="0x15ED940")]
		public static void AddInEvents(FlatBufferBuilder builder, bool inEvents)
		{
		}

		[Address(RVA="0x15ED904", Offset="0x15ED904", VA="0x15ED904")]
		public static void AddInKoth(FlatBufferBuilder builder, bool inKoth)
		{
		}

		[Address(RVA="0x15ED9F4", Offset="0x15ED9F4", VA="0x15ED9F4")]
		public static void AddInPvpArena(FlatBufferBuilder builder, bool inPvpArena)
		{
		}

		[Address(RVA="0x15ED9B8", Offset="0x15ED9B8", VA="0x15ED9B8")]
		public static void AddInTower(FlatBufferBuilder builder, bool inTower)
		{
		}

		[Address(RVA="0x15ED79C", Offset="0x15ED79C", VA="0x15ED79C")]
		public static Offset<ActivityBattleFilter> CreateActivityBattleFilter(FlatBufferBuilder builder, bool in_campaign_single = false, bool in_campaign_coop = false, bool in_pvp_arena = false, bool in_tower = false, bool in_club_dungeon = false, bool in_events = false, bool in_koth = false, bool in_club_war = false, VectorOffset explicit_campaignsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ActivityBattleFilter> Gamedata.ActivityBattleFilter::CreateActivityBattleFilter(FlatBuffers.FlatBufferBuilder,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ActivityBattleFilter> CreateActivityBattleFilter(FlatBuffers.FlatBufferBuilder,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EDB58", Offset="0x15EDB58", VA="0x15EDB58")]
		public static VectorOffset CreateExplicitCampaignsVector(FlatBufferBuilder builder, Offset<ActivityBattleFilterCampaign>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15EDAA8", Offset="0x15EDAA8", VA="0x15EDAA8")]
		public static Offset<ActivityBattleFilter> EndActivityBattleFilter(FlatBufferBuilder builder)
		{
			return new Offset<ActivityBattleFilter>();
		}

		[Address(RVA="0xF09C14", Offset="0xF09C14", VA="0xF09C14")]
		public ActivityBattleFilterCampaign? ExplicitCampaigns(int j)
		{
			return null;
		}

		[Address(RVA="0x15ED288", Offset="0x15ED288", VA="0x15ED288")]
		public static ActivityBattleFilter GetRootAsActivityBattleFilter(FlatBuffers.ByteBuffer _bb)
		{
			return new ActivityBattleFilter();
		}

		[Address(RVA="0x15ED294", Offset="0x15ED294", VA="0x15ED294")]
		public static ActivityBattleFilter GetRootAsActivityBattleFilter(FlatBuffers.ByteBuffer _bb, ActivityBattleFilter obj)
		{
			return new ActivityBattleFilter();
		}

		[Address(RVA="0x15EDB28", Offset="0x15EDB28", VA="0x15EDB28")]
		public static void StartActivityBattleFilter(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15EDC50", Offset="0x15EDC50", VA="0x15EDC50")]
		public static void StartExplicitCampaignsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}