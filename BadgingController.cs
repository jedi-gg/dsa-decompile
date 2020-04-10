using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class BadgingController : IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler<DClaimDailyEnergyGiftAction>, IDispatchHandler<DUnreadMessagesResponse>, IDispatchHandler<DDailyLoginClosedAction>, IDispatchHandler<DLockableFeatureUpdatedDynamicMessage>, IDispatchHandler<DClearUnlockedFeatureBadgeAction>, IDispatchHandler<DClubItemDonatedAction>, IDispatchHandler<DClearNewPlayerActivityBadgeAction>, IDispatchHandler<DHelpshiftUnreadCountChangeAction>, IDispatchHandler<DClubDungeonProgressAction>, IDispatchHandler<DHomeClubDungeonStatusResponse>, IDispatchHandler<DHomeClubDonationsResponse>, IDispatchHandler<DClubInvitesProcessedAction>, IDispatchHandler<DClubActivitiesShownAction>, IDispatchHandler<DUnitSkinsViewedProcessedAction>, IDispatchHandler<DScheduledEventDomainUpdatedAction>, IDispatchHandler<DEventStatusProcessedAction>, IDispatchHandler<DHomeKothResponse>, IDispatchHandler<DNewEmoteViewedProcessedAction>, IDispatchHandler<DNewPinViewedProcessedAction>, IDispatchHandler<DHomeClubWarResponse>, IDispatchHandler<DClubRewardOpenedAction>, IDispatchHandler<DViewShownAction>, IDispatchHandler<DNewStorePacksAcknowledgedAction>, IDispatchHandler<DFriendListProcessedAction>, IDispatchHandler<DStoreDataChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105294C", Offset="0x105294C")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105295C", Offset="0x105295C")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105296C", Offset="0x105296C")]
	[FieldOffset(Offset="0x20")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105297C", Offset="0x105297C")]
	[FieldOffset(Offset="0x28")]
	private EventUtility _eventUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105298C", Offset="0x105298C")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105299C", Offset="0x105299C")]
	[FieldOffset(Offset="0x38")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x10529AC", Offset="0x10529AC")]
	[FieldOffset(Offset="0x40")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x10529BC", Offset="0x10529BC")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x10529CC", Offset="0x10529CC")]
	[FieldOffset(Offset="0x50")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[Attribute(Name="InjectAttribute", RVA="0x10529DC", Offset="0x10529DC")]
	[FieldOffset(Offset="0x58")]
	private StoreDomainController _storeDC;

	[Attribute(Name="InjectAttribute", RVA="0x10529EC", Offset="0x10529EC")]
	[FieldOffset(Offset="0x60")]
	private ClubDomainController _clubDC;

	[Attribute(Name="InjectAttribute", RVA="0x10529FC", Offset="0x10529FC")]
	[FieldOffset(Offset="0x68")]
	private StoreUtility _storeUtility;

	[FieldOffset(Offset="0x70")]
	private List<Badge> _badges;

	[FieldOffset(Offset="0x78")]
	private int[] _sharedBadgeCounts;

	[FieldOffset(Offset="0x80")]
	private int _unreadInboxMessageCount;

	[FieldOffset(Offset="0x84")]
	private int _unreadNewsletterMessageCount;

	[FieldOffset(Offset="0x88")]
	private int _helpshiftUnreadCount;

	[FieldOffset(Offset="0x8C")]
	private int _clubDonationsBadgeCount;

	[FieldOffset(Offset="0x90")]
	private bool _showClubDungeonBadge;

	[FieldOffset(Offset="0x91")]
	private bool _showClubActivitiesBadge;

	[FieldOffset(Offset="0x92")]
	private bool _showKothBadge;

	[FieldOffset(Offset="0x93")]
	private bool _showClubWarRegisterBadge;

	[FieldOffset(Offset="0x94")]
	private bool _showClubWarRewardBadge;

	[Address(RVA="0x1164D90", Offset="0x1164D90", VA="0x1164D90")]
	public BadgingController()
	{
	}

	[Address(RVA="0x1162128", Offset="0x1162128", VA="0x1162128")]
	private void CacheSharedBadgeCounts()
	{
	}

	[Address(RVA="0x1163890", Offset="0x1163890", VA="0x1163890")]
	private int GetAbilityUpgradeCount(Badge badge)
	{
		return new int();
	}

	[Address(RVA="0x1162848", Offset="0x1162848", VA="0x1162848")]
	private int GetClubDonationsBadgeCount(IEnumerable<ClubItemRequest> itemRequests)
	{
		return new int();
	}

	[Address(RVA="0x1164140", Offset="0x1164140", VA="0x1164140")]
	private int GetDailyEnergyGiftBadgeCount()
	{
		return new int();
	}

	[Address(RVA="0x1163954", Offset="0x1163954", VA="0x1163954")]
	private int GetGearEquipCount(Badge badge)
	{
		return new int();
	}

	[Address(RVA="0x1164B00", Offset="0x1164B00", VA="0x1164B00")]
	private int GetKothDefenseCount()
	{
		return new int();
	}

	[Address(RVA="0x1163A80", Offset="0x1163A80", VA="0x1163A80")]
	private int GetPlayerActivityBadgeCount(Badge badge, PlayerActivityType activityType)
	{
		return new int();
	}

	[Address(RVA="0x1163DFC", Offset="0x1163DFC", VA="0x1163DFC")]
	private int GetPlayerActivityCompleteAllDailiesBadgeCount()
	{
		return new int();
	}

	[Address(RVA="0x1163804", Offset="0x1163804", VA="0x1163804")]
	private int GetPromotionCount(Badge badge)
	{
		return new int();
	}

	[Address(RVA="0x1164D04", Offset="0x1164D04", VA="0x1164D04")]
	private int GetSpellUpgradeCount(Badge badge)
	{
		return new int();
	}

	[Address(RVA="0x1163778", Offset="0x1163778", VA="0x1163778")]
	private int GetTrainingCount(Badge badge)
	{
		return new int();
	}

	[Address(RVA="0x1161FD4", Offset="0x1161FD4", VA="0x1161FD4", Slot="4")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x1162428", Offset="0x1162428", VA="0x1162428", Slot="5")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x11625A4", Offset="0x11625A4", VA="0x11625A4", Slot="6")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x11625F0", Offset="0x11625F0", VA="0x11625F0", Slot="7")]
	public void HandleDispatchAction(DClaimDailyEnergyGiftAction action)
	{
	}

	[Address(RVA="0x11625F8", Offset="0x11625F8", VA="0x11625F8", Slot="8")]
	public void HandleDispatchAction(DUnreadMessagesResponse response)
	{
	}

	[Address(RVA="0x1162628", Offset="0x1162628", VA="0x1162628", Slot="9")]
	public void HandleDispatchAction(DDailyLoginClosedAction action)
	{
	}

	[Address(RVA="0x1162630", Offset="0x1162630", VA="0x1162630", Slot="10")]
	public void HandleDispatchAction(DLockableFeatureUpdatedDynamicMessage action)
	{
	}

	[Address(RVA="0x116272C", Offset="0x116272C", VA="0x116272C", Slot="11")]
	public void HandleDispatchAction(DClearUnlockedFeatureBadgeAction action)
	{
	}

	[Address(RVA="0x11627E0", Offset="0x11627E0", VA="0x11627E0", Slot="12")]
	public void HandleDispatchAction(DClubItemDonatedAction action)
	{
	}

	[Address(RVA="0x1162D3C", Offset="0x1162D3C", VA="0x1162D3C", Slot="13")]
	public void HandleDispatchAction(DClearNewPlayerActivityBadgeAction action)
	{
	}

	[Address(RVA="0x1162D40", Offset="0x1162D40", VA="0x1162D40", Slot="14")]
	public void HandleDispatchAction(DHelpshiftUnreadCountChangeAction action)
	{
	}

	[Address(RVA="0x1162D60", Offset="0x1162D60", VA="0x1162D60", Slot="15")]
	public void HandleDispatchAction(DClubDungeonProgressAction action)
	{
	}

	[Address(RVA="0x1162E7C", Offset="0x1162E7C", VA="0x1162E7C", Slot="16")]
	public void HandleDispatchAction(DHomeClubDungeonStatusResponse action)
	{
	}

	[Address(RVA="0x1162F78", Offset="0x1162F78", VA="0x1162F78", Slot="17")]
	public void HandleDispatchAction(DHomeClubDonationsResponse action)
	{
	}

	[Address(RVA="0x1162FD0", Offset="0x1162FD0", VA="0x1162FD0", Slot="18")]
	public void HandleDispatchAction(DClubInvitesProcessedAction action)
	{
	}

	[Address(RVA="0x1162FFC", Offset="0x1162FFC", VA="0x1162FFC", Slot="19")]
	public void HandleDispatchAction(DClubActivitiesShownAction action)
	{
	}

	[Address(RVA="0x1163210", Offset="0x1163210", VA="0x1163210", Slot="20")]
	public void HandleDispatchAction(DUnitSkinsViewedProcessedAction action)
	{
	}

	[Address(RVA="0x1163218", Offset="0x1163218", VA="0x1163218", Slot="24")]
	public void HandleDispatchAction(DNewEmoteViewedProcessedAction action)
	{
	}

	[Address(RVA="0x1163220", Offset="0x1163220", VA="0x1163220", Slot="25")]
	public void HandleDispatchAction(DNewPinViewedProcessedAction action)
	{
	}

	[Address(RVA="0x1163228", Offset="0x1163228", VA="0x1163228", Slot="21")]
	public void HandleDispatchAction(DScheduledEventDomainUpdatedAction action)
	{
	}

	[Address(RVA="0x1163254", Offset="0x1163254", VA="0x1163254", Slot="22")]
	public void HandleDispatchAction(DEventStatusProcessedAction action)
	{
	}

	[Address(RVA="0x1163280", Offset="0x1163280", VA="0x1163280", Slot="23")]
	public void HandleDispatchAction(DHomeKothResponse action)
	{
	}

	[Address(RVA="0x11633E0", Offset="0x11633E0", VA="0x11633E0", Slot="26")]
	public void HandleDispatchAction(DHomeClubWarResponse action)
	{
	}

	[Address(RVA="0x1163694", Offset="0x1163694", VA="0x1163694", Slot="27")]
	public void HandleDispatchAction(DClubRewardOpenedAction action)
	{
	}

	[Address(RVA="0x11636AC", Offset="0x11636AC", VA="0x11636AC", Slot="28")]
	public void HandleDispatchAction(DViewShownAction action)
	{
	}

	[Address(RVA="0x1163754", Offset="0x1163754", VA="0x1163754", Slot="29")]
	public void HandleDispatchAction(DNewStorePacksAcknowledgedAction action)
	{
	}

	[Address(RVA="0x116375C", Offset="0x116375C", VA="0x116375C", Slot="30")]
	public void HandleDispatchAction(DFriendListProcessedAction action)
	{
	}

	[Address(RVA="0x1163764", Offset="0x1163764", VA="0x1163764", Slot="31")]
	public void HandleDispatchAction(DStoreDataChangedAction action)
	{
	}

	[Address(RVA="0x1160E20", Offset="0x1160E20", VA="0x1160E20")]
	public void Initialize()
	{
	}

	[Address(RVA="0x11610A0", Offset="0x11610A0", VA="0x11610A0")]
	public void RegisterBadge(Badge badge)
	{
	}

	[Address(RVA="0x1161E94", Offset="0x1161E94", VA="0x1161E94")]
	public void RegisterBadges(List<Badge> badges)
	{
	}

	[Address(RVA="0x1161D74", Offset="0x1161D74", VA="0x1161D74")]
	private void RemoveInvalidBadges()
	{
	}

	[Address(RVA="0x116101C", Offset="0x116101C", VA="0x116101C")]
	private void ResetSharedBadgeCounts()
	{
	}

	[Address(RVA="0x1163194", Offset="0x1163194", VA="0x1163194")]
	public void SetLatestSeenClubItemRequestTime(DateTime requestCreated)
	{
	}

	[Address(RVA="0x1160E5C", Offset="0x1160E5C", VA="0x1160E5C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11611B8", Offset="0x11611B8", VA="0x11611B8")]
	public void UnregisterBadge(Badge badge)
	{
	}

	[Address(RVA="0x1161F34", Offset="0x1161F34", VA="0x1161F34")]
	public void UnregisterBadges(List<Badge> badges)
	{
	}

	[Address(RVA="0x1162458", Offset="0x1162458", VA="0x1162458")]
	private void UpdateAllBadgeCounts(BadgingSource source)
	{
	}

	[Address(RVA="0x11622D8", Offset="0x11622D8", VA="0x11622D8")]
	private void UpdateAllBadges()
	{
	}

	[Address(RVA="0x11612C0", Offset="0x11612C0", VA="0x11612C0")]
	private void UpdateBadgeCount(Badge badge)
	{
	}

	[Address(RVA="0x11623F8", Offset="0x11623F8", VA="0x11623F8")]
	private void UpdateCachedUseableGearMap()
	{
	}
}