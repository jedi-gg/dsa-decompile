using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemFindListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _campaignEntryCostIconRegistry;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _shipmentCurrencyRegistry;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _shipmentItemRegistry;

	[FieldOffset(Offset="0x50")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x58")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x60")]
	private CostController _costController;

	[FieldOffset(Offset="0x68")]
	private CampaignUtility _campaignUtility;

	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _pvpPackRegistry;

	[FieldOffset(Offset="0x78")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x80")]
	private CampaignIdentifier _campaignIdentifier;

	[FieldOffset(Offset="0x88")]
	private ulong? _dailyEventId;

	[FieldOffset(Offset="0x98")]
	private ulong? _scheduledEventId;

	[FieldOffset(Offset="0xA8")]
	private ulong _shipmentDefId;

	[FieldOffset(Offset="0xB0")]
	private ItemFindShipment _itemFindShipment;

	[FieldOffset(Offset="0xB8")]
	private bool _isClubDungeonLocation;

	[FieldOffset(Offset="0xB9")]
	private bool _isArenaLocation;

	[FieldOffset(Offset="0xBA")]
	private bool _isKothLocation;

	[FieldOffset(Offset="0xBC")]
	private PlayerActivityType _playerActivityType;

	[FieldOffset(Offset="0xC0")]
	private bool _isPassportSeasonLevels;

	[FieldOffset(Offset="0xC1")]
	private bool _isStoreLocation;

	[FieldOffset(Offset="0xC2")]
	private bool _isClubWarLocation;

	[FieldOffset(Offset="0xC3")]
	private bool _isTowerLocation;

	[FieldOffset(Offset="0xC8")]
	private UiTimerLabel _attemptResetTimer;

	[FieldOffset(Offset="0xD0")]
	private CampaignUtility.DLimitedAttemptInfo _limitedAttemptInfo;

	[FieldOffset(Offset="0xF0")]
	private UiTimerLabel _eventAvailableInTimer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059AEC", Offset="0x1059AEC")]
	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private UiLabel _titleLabel;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private LabelButton _goButton;

	[Attribute(Name="HeaderAttribute", RVA="0x1059B48", Offset="0x1059B48")]
	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private UiLabel _battleTitleLabel;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private GameObject _battleContainer;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private CostButton _battleButton;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private CostButton _instantBattleButton;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private UiLockableFeature _instantBattleLock;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private UiLabel _rewardsLabel;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private List<Image> _completionStars;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private Sprite _emptyStarSprite;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private Sprite _fullStarSprite;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private List<InventoryItemListItem> _rewardItems;

	[Attribute(Name="HeaderAttribute", RVA="0x1059C24", Offset="0x1059C24")]
	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private GameObject _limitedAttemptsRoot;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private UiLabel _limitedAttemptLabel;

	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private GameObject[] _limitedAttemptHearts;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private Graphic _vipHeart;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private Button _vipButton;

	[FieldOffset(Offset="0x180")]
	[SerializeField]
	private UiLabel _attemptResetTimerLabel;

	[FieldOffset(Offset="0x188")]
	[SerializeField]
	private LabelButton _refreshAttemptsButton;

	[FieldOffset(Offset="0x190")]
	[SerializeField]
	private ClubSupportRequestButton _clubSupportRequestButton;

	[Attribute(Name="HeaderAttribute", RVA="0x1059CE0", Offset="0x1059CE0")]
	[FieldOffset(Offset="0x198")]
	[SerializeField]
	private EventStatusComponent _eventStatusComponent;

	[FieldOffset(Offset="0x1A0")]
	[SerializeField]
	private UiLabel _eventAvailableInPrefixLabel;

	[FieldOffset(Offset="0x1A8")]
	[SerializeField]
	private UiLabel _eventAvailableInLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x1059D4C", Offset="0x1059D4C")]
	[FieldOffset(Offset="0x1B0")]
	[SerializeField]
	private GameObject _shipmentContainer;

	[FieldOffset(Offset="0x1B8")]
	[SerializeField]
	private GameObject _shipmentActiveIndicator;

	[FieldOffset(Offset="0x1C0")]
	[SerializeField]
	private GameObject _shipmentInactiveIndicator;

	[FieldOffset(Offset="0x1C8")]
	[SerializeField]
	private RawImage _shipmentImage;

	[FieldOffset(Offset="0x1D0")]
	[SerializeField]
	private GameObject _shipmentBuyButton;

	[FieldOffset(Offset="0x1D8")]
	[SerializeField]
	private CostButton _shipmentCostButton;

	[FieldOffset(Offset="0x1E0")]
	[SerializeField]
	private GameObject _saleFlag;

	[FieldOffset(Offset="0x1E8")]
	[SerializeField]
	private UiLabel _saleText;

	[FieldOffset(Offset="0x1F0")]
	[SerializeField]
	private UiLabel _quantityText;

	[Attribute(Name="HeaderAttribute", RVA="0x1059E18", Offset="0x1059E18")]
	[FieldOffset(Offset="0x1F8")]
	[SerializeField]
	private GameObject _clubDungeonContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059E64", Offset="0x1059E64")]
	[FieldOffset(Offset="0x200")]
	[SerializeField]
	private GameObject _arenaContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059EB0", Offset="0x1059EB0")]
	[FieldOffset(Offset="0x208")]
	[SerializeField]
	private GameObject _kothContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059EFC", Offset="0x1059EFC")]
	[FieldOffset(Offset="0x210")]
	[SerializeField]
	private GameObject _playerActivitiesContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059F48", Offset="0x1059F48")]
	[FieldOffset(Offset="0x218")]
	[SerializeField]
	private GameObject _passportSeasonLevelsContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059F94", Offset="0x1059F94")]
	[FieldOffset(Offset="0x220")]
	[SerializeField]
	private GameObject _storeContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1059FE0", Offset="0x1059FE0")]
	[FieldOffset(Offset="0x228")]
	[SerializeField]
	private GameObject _clubWarContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x105A02C", Offset="0x105A02C")]
	[FieldOffset(Offset="0x230")]
	[SerializeField]
	private GameObject _pvpPackContainer;

	[FieldOffset(Offset="0x238")]
	[SerializeField]
	private RawImage _pvpPackImage;

	[Attribute(Name="HeaderAttribute", RVA="0x105A088", Offset="0x105A088")]
	[FieldOffset(Offset="0x240")]
	[SerializeField]
	private GameObject _towerContainer;

	[FieldOffset(Offset="0x248")]
	[SerializeField]
	private UiLabel _towerNameLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x105A0E4", Offset="0x105A0E4")]
	[FieldOffset(Offset="0x250")]
	[SerializeField]
	private GameObject _campaignMapRewardContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x105A130", Offset="0x105A130")]
	[FieldOffset(Offset="0x258")]
	[SerializeField]
	private AudioClipGroup _goClickAudio;

	[FieldOffset(Offset="0x260")]
	[SerializeField]
	private AudioClipGroup _battleClickAudio;

	[FieldOffset(Offset="0x268")]
	[SerializeField]
	private AudioClipGroup _instantBattleClickAudio;

	[Address(RVA="0x11C6CFC", Offset="0x11C6CFC", VA="0x11C6CFC")]
	public ItemFindListItem()
	{
	}

	[Address(RVA="0x11C6434", Offset="0x11C6434", VA="0x11C6434")]
	private void BattleClicked()
	{
	}

	[Address(RVA="0x11C6C54", Offset="0x11C6C54", VA="0x11C6C54")]
	private void DirectBuyButtonClicked()
	{
	}

	[Address(RVA="0x11C498C", Offset="0x11C498C", VA="0x11C498C")]
	public RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x11C65CC", Offset="0x11C65CC", VA="0x11C65CC")]
	private void GoClicked()
	{
	}

	[Address(RVA="0x11C2924", Offset="0x11C2924", VA="0x11C2924")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x11C5154", Offset="0x11C5154", VA="0x11C5154")]
	private string InitShipmentContainer(ulong shipmentDefId, bool shipmentActive)
	{
		return null;
	}

	[Address(RVA="0x11C6500", Offset="0x11C6500", VA="0x11C6500")]
	private void InstantBattleButtonClicked()
	{
	}

	[Address(RVA="0x11C6A00", Offset="0x11C6A00", VA="0x11C6A00")]
	private void RefreshAttemptsClicked()
	{
	}

	[Address(RVA="0x11C45FC", Offset="0x11C45FC", VA="0x11C45FC")]
	private void ResetListItem()
	{
	}

	[Address(RVA="0x11C530C", Offset="0x11C530C", VA="0x11C530C")]
	public void SetActiveShipmentData(ItemFindShipment shipment)
	{
	}

	[Address(RVA="0x11C58FC", Offset="0x11C58FC", VA="0x11C58FC")]
	public void SetArenaData()
	{
	}

	[Address(RVA="0x11C3A88", Offset="0x11C3A88", VA="0x11C3A88")]
	public void SetCampaignData(CampaignRewardsPreview campaignRewardsPreview)
	{
	}

	[Address(RVA="0x11C624C", Offset="0x11C624C", VA="0x11C624C")]
	public void SetCampaignMapReward(ulong campaignId)
	{
	}

	[Address(RVA="0x11C5800", Offset="0x11C5800", VA="0x11C5800")]
	public void SetClubDungeonData()
	{
	}

	[Address(RVA="0x11C5E80", Offset="0x11C5E80", VA="0x11C5E80")]
	public void SetClubWarData()
	{
	}

	[Address(RVA="0x11C4C90", Offset="0x11C4C90", VA="0x11C4C90")]
	public void SetDailyEventData(Serverproto.Event eventData)
	{
	}

	[Address(RVA="0x11C4D2C", Offset="0x11C4D2C", VA="0x11C4D2C")]
	private void SetEventData(Serverproto.Event eventData)
	{
	}

	[Address(RVA="0x11C507C", Offset="0x11C507C", VA="0x11C507C")]
	public void SetInactiveShipmentData(ulong shipmentDefId)
	{
	}

	[Address(RVA="0x11C59F8", Offset="0x11C59F8", VA="0x11C59F8")]
	public void SetKothData()
	{
	}

	[Address(RVA="0x11C5C88", Offset="0x11C5C88", VA="0x11C5C88")]
	public void SetPassportSeasonLevels()
	{
	}

	[Address(RVA="0x11C5AF4", Offset="0x11C5AF4", VA="0x11C5AF4")]
	public void SetPlayerActivityData(PlayerActivityType activityType)
	{
	}

	[Address(RVA="0x11C5F7C", Offset="0x11C5F7C", VA="0x11C5F7C")]
	public void SetPvpPackData(string packAssetId)
	{
	}

	[Address(RVA="0x11C4FE0", Offset="0x11C4FE0", VA="0x11C4FE0")]
	public void SetScheduledEventData(Serverproto.Event eventData)
	{
	}

	[Address(RVA="0x11C5D84", Offset="0x11C5D84", VA="0x11C5D84")]
	public void SetStoreData()
	{
	}

	[Address(RVA="0x11C60E0", Offset="0x11C60E0", VA="0x11C60E0")]
	public void SetTowerData(ItemFindTower towerData)
	{
	}

	[Address(RVA="0x11C3204", Offset="0x11C3204", VA="0x11C3204", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11C3508", Offset="0x11C3508", VA="0x11C3508", Slot="5")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x11C36A4", Offset="0x11C36A4", VA="0x11C36A4")]
	private void UpdateLimitedAttemptWidgets()
	{
	}

	[Address(RVA="0x11C6B4C", Offset="0x11C6B4C", VA="0x11C6B4C")]
	private void VipClicked()
	{
	}
}