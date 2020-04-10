using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PvpTakeover : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong BattleEnvAsset
		{
			[Address(RVA="0xF583D4", Offset="0xF583D4", VA="0xF583D4")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF582E8", Offset="0xF582E8", VA="0xF582E8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong DailyPvpPack
		{
			[Address(RVA="0xF583F4", Offset="0xF583F4", VA="0xF583F4")]
			get
			{
				return new ulong();
			}
		}

		public string HomeAsset
		{
			[Address(RVA="0xF5831C", Offset="0xF5831C", VA="0xF5831C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58314", Offset="0xF58314", VA="0xF58314")]
			get
			{
				return new ulong();
			}
		}

		public ulong IntroCinematicOverride
		{
			[Address(RVA="0xF583EC", Offset="0xF583EC", VA="0xF583EC")]
			get
			{
				return new ulong();
			}
		}

		public string LeftBannerAsset
		{
			[Address(RVA="0xF58334", Offset="0xF58334", VA="0xF58334")]
			get
			{
				return null;
			}
		}

		public string LeftBannerText
		{
			[Address(RVA="0xF5834C", Offset="0xF5834C", VA="0xF5834C")]
			get
			{
				return null;
			}
		}

		public string LobbyEnvAsset
		{
			[Address(RVA="0xF583BC", Offset="0xF583BC", VA="0xF583BC")]
			get
			{
				return null;
			}
		}

		public int OccasionLength
		{
			[Address(RVA="0xF583E4", Offset="0xF583E4", VA="0xF583E4")]
			get
			{
				return new int();
			}
		}

		public string PackAsset
		{
			[Address(RVA="0xF58394", Offset="0xF58394", VA="0xF58394")]
			get
			{
				return null;
			}
		}

		public ulong PvpBattle
		{
			[Address(RVA="0xF583FC", Offset="0xF583FC", VA="0xF583FC")]
			get
			{
				return new ulong();
			}
		}

		public int RankOverridesLength
		{
			[Address(RVA="0xF583B4", Offset="0xF583B4", VA="0xF583B4")]
			get
			{
				return new int();
			}
		}

		public string RightBannerAsset
		{
			[Address(RVA="0xF58364", Offset="0xF58364", VA="0xF58364")]
			get
			{
				return null;
			}
		}

		public string RightBannerText
		{
			[Address(RVA="0xF5837C", Offset="0xF5837C", VA="0xF5837C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF582FC", Offset="0xF582FC", VA="0xF582FC")]
		public PvpTakeover __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PvpTakeover();
		}

		[Address(RVA="0xF582F0", Offset="0xF582F0", VA="0xF582F0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E4660", Offset="0x24E4660", VA="0x24E4660")]
		public static void AddBattleEnvAsset(FlatBufferBuilder builder, ulong battleEnvAsset)
		{
		}

		[Address(RVA="0x24E45E8", Offset="0x24E45E8", VA="0x24E45E8")]
		public static void AddDailyPvpPack(FlatBufferBuilder builder, ulong dailyPvpPack)
		{
		}

		[Address(RVA="0x24E48B8", Offset="0x24E48B8", VA="0x24E48B8")]
		public static void AddHomeAsset(FlatBufferBuilder builder, StringOffset homeAssetOffset)
		{
		}

		[Address(RVA="0x24E469C", Offset="0x24E469C", VA="0x24E469C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E4624", Offset="0x24E4624", VA="0x24E4624")]
		public static void AddIntroCinematicOverride(FlatBufferBuilder builder, ulong introCinematicOverride)
		{
		}

		[Address(RVA="0x24E487C", Offset="0x24E487C", VA="0x24E487C")]
		public static void AddLeftBannerAsset(FlatBufferBuilder builder, StringOffset leftBannerAssetOffset)
		{
		}

		[Address(RVA="0x24E4840", Offset="0x24E4840", VA="0x24E4840")]
		public static void AddLeftBannerText(FlatBufferBuilder builder, StringOffset leftBannerTextOffset)
		{
		}

		[Address(RVA="0x24E4714", Offset="0x24E4714", VA="0x24E4714")]
		public static void AddLobbyEnvAsset(FlatBufferBuilder builder, StringOffset lobbyEnvAssetOffset)
		{
		}

		[Address(RVA="0x24E46D8", Offset="0x24E46D8", VA="0x24E46D8")]
		public static void AddOccasion(FlatBufferBuilder builder, VectorOffset occasionOffset)
		{
		}

		[Address(RVA="0x24E478C", Offset="0x24E478C", VA="0x24E478C")]
		public static void AddPackAsset(FlatBufferBuilder builder, StringOffset packAssetOffset)
		{
		}

		[Address(RVA="0x24E45AC", Offset="0x24E45AC", VA="0x24E45AC")]
		public static void AddPvpBattle(FlatBufferBuilder builder, ulong pvpBattle)
		{
		}

		[Address(RVA="0x24E4750", Offset="0x24E4750", VA="0x24E4750")]
		public static void AddRankOverrides(FlatBufferBuilder builder, VectorOffset rankOverridesOffset)
		{
		}

		[Address(RVA="0x24E4804", Offset="0x24E4804", VA="0x24E4804")]
		public static void AddRightBannerAsset(FlatBufferBuilder builder, StringOffset rightBannerAssetOffset)
		{
		}

		[Address(RVA="0x24E47C8", Offset="0x24E47C8", VA="0x24E47C8")]
		public static void AddRightBannerText(FlatBufferBuilder builder, StringOffset rightBannerTextOffset)
		{
		}

		[Address(RVA="0x24E4AD8", Offset="0x24E4AD8", VA="0x24E4AD8")]
		public static VectorOffset CreateOccasionVector(FlatBufferBuilder builder, Offset<OccasionRef>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E4464", Offset="0x24E4464", VA="0x24E4464")]
		public static Offset<PvpTakeover> CreatePvpTakeover(FlatBufferBuilder builder, ulong id = 0L, StringOffset home_assetOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PvpTakeover> Gamedata.PvpTakeover::CreatePvpTakeover(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.VectorOffset,System.UInt64,System.UInt64,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PvpTakeover> CreatePvpTakeover(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.VectorOffset,System.UInt64,System.UInt64,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E49A4", Offset="0x24E49A4", VA="0x24E49A4")]
		public static VectorOffset CreateRankOverridesVector(FlatBufferBuilder builder, Offset<PvpRankOverride>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E48F4", Offset="0x24E48F4", VA="0x24E48F4")]
		public static Offset<PvpTakeover> EndPvpTakeover(FlatBufferBuilder builder)
		{
			return new Offset<PvpTakeover>();
		}

		[Address(RVA="0x24E4C0C", Offset="0x24E4C0C", VA="0x24E4C0C")]
		public static void FinishPvpTakeoverBuffer(FlatBufferBuilder builder, Offset<PvpTakeover> offset)
		{
		}

		[Address(RVA="0xF58324", Offset="0xF58324", VA="0xF58324")]
		public ArraySegment<byte>? GetHomeAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF5833C", Offset="0xF5833C", VA="0xF5833C")]
		public ArraySegment<byte>? GetLeftBannerAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF58354", Offset="0xF58354", VA="0xF58354")]
		public ArraySegment<byte>? GetLeftBannerTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF583C4", Offset="0xF583C4", VA="0xF583C4")]
		public ArraySegment<byte>? GetLobbyEnvAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF5839C", Offset="0xF5839C", VA="0xF5839C")]
		public ArraySegment<byte>? GetPackAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF5836C", Offset="0xF5836C", VA="0xF5836C")]
		public ArraySegment<byte>? GetRightBannerAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF58384", Offset="0xF58384", VA="0xF58384")]
		public ArraySegment<byte>? GetRightBannerTextBytes()
		{
			return null;
		}

		[Address(RVA="0x24E3CD8", Offset="0x24E3CD8", VA="0x24E3CD8")]
		public static PvpTakeover GetRootAsPvpTakeover(FlatBuffers.ByteBuffer _bb)
		{
			return new PvpTakeover();
		}

		[Address(RVA="0x24E3CE4", Offset="0x24E3CE4", VA="0x24E3CE4")]
		public static PvpTakeover GetRootAsPvpTakeover(FlatBuffers.ByteBuffer _bb, PvpTakeover obj)
		{
			return new PvpTakeover();
		}

		[Address(RVA="0xF583DC", Offset="0xF583DC", VA="0xF583DC")]
		public OccasionRef? Occasion(int j)
		{
			return null;
		}

		[Address(RVA="0xF583AC", Offset="0xF583AC", VA="0xF583AC")]
		public PvpRankOverride? RankOverrides(int j)
		{
			return null;
		}

		[Address(RVA="0x24E4BD0", Offset="0x24E4BD0", VA="0x24E4BD0")]
		public static void StartOccasionVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E4974", Offset="0x24E4974", VA="0x24E4974")]
		public static void StartPvpTakeover(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24E4A9C", Offset="0x24E4A9C", VA="0x24E4A9C")]
		public static void StartRankOverridesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}