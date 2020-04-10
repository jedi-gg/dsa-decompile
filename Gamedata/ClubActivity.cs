using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubActivity : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ActivityBattleFilter? BattleActivityFilter
		{
			[Address(RVA="0xF436D8", Offset="0xF436D8", VA="0xF436D8")]
			get
			{
				return null;
			}
		}

		public ulong BattleActivityTracker
		{
			[Address(RVA="0xF436D0", Offset="0xF436D0", VA="0xF436D0")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43654", Offset="0xF43654", VA="0xF43654", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DayOfWeek? Days
		{
			[Address(RVA="0xF43688", Offset="0xF43688", VA="0xF43688")]
			get
			{
				return null;
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF436B0", Offset="0xF436B0", VA="0xF436B0")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF436B8", Offset="0xF436B8", VA="0xF436B8")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF43680", Offset="0xF43680", VA="0xF43680")]
			get
			{
				return new ulong();
			}
		}

		public string LuaEvalFunc
		{
			[Address(RVA="0xF436E0", Offset="0xF436E0", VA="0xF436E0")]
			get
			{
				return null;
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF43690", Offset="0xF43690", VA="0xF43690")]
			get
			{
				return new int();
			}
		}

		public PlayerStat StatType
		{
			[Address(RVA="0xF436A8", Offset="0xF436A8", VA="0xF436A8")]
			get
			{
				return new PlayerStat();
			}
		}

		public int TiersLength
		{
			[Address(RVA="0xF436A0", Offset="0xF436A0", VA="0xF436A0")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF43668", Offset="0xF43668", VA="0xF43668")]
		public ClubActivity __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubActivity();
		}

		[Address(RVA="0xF4365C", Offset="0xF4365C", VA="0xF4365C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2321268", Offset="0x2321268", VA="0x2321268")]
		public static void AddBattleActivityFilter(FlatBufferBuilder builder, Offset<ActivityBattleFilter> battleActivityFilterOffset)
		{
		}

		[Address(RVA="0x23211B4", Offset="0x23211B4", VA="0x23211B4")]
		public static void AddBattleActivityTracker(FlatBufferBuilder builder, ulong battleActivityTracker)
		{
		}

		[Address(RVA="0x2321358", Offset="0x2321358", VA="0x2321358")]
		public static void AddDays(FlatBufferBuilder builder, Offset<Gamedata.DayOfWeek> daysOffset)
		{
		}

		[Address(RVA="0x2321394", Offset="0x2321394", VA="0x2321394")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x23212A4", Offset="0x23212A4", VA="0x23212A4")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x23211F0", Offset="0x23211F0", VA="0x23211F0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x232122C", Offset="0x232122C", VA="0x232122C")]
		public static void AddLuaEvalFunc(FlatBufferBuilder builder, StringOffset luaEvalFuncOffset)
		{
		}

		[Address(RVA="0x232131C", Offset="0x232131C", VA="0x232131C")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x23213D0", Offset="0x23213D0", VA="0x23213D0")]
		public static void AddStatType(FlatBufferBuilder builder, PlayerStat statType)
		{
		}

		[Address(RVA="0x23212E0", Offset="0x23212E0", VA="0x23212E0")]
		public static void AddTiers(FlatBufferBuilder builder, VectorOffset tiersOffset)
		{
		}

		[Address(RVA="0x23210B0", Offset="0x23210B0", VA="0x23210B0")]
		public static Offset<ClubActivity> CreateClubActivity(FlatBufferBuilder builder, ulong id = 0L, Offset<Gamedata.DayOfWeek> daysOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubActivity> Gamedata.ClubActivity::CreateClubActivity(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.DayOfWeek>,System.Int32,FlatBuffers.VectorOffset,Gamedata.PlayerStat,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.Offset`1<Gamedata.ActivityBattleFilter>,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubActivity> CreateClubActivity(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.DayOfWeek>,System.Int32,FlatBuffers.VectorOffset,Gamedata.PlayerStat,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.Offset<Gamedata.ActivityBattleFilter>,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23214BC", Offset="0x23214BC", VA="0x23214BC")]
		public static VectorOffset CreateTiersVector(FlatBufferBuilder builder, Offset<ClubActivityTier>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232140C", Offset="0x232140C", VA="0x232140C")]
		public static Offset<ClubActivity> EndClubActivity(FlatBufferBuilder builder)
		{
			return new Offset<ClubActivity>();
		}

		[Address(RVA="0x23215F0", Offset="0x23215F0", VA="0x23215F0")]
		public static void FinishClubActivityBuffer(FlatBufferBuilder builder, Offset<ClubActivity> offset)
		{
		}

		[Address(RVA="0xF436C0", Offset="0xF436C0", VA="0xF436C0")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF436E8", Offset="0xF436E8", VA="0xF436E8")]
		public ArraySegment<byte>? GetLuaEvalFuncBytes()
		{
			return null;
		}

		[Address(RVA="0x2320A5C", Offset="0x2320A5C", VA="0x2320A5C")]
		public static ClubActivity GetRootAsClubActivity(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubActivity();
		}

		[Address(RVA="0x2320A68", Offset="0x2320A68", VA="0x2320A68")]
		public static ClubActivity GetRootAsClubActivity(FlatBuffers.ByteBuffer _bb, ClubActivity obj)
		{
			return new ClubActivity();
		}

		[Address(RVA="0x232148C", Offset="0x232148C", VA="0x232148C")]
		public static void StartClubActivity(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x23215B4", Offset="0x23215B4", VA="0x23215B4")]
		public static void StartTiersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF43698", Offset="0xF43698", VA="0xF43698")]
		public ClubActivityTier? Tiers(int j)
		{
			return null;
		}
	}
}