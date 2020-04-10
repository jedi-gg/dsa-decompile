using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class PlayerDomainController : ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerTotalSpendChangeAction>, IDispatchHandler<DInventoryDeltaAction>, IDispatchHandler<DPlayerActivityDynamicMessageAction>, IDispatchHandler<DPlayerActivityClaimedAction>, IDispatchHandler<DEnergyGeneratedAction>, IDispatchHandler<DEnergyRefreshAction>, IDispatchHandler<DClaimDailyEnergyGiftAction>, IDispatchHandler<DSquadSelectedAction>, IDispatchHandler<DCampaignProgressUpdatedAction>, IDispatchHandler<DDailyLoginClaimedAction>, IDispatchHandler<DDailyLoginExpiredDayBoughtAction>, IDispatchHandler<DDailyLoginBonusClaimedAction>, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DPlayerCollectionPowerDynamicMessageAction>, IDispatchHandler<DShowVipProfileBgDynamicMessage>, IDispatchHandler<DLockableFeatureUpdatedDynamicMessage>, IDispatchHandler<DDisabledFeatureUpdatedDynamicMessage>, IDispatchHandler<DClubItemRequestedAction>, IDispatchHandler<DClubItemDonatedAction>, IDispatchHandler<DEventProgressUpdatedAction>, IDispatchHandler<DEventStatusUpdatedAction>, IDispatchHandler<DEventStatusesUpdatedAction>, IDispatchHandler<DFinishedProcessingDynamicMessages>, IDispatchHandler<DPvpScoreUpdateAction>, IDispatchHandler<DAgeGateStatusAction>, IDispatchHandler<DContextualMessageUnlockedAction>, IDispatchHandler<DContextualMessageAutoCompletedAction>, IDispatchHandler<DAdRewardedEnergyGrantedAction>, IDispatchHandler<DBonusEnergyGenerateBeginAction>, IDispatchHandler<DStoreAdRewardCountUpdated>, IDispatchHandler<DHomeClubDonationsResponse>, IDispatchHandler<DClubSettingsChangedAction>, IDispatchHandler<DClubRosterChangedAction>, IDispatchHandler<DClubFetchedAction>, IDispatchHandler<DEmoteDeckChangeAction>, IDispatchHandler<DFriendsListFetchedAction>, IDispatchHandler<DFriendListModifyAction>, IDispatchHandler<DDailyRewardClaimedAction>, IDispatchHandler<DPlayerVipStatusUpdatedAction>, IDispatchHandler<DPlayerKothRankChangedAction>
{
	[FieldOffset(Offset="0x0")]
	public const int EMOTE_DECK_SIZE = 5;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B4C4", Offset="0x105B4C4")]
	[FieldOffset(Offset="0x10")]
	private Serverproto.Player <Player>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B4D4", Offset="0x105B4D4")]
	[FieldOffset(Offset="0x18")]
	private PlayerLevelUp <PendingPlayerLevelUp>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B4E4", Offset="0x105B4E4")]
	[FieldOffset(Offset="0x20")]
	private PassportSeasonLevelUp <PendingPassportSeasonLevelUp>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B4F4", Offset="0x105B4F4")]
	[FieldOffset(Offset="0x28")]
	private float <PlayerTotalSpend>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B504", Offset="0x105B504")]
	[FieldOffset(Offset="0x2C")]
	private bool <HasShownDailyRewardToday>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B514", Offset="0x105B514")]
	[FieldOffset(Offset="0x30")]
	private ulong <ClubItemDonationsRemaining>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B524", Offset="0x105B524")]
	[FieldOffset(Offset="0x38")]
	private DateTime <ClubItemDonationsResetTime>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105B534", Offset="0x105B534")]
	[FieldOffset(Offset="0x40")]
	private DateTime <NextClubItemRequestTime>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x105B544", Offset="0x105B544")]
	[FieldOffset(Offset="0x48")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105B554", Offset="0x105B554")]
	[FieldOffset(Offset="0x50")]
	private Serverproto.Unit.Factory _unitFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105B564", Offset="0x105B564")]
	[FieldOffset(Offset="0x58")]
	private Serverproto.Spell.Factory _spellFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105B574", Offset="0x105B574")]
	[FieldOffset(Offset="0x60")]
	private TelemetryTranslator _telemetryTranslator;

	[FieldOffset(Offset="0x68")]
	private List<CampaignProgress> _recentlyUpdatedCampaignProgress;

	[FieldOffset(Offset="0x70")]
	private List<Friend> _friends;

	[FieldOffset(Offset="0x78")]
	private bool _activitiesDirty;

	public ulong ClubItemDonationsRemaining
	{
		[Address(RVA="0x132FB2C", Offset="0x132FB2C", VA="0x132FB2C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070488", Offset="0x1070488")]
		get
		{
			return new ulong();
		}
		[Address(RVA="0x132FB34", Offset="0x132FB34", VA="0x132FB34")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070498", Offset="0x1070498")]
		private set
		{
		}
	}

	public DateTime ClubItemDonationsResetTime
	{
		[Address(RVA="0x132FB3C", Offset="0x132FB3C", VA="0x132FB3C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10704A8", Offset="0x10704A8")]
		get
		{
			return new DateTime();
		}
		[Address(RVA="0x132FB44", Offset="0x132FB44", VA="0x132FB44")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10704B8", Offset="0x10704B8")]
		private set
		{
		}
	}

	public bool HasShownDailyRewardToday
	{
		[Address(RVA="0x132F9BC", Offset="0x132F9BC", VA="0x132F9BC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070468", Offset="0x1070468")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x132F9C4", Offset="0x132F9C4", VA="0x132F9C4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070478", Offset="0x1070478")]
		set
		{
		}
	}

	public bool IsVip
	{
		[Address(RVA="0x132FB5C", Offset="0x132FB5C", VA="0x132FB5C")]
		get
		{
			return new bool();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x132F8F0", Offset="0x132F8F0", VA="0x132F8F0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public DateTime NextClubItemRequestTime
	{
		[Address(RVA="0x132FB4C", Offset="0x132FB4C", VA="0x132FB4C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10704C8", Offset="0x10704C8")]
		get
		{
			return new DateTime();
		}
		[Address(RVA="0x132FB54", Offset="0x132FB54", VA="0x132FB54")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10704D8", Offset="0x10704D8")]
		private set
		{
		}
	}

	public PassportSeasonLevelUp PendingPassportSeasonLevelUp
	{
		[Address(RVA="0x132F910", Offset="0x132F910", VA="0x132F910")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070428", Offset="0x1070428")]
		get
		{
			return null;
		}
		[Address(RVA="0x132F918", Offset="0x132F918", VA="0x132F918")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070438", Offset="0x1070438")]
		private set
		{
		}
	}

	public PlayerLevelUp PendingPlayerLevelUp
	{
		[Address(RVA="0x132F900", Offset="0x132F900", VA="0x132F900")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070408", Offset="0x1070408")]
		get
		{
			return null;
		}
		[Address(RVA="0x132F908", Offset="0x132F908", VA="0x132F908")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070418", Offset="0x1070418")]
		private set
		{
		}
	}

	public Serverproto.Player Player
	{
		[Address(RVA="0x132D280", Offset="0x132D280", VA="0x132D280")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10703E8", Offset="0x10703E8")]
		get
		{
			return null;
		}
		[Address(RVA="0x132F8F8", Offset="0x132F8F8", VA="0x132F8F8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10703F8", Offset="0x10703F8")]
		private set
		{
		}
	}

	public bool PlayerHasClaimedDailyLoginToday
	{
		[Address(RVA="0x132F930", Offset="0x132F930", VA="0x132F930")]
		get
		{
			return new bool();
		}
	}

	public bool PlayerHasClaimedDailyRewardToday
	{
		[Address(RVA="0x132F9D0", Offset="0x132F9D0", VA="0x132F9D0")]
		get
		{
			return new bool();
		}
	}

	public float PlayerTotalSpend
	{
		[Address(RVA="0x132F920", Offset="0x132F920", VA="0x132F920")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070448", Offset="0x1070448")]
		get
		{
			return new float();
		}
		[Address(RVA="0x132F928", Offset="0x132F928", VA="0x132F928")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070458", Offset="0x1070458")]
		private set
		{
		}
	}

	public bool ShouldShowDailyLogin
	{
		[Address(RVA="0x132F9A0", Offset="0x132F9A0", VA="0x132F9A0")]
		get
		{
			return new bool();
		}
	}

	public bool ShouldShowDailyReward
	{
		[Address(RVA="0x132FADC", Offset="0x132FADC", VA="0x132FADC")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1339BF0", Offset="0x1339BF0", VA="0x1339BF0")]
	public PlayerDomainController()
	{
	}

	[Address(RVA="0x1339418", Offset="0x1339418", VA="0x1339418")]
	public bool CanDonateItemToClub(Gamedata.InventoryItem item)
	{
		return new bool();
	}

	[Address(RVA="0x1332C0C", Offset="0x1332C0C", VA="0x1332C0C")]
	public bool CanInstantBattleAnyTierInEvent(ulong eventContentId)
	{
		return new bool();
	}

	[Address(RVA="0x1339490", Offset="0x1339490", VA="0x1339490")]
	public bool CanRequestAnyItemFromClub()
	{
		return new bool();
	}

	[Address(RVA="0x133954C", Offset="0x133954C", VA="0x133954C")]
	public bool CanRequestItemFromClub(Gamedata.InventoryItem item)
	{
		return new bool();
	}

	[Address(RVA="0x133083C", Offset="0x133083C", VA="0x133083C")]
	public void ClearPendingPassportLevelUp()
	{
	}

	[Address(RVA="0x1330834", Offset="0x1330834", VA="0x1330834")]
	public void ClearPendingPlayerLevelUp()
	{
	}

	[Address(RVA="0x1331124", Offset="0x1331124", VA="0x1331124")]
	public void ClearRecentlyUpdatedCampaignProgressForMap(ulong campaignId, int mapIndex)
	{
	}

	[Address(RVA="0x1333600", Offset="0x1333600", VA="0x1333600")]
	public IReadOnlyList<Serverproto.PlayerActivity> GetActivities()
	{
		return null;
	}

	[Address(RVA="0x1333F44", Offset="0x1333F44", VA="0x1333F44")]
	public Serverproto.PlayerActivity GetActivity(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1330844", Offset="0x1330844", VA="0x1330844")]
	public CampaignProgress GetCampaignProgress(CampaignIdentifier campaignId)
	{
		return null;
	}

	[Address(RVA="0x1330B1C", Offset="0x1330B1C", VA="0x1330B1C")]
	public CampaignProgress GetCampaignProgress(DCampaignAddress campaignAddress)
	{
		return null;
	}

	[Address(RVA="0x132D168", Offset="0x132D168", VA="0x132D168")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107054C", Offset="0x107054C")]
	public IEnumerable<Serverproto.PlayerActivity> GetDailyPlayerActivities()
	{
		return null;
	}

	[Address(RVA="0x13395B4", Offset="0x13395B4", VA="0x13395B4")]
	public IReadOnlyList<ulong> GetEmoteDeck()
	{
		return null;
	}

	[Address(RVA="0x13325FC", Offset="0x13325FC", VA="0x13325FC")]
	public EventProgress GetEventProgress(EventIdentifier eventId)
	{
		return null;
	}

	[Address(RVA="0x13328E0", Offset="0x13328E0", VA="0x13328E0")]
	public EventProgress GetEventProgress(ulong eventContentId, ulong eventTierIndex)
	{
		return null;
	}

	[Address(RVA="0x1332F18", Offset="0x1332F18", VA="0x1332F18")]
	public EventStatus GetEventStatus(ulong eventContentId)
	{
		return null;
	}

	[Address(RVA="0x13347F0", Offset="0x13347F0", VA="0x13347F0")]
	public int GetFriendRequestPendingSelfAcceptCount()
	{
		return new int();
	}

	[Address(RVA="0x13332E4", Offset="0x13332E4", VA="0x13332E4")]
	public ulong GetHighestCompletedEventTier(ulong eventContentId)
	{
		return new ulong();
	}

	[Address(RVA="0x1331CA4", Offset="0x1331CA4", VA="0x1331CA4")]
	public int GetHighestUnlockedBattleIndex(ulong campaignContentId, int mapIndex, int nodeIndex)
	{
		return new int();
	}

	[Address(RVA="0x133127C", Offset="0x133127C", VA="0x133127C")]
	public int GetHighestUnlockedMapIndex(ulong campaignContentId)
	{
		return new int();
	}

	[Address(RVA="0x13318E4", Offset="0x13318E4", VA="0x13318E4")]
	public CampaignIdentifier GetHighestUnlockedNode(ulong campaignContentId)
	{
		return null;
	}

	[Address(RVA="0x1331588", Offset="0x1331588", VA="0x1331588")]
	public int GetHighestUnlockedNodeIndex(ulong campaignContentId, int mapIndex)
	{
		return new int();
	}

	[Address(RVA="0x133054C", Offset="0x133054C", VA="0x133054C")]
	public long GetItemCount(ulong contentId)
	{
		return new long();
	}

	[Address(RVA="0x132FF08", Offset="0x132FF08", VA="0x132FF08")]
	public IReadOnlyList<Serverproto.InventoryItem> GetItemInventory()
	{
		return null;
	}

	[Address(RVA="0x132D1F4", Offset="0x132D1F4", VA="0x132D1F4")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10704E8", Offset="0x10704E8")]
	public IEnumerable<Serverproto.PlayerActivity> GetLifetimePlayerActivities()
	{
		return null;
	}

	[Address(RVA="0x13331C8", Offset="0x13331C8", VA="0x13331C8")]
	public int GetNextOpenLifetimeEventTier(Event evt)
	{
		return new int();
	}

	[Address(RVA="0x1333E88", Offset="0x1333E88", VA="0x1333E88")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10705B0", Offset="0x10705B0")]
	public IEnumerable<Serverproto.PlayerActivity> GetPassportSeasonPlayerActivities()
	{
		return null;
	}

	[Address(RVA="0x13341F4", Offset="0x13341F4", VA="0x13341F4")]
	public PlayerEnergyTracker GetPlayerEnergyTracker(ulong energyItemId)
	{
		return null;
	}

	[Address(RVA="0x1330ED0", Offset="0x1330ED0", VA="0x1330ED0")]
	public CampaignProgress GetRecentlyUpdatedCampaignProgress(DCampaignAddress campaignAddress)
	{
		return null;
	}

	[Address(RVA="0x1333630", Offset="0x1333630", VA="0x1333630")]
	public int GetRemainingDailyActivityCount()
	{
		return new int();
	}

	[Address(RVA="0x1330228", Offset="0x1330228", VA="0x1330228")]
	public Serverproto.Spell GetSpell(ulong definitionId)
	{
		return null;
	}

	[Address(RVA="0x132FEE8", Offset="0x132FEE8", VA="0x132FEE8")]
	public IReadOnlyList<Serverproto.Spell> GetSpellInventory()
	{
		return null;
	}

	[Address(RVA="0x13344B0", Offset="0x13344B0", VA="0x13344B0")]
	public PlayerSquadSelection GetSquadSelection(Gamedata.GameMode gameMode, ulong slot)
	{
		return null;
	}

	[Address(RVA="0x13322FC", Offset="0x13322FC", VA="0x13322FC")]
	public int GetTotalCampaignMapStars(ulong campaignContentId, int mapIndex)
	{
		return new int();
	}

	[Address(RVA="0x1332048", Offset="0x1332048", VA="0x1332048")]
	public ulong GetTotalCampaignStars(ulong campaignContentId)
	{
		return new ulong();
	}

	[Address(RVA="0x132FF28", Offset="0x132FF28", VA="0x132FF28")]
	public Serverproto.Unit GetUnit(ulong definitionId)
	{
		return null;
	}

	[Address(RVA="0x132FE3C", Offset="0x132FE3C", VA="0x132FE3C")]
	public IReadOnlyList<Serverproto.Unit> GetUnitInventory()
	{
		return null;
	}

	[Address(RVA="0x132FE5C", Offset="0x132FE5C", VA="0x132FE5C")]
	public IEnumerable<Serverproto.Unit> GetUnitInventoryRandomly()
	{
		return null;
	}

	[Address(RVA="0x1334928", Offset="0x1334928", VA="0x1334928", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeAction playerAuthAction)
	{
	}

	[Address(RVA="0x1334E34", Offset="0x1334E34", VA="0x1334E34", Slot="6")]
	public void HandleDispatchAction(DPlayerTotalSpendChangeAction action)
	{
	}

	[Address(RVA="0x1334E3C", Offset="0x1334E3C", VA="0x1334E3C", Slot="29")]
	public void HandleDispatchAction(DPvpScoreUpdateAction action)
	{
	}

	[Address(RVA="0x1334E50", Offset="0x1334E50", VA="0x1334E50", Slot="28")]
	public void HandleDispatchAction(DFinishedProcessingDynamicMessages action)
	{
	}

	[Address(RVA="0x1334E60", Offset="0x1334E60", VA="0x1334E60", Slot="7")]
	public void HandleDispatchAction(DInventoryDeltaAction inventoryDeltaAction)
	{
	}

	[Address(RVA="0x1335B78", Offset="0x1335B78", VA="0x1335B78", Slot="8")]
	public void HandleDispatchAction(DPlayerActivityDynamicMessageAction action)
	{
	}

	[Address(RVA="0x1336064", Offset="0x1336064", VA="0x1336064", Slot="9")]
	public void HandleDispatchAction(DPlayerActivityClaimedAction action)
	{
	}

	[Address(RVA="0x133646C", Offset="0x133646C", VA="0x133646C", Slot="10")]
	public void HandleDispatchAction(DEnergyGeneratedAction action)
	{
	}

	[Address(RVA="0x133664C", Offset="0x133664C", VA="0x133664C", Slot="11")]
	public void HandleDispatchAction(DEnergyRefreshAction action)
	{
	}

	[Address(RVA="0x1336914", Offset="0x1336914", VA="0x1336914", Slot="12")]
	public void HandleDispatchAction(DClaimDailyEnergyGiftAction action)
	{
	}

	[Address(RVA="0x1336C48", Offset="0x1336C48", VA="0x1336C48", Slot="13")]
	public void HandleDispatchAction(DSquadSelectedAction action)
	{
	}

	[Address(RVA="0x1336E64", Offset="0x1336E64", VA="0x1336E64", Slot="14")]
	public void HandleDispatchAction(DCampaignProgressUpdatedAction action)
	{
	}

	[Address(RVA="0x1337208", Offset="0x1337208", VA="0x1337208", Slot="15")]
	public void HandleDispatchAction(DDailyLoginClaimedAction action)
	{
	}

	[Address(RVA="0x1337300", Offset="0x1337300", VA="0x1337300", Slot="16")]
	public void HandleDispatchAction(DDailyLoginExpiredDayBoughtAction action)
	{
	}

	[Address(RVA="0x1337378", Offset="0x1337378", VA="0x1337378", Slot="17")]
	public void HandleDispatchAction(DDailyLoginBonusClaimedAction action)
	{
	}

	[Address(RVA="0x13373C4", Offset="0x13373C4", VA="0x13373C4", Slot="18")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x133788C", Offset="0x133788C", VA="0x133788C", Slot="19")]
	public void HandleDispatchAction(DPlayerCollectionPowerDynamicMessageAction action)
	{
	}

	[Address(RVA="0x1337970", Offset="0x1337970", VA="0x1337970", Slot="20")]
	public void HandleDispatchAction(DShowVipProfileBgDynamicMessage action)
	{
	}

	[Address(RVA="0x1337A10", Offset="0x1337A10", VA="0x1337A10", Slot="21")]
	public void HandleDispatchAction(DLockableFeatureUpdatedDynamicMessage action)
	{
	}

	[Address(RVA="0x1337BC8", Offset="0x1337BC8", VA="0x1337BC8", Slot="22")]
	public void HandleDispatchAction(DDisabledFeatureUpdatedDynamicMessage action)
	{
	}

	[Address(RVA="0x1337D80", Offset="0x1337D80", VA="0x1337D80", Slot="25")]
	public void HandleDispatchAction(DEventProgressUpdatedAction action)
	{
	}

	[Address(RVA="0x133802C", Offset="0x133802C", VA="0x133802C", Slot="26")]
	public void HandleDispatchAction(DEventStatusUpdatedAction action)
	{
	}

	[Address(RVA="0x133826C", Offset="0x133826C", VA="0x133826C", Slot="27")]
	public void HandleDispatchAction(DEventStatusesUpdatedAction action)
	{
	}

	[Address(RVA="0x1338524", Offset="0x1338524", VA="0x1338524", Slot="30")]
	public void HandleDispatchAction(DAgeGateStatusAction action)
	{
	}

	[Address(RVA="0x1338538", Offset="0x1338538", VA="0x1338538", Slot="31")]
	public void HandleDispatchAction(DContextualMessageUnlockedAction action)
	{
	}

	[Address(RVA="0x133886C", Offset="0x133886C", VA="0x133886C", Slot="32")]
	public void HandleDispatchAction(DContextualMessageAutoCompletedAction action)
	{
	}

	[Address(RVA="0x1338994", Offset="0x1338994", VA="0x1338994", Slot="33")]
	public void HandleDispatchAction(DAdRewardedEnergyGrantedAction action)
	{
	}

	[Address(RVA="0x1338C8C", Offset="0x1338C8C", VA="0x1338C8C", Slot="34")]
	public void HandleDispatchAction(DBonusEnergyGenerateBeginAction action)
	{
	}

	[Address(RVA="0x1338F88", Offset="0x1338F88", VA="0x1338F88", Slot="35")]
	public void HandleDispatchAction(DStoreAdRewardCountUpdated action)
	{
	}

	[Address(RVA="0x1338F9C", Offset="0x1338F9C", VA="0x1338F9C", Slot="36")]
	public void HandleDispatchAction(DHomeClubDonationsResponse action)
	{
	}

	[Address(RVA="0x1338FB8", Offset="0x1338FB8", VA="0x1338FB8", Slot="37")]
	public void HandleDispatchAction(DClubSettingsChangedAction action)
	{
	}

	[Address(RVA="0x1339094", Offset="0x1339094", VA="0x1339094", Slot="38")]
	public void HandleDispatchAction(DClubRosterChangedAction action)
	{
	}

	[Address(RVA="0x1339414", Offset="0x1339414", VA="0x1339414", Slot="39")]
	public void HandleDispatchAction(DClubFetchedAction action)
	{
	}

	[Address(RVA="0x1339598", Offset="0x1339598", VA="0x1339598", Slot="23")]
	public void HandleDispatchAction(DClubItemRequestedAction action)
	{
	}

	[Address(RVA="0x13395A0", Offset="0x13395A0", VA="0x13395A0", Slot="24")]
	public void HandleDispatchAction(DClubItemDonatedAction action)
	{
	}

	[Address(RVA="0x1339634", Offset="0x1339634", VA="0x1339634", Slot="40")]
	public void HandleDispatchAction(DEmoteDeckChangeAction action)
	{
	}

	[Address(RVA="0x13396FC", Offset="0x13396FC", VA="0x13396FC", Slot="41")]
	public void HandleDispatchAction(DFriendsListFetchedAction action)
	{
	}

	[Address(RVA="0x13397CC", Offset="0x13397CC", VA="0x13397CC", Slot="42")]
	public void HandleDispatchAction(DFriendListModifyAction action)
	{
	}

	[Address(RVA="0x1339AAC", Offset="0x1339AAC", VA="0x1339AAC", Slot="43")]
	public void HandleDispatchAction(DDailyRewardClaimedAction action)
	{
	}

	[Address(RVA="0x1339BC8", Offset="0x1339BC8", VA="0x1339BC8", Slot="44")]
	public void HandleDispatchAction(DPlayerVipStatusUpdatedAction action)
	{
	}

	[Address(RVA="0x1339BDC", Offset="0x1339BDC", VA="0x1339BDC", Slot="45")]
	public void HandleDispatchAction(DPlayerKothRankChangedAction action)
	{
	}

	[Address(RVA="0x1334E64", Offset="0x1334E64", VA="0x1334E64")]
	private void HandleInventoryDelta(InventoryDelta delta)
	{
	}

	[Address(RVA="0x13338BC", Offset="0x13338BC", VA="0x13338BC")]
	public bool HasAnyTutorialActivities()
	{
		return new bool();
	}

	[Address(RVA="0x1333B78", Offset="0x1333B78", VA="0x1333B78")]
	public bool HasClaimedDailyCompleteAllActivity()
	{
		return new bool();
	}

	[Address(RVA="0x132FC9C", Offset="0x132FC9C", VA="0x132FC9C")]
	public bool HasDayEnded()
	{
		return new bool();
	}

	[Address(RVA="0x132FD6C", Offset="0x132FD6C", VA="0x132FD6C")]
	public bool HasKothDayEnded()
	{
		return new bool();
	}

	[Address(RVA="0x132FC2C", Offset="0x132FC2C", VA="0x132FC2C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1339054", Offset="0x1339054", VA="0x1339054")]
	public bool IsInClub(string clubId)
	{
		return new bool();
	}

	[Address(RVA="0x13347A0", Offset="0x13347A0", VA="0x13347A0")]
	public bool NeedsToSeeAgeGate()
	{
		return new bool();
	}

	[Address(RVA="0x13347C8", Offset="0x13347C8", VA="0x13347C8")]
	public bool PlayerPassedAgeGate()
	{
		return new bool();
	}

	[Address(RVA="0x1334BE4", Offset="0x1334BE4", VA="0x1334BE4")]
	private void ProcessActivities()
	{
	}

	[Address(RVA="0x132FC64", Offset="0x132FC64", VA="0x132FC64")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1338FBC", Offset="0x1338FBC", VA="0x1338FBC")]
	private void UpdateClubAvatar(Club club)
	{
	}

	[Address(RVA="0x13380C0", Offset="0x13380C0", VA="0x13380C0")]
	private void UpdateEventStatus(EventStatus newStatus)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C66C", Offset="0x104C66C")]
	private sealed class <>c__DisplayClass129_0
	{
		[FieldOffset(Offset="0x10")]
		public DFriendListModifyAction action;

		[Address(RVA="0x1339AA4", Offset="0x1339AA4", VA="0x1339AA4")]
		public <>c__DisplayClass129_0()
		{
		}

		[Address(RVA="0x1339C90", Offset="0x1339C90", VA="0x1339C90")]
		internal bool <HandleDispatchAction>b__0(Friend f)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C64C", Offset="0x104C64C")]
	private sealed class <GetDailyPlayerActivities>d__79 : IEnumerable<Serverproto.PlayerActivity>, IEnumerable, IEnumerator<Serverproto.PlayerActivity>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private Serverproto.PlayerActivity <>2__current;

		[FieldOffset(Offset="0x20")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x28")]
		public PlayerDomainController <>4__this;

		[FieldOffset(Offset="0x30")]
		private IEnumerator<Serverproto.PlayerActivity> <>7__wrap1;

		private Serverproto.PlayerActivity System.Collections.Generic.IEnumerator<Serverproto.PlayerActivity>.Current
		{
			[Address(RVA="0x133A0C4", Offset="0x133A0C4", VA="0x133A0C4", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x133A134", Offset="0x133A134", VA="0x133A134", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1333E50", Offset="0x1333E50", VA="0x1333E50")]
		[DebuggerHidden]
		public <GetDailyPlayerActivities>d__79(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x1339D04", Offset="0x1339D04", VA="0x1339D04")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x1339DC4", Offset="0x1339DC4", VA="0x1339DC4", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x133A13C", Offset="0x133A13C", VA="0x133A13C", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<Serverproto.PlayerActivity> System.Collections.Generic.IEnumerable<Serverproto.PlayerActivity>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x133A1EC", Offset="0x133A1EC", VA="0x133A1EC", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x133A0CC", Offset="0x133A0CC", VA="0x133A0CC", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x1339CE8", Offset="0x1339CE8", VA="0x1339CE8", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C63C", Offset="0x104C63C")]
	private sealed class <GetLifetimePlayerActivities>d__78 : IEnumerable<Serverproto.PlayerActivity>, IEnumerable, IEnumerator<Serverproto.PlayerActivity>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private Serverproto.PlayerActivity <>2__current;

		[FieldOffset(Offset="0x20")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x28")]
		public PlayerDomainController <>4__this;

		[FieldOffset(Offset="0x30")]
		private IEnumerator<Serverproto.PlayerActivity> <>7__wrap1;

		private Serverproto.PlayerActivity System.Collections.Generic.IEnumerator<Serverproto.PlayerActivity>.Current
		{
			[Address(RVA="0x133A538", Offset="0x133A538", VA="0x133A538", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x133A5A8", Offset="0x133A5A8", VA="0x133A5A8", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1333E18", Offset="0x1333E18", VA="0x1333E18")]
		[DebuggerHidden]
		public <GetLifetimePlayerActivities>d__78(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x133A20C", Offset="0x133A20C", VA="0x133A20C")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x133A2CC", Offset="0x133A2CC", VA="0x133A2CC", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x133A5B0", Offset="0x133A5B0", VA="0x133A5B0", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<Serverproto.PlayerActivity> System.Collections.Generic.IEnumerable<Serverproto.PlayerActivity>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x133A660", Offset="0x133A660", VA="0x133A660", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x133A540", Offset="0x133A540", VA="0x133A540", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x133A1F0", Offset="0x133A1F0", VA="0x133A1F0", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C65C", Offset="0x104C65C")]
	private sealed class <GetPassportSeasonPlayerActivities>d__80 : IEnumerable<Serverproto.PlayerActivity>, IEnumerable, IEnumerator<Serverproto.PlayerActivity>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private Serverproto.PlayerActivity <>2__current;

		[FieldOffset(Offset="0x20")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x28")]
		public PlayerDomainController <>4__this;

		[FieldOffset(Offset="0x30")]
		private IEnumerator<Serverproto.PlayerActivity> <>7__wrap1;

		private Serverproto.PlayerActivity System.Collections.Generic.IEnumerator<Serverproto.PlayerActivity>.Current
		{
			[Address(RVA="0x133A9D4", Offset="0x133A9D4", VA="0x133A9D4", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x133AA44", Offset="0x133AA44", VA="0x133AA44", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1333F0C", Offset="0x1333F0C", VA="0x1333F0C")]
		[DebuggerHidden]
		public <GetPassportSeasonPlayerActivities>d__80(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x133A680", Offset="0x133A680", VA="0x133A680")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x133A740", Offset="0x133A740", VA="0x133A740", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x133AA4C", Offset="0x133AA4C", VA="0x133AA4C", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<Serverproto.PlayerActivity> System.Collections.Generic.IEnumerable<Serverproto.PlayerActivity>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x133AAFC", Offset="0x133AAFC", VA="0x133AAFC", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x133A9DC", Offset="0x133A9DC", VA="0x133A9DC", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x133A664", Offset="0x133A664", VA="0x133A664", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}
}