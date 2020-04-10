using DG.Tweening;
using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitGearView : AStandardView, IItemFindListView, IDispatchHandler<DUnitGearIngredientItemAction>, IDispatchHandler, IDispatchHandler<DClubItemRequestedAction>, IDispatchHandler<DInventoryItemListItemAction>
{
	[FieldOffset(Offset="0x0")]
	private const int DEFAULT_MAX_INGREDIENT_COLUMNS = 6;

	[FieldOffset(Offset="0x0")]
	private const float MAIN_SCROLL_RECT_AUTO_SCROLL_VELOCITY = -4500f;

	[FieldOffset(Offset="0x0")]
	private const float AUTO_SCROLL_THRESHOLD_SQ = 10f;

	[Attribute(Name="InjectAttribute", RVA="0x105F6A0", Offset="0x105F6A0")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F6B0", Offset="0x105F6B0")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F6C0", Offset="0x105F6C0")]
	[FieldOffset(Offset="0x78")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105F6D0", Offset="0x105F6D0")]
	[FieldOffset(Offset="0x80")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105F6E0", Offset="0x105F6E0")]
	[FieldOffset(Offset="0x88")]
	private UnitVisualSequencerFactory _unitVisualSequencerFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105F6F0", Offset="0x105F6F0")]
	[FieldOffset(Offset="0x90")]
	private SingleAssetRegistry _unitModelAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F700", Offset="0x105F700")]
	[FieldOffset(Offset="0x98")]
	private SingleAssetRegistry _buyAndEquipCostImageAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F710", Offset="0x105F710")]
	[FieldOffset(Offset="0xA0")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105F720", Offset="0x105F720")]
	[FieldOffset(Offset="0xA8")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0xB0")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0xB8")]
	private UnitGearTier _unitGearTier;

	[FieldOffset(Offset="0xC8")]
	private Gamedata.InventoryItem _mainGearItem;

	[FieldOffset(Offset="0xD8")]
	private int _gearSlotIndex;

	[FieldOffset(Offset="0xE0")]
	private RectTransform _mainScrollRectTransform;

	[FieldOffset(Offset="0xE8")]
	private Transform _unitTransform;

	[FieldOffset(Offset="0xF0")]
	private UnitVisualSequencer _idleSequencer;

	[FieldOffset(Offset="0xF8")]
	private UnitVisualSequencer _upgradeCelebrationSequencer;

	[FieldOffset(Offset="0x100")]
	private Vector3 _contentStartingScreenPoint;

	[FieldOffset(Offset="0x110")]
	private List<UnitGearView.DBreadcrumbData> _ingredientBreadcrumbs;

	[FieldOffset(Offset="0x118")]
	private List<UnitGearIngredientColumn> _ingredientColumns;

	[FieldOffset(Offset="0x120")]
	private ulong _grindCurrencyItemId;

	[FieldOffset(Offset="0x128")]
	private bool _itemFindUnlocked;

	[FieldOffset(Offset="0x130")]
	private UiTimerLabel _requestTimerLabel;

	[FieldOffset(Offset="0x138")]
	private Sequence _powerTween;

	[FieldOffset(Offset="0x140")]
	private Sequence _statsEquippedTween;

	[FieldOffset(Offset="0x148")]
	private ItemFindListIndexTutorialPointAtLookup _itemFindPointAtLookup;

	private UnitGearView.SerializedFields Fields
	{
		[Address(RVA="0x11F5CD8", Offset="0x11F5CD8", VA="0x11F5CD8")]
		get
		{
			return null;
		}
	}

	private Gamedata.InventoryItem? SelectedBreadcrumbItem
	{
		[Address(RVA="0x11F9440", Offset="0x11F9440", VA="0x11F9440")]
		get
		{
			return null;
		}
	}

	private bool SelectedBreadcrumbItemHasRecipe
	{
		[Address(RVA="0x11F8F5C", Offset="0x11F8F5C", VA="0x11F8F5C")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11FC968", Offset="0x11FC968", VA="0x11FC968")]
	public UnitGearView()
	{
	}

	[Address(RVA="0x11FCA04", Offset="0x11FCA04", VA="0x11FCA04")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10710AC", Offset="0x10710AC")]
	private void <LoadUnitModel>b__38_0(AssetHandle assetHandle)
	{
	}

	[Address(RVA="0x11F624C", Offset="0x11F624C", VA="0x11F624C")]
	private void AddBreadcrumbItem(ulong itemId)
	{
	}

	[Address(RVA="0x11FC354", Offset="0x11FC354", VA="0x11FC354")]
	private void CreateRuntimeIngredientColumn(int i)
	{
	}

	[Address(RVA="0x11FC094", Offset="0x11FC094", VA="0x11FC094")]
	private void DispatchClubRequest()
	{
	}

	[Address(RVA="0x11FBFF4", Offset="0x11FBFF4", VA="0x11FBFF4")]
	private void DispatchViewAction(DUnitGearViewAction.Type actionType)
	{
	}

	[Address(RVA="0x11FBBE8", Offset="0x11FBBE8", VA="0x11FBBE8", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x11F9534", Offset="0x11F9534", VA="0x11F9534", Slot="24")]
	public long? GetItemGoalCount()
	{
		return null;
	}

	[Address(RVA="0x11EFAB0", Offset="0x11EFAB0", VA="0x11EFAB0")]
	public List<ulong> GetSelectedIngredients()
	{
		return null;
	}

	[Address(RVA="0x11F9644", Offset="0x11F9644", VA="0x11F9644", Slot="26")]
	public void HandleDispatchAction(DUnitGearIngredientItemAction action)
	{
	}

	[Address(RVA="0x11F991C", Offset="0x11F991C", VA="0x11F991C", Slot="27")]
	public void HandleDispatchAction(DClubItemRequestedAction action)
	{
	}

	[Address(RVA="0x11F99D8", Offset="0x11F99D8", VA="0x11F99D8", Slot="28")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x11F14D8", Offset="0x11F14D8", VA="0x11F14D8")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x11FC694", Offset="0x11FC694", VA="0x11FC694")]
	private void InitializeItemFindListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11FC778", Offset="0x11FC778", VA="0x11FC778")]
	private void ItemFindScrolled(Vector2 normalizedPos)
	{
	}

	[Address(RVA="0x11FC18C", Offset="0x11FC18C", VA="0x11FC18C")]
	private bool ItemIsEligibleForBuyAndEquip(Gamedata.InventoryItem? item, UnitGearSlotState gearSlotState)
	{
		return new bool();
	}

	[Address(RVA="0x11F7004", Offset="0x11F7004", VA="0x11F7004")]
	private void LoadUnitModel(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x11FAE44", Offset="0x11FAE44", VA="0x11FAE44")]
	private void MainScrollRectScrolled(Vector2 normalizedPos)
	{
	}

	[Address(RVA="0x11F0F9C", Offset="0x11F0F9C", VA="0x11F0F9C")]
	public void PlayCraftGearAnimation()
	{
	}

	[Address(RVA="0x11F180C", Offset="0x11F180C", VA="0x11F180C")]
	public void PlayEquipGearAnimation(Serverproto.Unit oldUnit, Serverproto.Unit newUnit, bool multipleGearEquipped)
	{
	}

	[Address(RVA="0x11F3038", Offset="0x11F3038", VA="0x11F3038")]
	public void PlayTierUpAnimation(Serverproto.Unit oldUnit, Serverproto.Unit newUnit)
	{
	}

	[Address(RVA="0x11F9604", Offset="0x11F9604", VA="0x11F9604", Slot="25")]
	public void RebindItemFindList()
	{
	}

	[Address(RVA="0x11F5DB8", Offset="0x11F5DB8", VA="0x11F5DB8")]
	private void RefreshRequestButtonAndTimer()
	{
	}

	[Address(RVA="0x11EF950", Offset="0x11EF950", VA="0x11EF950")]
	public void RefreshUi(bool resetItemFindScroll = true, bool scrollToEnd = true)
	{
	}

	[Address(RVA="0x11F0380", Offset="0x11F0380", VA="0x11F0380")]
	public void ScrollToEnd()
	{
	}

	[Address(RVA="0x11F0224", Offset="0x11F0224", VA="0x11F0224")]
	public void SelectIngredients(List<ulong> selectedIngredientIds)
	{
	}

	[Address(RVA="0x11EEE90", Offset="0x11EEE90", VA="0x11EEE90")]
	public void SetGearItem(Gamedata.InventoryItem item, List<ulong> selectedIngredientIds)
	{
	}

	[Address(RVA="0x11EF40C", Offset="0x11EF40C", VA="0x11EF40C")]
	public void SetGearSlot(UnitGearSlot unitGearSlot, int gearSlotIndex)
	{
	}

	[Address(RVA="0x11F91E8", Offset="0x11F91E8", VA="0x11F91E8", Slot="23")]
	public void SetItemFindResults(ulong itemId, int itemFindListCount)
	{
	}

	[Address(RVA="0x11F90CC", Offset="0x11F90CC", VA="0x11F90CC", Slot="21")]
	public void SetListItemBindDataDelegate(WrappedScrollRect.BindDataDelegate bindDataDelegate)
	{
	}

	[Address(RVA="0x11F7890", Offset="0x11F7890", VA="0x11F7890")]
	private void SetStatLabels(Serverproto.Unit unit, UnitGearSlot unitGearSlot)
	{
	}

	[Address(RVA="0x11F91E0", Offset="0x11F91E0", VA="0x11F91E0", Slot="22")]
	public void SetTutorialPointAtLookup(ItemFindListIndexTutorialPointAtLookup lookup)
	{
	}

	[Address(RVA="0x11EF380", Offset="0x11EF380", VA="0x11EF380")]
	public void SetUnit(Serverproto.Unit unit, UnitGearTier unitGearTier)
	{
	}

	[Address(RVA="0x11FB8B4", Offset="0x11FB8B4", VA="0x11FB8B4")]
	private void ShutdownUnitVisuals()
	{
	}

	[Address(RVA="0x11ECDA8", Offset="0x11ECDA8", VA="0x11ECDA8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11FC8E8", Offset="0x11FC8E8", VA="0x11FC8E8")]
	private void ToggleDescriptionWindow()
	{
	}

	[Address(RVA="0x11F6468", Offset="0x11F6468", VA="0x11F6468")]
	private void UpdateIngredientTree(bool resetItemFindScroll = true, bool scrollToEnd = true)
	{
	}

	[Address(RVA="0x11F8810", Offset="0x11F8810", VA="0x11F8810")]
	private void UpdateMainGearCount()
	{
	}

	[Address(RVA="0x11F7114", Offset="0x11F7114", VA="0x11F7114")]
	private void UpdateUnitGearSlotState()
	{
	}

	[Address(RVA="0x11F60F0", Offset="0x11F60F0", VA="0x11F60F0")]
	private void UpdateUnitGearUsedByCount()
	{
	}

	[Address(RVA="0x11F85F4", Offset="0x11F85F4", VA="0x11F85F4")]
	private void UpdateUnitRequirements(Serverproto.Unit unit, UnitGearSlot unitGearSlot)
	{
	}

	[Address(RVA="0x11F9BBC", Offset="0x11F9BBC", VA="0x11F9BBC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11FB2C8", Offset="0x11FB2C8", VA="0x11FB2C8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D13C", Offset="0x104D13C")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitGearView <>4__this;

		[FieldOffset(Offset="0x18")]
		public List<CostButton> craftCostButtons;

		[Address(RVA="0x1501498", Offset="0x1501498", VA="0x1501498")]
		public <>c__DisplayClass19_0()
		{
		}

		[Address(RVA="0x15014A0", Offset="0x15014A0", VA="0x15014A0")]
		internal void <ViewAssetLoaded>b__0()
		{
		}

		[Address(RVA="0x15014D4", Offset="0x15014D4", VA="0x15014D4")]
		internal void <ViewAssetLoaded>b__1()
		{
		}

		[Address(RVA="0x1501508", Offset="0x1501508", VA="0x1501508")]
		internal void <ViewAssetLoaded>b__2()
		{
		}

		[Address(RVA="0x150153C", Offset="0x150153C", VA="0x150153C")]
		internal void <ViewAssetLoaded>b__3()
		{
		}

		[Address(RVA="0x1501570", Offset="0x1501570", VA="0x1501570")]
		internal void <ViewAssetLoaded>b__4()
		{
		}

		[Address(RVA="0x15015A4", Offset="0x15015A4", VA="0x15015A4")]
		internal void <ViewAssetLoaded>b__5(AssetHandle assetHandle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D14C", Offset="0x104D14C")]
	private sealed class <>c__DisplayClass32_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitGearIngredientColumn newIngredientColumn;

		[Address(RVA="0x150177C", Offset="0x150177C", VA="0x150177C")]
		public <>c__DisplayClass32_0()
		{
		}

		[Address(RVA="0x1501784", Offset="0x1501784", VA="0x1501784")]
		internal void <CreateRuntimeIngredientColumn>b__0(AssetHandle assetHandle)
		{
		}
	}

	public struct DBreadcrumbData
	{
		[FieldOffset(Offset="0x0")]
		public Gamedata.InventoryItem? Item;

		[FieldOffset(Offset="0x18")]
		public long RequiredCount;
	}

	[Serializable]
	public class ScrollRectParallax
	{
		[FieldOffset(Offset="0x10")]
		public Transform Transform;

		[FieldOffset(Offset="0x18")]
		public bool LookAt;

		[FieldOffset(Offset="0x1C")]
		[NonSerialized]
		public Vector3 StartingScreenPoint;

		[Address(RVA="0x15018AC", Offset="0x15018AC", VA="0x15018AC")]
		public ScrollRectParallax()
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C3D4", Offset="0x106C3D4")]
		[FieldOffset(Offset="0x28")]
		public ScrollRect MainScrollRect;

		[FieldOffset(Offset="0x30")]
		public HorizontalLayoutGroup MainLayoutGroup;

		[FieldOffset(Offset="0x38")]
		public int NoItemFindContentRightPadding;

		[Attribute(Name="HeaderAttribute", RVA="0x106C40C", Offset="0x106C40C")]
		[FieldOffset(Offset="0x40")]
		public List<UnitGearView.ScrollRectParallax> ScrollRectParallax;

		[FieldOffset(Offset="0x48")]
		public Camera WorldCamera;

		[FieldOffset(Offset="0x50")]
		public Transform UnitModelMarker;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject UnitModelLoader;

		[FieldOffset(Offset="0x60")]
		public UnitGearSlotStateData GearSlotStateData;

		[FieldOffset(Offset="0x68")]
		public List<UnitDetailsGearSlot> GearSlots;

		[FieldOffset(Offset="0x70")]
		public Button TierUpButton;

		[FieldOffset(Offset="0x78")]
		public Button EquipAllButton;

		[FieldOffset(Offset="0x80")]
		public CostButton BuyAndEquipAllButton;

		[FieldOffset(Offset="0x88")]
		public Graphic CurrentGearTierIndicator;

		[FieldOffset(Offset="0x90")]
		public UiLabel GearTierLabel;

		[FieldOffset(Offset="0x98")]
		public UiLabel GearStatsEquippedLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106C444", Offset="0x106C444")]
		[FieldOffset(Offset="0xA0")]
		public InventoryItemListItem GearItem;

		[FieldOffset(Offset="0xA8")]
		public UiLabel GearOwnedLabel;

		[FieldOffset(Offset="0xB0")]
		public UiLabel GearNameLabel;

		[FieldOffset(Offset="0xB8")]
		public List<UnitGearStatLabels> StatLabels;

		[FieldOffset(Offset="0xC0")]
		public LabelButton EquipButton;

		[FieldOffset(Offset="0xC8")]
		public CostButton BuyAndEquipButton;

		[FieldOffset(Offset="0xD0")]
		public UiLabel RequirementsLabel;

		[FieldOffset(Offset="0xD8")]
		public UnityEngine.Color RequirementMetLabelColor;

		[FieldOffset(Offset="0xE8")]
		public UnityEngine.Color RequirementFailedLabelColor;

		[FieldOffset(Offset="0xF8")]
		public UnityEngine.GameObject OtherUnitsUseableContainer;

		[FieldOffset(Offset="0x100")]
		public UiLabel OtherUnitsUseableLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106C47C", Offset="0x106C47C")]
		[FieldOffset(Offset="0x108")]
		public RectTransform IngredientColumnsLayoutRect;

		[FieldOffset(Offset="0x110")]
		public UnitGearIngredientColumn IngredientColumnArchetype;

		[Attribute(Name="HeaderAttribute", RVA="0x106C4B4", Offset="0x106C4B4")]
		[FieldOffset(Offset="0x118")]
		public UnityEngine.GameObject ItemFindContainer;

		[FieldOffset(Offset="0x120")]
		public UnityEngine.GameObject LockedItemFindContainer;

		[FieldOffset(Offset="0x128")]
		public WrappedScrollRect ItemFindScrollRect;

		[FieldOffset(Offset="0x130")]
		public UnityEngine.GameObject ItemFindLoadingSpinner;

		[FieldOffset(Offset="0x138")]
		public CanvasGroup ItemFindTitleContainer;

		[FieldOffset(Offset="0x140")]
		public float ItemFindTitleAlphaYCutoff;

		[FieldOffset(Offset="0x148")]
		public UiLabel NoLocationsLabel;

		[FieldOffset(Offset="0x150")]
		public LabelButton RequestButton;

		[FieldOffset(Offset="0x158")]
		public UnityEngine.GameObject RequestButtonBadge;

		[FieldOffset(Offset="0x160")]
		public UiLabel RequestTimerLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106C4EC", Offset="0x106C4EC")]
		[FieldOffset(Offset="0x168")]
		public Button GearFeatureInfoButton;

		[FieldOffset(Offset="0x170")]
		public Button GearFeatureCloseButton;

		[FieldOffset(Offset="0x178")]
		public UnityEngine.GameObject GearFeatureDescriptionWindow;

		[Attribute(Name="HeaderAttribute", RVA="0x106C524", Offset="0x106C524")]
		[FieldOffset(Offset="0x180")]
		public float CraftTweenScale;

		[FieldOffset(Offset="0x184")]
		public float CraftTweenDuration;

		[Attribute(Name="RangeAttribute", RVA="0x106C55C", Offset="0x106C55C")]
		[FieldOffset(Offset="0x188")]
		public float CraftTweenElasticity;

		[Attribute(Name="HeaderAttribute", RVA="0x106C574", Offset="0x106C574")]
		[FieldOffset(Offset="0x190")]
		public ParticleSystem EquipParticles;

		[FieldOffset(Offset="0x198")]
		public ParticleSystem EquipAllParticles;

		[FieldOffset(Offset="0x1A0")]
		public ParticleSystem TierUpParticles;

		[FieldOffset(Offset="0x1A8")]
		public ParticleSystem CraftParticles;

		[Attribute(Name="HeaderAttribute", RVA="0x106C5AC", Offset="0x106C5AC")]
		[FieldOffset(Offset="0x1B0")]
		public RectTransform PowerCelebrationRoot;

		[FieldOffset(Offset="0x1B8")]
		public TallyLabelUnsigned PowerTallyLabel;

		[FieldOffset(Offset="0x1C0")]
		public float PowerScaleDurationIn;

		[FieldOffset(Offset="0x1C4")]
		public float PowerScaleDurationOut;

		[FieldOffset(Offset="0x1C8")]
		public float PowerTallyDelay;

		[FieldOffset(Offset="0x1CC")]
		public float PowerTallyDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x106C5E4", Offset="0x106C5E4")]
		[FieldOffset(Offset="0x1D0")]
		public AudioClipGroup GearTierUpAudioHero;

		[FieldOffset(Offset="0x1D8")]
		public AudioClipGroup GearTierUpAudioVillain;

		[Address(RVA="0x15018B4", Offset="0x15018B4", VA="0x15018B4")]
		public SerializedFields()
		{
		}
	}
}