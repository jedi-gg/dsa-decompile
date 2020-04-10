using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleNode : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong Battle
		{
			[Address(RVA="0xF0A814", Offset="0xF0A814", VA="0xF0A814")]
			get
			{
				return new ulong();
			}
		}

		public ulong BattleRestriction
		{
			[Address(RVA="0xF0A84C", Offset="0xF0A84C", VA="0xF0A84C")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A7B8", Offset="0xF0A7B8", VA="0xF0A7B8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF0A854", Offset="0xF0A854", VA="0xF0A854")]
			get
			{
				return null;
			}
		}

		public ulong EnemyAi
		{
			[Address(RVA="0xF0A82C", Offset="0xF0A82C", VA="0xF0A82C")]
			get
			{
				return new ulong();
			}
		}

		public UnitStatOverride? EnemyStats
		{
			[Address(RVA="0xF0A824", Offset="0xF0A824", VA="0xF0A824")]
			get
			{
				return null;
			}
		}

		public uint EntryCostCount
		{
			[Address(RVA="0xF0A844", Offset="0xF0A844", VA="0xF0A844")]
			get
			{
				return new uint();
			}
		}

		public ulong EntryCostId
		{
			[Address(RVA="0xF0A83C", Offset="0xF0A83C", VA="0xF0A83C")]
			get
			{
				return new ulong();
			}
		}

		public ulong FirstTimeLoot
		{
			[Address(RVA="0xF0A884", Offset="0xF0A884", VA="0xF0A884")]
			get
			{
				return new ulong();
			}
		}

		public string LockedKey
		{
			[Address(RVA="0xF0A86C", Offset="0xF0A86C", VA="0xF0A86C")]
			get
			{
				return null;
			}
		}

		public ulong Loot
		{
			[Address(RVA="0xF0A81C", Offset="0xF0A81C", VA="0xF0A81C")]
			get
			{
				return new ulong();
			}
		}

		public string MapIcon
		{
			[Address(RVA="0xF0A88C", Offset="0xF0A88C", VA="0xF0A88C")]
			get
			{
				return null;
			}
		}

		public ulong MonteCarloItem
		{
			[Address(RVA="0xF0A8A4", Offset="0xF0A8A4", VA="0xF0A8A4")]
			get
			{
				return new ulong();
			}
		}

		public uint MonteCarloLimit
		{
			[Address(RVA="0xF0A8AC", Offset="0xF0A8AC", VA="0xF0A8AC")]
			get
			{
				return new uint();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0A7E4", Offset="0xF0A7E4", VA="0xF0A7E4")]
			get
			{
				return null;
			}
		}

		public int PersistentRewardsLength
		{
			[Address(RVA="0xF0A8DC", Offset="0xF0A8DC", VA="0xF0A8DC")]
			get
			{
				return new int();
			}
		}

		public string RecommendedDescription
		{
			[Address(RVA="0xF0A8BC", Offset="0xF0A8BC", VA="0xF0A8BC")]
			get
			{
				return null;
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF0A7FC", Offset="0xF0A7FC", VA="0xF0A7FC")]
			get
			{
				return null;
			}
		}

		public BattleRuleset Ruleset
		{
			[Address(RVA="0xF0A834", Offset="0xF0A834", VA="0xF0A834")]
			get
			{
				return new BattleRuleset();
			}
		}

		public ulong UnitBonusRestriction
		{
			[Address(RVA="0xF0A8B4", Offset="0xF0A8B4", VA="0xF0A8B4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0A7CC", Offset="0xF0A7CC", VA="0xF0A7CC")]
		public BattleNode __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleNode();
		}

		[Address(RVA="0xF0A7C0", Offset="0xF0A7C0", VA="0xF0A7C0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F4264", Offset="0x15F4264", VA="0x15F4264")]
		public static void AddBattle(FlatBufferBuilder builder, ulong battle)
		{
		}

		[Address(RVA="0x15F4174", Offset="0x15F4174", VA="0x15F4174")]
		public static void AddBattleRestriction(FlatBufferBuilder builder, ulong battleRestriction)
		{
		}

		[Address(RVA="0x15F43CC", Offset="0x15F43CC", VA="0x15F43CC")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x15F41EC", Offset="0x15F41EC", VA="0x15F41EC")]
		public static void AddEnemyAi(FlatBufferBuilder builder, ulong enemyAi)
		{
		}

		[Address(RVA="0x15F4444", Offset="0x15F4444", VA="0x15F4444")]
		public static void AddEnemyStats(FlatBufferBuilder builder, Offset<UnitStatOverride> enemyStatsOffset)
		{
		}

		[Address(RVA="0x15F4408", Offset="0x15F4408", VA="0x15F4408")]
		public static void AddEntryCostCount(FlatBufferBuilder builder, uint entryCostCount)
		{
		}

		[Address(RVA="0x15F41B0", Offset="0x15F41B0", VA="0x15F41B0")]
		public static void AddEntryCostId(FlatBufferBuilder builder, ulong entryCostId)
		{
		}

		[Address(RVA="0x15F4138", Offset="0x15F4138", VA="0x15F4138")]
		public static void AddFirstTimeLoot(FlatBufferBuilder builder, ulong firstTimeLoot)
		{
		}

		[Address(RVA="0x15F4390", Offset="0x15F4390", VA="0x15F4390")]
		public static void AddLockedKey(FlatBufferBuilder builder, StringOffset lockedKeyOffset)
		{
		}

		[Address(RVA="0x15F4228", Offset="0x15F4228", VA="0x15F4228")]
		public static void AddLoot(FlatBufferBuilder builder, ulong loot)
		{
		}

		[Address(RVA="0x15F4354", Offset="0x15F4354", VA="0x15F4354")]
		public static void AddMapIcon(FlatBufferBuilder builder, StringOffset mapIconOffset)
		{
		}

		[Address(RVA="0x15F40FC", Offset="0x15F40FC", VA="0x15F40FC")]
		public static void AddMonteCarloItem(FlatBufferBuilder builder, ulong monteCarloItem)
		{
		}

		[Address(RVA="0x15F4318", Offset="0x15F4318", VA="0x15F4318")]
		public static void AddMonteCarloLimit(FlatBufferBuilder builder, uint monteCarloLimit)
		{
		}

		[Address(RVA="0x15F44BC", Offset="0x15F44BC", VA="0x15F44BC")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x15F42A0", Offset="0x15F42A0", VA="0x15F42A0")]
		public static void AddPersistentRewards(FlatBufferBuilder builder, VectorOffset persistentRewardsOffset)
		{
		}

		[Address(RVA="0x15F42DC", Offset="0x15F42DC", VA="0x15F42DC")]
		public static void AddRecommendedDescription(FlatBufferBuilder builder, StringOffset recommendedDescriptionOffset)
		{
		}

		[Address(RVA="0x15F4480", Offset="0x15F4480", VA="0x15F4480")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x15F44F8", Offset="0x15F44F8", VA="0x15F44F8")]
		public static void AddRuleset(FlatBufferBuilder builder, BattleRuleset ruleset)
		{
		}

		[Address(RVA="0x15F40C0", Offset="0x15F40C0", VA="0x15F40C0")]
		public static void AddUnitBonusRestriction(FlatBufferBuilder builder, ulong unitBonusRestriction)
		{
		}

		[Address(RVA="0x15F3F04", Offset="0x15F3F04", VA="0x15F3F04")]
		public static Offset<BattleNode> CreateBattleNode(FlatBufferBuilder builder, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleNode> Gamedata.BattleNode::CreateBattleNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,System.UInt64,FlatBuffers.Offset`1<Gamedata.UnitStatOverride>,System.UInt64,Gamedata.BattleRuleset,System.UInt64,System.UInt32,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.StringOffset,System.UInt64,System.UInt32,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleNode> CreateBattleNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,System.UInt64,FlatBuffers.Offset<Gamedata.UnitStatOverride>,System.UInt64,Gamedata.BattleRuleset,System.UInt64,System.UInt32,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.StringOffset,System.UInt64,System.UInt32,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F45E4", Offset="0x15F45E4", VA="0x15F45E4")]
		public static VectorOffset CreatePersistentRewardsVector(FlatBufferBuilder builder, Offset<PersistentReward>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F4534", Offset="0x15F4534", VA="0x15F4534")]
		public static Offset<BattleNode> EndBattleNode(FlatBufferBuilder builder)
		{
			return new Offset<BattleNode>();
		}

		[Address(RVA="0xF0A85C", Offset="0xF0A85C", VA="0xF0A85C")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A874", Offset="0xF0A874", VA="0xF0A874")]
		public ArraySegment<byte>? GetLockedKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A894", Offset="0xF0A894", VA="0xF0A894")]
		public ArraySegment<byte>? GetMapIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A7EC", Offset="0xF0A7EC", VA="0xF0A7EC")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A8C4", Offset="0xF0A8C4", VA="0xF0A8C4")]
		public ArraySegment<byte>? GetRecommendedDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A804", Offset="0xF0A804", VA="0xF0A804")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x15F358C", Offset="0x15F358C", VA="0x15F358C")]
		public static BattleNode GetRootAsBattleNode(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleNode();
		}

		[Address(RVA="0x15F3598", Offset="0x15F3598", VA="0x15F3598")]
		public static BattleNode GetRootAsBattleNode(FlatBuffers.ByteBuffer _bb, BattleNode obj)
		{
			return new BattleNode();
		}

		[Address(RVA="0xF0A8D4", Offset="0xF0A8D4", VA="0xF0A8D4")]
		public PersistentReward? PersistentRewards(int j)
		{
			return null;
		}

		[Address(RVA="0x15F45B4", Offset="0x15F45B4", VA="0x15F45B4")]
		public static void StartBattleNode(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F46DC", Offset="0x15F46DC", VA="0x15F46DC")]
		public static void StartPersistentRewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}