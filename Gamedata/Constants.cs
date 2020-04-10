using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Constants : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong AbilityCodesRef
		{
			[Address(RVA="0xF44980", Offset="0xF44980", VA="0xF44980")]
			get
			{
				return new ulong();
			}
		}

		public uint AdRewardValidationTimeoutS
		{
			[Address(RVA="0xF44860", Offset="0xF44860", VA="0xF44860")]
			get
			{
				return new uint();
			}
		}

		public ulong AgeGatePlayerActivityClaimedPrompt
		{
			[Address(RVA="0xF44760", Offset="0xF44760", VA="0xF44760")]
			get
			{
				return new ulong();
			}
		}

		public string AgeGateReq
		{
			[Address(RVA="0xF44A30", Offset="0xF44A30", VA="0xF44A30")]
			get
			{
				return null;
			}
		}

		public uint AgeGateUnderage
		{
			[Address(RVA="0xF44758", Offset="0xF44758", VA="0xF44758")]
			get
			{
				return new uint();
			}
		}

		public Gamedata.AppRatingData? AppRatingData
		{
			[Address(RVA="0xF447E0", Offset="0xF447E0", VA="0xF447E0")]
			get
			{
				return null;
			}
		}

		public string AttributionUrl
		{
			[Address(RVA="0xF44898", Offset="0xF44898", VA="0xF44898")]
			get
			{
				return null;
			}
		}

		public ulong AutobattleDefaultAiPlayer
		{
			[Address(RVA="0xF445C0", Offset="0xF445C0", VA="0xF445C0")]
			get
			{
				return new ulong();
			}
		}

		public float BattleAbilityCastTimeScale
		{
			[Address(RVA="0xF445A0", Offset="0xF445A0", VA="0xF445A0")]
			get
			{
				return new float();
			}
		}

		public float BattleBadConnectionMaxClockDriftS
		{
			[Address(RVA="0xF44968", Offset="0xF44968", VA="0xF44968")]
			get
			{
				return new float();
			}
		}

		public float BattleBadConnectionMinDurationS
		{
			[Address(RVA="0xF44978", Offset="0xF44978", VA="0xF44978")]
			get
			{
				return new float();
			}
		}

		public float BattleBadConnectionUpdateWaitS
		{
			[Address(RVA="0xF44970", Offset="0xF44970", VA="0xF44970")]
			get
			{
				return new float();
			}
		}

		public ulong BattleDefaultFormation
		{
			[Address(RVA="0xF449D0", Offset="0xF449D0", VA="0xF449D0")]
			get
			{
				return new ulong();
			}
		}

		public int BattleStatusEffectTextPriorityLength
		{
			[Address(RVA="0xF445B0", Offset="0xF445B0", VA="0xF445B0")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF44504", Offset="0xF44504", VA="0xF44504", Slot="5")]
			get
			{
				return null;
			}
		}

		public string CcpaUrl
		{
			[Address(RVA="0xF44A90", Offset="0xF44A90", VA="0xF44A90")]
			get
			{
				return null;
			}
		}

		public uint ClubAutoDemoteInactiveLeaderPeriodHours
		{
			[Address(RVA="0xF449C0", Offset="0xF449C0", VA="0xF449C0")]
			get
			{
				return new uint();
			}
		}

		public uint ClubAutoDemoteInactivityPeriodHours
		{
			[Address(RVA="0xF44780", Offset="0xF44780", VA="0xF44780")]
			get
			{
				return new uint();
			}
		}

		public uint ClubAutoPromoteActivityPeriodHours
		{
			[Address(RVA="0xF44788", Offset="0xF44788", VA="0xF44788")]
			get
			{
				return new uint();
			}
		}

		public ulong ClubDungeon
		{
			[Address(RVA="0xF44870", Offset="0xF44870", VA="0xF44870")]
			get
			{
				return new ulong();
			}
		}

		public uint ClubDungeonDurationS
		{
			[Address(RVA="0xF44890", Offset="0xF44890", VA="0xF44890")]
			get
			{
				return new uint();
			}
		}

		public uint ClubDungeonStartTimestamp
		{
			[Address(RVA="0xF44888", Offset="0xF44888", VA="0xF44888")]
			get
			{
				return new uint();
			}
		}

		public uint ClubFindPageSize
		{
			[Address(RVA="0xF449B8", Offset="0xF449B8", VA="0xF449B8")]
			get
			{
				return new uint();
			}
		}

		public uint ClubInviteExpireTime
		{
			[Address(RVA="0xF449A8", Offset="0xF449A8", VA="0xF449A8")]
			get
			{
				return new uint();
			}
		}

		public ulong ClubItemRequestClaimedInboxMessage
		{
			[Address(RVA="0xF446C8", Offset="0xF446C8", VA="0xF446C8")]
			get
			{
				return new ulong();
			}
		}

		public uint ClubItemRequestLifespanHours
		{
			[Address(RVA="0xF446C0", Offset="0xF446C0", VA="0xF446C0")]
			get
			{
				return new uint();
			}
		}

		public uint ClubMaxRosterSize
		{
			[Address(RVA="0xF44648", Offset="0xF44648", VA="0xF44648")]
			get
			{
				return new uint();
			}
		}

		public uint ClubMinPlayerLevel
		{
			[Address(RVA="0xF44830", Offset="0xF44830", VA="0xF44830")]
			get
			{
				return new uint();
			}
		}

		public CollectionScoreTable? CollectionScore
		{
			[Address(RVA="0xF446E0", Offset="0xF446E0", VA="0xF446E0")]
			get
			{
				return null;
			}
		}

		public int ColorIdsLength
		{
			[Address(RVA="0xF44A10", Offset="0xF44A10", VA="0xF44A10")]
			get
			{
				return new int();
			}
		}

		public int CommonAbilityEffectsLength
		{
			[Address(RVA="0xF44588", Offset="0xF44588", VA="0xF44588")]
			get
			{
				return new int();
			}
		}

		public ulong CoopCampaign
		{
			[Address(RVA="0xF44620", Offset="0xF44620", VA="0xF44620")]
			get
			{
				return new ulong();
			}
		}

		public int CreateClubCostLength
		{
			[Address(RVA="0xF44640", Offset="0xF44640", VA="0xF44640")]
			get
			{
				return new int();
			}
		}

		public string CreditsUrl
		{
			[Address(RVA="0xF44698", Offset="0xF44698", VA="0xF44698")]
			get
			{
				return null;
			}
		}

		public Gamedata.CurrencyIds? CurrencyIds
		{
			[Address(RVA="0xF44560", Offset="0xF44560", VA="0xF44560")]
			get
			{
				return null;
			}
		}

		public uint DailyLoginBonusEligibilitySeconds
		{
			[Address(RVA="0xF44658", Offset="0xF44658", VA="0xF44658")]
			get
			{
				return new uint();
			}
		}

		public ItemCount? DailyLoginExpiredBuybackCost
		{
			[Address(RVA="0xF44650", Offset="0xF44650", VA="0xF44650")]
			get
			{
				return null;
			}
		}

		public float DeathSlowMoPostDurationS
		{
			[Address(RVA="0xF44A20", Offset="0xF44A20", VA="0xF44A20")]
			get
			{
				return new float();
			}
		}

		public float DeathSlowMoPreDurationS
		{
			[Address(RVA="0xF44A18", Offset="0xF44A18", VA="0xF44A18")]
			get
			{
				return new float();
			}
		}

		public float DeathSlowMoTimeScale
		{
			[Address(RVA="0xF44A28", Offset="0xF44A28", VA="0xF44A28")]
			get
			{
				return new float();
			}
		}

		public ulong DefaultScheduledEventGroup
		{
			[Address(RVA="0xF449B0", Offset="0xF449B0", VA="0xF449B0")]
			get
			{
				return new ulong();
			}
		}

		public ulong DefaultStoreShowcaseItem
		{
			[Address(RVA="0xF44A60", Offset="0xF44A60", VA="0xF44A60")]
			get
			{
				return new ulong();
			}
		}

		public ulong EnchantedMirrorSpell
		{
			[Address(RVA="0xF446F8", Offset="0xF446F8", VA="0xF446F8")]
			get
			{
				return new ulong();
			}
		}

		public Gamedata.EnergyIds? EnergyIds
		{
			[Address(RVA="0xF44568", Offset="0xF44568", VA="0xF44568")]
			get
			{
				return null;
			}
		}

		public uint FriendListSize
		{
			[Address(RVA="0xF449C8", Offset="0xF449C8", VA="0xF449C8")]
			get
			{
				return new uint();
			}
		}

		public int GearTierColorsLength
		{
			[Address(RVA="0xF44578", Offset="0xF44578", VA="0xF44578")]
			get
			{
				return new int();
			}
		}

		public ulong GrandCampaign
		{
			[Address(RVA="0xF446D0", Offset="0xF446D0", VA="0xF446D0")]
			get
			{
				return new ulong();
			}
		}

		public ulong GrandCampaignHard
		{
			[Address(RVA="0xF44710", Offset="0xF44710", VA="0xF44710")]
			get
			{
				return new ulong();
			}
		}

		public ulong HardRefreshCostItem
		{
			[Address(RVA="0xF44718", Offset="0xF44718", VA="0xF44718")]
			get
			{
				return new ulong();
			}
		}

		public int HardRefreshCostsLength
		{
			[Address(RVA="0xF44728", Offset="0xF44728", VA="0xF44728")]
			get
			{
				return new int();
			}
		}

		public ulong HeroCampaign
		{
			[Address(RVA="0xF44550", Offset="0xF44550", VA="0xF44550")]
			get
			{
				return new ulong();
			}
		}

		public ulong HeroCampaignHard
		{
			[Address(RVA="0xF44700", Offset="0xF44700", VA="0xF44700")]
			get
			{
				return new ulong();
			}
		}

		public ulong HeroCampaignRestriction
		{
			[Address(RVA="0xF447C0", Offset="0xF447C0", VA="0xF447C0")]
			get
			{
				return new ulong();
			}
		}

		public ulong HeroUnitCategory
		{
			[Address(RVA="0xF446E8", Offset="0xF446E8", VA="0xF446E8")]
			get
			{
				return new ulong();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF44530", Offset="0xF44530", VA="0xF44530")]
			get
			{
				return new ulong();
			}
		}

		public GlobalInboxMessages? InboxMessages
		{
			[Address(RVA="0xF44748", Offset="0xF44748", VA="0xF44748")]
			get
			{
				return null;
			}
		}

		public int ItemSortOrderLength
		{
			[Address(RVA="0xF447F8", Offset="0xF447F8", VA="0xF447F8")]
			get
			{
				return new int();
			}
		}

		public uint JoinClubLockResetTimeS
		{
			[Address(RVA="0xF44858", Offset="0xF44858", VA="0xF44858")]
			get
			{
				return new uint();
			}
		}

		public int JoinClubLockTimeSLength
		{
			[Address(RVA="0xF44840", Offset="0xF44840", VA="0xF44840")]
			get
			{
				return new int();
			}
		}

		public ItemCount? KothAttackCooldownResetCost
		{
			[Address(RVA="0xF44930", Offset="0xF44930", VA="0xF44930")]
			get
			{
				return null;
			}
		}

		public uint KothAttackCooldownSeconds
		{
			[Address(RVA="0xF44928", Offset="0xF44928", VA="0xF44928")]
			get
			{
				return new uint();
			}
		}

		public uint KothAutoRefreshFrequencySeconds
		{
			[Address(RVA="0xF44938", Offset="0xF44938", VA="0xF44938")]
			get
			{
				return new uint();
			}
		}

		public uint KothInBattleTimeoutSeconds
		{
			[Address(RVA="0xF44950", Offset="0xF44950", VA="0xF44950")]
			get
			{
				return new uint();
			}
		}

		public uint KothLocalDayEndTimeSeconds
		{
			[Address(RVA="0xF44910", Offset="0xF44910", VA="0xF44910")]
			get
			{
				return new uint();
			}
		}

		public uint KothNumAggregatePayouts
		{
			[Address(RVA="0xF44908", Offset="0xF44908", VA="0xF44908")]
			get
			{
				return new uint();
			}
		}

		public uint KothNumBotsInNewShards
		{
			[Address(RVA="0xF448F0", Offset="0xF448F0", VA="0xF448F0")]
			get
			{
				return new uint();
			}
		}

		public uint KothNumDailyAttacks
		{
			[Address(RVA="0xF44920", Offset="0xF44920", VA="0xF44920")]
			get
			{
				return new uint();
			}
		}

		public uint KothNumPlayersPerShard
		{
			[Address(RVA="0xF448F8", Offset="0xF448F8", VA="0xF448F8")]
			get
			{
				return new uint();
			}
		}

		public ulong KothPayoutInboxMessage
		{
			[Address(RVA="0xF44918", Offset="0xF44918", VA="0xF44918")]
			get
			{
				return new ulong();
			}
		}

		public uint KothShieldMaxRank
		{
			[Address(RVA="0xF44948", Offset="0xF44948", VA="0xF44948")]
			get
			{
				return new uint();
			}
		}

		public uint KothShieldsCooldownSeconds
		{
			[Address(RVA="0xF44900", Offset="0xF44900", VA="0xF44900")]
			get
			{
				return new uint();
			}
		}

		public ulong KothTable
		{
			[Address(RVA="0xF44940", Offset="0xF44940", VA="0xF44940")]
			get
			{
				return new ulong();
			}
		}

		public ulong LimitedPinPageCollection
		{
			[Address(RVA="0xF44628", Offset="0xF44628", VA="0xF44628")]
			get
			{
				return new ulong();
			}
		}

		public int LockableFeaturesLegacyLength
		{
			[Address(RVA="0xF446B8", Offset="0xF446B8", VA="0xF446B8")]
			get
			{
				return new int();
			}
		}

		public ulong LockableFeaturesRef
		{
			[Address(RVA="0xF448E8", Offset="0xF448E8", VA="0xF448E8")]
			get
			{
				return new ulong();
			}
		}

		public uint MaxOptionalDailyActivityCount
		{
			[Address(RVA="0xF44A68", Offset="0xF44A68", VA="0xF44A68")]
			get
			{
				return new uint();
			}
		}

		public uint MaxSeasonAffectingPvpBattlesPerDay
		{
			[Address(RVA="0xF44750", Offset="0xF44750", VA="0xF44750")]
			get
			{
				return new uint();
			}
		}

		public int NewAccountInboxMessagesLength
		{
			[Address(RVA="0xF44608", Offset="0xF44608", VA="0xF44608")]
			get
			{
				return new int();
			}
		}

		public ulong NewAccountLoot
		{
			[Address(RVA="0xF44548", Offset="0xF44548", VA="0xF44548")]
			get
			{
				return new ulong();
			}
		}

		public string NewsletterLastModifiedUrl
		{
			[Address(RVA="0xF44A48", Offset="0xF44A48", VA="0xF44A48")]
			get
			{
				return null;
			}
		}

		public string NewsletterUrl
		{
			[Address(RVA="0xF445E8", Offset="0xF445E8", VA="0xF445E8")]
			get
			{
				return null;
			}
		}

		public Gamedata.NewsletterUrls? NewsletterUrls
		{
			[Address(RVA="0xF44AD0", Offset="0xF44AD0", VA="0xF44AD0")]
			get
			{
				return null;
			}
		}

		public int OfferWallSpecialsLength
		{
			[Address(RVA="0xF44AB8", Offset="0xF44AB8", VA="0xF44AB8")]
			get
			{
				return new int();
			}
		}

		public Gamedata.PassportSeasonLevelTable? PassportSeasonLevelTable
		{
			[Address(RVA="0xF44668", Offset="0xF44668", VA="0xF44668")]
			get
			{
				return null;
			}
		}

		public ulong PassportSeasonPinPageCollection
		{
			[Address(RVA="0xF44660", Offset="0xF44660", VA="0xF44660")]
			get
			{
				return new ulong();
			}
		}

		public PlayerActivityIds? PlayerActivities
		{
			[Address(RVA="0xF447D8", Offset="0xF447D8", VA="0xF447D8")]
			get
			{
				return null;
			}
		}

		public Gamedata.PlayerLevelTable? PlayerLevelTable
		{
			[Address(RVA="0xF44558", Offset="0xF44558", VA="0xF44558")]
			get
			{
				return null;
			}
		}

		public Gamedata.PlayerPowerRating? PlayerPowerRating
		{
			[Address(RVA="0xF445B8", Offset="0xF445B8", VA="0xF445B8")]
			get
			{
				return null;
			}
		}

		public int PlayerProfileStatsLength
		{
			[Address(RVA="0xF445D0", Offset="0xF445D0", VA="0xF445D0")]
			get
			{
				return new int();
			}
		}

		public string PrivacyPolicyUrl
		{
			[Address(RVA="0xF44768", Offset="0xF44768", VA="0xF44768")]
			get
			{
				return null;
			}
		}

		public int ProfanityBlackListExactLength
		{
			[Address(RVA="0xF44818", Offset="0xF44818", VA="0xF44818")]
			get
			{
				return new int();
			}
		}

		public int ProfanityBlackListFuzzyLength
		{
			[Address(RVA="0xF44808", Offset="0xF44808", VA="0xF44808")]
			get
			{
				return new int();
			}
		}

		public int ProfanityWhiteListLength
		{
			[Address(RVA="0xF44828", Offset="0xF44828", VA="0xF44828")]
			get
			{
				return new int();
			}
		}

		public ulong PvpBattle
		{
			[Address(RVA="0xF44AA8", Offset="0xF44AA8", VA="0xF44AA8")]
			get
			{
				return new ulong();
			}
		}

		public string PvpLobbyScene
		{
			[Address(RVA="0xF448C0", Offset="0xF448C0", VA="0xF448C0")]
			get
			{
				return null;
			}
		}

		public uint PvpMatchBucketRange
		{
			[Address(RVA="0xF448B0", Offset="0xF448B0", VA="0xF448B0")]
			get
			{
				return new uint();
			}
		}

		public ulong RandomizedSpellDef
		{
			[Address(RVA="0xF44790", Offset="0xF44790", VA="0xF44790")]
			get
			{
				return new ulong();
			}
		}

		public uint RandomizedSpellMaxCount
		{
			[Address(RVA="0xF447B8", Offset="0xF447B8", VA="0xF447B8")]
			get
			{
				return new uint();
			}
		}

		public int RandomizedSpellOptionsLength
		{
			[Address(RVA="0xF447A0", Offset="0xF447A0", VA="0xF447A0")]
			get
			{
				return new int();
			}
		}

		public uint SavedSquadsFreeCount
		{
			[Address(RVA="0xF44AC0", Offset="0xF44AC0", VA="0xF44AC0")]
			get
			{
				return new uint();
			}
		}

		public uint SavedSquadsVipCount
		{
			[Address(RVA="0xF44AC8", Offset="0xF44AC8", VA="0xF44AC8")]
			get
			{
				return new uint();
			}
		}

		public string SeekerPrefab
		{
			[Address(RVA="0xF449D8", Offset="0xF449D8", VA="0xF449D8")]
			get
			{
				return null;
			}
		}

		public string SeekerRenderTexture
		{
			[Address(RVA="0xF449F0", Offset="0xF449F0", VA="0xF449F0")]
			get
			{
				return null;
			}
		}

		public uint ShardShopSpellPromoMatRate
		{
			[Address(RVA="0xF448E0", Offset="0xF448E0", VA="0xF448E0")]
			get
			{
				return new uint();
			}
		}

		public uint ShardShopUnitPromoMatRate
		{
			[Address(RVA="0xF448D8", Offset="0xF448D8", VA="0xF448D8")]
			get
			{
				return new uint();
			}
		}

		public uint ShardShopUnitSkinRate
		{
			[Address(RVA="0xF44A70", Offset="0xF44A70", VA="0xF44A70")]
			get
			{
				return new uint();
			}
		}

		public Gamedata.ShipmentIds? ShipmentIds
		{
			[Address(RVA="0xF44A88", Offset="0xF44A88", VA="0xF44A88")]
			get
			{
				return null;
			}
		}

		public ulong ShipmentNameMapRef
		{
			[Address(RVA="0xF44958", Offset="0xF44958", VA="0xF44958")]
			get
			{
				return new ulong();
			}
		}

		public uint ShipmentRefreshTime
		{
			[Address(RVA="0xF448B8", Offset="0xF448B8", VA="0xF448B8")]
			get
			{
				return new uint();
			}
		}

		public int SorcererStoneCollectionsLength
		{
			[Address(RVA="0xF44990", Offset="0xF44990", VA="0xF44990")]
			get
			{
				return new int();
			}
		}

		public uint SpecialOfferPopupLimit
		{
			[Address(RVA="0xF44A78", Offset="0xF44A78", VA="0xF44A78")]
			get
			{
				return new uint();
			}
		}

		public uint SpecialOfferPopupLimitCooldownS
		{
			[Address(RVA="0xF44A80", Offset="0xF44A80", VA="0xF44A80")]
			get
			{
				return new uint();
			}
		}

		public Gamedata.StoreAdRewards? StoreAdRewards
		{
			[Address(RVA="0xF447E8", Offset="0xF447E8", VA="0xF447E8")]
			get
			{
				return null;
			}
		}

		public StoreTabIds? StoreTabs
		{
			[Address(RVA="0xF447D0", Offset="0xF447D0", VA="0xF447D0")]
			get
			{
				return null;
			}
		}

		public string SupportUrl
		{
			[Address(RVA="0xF44680", Offset="0xF44680", VA="0xF44680")]
			get
			{
				return null;
			}
		}

		public ulong Tower
		{
			[Address(RVA="0xF44868", Offset="0xF44868", VA="0xF44868")]
			get
			{
				return new ulong();
			}
		}

		public Gamedata.TutorialBattle? TutorialBattle
		{
			[Address(RVA="0xF446D8", Offset="0xF446D8", VA="0xF446D8")]
			get
			{
				return null;
			}
		}

		public Gamedata.UnitPromotionTable? UnitPromotionTable
		{
			[Address(RVA="0xF44538", Offset="0xF44538", VA="0xF44538")]
			get
			{
				return null;
			}
		}

		public ulong UnitPromotionTableRef
		{
			[Address(RVA="0xF44878", Offset="0xF44878", VA="0xF44878")]
			get
			{
				return new ulong();
			}
		}

		public int UnitRangeNamesLength
		{
			[Address(RVA="0xF44678", Offset="0xF44678", VA="0xF44678")]
			get
			{
				return new int();
			}
		}

		public Gamedata.UnitTrainingTable? UnitTrainingTable
		{
			[Address(RVA="0xF44540", Offset="0xF44540", VA="0xF44540")]
			get
			{
				return null;
			}
		}

		public ulong UnitTrainingTableRef
		{
			[Address(RVA="0xF44880", Offset="0xF44880", VA="0xF44880")]
			get
			{
				return new ulong();
			}
		}

		public UnitVisualSequencerAssetIds? UnitVisuals
		{
			[Address(RVA="0xF44740", Offset="0xF44740", VA="0xF44740")]
			get
			{
				return null;
			}
		}

		public ulong VillainCampaign
		{
			[Address(RVA="0xF44630", Offset="0xF44630", VA="0xF44630")]
			get
			{
				return new ulong();
			}
		}

		public ulong VillainCampaignHard
		{
			[Address(RVA="0xF44708", Offset="0xF44708", VA="0xF44708")]
			get
			{
				return new ulong();
			}
		}

		public ulong VillainCampaignRestriction
		{
			[Address(RVA="0xF447C8", Offset="0xF447C8", VA="0xF447C8")]
			get
			{
				return new ulong();
			}
		}

		public ulong VillainUnitCategory
		{
			[Address(RVA="0xF446F0", Offset="0xF446F0", VA="0xF446F0")]
			get
			{
				return new ulong();
			}
		}

		public Gamedata.XpIds? XpIds
		{
			[Address(RVA="0xF44960", Offset="0xF44960", VA="0xF44960")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF44518", Offset="0xF44518", VA="0xF44518")]
		public Constants __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Constants();
		}

		[Address(RVA="0xF4450C", Offset="0xF4450C", VA="0xF4450C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x233106C", Offset="0x233106C", VA="0x233106C")]
		public static void AddAbilityCodesRef(FlatBufferBuilder builder, ulong abilityCodesRef)
		{
		}

		[Address(RVA="0x23308D4", Offset="0x23308D4", VA="0x23308D4")]
		public static void AddAdRewardValidationTimeoutS(FlatBufferBuilder builder, uint adRewardValidationTimeoutS)
		{
		}

		[Address(RVA="0x232FCEC", Offset="0x232FCEC", VA="0x232FCEC")]
		public static void AddAgeGatePlayerActivityClaimedPrompt(FlatBufferBuilder builder, ulong ageGatePlayerActivityClaimedPrompt)
		{
		}

		[Address(RVA="0x2331634", Offset="0x2331634", VA="0x2331634")]
		public static void AddAgeGateReq(FlatBufferBuilder builder, StringOffset ageGateReqOffset)
		{
		}

		[Address(RVA="0x232FCB0", Offset="0x232FCB0", VA="0x232FCB0")]
		public static void AddAgeGateUnderage(FlatBufferBuilder builder, uint ageGateUnderage)
		{
		}

		[Address(RVA="0x23300B4", Offset="0x23300B4", VA="0x23300B4")]
		public static void AddAppRatingData(FlatBufferBuilder builder, Offset<Gamedata.AppRatingData> appRatingDataOffset)
		{
		}

		[Address(RVA="0x2330A78", Offset="0x2330A78", VA="0x2330A78")]
		public static void AddAttributionUrl(FlatBufferBuilder builder, StringOffset attributionUrlOffset)
		{
		}

		[Address(RVA="0x232EDBC", Offset="0x232EDBC", VA="0x232EDBC")]
		public static void AddAutobattleDefaultAiPlayer(FlatBufferBuilder builder, ulong autobattleDefaultAiPlayer)
		{
		}

		[Address(RVA="0x232EBCC", Offset="0x232EBCC", VA="0x232EBCC")]
		public static void AddBattleAbilityCastTimeScale(FlatBufferBuilder builder, float battleAbilityCastTimeScale)
		{
		}

		[Address(RVA="0x2330FA0", Offset="0x2330FA0", VA="0x2330FA0")]
		public static void AddBattleBadConnectionMaxClockDriftS(FlatBufferBuilder builder, float battleBadConnectionMaxClockDriftS)
		{
		}

		[Address(RVA="0x2331028", Offset="0x2331028", VA="0x2331028")]
		public static void AddBattleBadConnectionMinDurationS(FlatBufferBuilder builder, float battleBadConnectionMinDurationS)
		{
		}

		[Address(RVA="0x2330FE4", Offset="0x2330FE4", VA="0x2330FE4")]
		public static void AddBattleBadConnectionUpdateWaitS(FlatBufferBuilder builder, float battleBadConnectionUpdateWaitS)
		{
		}

		[Address(RVA="0x2331344", Offset="0x2331344", VA="0x2331344")]
		public static void AddBattleDefaultFormation(FlatBufferBuilder builder, ulong battleDefaultFormation)
		{
		}

		[Address(RVA="0x232EC10", Offset="0x232EC10", VA="0x232EC10")]
		public static void AddBattleStatusEffectTextPriority(FlatBufferBuilder builder, VectorOffset battleStatusEffectTextPriorityOffset)
		{
		}

		[Address(RVA="0x2331814", Offset="0x2331814", VA="0x2331814")]
		public static void AddCcpaUrl(FlatBufferBuilder builder, StringOffset ccpaUrlOffset)
		{
		}

		[Address(RVA="0x23312CC", Offset="0x23312CC", VA="0x23312CC")]
		public static void AddClubAutoDemoteInactiveLeaderPeriodHours(FlatBufferBuilder builder, uint clubAutoDemoteInactiveLeaderPeriodHours)
		{
		}

		[Address(RVA="0x232FD64", Offset="0x232FD64", VA="0x232FD64")]
		public static void AddClubAutoDemoteInactivityPeriodHours(FlatBufferBuilder builder, uint clubAutoDemoteInactivityPeriodHours)
		{
		}

		[Address(RVA="0x232FDA0", Offset="0x232FDA0", VA="0x232FDA0")]
		public static void AddClubAutoPromoteActivityPeriodHours(FlatBufferBuilder builder, uint clubAutoPromoteActivityPeriodHours)
		{
		}

		[Address(RVA="0x233094C", Offset="0x233094C", VA="0x233094C")]
		public static void AddClubDungeon(FlatBufferBuilder builder, ulong clubDungeon)
		{
		}

		[Address(RVA="0x2330A3C", Offset="0x2330A3C", VA="0x2330A3C")]
		public static void AddClubDungeonDurationS(FlatBufferBuilder builder, uint clubDungeonDurationS)
		{
		}

		[Address(RVA="0x2330A00", Offset="0x2330A00", VA="0x2330A00")]
		public static void AddClubDungeonStartTimestamp(FlatBufferBuilder builder, uint clubDungeonStartTimestamp)
		{
		}

		[Address(RVA="0x2331290", Offset="0x2331290", VA="0x2331290")]
		public static void AddClubFindPageSize(FlatBufferBuilder builder, uint clubFindPageSize)
		{
		}

		[Address(RVA="0x2331218", Offset="0x2331218", VA="0x2331218")]
		public static void AddClubInviteExpireTime(FlatBufferBuilder builder, uint clubInviteExpireTime)
		{
		}

		[Address(RVA="0x232F7F8", Offset="0x232F7F8", VA="0x232F7F8")]
		public static void AddClubItemRequestClaimedInboxMessage(FlatBufferBuilder builder, ulong clubItemRequestClaimedInboxMessage)
		{
		}

		[Address(RVA="0x232F7BC", Offset="0x232F7BC", VA="0x232F7BC")]
		public static void AddClubItemRequestLifespanHours(FlatBufferBuilder builder, uint clubItemRequestLifespanHours)
		{
		}

		[Address(RVA="0x232F338", Offset="0x232F338", VA="0x232F338")]
		public static void AddClubMaxRosterSize(FlatBufferBuilder builder, uint clubMaxRosterSize)
		{
		}

		[Address(RVA="0x23306EC", Offset="0x23306EC", VA="0x23306EC")]
		public static void AddClubMinPlayerLevel(FlatBufferBuilder builder, uint clubMinPlayerLevel)
		{
		}

		[Address(RVA="0x232F8AC", Offset="0x232F8AC", VA="0x232F8AC")]
		public static void AddCollectionScore(FlatBufferBuilder builder, Offset<CollectionScoreTable> collectionScoreOffset)
		{
		}

		[Address(RVA="0x23313F8", Offset="0x23313F8", VA="0x23313F8")]
		public static void AddColorIds(FlatBufferBuilder builder, VectorOffset colorIdsOffset)
		{
		}

		[Address(RVA="0x232EA5C", Offset="0x232EA5C", VA="0x232EA5C")]
		public static void AddCommonAbilityEffects(FlatBufferBuilder builder, VectorOffset commonAbilityEffectsOffset)
		{
		}

		[Address(RVA="0x232F114", Offset="0x232F114", VA="0x232F114")]
		public static void AddCoopCampaign(FlatBufferBuilder builder, ulong coopCampaign)
		{
		}

		[Address(RVA="0x232F1C8", Offset="0x232F1C8", VA="0x232F1C8")]
		public static void AddCreateClubCost(FlatBufferBuilder builder, VectorOffset createClubCostOffset)
		{
		}

		[Address(RVA="0x232F610", Offset="0x232F610", VA="0x232F610")]
		public static void AddCreditsUrl(FlatBufferBuilder builder, StringOffset creditsUrlOffset)
		{
		}

		[Address(RVA="0x232E874", Offset="0x232E874", VA="0x232E874")]
		public static void AddCurrencyIds(FlatBufferBuilder builder, Offset<Gamedata.CurrencyIds> currencyIdsOffset)
		{
		}

		[Address(RVA="0x232F3B0", Offset="0x232F3B0", VA="0x232F3B0")]
		public static void AddDailyLoginBonusEligibilitySeconds(FlatBufferBuilder builder, uint dailyLoginBonusEligibilitySeconds)
		{
		}

		[Address(RVA="0x232F374", Offset="0x232F374", VA="0x232F374")]
		public static void AddDailyLoginExpiredBuybackCost(FlatBufferBuilder builder, Offset<ItemCount> dailyLoginExpiredBuybackCostOffset)
		{
		}

		[Address(RVA="0x23315AC", Offset="0x23315AC", VA="0x23315AC")]
		public static void AddDeathSlowMoPostDurationS(FlatBufferBuilder builder, float deathSlowMoPostDurationS)
		{
		}

		[Address(RVA="0x2331568", Offset="0x2331568", VA="0x2331568")]
		public static void AddDeathSlowMoPreDurationS(FlatBufferBuilder builder, float deathSlowMoPreDurationS)
		{
		}

		[Address(RVA="0x23315F0", Offset="0x23315F0", VA="0x23315F0")]
		public static void AddDeathSlowMoTimeScale(FlatBufferBuilder builder, float deathSlowMoTimeScale)
		{
		}

		[Address(RVA="0x2331254", Offset="0x2331254", VA="0x2331254")]
		public static void AddDefaultScheduledEventGroup(FlatBufferBuilder builder, ulong defaultScheduledEventGroup)
		{
		}

		[Address(RVA="0x23316AC", Offset="0x23316AC", VA="0x23316AC")]
		public static void AddDefaultStoreShowcaseItem(FlatBufferBuilder builder, ulong defaultStoreShowcaseItem)
		{
		}

		[Address(RVA="0x232F960", Offset="0x232F960", VA="0x232F960")]
		public static void AddEnchantedMirrorSpell(FlatBufferBuilder builder, ulong enchantedMirrorSpell)
		{
		}

		[Address(RVA="0x232E8B0", Offset="0x232E8B0", VA="0x232E8B0")]
		public static void AddEnergyIds(FlatBufferBuilder builder, Offset<Gamedata.EnergyIds> energyIdsOffset)
		{
		}

		[Address(RVA="0x2331308", Offset="0x2331308", VA="0x2331308")]
		public static void AddFriendListSize(FlatBufferBuilder builder, uint friendListSize)
		{
		}

		[Address(RVA="0x232E8EC", Offset="0x232E8EC", VA="0x232E8EC")]
		public static void AddGearTierColors(FlatBufferBuilder builder, VectorOffset gearTierColorsOffset)
		{
		}

		[Address(RVA="0x232F834", Offset="0x232F834", VA="0x232F834")]
		public static void AddGrandCampaign(FlatBufferBuilder builder, ulong grandCampaign)
		{
		}

		[Address(RVA="0x232FA14", Offset="0x232FA14", VA="0x232FA14")]
		public static void AddGrandCampaignHard(FlatBufferBuilder builder, ulong grandCampaignHard)
		{
		}

		[Address(RVA="0x232FA50", Offset="0x232FA50", VA="0x232FA50")]
		public static void AddHardRefreshCostItem(FlatBufferBuilder builder, ulong hardRefreshCostItem)
		{
		}

		[Address(RVA="0x232FA8C", Offset="0x232FA8C", VA="0x232FA8C")]
		public static void AddHardRefreshCosts(FlatBufferBuilder builder, VectorOffset hardRefreshCostsOffset)
		{
		}

		[Address(RVA="0x232E7FC", Offset="0x232E7FC", VA="0x232E7FC")]
		public static void AddHeroCampaign(FlatBufferBuilder builder, ulong heroCampaign)
		{
		}

		[Address(RVA="0x232F99C", Offset="0x232F99C", VA="0x232F99C")]
		public static void AddHeroCampaignHard(FlatBufferBuilder builder, ulong heroCampaignHard)
		{
		}

		[Address(RVA="0x232FFC4", Offset="0x232FFC4", VA="0x232FFC4")]
		public static void AddHeroCampaignRestriction(FlatBufferBuilder builder, ulong heroCampaignRestriction)
		{
		}

		[Address(RVA="0x232F8E8", Offset="0x232F8E8", VA="0x232F8E8")]
		public static void AddHeroUnitCategory(FlatBufferBuilder builder, ulong heroUnitCategory)
		{
		}

		[Address(RVA="0x232E70C", Offset="0x232E70C", VA="0x232E70C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x232FC38", Offset="0x232FC38", VA="0x232FC38")]
		public static void AddInboxMessages(FlatBufferBuilder builder, Offset<GlobalInboxMessages> inboxMessagesOffset)
		{
		}

		[Address(RVA="0x233012C", Offset="0x233012C", VA="0x233012C")]
		public static void AddItemSortOrder(FlatBufferBuilder builder, VectorOffset itemSortOrderOffset)
		{
		}

		[Address(RVA="0x2330898", Offset="0x2330898", VA="0x2330898")]
		public static void AddJoinClubLockResetTimeS(FlatBufferBuilder builder, uint joinClubLockResetTimeS)
		{
		}

		[Address(RVA="0x2330728", Offset="0x2330728", VA="0x2330728")]
		public static void AddJoinClubLockTimeS(FlatBufferBuilder builder, VectorOffset joinClubLockTimeSOffset)
		{
		}

		[Address(RVA="0x2330DFC", Offset="0x2330DFC", VA="0x2330DFC")]
		public static void AddKothAttackCooldownResetCost(FlatBufferBuilder builder, Offset<ItemCount> kothAttackCooldownResetCostOffset)
		{
		}

		[Address(RVA="0x2330DC0", Offset="0x2330DC0", VA="0x2330DC0")]
		public static void AddKothAttackCooldownSeconds(FlatBufferBuilder builder, uint kothAttackCooldownSeconds)
		{
		}

		[Address(RVA="0x2330E38", Offset="0x2330E38", VA="0x2330E38")]
		public static void AddKothAutoRefreshFrequencySeconds(FlatBufferBuilder builder, uint kothAutoRefreshFrequencySeconds)
		{
		}

		[Address(RVA="0x2330EEC", Offset="0x2330EEC", VA="0x2330EEC")]
		public static void AddKothInBattleTimeoutSeconds(FlatBufferBuilder builder, uint kothInBattleTimeoutSeconds)
		{
		}

		[Address(RVA="0x2330D0C", Offset="0x2330D0C", VA="0x2330D0C")]
		public static void AddKothLocalDayEndTimeSeconds(FlatBufferBuilder builder, uint kothLocalDayEndTimeSeconds)
		{
		}

		[Address(RVA="0x2330CD0", Offset="0x2330CD0", VA="0x2330CD0")]
		public static void AddKothNumAggregatePayouts(FlatBufferBuilder builder, uint kothNumAggregatePayouts)
		{
		}

		[Address(RVA="0x2330C1C", Offset="0x2330C1C", VA="0x2330C1C")]
		public static void AddKothNumBotsInNewShards(FlatBufferBuilder builder, uint kothNumBotsInNewShards)
		{
		}

		[Address(RVA="0x2330D84", Offset="0x2330D84", VA="0x2330D84")]
		public static void AddKothNumDailyAttacks(FlatBufferBuilder builder, uint kothNumDailyAttacks)
		{
		}

		[Address(RVA="0x2330C58", Offset="0x2330C58", VA="0x2330C58")]
		public static void AddKothNumPlayersPerShard(FlatBufferBuilder builder, uint kothNumPlayersPerShard)
		{
		}

		[Address(RVA="0x2330D48", Offset="0x2330D48", VA="0x2330D48")]
		public static void AddKothPayoutInboxMessage(FlatBufferBuilder builder, ulong kothPayoutInboxMessage)
		{
		}

		[Address(RVA="0x2330EB0", Offset="0x2330EB0", VA="0x2330EB0")]
		public static void AddKothShieldMaxRank(FlatBufferBuilder builder, uint kothShieldMaxRank)
		{
		}

		[Address(RVA="0x2330C94", Offset="0x2330C94", VA="0x2330C94")]
		public static void AddKothShieldsCooldownSeconds(FlatBufferBuilder builder, uint kothShieldsCooldownSeconds)
		{
		}

		[Address(RVA="0x2330E74", Offset="0x2330E74", VA="0x2330E74")]
		public static void AddKothTable(FlatBufferBuilder builder, ulong kothTable)
		{
		}

		[Address(RVA="0x232F150", Offset="0x232F150", VA="0x232F150")]
		public static void AddLimitedPinPageCollection(FlatBufferBuilder builder, ulong limitedPinPageCollection)
		{
		}

		[Address(RVA="0x232F64C", Offset="0x232F64C", VA="0x232F64C")]
		public static void AddLockableFeaturesLegacy(FlatBufferBuilder builder, VectorOffset lockableFeaturesLegacyOffset)
		{
		}

		[Address(RVA="0x2330BE0", Offset="0x2330BE0", VA="0x2330BE0")]
		public static void AddLockableFeaturesRef(FlatBufferBuilder builder, ulong lockableFeaturesRef)
		{
		}

		[Address(RVA="0x23316E8", Offset="0x23316E8", VA="0x23316E8")]
		public static void AddMaxOptionalDailyActivityCount(FlatBufferBuilder builder, uint maxOptionalDailyActivityCount)
		{
		}

		[Address(RVA="0x232FC74", Offset="0x232FC74", VA="0x232FC74")]
		public static void AddMaxSeasonAffectingPvpBattlesPerDay(FlatBufferBuilder builder, uint maxSeasonAffectingPvpBattlesPerDay)
		{
		}

		[Address(RVA="0x232EFA4", Offset="0x232EFA4", VA="0x232EFA4")]
		public static void AddNewAccountInboxMessages(FlatBufferBuilder builder, VectorOffset newAccountInboxMessagesOffset)
		{
		}

		[Address(RVA="0x232E7C0", Offset="0x232E7C0", VA="0x232E7C0")]
		public static void AddNewAccountLoot(FlatBufferBuilder builder, ulong newAccountLoot)
		{
		}

		[Address(RVA="0x2331670", Offset="0x2331670", VA="0x2331670")]
		public static void AddNewsletterLastModifiedUrl(FlatBufferBuilder builder, StringOffset newsletterLastModifiedUrlOffset)
		{
		}

		[Address(RVA="0x232EF68", Offset="0x232EF68", VA="0x232EF68")]
		public static void AddNewsletterUrl(FlatBufferBuilder builder, StringOffset newsletterUrlOffset)
		{
		}

		[Address(RVA="0x2331A74", Offset="0x2331A74", VA="0x2331A74")]
		public static void AddNewsletterUrls(FlatBufferBuilder builder, Offset<Gamedata.NewsletterUrls> newsletterUrlsOffset)
		{
		}

		[Address(RVA="0x233188C", Offset="0x233188C", VA="0x233188C")]
		public static void AddOfferWallSpecials(FlatBufferBuilder builder, VectorOffset offerWallSpecialsOffset)
		{
		}

		[Address(RVA="0x232F428", Offset="0x232F428", VA="0x232F428")]
		public static void AddPassportSeasonLevelTable(FlatBufferBuilder builder, Offset<Gamedata.PassportSeasonLevelTable> passportSeasonLevelTableOffset)
		{
		}

		[Address(RVA="0x232F3EC", Offset="0x232F3EC", VA="0x232F3EC")]
		public static void AddPassportSeasonPinPageCollection(FlatBufferBuilder builder, ulong passportSeasonPinPageCollection)
		{
		}

		[Address(RVA="0x2330078", Offset="0x2330078", VA="0x2330078")]
		public static void AddPlayerActivities(FlatBufferBuilder builder, Offset<PlayerActivityIds> playerActivitiesOffset)
		{
		}

		[Address(RVA="0x232E838", Offset="0x232E838", VA="0x232E838")]
		public static void AddPlayerLevelTable(FlatBufferBuilder builder, Offset<Gamedata.PlayerLevelTable> playerLevelTableOffset)
		{
		}

		[Address(RVA="0x232ED80", Offset="0x232ED80", VA="0x232ED80")]
		public static void AddPlayerPowerRating(FlatBufferBuilder builder, Offset<Gamedata.PlayerPowerRating> playerPowerRatingOffset)
		{
		}

		[Address(RVA="0x232EDF8", Offset="0x232EDF8", VA="0x232EDF8")]
		public static void AddPlayerProfileStats(FlatBufferBuilder builder, VectorOffset playerProfileStatsOffset)
		{
		}

		[Address(RVA="0x232FD28", Offset="0x232FD28", VA="0x232FD28")]
		public static void AddPrivacyPolicyUrl(FlatBufferBuilder builder, StringOffset privacyPolicyUrlOffset)
		{
		}

		[Address(RVA="0x233040C", Offset="0x233040C", VA="0x233040C")]
		public static void AddProfanityBlackListExact(FlatBufferBuilder builder, VectorOffset profanityBlackListExactOffset)
		{
		}

		[Address(RVA="0x233029C", Offset="0x233029C", VA="0x233029C")]
		public static void AddProfanityBlackListFuzzy(FlatBufferBuilder builder, VectorOffset profanityBlackListFuzzyOffset)
		{
		}

		[Address(RVA="0x233057C", Offset="0x233057C", VA="0x233057C")]
		public static void AddProfanityWhiteList(FlatBufferBuilder builder, VectorOffset profanityWhiteListOffset)
		{
		}

		[Address(RVA="0x2331850", Offset="0x2331850", VA="0x2331850")]
		public static void AddPvpBattle(FlatBufferBuilder builder, ulong pvpBattle)
		{
		}

		[Address(RVA="0x2330B2C", Offset="0x2330B2C", VA="0x2330B2C")]
		public static void AddPvpLobbyScene(FlatBufferBuilder builder, StringOffset pvpLobbySceneOffset)
		{
		}

		[Address(RVA="0x2330AB4", Offset="0x2330AB4", VA="0x2330AB4")]
		public static void AddPvpMatchBucketRange(FlatBufferBuilder builder, uint pvpMatchBucketRange)
		{
		}

		[Address(RVA="0x232FDDC", Offset="0x232FDDC", VA="0x232FDDC")]
		public static void AddRandomizedSpellDef(FlatBufferBuilder builder, ulong randomizedSpellDef)
		{
		}

		[Address(RVA="0x232FF88", Offset="0x232FF88", VA="0x232FF88")]
		public static void AddRandomizedSpellMaxCount(FlatBufferBuilder builder, uint randomizedSpellMaxCount)
		{
		}

		[Address(RVA="0x232FE18", Offset="0x232FE18", VA="0x232FE18")]
		public static void AddRandomizedSpellOptions(FlatBufferBuilder builder, VectorOffset randomizedSpellOptionsOffset)
		{
		}

		[Address(RVA="0x23319FC", Offset="0x23319FC", VA="0x23319FC")]
		public static void AddSavedSquadsFreeCount(FlatBufferBuilder builder, uint savedSquadsFreeCount)
		{
		}

		[Address(RVA="0x2331A38", Offset="0x2331A38", VA="0x2331A38")]
		public static void AddSavedSquadsVipCount(FlatBufferBuilder builder, uint savedSquadsVipCount)
		{
		}

		[Address(RVA="0x2331380", Offset="0x2331380", VA="0x2331380")]
		public static void AddSeekerPrefab(FlatBufferBuilder builder, StringOffset seekerPrefabOffset)
		{
		}

		[Address(RVA="0x23313BC", Offset="0x23313BC", VA="0x23313BC")]
		public static void AddSeekerRenderTexture(FlatBufferBuilder builder, StringOffset seekerRenderTextureOffset)
		{
		}

		[Address(RVA="0x2330BA4", Offset="0x2330BA4", VA="0x2330BA4")]
		public static void AddShardShopSpellPromoMatRate(FlatBufferBuilder builder, uint shardShopSpellPromoMatRate)
		{
		}

		[Address(RVA="0x2330B68", Offset="0x2330B68", VA="0x2330B68")]
		public static void AddShardShopUnitPromoMatRate(FlatBufferBuilder builder, uint shardShopUnitPromoMatRate)
		{
		}

		[Address(RVA="0x2331724", Offset="0x2331724", VA="0x2331724")]
		public static void AddShardShopUnitSkinRate(FlatBufferBuilder builder, uint shardShopUnitSkinRate)
		{
		}

		[Address(RVA="0x23317D8", Offset="0x23317D8", VA="0x23317D8")]
		public static void AddShipmentIds(FlatBufferBuilder builder, Offset<Gamedata.ShipmentIds> shipmentIdsOffset)
		{
		}

		[Address(RVA="0x2330F28", Offset="0x2330F28", VA="0x2330F28")]
		public static void AddShipmentNameMapRef(FlatBufferBuilder builder, ulong shipmentNameMapRef)
		{
		}

		[Address(RVA="0x2330AF0", Offset="0x2330AF0", VA="0x2330AF0")]
		public static void AddShipmentRefreshTime(FlatBufferBuilder builder, uint shipmentRefreshTime)
		{
		}

		[Address(RVA="0x23310A8", Offset="0x23310A8", VA="0x23310A8")]
		public static void AddSorcererStoneCollections(FlatBufferBuilder builder, VectorOffset sorcererStoneCollectionsOffset)
		{
		}

		[Address(RVA="0x2331760", Offset="0x2331760", VA="0x2331760")]
		public static void AddSpecialOfferPopupLimit(FlatBufferBuilder builder, uint specialOfferPopupLimit)
		{
		}

		[Address(RVA="0x233179C", Offset="0x233179C", VA="0x233179C")]
		public static void AddSpecialOfferPopupLimitCooldownS(FlatBufferBuilder builder, uint specialOfferPopupLimitCooldownS)
		{
		}

		[Address(RVA="0x23300F0", Offset="0x23300F0", VA="0x23300F0")]
		public static void AddStoreAdRewards(FlatBufferBuilder builder, Offset<Gamedata.StoreAdRewards> storeAdRewardsOffset)
		{
		}

		[Address(RVA="0x233003C", Offset="0x233003C", VA="0x233003C")]
		public static void AddStoreTabs(FlatBufferBuilder builder, Offset<StoreTabIds> storeTabsOffset)
		{
		}

		[Address(RVA="0x232F5D4", Offset="0x232F5D4", VA="0x232F5D4")]
		public static void AddSupportUrl(FlatBufferBuilder builder, StringOffset supportUrlOffset)
		{
		}

		[Address(RVA="0x2330910", Offset="0x2330910", VA="0x2330910")]
		public static void AddTower(FlatBufferBuilder builder, ulong tower)
		{
		}

		[Address(RVA="0x232F870", Offset="0x232F870", VA="0x232F870")]
		public static void AddTutorialBattle(FlatBufferBuilder builder, Offset<Gamedata.TutorialBattle> tutorialBattleOffset)
		{
		}

		[Address(RVA="0x232E748", Offset="0x232E748", VA="0x232E748")]
		public static void AddUnitPromotionTable(FlatBufferBuilder builder, Offset<Gamedata.UnitPromotionTable> unitPromotionTableOffset)
		{
		}

		[Address(RVA="0x2330988", Offset="0x2330988", VA="0x2330988")]
		public static void AddUnitPromotionTableRef(FlatBufferBuilder builder, ulong unitPromotionTableRef)
		{
		}

		[Address(RVA="0x232F464", Offset="0x232F464", VA="0x232F464")]
		public static void AddUnitRangeNames(FlatBufferBuilder builder, VectorOffset unitRangeNamesOffset)
		{
		}

		[Address(RVA="0x232E784", Offset="0x232E784", VA="0x232E784")]
		public static void AddUnitTrainingTable(FlatBufferBuilder builder, Offset<Gamedata.UnitTrainingTable> unitTrainingTableOffset)
		{
		}

		[Address(RVA="0x23309C4", Offset="0x23309C4", VA="0x23309C4")]
		public static void AddUnitTrainingTableRef(FlatBufferBuilder builder, ulong unitTrainingTableRef)
		{
		}

		[Address(RVA="0x232FBFC", Offset="0x232FBFC", VA="0x232FBFC")]
		public static void AddUnitVisuals(FlatBufferBuilder builder, Offset<UnitVisualSequencerAssetIds> unitVisualsOffset)
		{
		}

		[Address(RVA="0x232F18C", Offset="0x232F18C", VA="0x232F18C")]
		public static void AddVillainCampaign(FlatBufferBuilder builder, ulong villainCampaign)
		{
		}

		[Address(RVA="0x232F9D8", Offset="0x232F9D8", VA="0x232F9D8")]
		public static void AddVillainCampaignHard(FlatBufferBuilder builder, ulong villainCampaignHard)
		{
		}

		[Address(RVA="0x2330000", Offset="0x2330000", VA="0x2330000")]
		public static void AddVillainCampaignRestriction(FlatBufferBuilder builder, ulong villainCampaignRestriction)
		{
		}

		[Address(RVA="0x232F924", Offset="0x232F924", VA="0x232F924")]
		public static void AddVillainUnitCategory(FlatBufferBuilder builder, ulong villainUnitCategory)
		{
		}

		[Address(RVA="0x2330F64", Offset="0x2330F64", VA="0x2330F64")]
		public static void AddXpIds(FlatBufferBuilder builder, Offset<Gamedata.XpIds> xpIdsOffset)
		{
		}

		[Address(RVA="0xF445A8", Offset="0xF445A8", VA="0xF445A8")]
		public string BattleStatusEffectTextPriority(int j)
		{
			return null;
		}

		[Address(RVA="0xF44A08", Offset="0xF44A08", VA="0xF44A08")]
		public ColorId? ColorIds(int j)
		{
			return null;
		}

		[Address(RVA="0xF44580", Offset="0xF44580", VA="0xF44580")]
		public ulong CommonAbilityEffects(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x232EC4C", Offset="0x232EC4C", VA="0x232EC4C")]
		public static VectorOffset CreateBattleStatusEffectTextPriorityVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0xF44638", Offset="0xF44638", VA="0xF44638")]
		public ItemCount? CreateClubCost(int j)
		{
			return null;
		}

		[Address(RVA="0x2331434", Offset="0x2331434", VA="0x2331434")]
		public static VectorOffset CreateColorIdsVector(FlatBufferBuilder builder, Offset<ColorId>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232EA98", Offset="0x232EA98", VA="0x232EA98")]
		public static VectorOffset CreateCommonAbilityEffectsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232F204", Offset="0x232F204", VA="0x232F204")]
		public static VectorOffset CreateCreateClubCostVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232E928", Offset="0x232E928", VA="0x232E928")]
		public static VectorOffset CreateGearTierColorsVector(FlatBufferBuilder builder, Offset<Color>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232FAC8", Offset="0x232FAC8", VA="0x232FAC8")]
		public static VectorOffset CreateHardRefreshCostsVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2330168", Offset="0x2330168", VA="0x2330168")]
		public static VectorOffset CreateItemSortOrderVector(FlatBufferBuilder builder, Offset<SortableItem>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2330764", Offset="0x2330764", VA="0x2330764")]
		public static VectorOffset CreateJoinClubLockTimeSVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232F688", Offset="0x232F688", VA="0x232F688")]
		public static VectorOffset CreateLockableFeaturesLegacyVector(FlatBufferBuilder builder, Offset<LockableFeatureEntry>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232EFE0", Offset="0x232EFE0", VA="0x232EFE0")]
		public static VectorOffset CreateNewAccountInboxMessagesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23318C8", Offset="0x23318C8", VA="0x23318C8")]
		public static VectorOffset CreateOfferWallSpecialsVector(FlatBufferBuilder builder, Offset<OfferWallSpecial>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232EE34", Offset="0x232EE34", VA="0x232EE34")]
		public static VectorOffset CreatePlayerProfileStatsVector(FlatBufferBuilder builder, PlayerStat[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2330448", Offset="0x2330448", VA="0x2330448")]
		public static VectorOffset CreateProfanityBlackListExactVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23302D8", Offset="0x23302D8", VA="0x23302D8")]
		public static VectorOffset CreateProfanityBlackListFuzzyVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23305B8", Offset="0x23305B8", VA="0x23305B8")]
		public static VectorOffset CreateProfanityWhiteListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232FE54", Offset="0x232FE54", VA="0x232FE54")]
		public static VectorOffset CreateRandomizedSpellOptionsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23310E4", Offset="0x23310E4", VA="0x23310E4")]
		public static VectorOffset CreateSorcererStoneCollectionsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232F4A0", Offset="0x232F4A0", VA="0x232F4A0")]
		public static VectorOffset CreateUnitRangeNamesVector(FlatBufferBuilder builder, Offset<UnitRangeName>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2331AB0", Offset="0x2331AB0", VA="0x2331AB0")]
		public static Offset<Constants> EndConstants(FlatBufferBuilder builder)
		{
			return new Offset<Constants>();
		}

		[Address(RVA="0x2331B30", Offset="0x2331B30", VA="0x2331B30")]
		public static void FinishConstantsBuffer(FlatBufferBuilder builder, Offset<Constants> offset)
		{
		}

		[Address(RVA="0xF44570", Offset="0xF44570", VA="0xF44570")]
		public Color? GearTierColors(int j)
		{
			return null;
		}

		[Address(RVA="0xF44A38", Offset="0xF44A38", VA="0xF44A38")]
		public ArraySegment<byte>? GetAgeGateReqBytes()
		{
			return null;
		}

		[Address(RVA="0xF448A0", Offset="0xF448A0", VA="0xF448A0")]
		public ArraySegment<byte>? GetAttributionUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF44A98", Offset="0xF44A98", VA="0xF44A98")]
		public ArraySegment<byte>? GetCcpaUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF44590", Offset="0xF44590", VA="0xF44590")]
		public ArraySegment<byte>? GetCommonAbilityEffectsBytes()
		{
			return null;
		}

		[Address(RVA="0xF446A0", Offset="0xF446A0", VA="0xF446A0")]
		public ArraySegment<byte>? GetCreditsUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF44730", Offset="0xF44730", VA="0xF44730")]
		public ArraySegment<byte>? GetHardRefreshCostsBytes()
		{
			return null;
		}

		[Address(RVA="0xF44848", Offset="0xF44848", VA="0xF44848")]
		public ArraySegment<byte>? GetJoinClubLockTimeSBytes()
		{
			return null;
		}

		[Address(RVA="0xF44610", Offset="0xF44610", VA="0xF44610")]
		public ArraySegment<byte>? GetNewAccountInboxMessagesBytes()
		{
			return null;
		}

		[Address(RVA="0xF44A50", Offset="0xF44A50", VA="0xF44A50")]
		public ArraySegment<byte>? GetNewsletterLastModifiedUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF445F0", Offset="0xF445F0", VA="0xF445F0")]
		public ArraySegment<byte>? GetNewsletterUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF445D8", Offset="0xF445D8", VA="0xF445D8")]
		public ArraySegment<byte>? GetPlayerProfileStatsBytes()
		{
			return null;
		}

		[Address(RVA="0xF44770", Offset="0xF44770", VA="0xF44770")]
		public ArraySegment<byte>? GetPrivacyPolicyUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF448C8", Offset="0xF448C8", VA="0xF448C8")]
		public ArraySegment<byte>? GetPvpLobbySceneBytes()
		{
			return null;
		}

		[Address(RVA="0xF447A8", Offset="0xF447A8", VA="0xF447A8")]
		public ArraySegment<byte>? GetRandomizedSpellOptionsBytes()
		{
			return null;
		}

		[Address(RVA="0x232A184", Offset="0x232A184", VA="0x232A184")]
		public static Constants GetRootAsConstants(FlatBuffers.ByteBuffer _bb)
		{
			return new Constants();
		}

		[Address(RVA="0x232A190", Offset="0x232A190", VA="0x232A190")]
		public static Constants GetRootAsConstants(FlatBuffers.ByteBuffer _bb, Constants obj)
		{
			return new Constants();
		}

		[Address(RVA="0xF449E0", Offset="0xF449E0", VA="0xF449E0")]
		public ArraySegment<byte>? GetSeekerPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0xF449F8", Offset="0xF449F8", VA="0xF449F8")]
		public ArraySegment<byte>? GetSeekerRenderTextureBytes()
		{
			return null;
		}

		[Address(RVA="0xF44998", Offset="0xF44998", VA="0xF44998")]
		public ArraySegment<byte>? GetSorcererStoneCollectionsBytes()
		{
			return null;
		}

		[Address(RVA="0xF44688", Offset="0xF44688", VA="0xF44688")]
		public ArraySegment<byte>? GetSupportUrlBytes()
		{
			return null;
		}

		[Address(RVA="0xF44720", Offset="0xF44720", VA="0xF44720")]
		public uint HardRefreshCosts(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF447F0", Offset="0xF447F0", VA="0xF447F0")]
		public SortableItem? ItemSortOrder(int j)
		{
			return null;
		}

		[Address(RVA="0xF44838", Offset="0xF44838", VA="0xF44838")]
		public uint JoinClubLockTimeS(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF446B0", Offset="0xF446B0", VA="0xF446B0")]
		public LockableFeatureEntry? LockableFeaturesLegacy(int j)
		{
			return null;
		}

		[Address(RVA="0xF44600", Offset="0xF44600", VA="0xF44600")]
		public ulong NewAccountInboxMessages(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF44AB0", Offset="0xF44AB0", VA="0xF44AB0")]
		public OfferWallSpecial? OfferWallSpecials(int j)
		{
			return null;
		}

		[Address(RVA="0xF445C8", Offset="0xF445C8", VA="0xF445C8")]
		public PlayerStat PlayerProfileStats(int j)
		{
			return new PlayerStat();
		}

		[Address(RVA="0xF44810", Offset="0xF44810", VA="0xF44810")]
		public string ProfanityBlackListExact(int j)
		{
			return null;
		}

		[Address(RVA="0xF44800", Offset="0xF44800", VA="0xF44800")]
		public string ProfanityBlackListFuzzy(int j)
		{
			return null;
		}

		[Address(RVA="0xF44820", Offset="0xF44820", VA="0xF44820")]
		public string ProfanityWhiteList(int j)
		{
			return null;
		}

		[Address(RVA="0xF44798", Offset="0xF44798", VA="0xF44798")]
		public ulong RandomizedSpellOptions(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF44988", Offset="0xF44988", VA="0xF44988")]
		public ulong SorcererStoneCollections(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x232ED44", Offset="0x232ED44", VA="0x232ED44")]
		public static void StartBattleStatusEffectTextPriorityVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x233152C", Offset="0x233152C", VA="0x233152C")]
		public static void StartColorIdsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232EB90", Offset="0x232EB90", VA="0x232EB90")]
		public static void StartCommonAbilityEffectsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232E6DC", Offset="0x232E6DC", VA="0x232E6DC")]
		public static void StartConstants(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x232F2FC", Offset="0x232F2FC", VA="0x232F2FC")]
		public static void StartCreateClubCostVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232EA20", Offset="0x232EA20", VA="0x232EA20")]
		public static void StartGearTierColorsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232FBC0", Offset="0x232FBC0", VA="0x232FBC0")]
		public static void StartHardRefreshCostsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2330260", Offset="0x2330260", VA="0x2330260")]
		public static void StartItemSortOrderVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x233085C", Offset="0x233085C", VA="0x233085C")]
		public static void StartJoinClubLockTimeSVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232F780", Offset="0x232F780", VA="0x232F780")]
		public static void StartLockableFeaturesLegacyVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232F0D8", Offset="0x232F0D8", VA="0x232F0D8")]
		public static void StartNewAccountInboxMessagesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23319C0", Offset="0x23319C0", VA="0x23319C0")]
		public static void StartOfferWallSpecialsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232EF2C", Offset="0x232EF2C", VA="0x232EF2C")]
		public static void StartPlayerProfileStatsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2330540", Offset="0x2330540", VA="0x2330540")]
		public static void StartProfanityBlackListExactVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23303D0", Offset="0x23303D0", VA="0x23303D0")]
		public static void StartProfanityBlackListFuzzyVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23306B0", Offset="0x23306B0", VA="0x23306B0")]
		public static void StartProfanityWhiteListVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232FF4C", Offset="0x232FF4C", VA="0x232FF4C")]
		public static void StartRandomizedSpellOptionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23311DC", Offset="0x23311DC", VA="0x23311DC")]
		public static void StartSorcererStoneCollectionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232F598", Offset="0x232F598", VA="0x232F598")]
		public static void StartUnitRangeNamesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF44670", Offset="0xF44670", VA="0xF44670")]
		public UnitRangeName? UnitRangeNames(int j)
		{
			return null;
		}
	}
}