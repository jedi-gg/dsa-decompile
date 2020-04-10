using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PlayerActivity : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public PlayerActivityType ActivityType
		{
			[Address(RVA="0xF57814", Offset="0xF57814", VA="0xF57814")]
			get
			{
				return new PlayerActivityType();
			}
		}

		public ActivityBattleFilter? BattleActivityFilter
		{
			[Address(RVA="0xF5787C", Offset="0xF5787C", VA="0xF5787C")]
			get
			{
				return null;
			}
		}

		public ulong BattleActivityTracker
		{
			[Address(RVA="0xF57874", Offset="0xF57874", VA="0xF57874")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF577B0", Offset="0xF577B0", VA="0xF577B0", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint DailyOptionalWeight
		{
			[Address(RVA="0xF578AC", Offset="0xF578AC", VA="0xF578AC")]
			get
			{
				return new uint();
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF57854", Offset="0xF57854", VA="0xF57854")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF5785C", Offset="0xF5785C", VA="0xF5785C")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF577FC", Offset="0xF577FC", VA="0xF577FC")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF577DC", Offset="0xF577DC", VA="0xF577DC")]
			get
			{
				return new ulong();
			}
		}

		public string LuaEvalFunc
		{
			[Address(RVA="0xF57884", Offset="0xF57884", VA="0xF57884")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF577E4", Offset="0xF577E4", VA="0xF577E4")]
			get
			{
				return null;
			}
		}

		public int RequiredValue
		{
			[Address(RVA="0xF5784C", Offset="0xF5784C", VA="0xF5784C")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF57824", Offset="0xF57824", VA="0xF57824")]
			get
			{
				return null;
			}
		}

		public int RewardChoicesLength
		{
			[Address(RVA="0xF578A4", Offset="0xF578A4", VA="0xF578A4")]
			get
			{
				return new int();
			}
		}

		public LevelBandedReward? Rewards
		{
			[Address(RVA="0xF5783C", Offset="0xF5783C", VA="0xF5783C")]
			get
			{
				return null;
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF5781C", Offset="0xF5781C", VA="0xF5781C")]
			get
			{
				return new int();
			}
		}

		public PlayerStat StatType
		{
			[Address(RVA="0xF57844", Offset="0xF57844", VA="0xF57844")]
			get
			{
				return new PlayerStat();
			}
		}

		[Address(RVA="0xF577C4", Offset="0xF577C4", VA="0xF577C4")]
		public PlayerActivity __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerActivity();
		}

		[Address(RVA="0xF577B8", Offset="0xF577B8", VA="0xF577B8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DD7CC", Offset="0x24DD7CC", VA="0x24DD7CC")]
		public static void AddActivityType(FlatBufferBuilder builder, PlayerActivityType activityType)
		{
		}

		[Address(RVA="0x24DD574", Offset="0x24DD574", VA="0x24DD574")]
		public static void AddBattleActivityFilter(FlatBufferBuilder builder, Offset<ActivityBattleFilter> battleActivityFilterOffset)
		{
		}

		[Address(RVA="0x24DD448", Offset="0x24DD448", VA="0x24DD448")]
		public static void AddBattleActivityTracker(FlatBufferBuilder builder, ulong battleActivityTracker)
		{
		}

		[Address(RVA="0x24DD4C0", Offset="0x24DD4C0", VA="0x24DD4C0")]
		public static void AddDailyOptionalWeight(FlatBufferBuilder builder, uint dailyOptionalWeight)
		{
		}

		[Address(RVA="0x24DD754", Offset="0x24DD754", VA="0x24DD754")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x24DD5B0", Offset="0x24DD5B0", VA="0x24DD5B0")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x24DD6DC", Offset="0x24DD6DC", VA="0x24DD6DC")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x24DD484", Offset="0x24DD484", VA="0x24DD484")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24DD538", Offset="0x24DD538", VA="0x24DD538")]
		public static void AddLuaEvalFunc(FlatBufferBuilder builder, StringOffset luaEvalFuncOffset)
		{
		}

		[Address(RVA="0x24DD718", Offset="0x24DD718", VA="0x24DD718")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24DD5EC", Offset="0x24DD5EC", VA="0x24DD5EC")]
		public static void AddRequiredValue(FlatBufferBuilder builder, int requiredValue)
		{
		}

		[Address(RVA="0x24DD664", Offset="0x24DD664", VA="0x24DD664")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x24DD4FC", Offset="0x24DD4FC", VA="0x24DD4FC")]
		public static void AddRewardChoices(FlatBufferBuilder builder, VectorOffset rewardChoicesOffset)
		{
		}

		[Address(RVA="0x24DD628", Offset="0x24DD628", VA="0x24DD628")]
		public static void AddRewards(FlatBufferBuilder builder, Offset<LevelBandedReward> rewardsOffset)
		{
		}

		[Address(RVA="0x24DD6A0", Offset="0x24DD6A0", VA="0x24DD6A0")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x24DD790", Offset="0x24DD790", VA="0x24DD790")]
		public static void AddStatType(FlatBufferBuilder builder, PlayerStat statType)
		{
		}

		[Address(RVA="0x24DD2D4", Offset="0x24DD2D4", VA="0x24DD2D4")]
		public static Offset<PlayerActivity> CreatePlayerActivity(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PlayerActivity> Gamedata.PlayerActivity::CreatePlayerActivity(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.PlayerActivityType,System.Int32,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.LevelBandedReward>,Gamedata.PlayerStat,System.Int32,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.Offset`1<Gamedata.ActivityBattleFilter>,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PlayerActivity> CreatePlayerActivity(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,Gamedata.PlayerActivityType,System.Int32,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.LevelBandedReward>,Gamedata.PlayerStat,System.Int32,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.Offset<Gamedata.ActivityBattleFilter>,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DD8B8", Offset="0x24DD8B8", VA="0x24DD8B8")]
		public static VectorOffset CreateRewardChoicesVector(FlatBufferBuilder builder, Offset<LevelBandedRewardChoice>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DD808", Offset="0x24DD808", VA="0x24DD808")]
		public static Offset<PlayerActivity> EndPlayerActivity(FlatBufferBuilder builder)
		{
			return new Offset<PlayerActivity>();
		}

		[Address(RVA="0x24DD9EC", Offset="0x24DD9EC", VA="0x24DD9EC")]
		public static void FinishPlayerActivityBuffer(FlatBufferBuilder builder, Offset<PlayerActivity> offset)
		{
		}

		[Address(RVA="0xF57864", Offset="0xF57864", VA="0xF57864")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF57804", Offset="0xF57804", VA="0xF57804")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5788C", Offset="0xF5788C", VA="0xF5788C")]
		public ArraySegment<byte>? GetLuaEvalFuncBytes()
		{
			return null;
		}

		[Address(RVA="0xF577EC", Offset="0xF577EC", VA="0xF577EC")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5782C", Offset="0xF5782C", VA="0xF5782C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24DCA7C", Offset="0x24DCA7C", VA="0x24DCA7C")]
		public static PlayerActivity GetRootAsPlayerActivity(FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerActivity();
		}

		[Address(RVA="0x24DCA88", Offset="0x24DCA88", VA="0x24DCA88")]
		public static PlayerActivity GetRootAsPlayerActivity(FlatBuffers.ByteBuffer _bb, PlayerActivity obj)
		{
			return new PlayerActivity();
		}

		[Address(RVA="0xF5789C", Offset="0xF5789C", VA="0xF5789C")]
		public LevelBandedRewardChoice? RewardChoices(int j)
		{
			return null;
		}

		[Address(RVA="0x24DD888", Offset="0x24DD888", VA="0x24DD888")]
		public static void StartPlayerActivity(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24DD9B0", Offset="0x24DD9B0", VA="0x24DD9B0")]
		public static void StartRewardChoicesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}