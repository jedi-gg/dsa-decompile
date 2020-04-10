using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventTierListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x48")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x50")]
	private UnitSorter _unitSorter;

	[FieldOffset(Offset="0x58")]
	private SingleAssetRegistry _entryCostTextureAssetRegistry;

	[FieldOffset(Offset="0x60")]
	private CostController _costController;

	[FieldOffset(Offset="0x68")]
	private BattleRestrictionUtility _battleRestrictionUtility;

	[FieldOffset(Offset="0x70")]
	private Serverproto.Event _event;

	[FieldOffset(Offset="0x78")]
	private EventTier _eventTier;

	[FieldOffset(Offset="0x80")]
	private EventStatus _eventStatus;

	[FieldOffset(Offset="0x88")]
	private EventProgress _progress;

	[FieldOffset(Offset="0x90")]
	private BattleRestriction? _battleRestriction;

	[FieldOffset(Offset="0xA8")]
	private List<Gamedata.Unit?> _allowedUnitDefs;

	[FieldOffset(Offset="0xB0")]
	private ulong _completionStarCount;

	[FieldOffset(Offset="0xB8")]
	private bool _passesBattleRestrictions;

	[FieldOffset(Offset="0xC0")]
	private object _scrollListOwnerIdentifier;

	[FieldOffset(Offset="0xC8")]
	private List<ItemCountRange> _rewards;

	[FieldOffset(Offset="0xD0")]
	private UiTimerLabel _availableInTimerLabel;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private UiLabel _recommendedLabel;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private UiLabel _lockedLabel;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private UiLabel _lifetimeProgressCompleteLabel;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private List<Image> _completionStars;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private Sprite _filledStar;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private Sprite _emptyStar;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private UnityEngine.Color _filledStarColor;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private UnityEngine.Color _emptyStarColor;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private GameObject _buttonContainer;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private CostButton _instantBattleButton;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private UiLockableFeature _instantBattleLock;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private CostButton _enterBattleButton;

	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private WrappedScrollRect _unitsScrollRect;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private WrappedScrollRect _rewardsScrollRect;

	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private InventoryItemListItem _singleWideRewardItem;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private GameObject _eventInactiveContainer;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private UiLabel _availableInPreview;

	[FieldOffset(Offset="0x180")]
	[SerializeField]
	private UiLabel _availableInLabel;

	[FieldOffset(Offset="0x188")]
	[SerializeField]
	private GameObject _lockIcon;

	[FieldOffset(Offset="0x190")]
	[SerializeField]
	private GameObject _restrictionsNotMetContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x10582E4", Offset="0x10582E4")]
	[FieldOffset(Offset="0x198")]
	[SerializeField]
	private List<GameObject> _restrictionHeaderObjs;

	[FieldOffset(Offset="0x1A0")]
	[SerializeField]
	private BattleRestrictionUtility.Labels _restrictionLabels;

	[Address(RVA="0x12B86CC", Offset="0x12B86CC", VA="0x12B86CC")]
	public EventTierListItem()
	{
	}

	[Address(RVA="0x12B873C", Offset="0x12B873C", VA="0x12B873C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F6D4", Offset="0x106F6D4")]
	private void <SetBattleRestriction>b__6_0(GameObject o)
	{
	}

	[Address(RVA="0x12B81DC", Offset="0x12B81DC", VA="0x12B81DC")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12B7DC8", Offset="0x12B7DC8", VA="0x12B7DC8")]
	private void BindUnitListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12B7ADC", Offset="0x12B7ADC", VA="0x12B7ADC")]
	private void EnterBattleClicked()
	{
	}

	[Address(RVA="0x12B7700", Offset="0x12B7700", VA="0x12B7700")]
	public RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x12B5078", Offset="0x12B5078", VA="0x12B5078")]
	public void Initialize(WidgetDependencyContainer dependencies, object scrollListOwnerIdentifier)
	{
	}

	[Address(RVA="0x12B8100", Offset="0x12B8100", VA="0x12B8100")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x12B7D08", Offset="0x12B7D08", VA="0x12B7D08")]
	private void InitializeUnitListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x12B78A8", Offset="0x12B78A8", VA="0x12B78A8")]
	private void InstantBattleClicked()
	{
	}

	[Address(RVA="0x12B5EB4", Offset="0x12B5EB4", VA="0x12B5EB4")]
	private void SetBattleRestriction()
	{
	}

	[Address(RVA="0x12B5A38", Offset="0x12B5A38", VA="0x12B5A38")]
	public void SetData(Serverproto.Event eventData, EventTier eventTier, EventProgress progress, EventStatus eventStatus)
	{
	}

	[Address(RVA="0x12B60C4", Offset="0x12B60C4", VA="0x12B60C4")]
	private void SetEntryCost(ulong entryCostItemId, ulong entryCostAmount)
	{
	}

	[Address(RVA="0x12B58A8", Offset="0x12B58A8", VA="0x12B58A8")]
	private void SetEventState()
	{
	}

	[Address(RVA="0x12B764C", Offset="0x12B764C", VA="0x12B764C")]
	public void SetPreviewText(string previewText)
	{
	}

	[Address(RVA="0x12B6440", Offset="0x12B6440", VA="0x12B6440")]
	private void SetProgress()
	{
	}

	[Address(RVA="0x12B6750", Offset="0x12B6750", VA="0x12B6750")]
	private void SetRewards()
	{
	}

	[Address(RVA="0x12B6368", Offset="0x12B6368", VA="0x12B6368")]
	private void SetUnits()
	{
	}

	[Address(RVA="0x12B5528", Offset="0x12B5528", VA="0x12B5528", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12B56D8", Offset="0x12B56D8", VA="0x12B56D8", Slot="5")]
	public override void TickUpdate()
	{
	}
}