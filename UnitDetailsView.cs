using DG.Tweening;
using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class UnitDetailsView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x105F368", Offset="0x105F368")]
	[FieldOffset(Offset="0x68")]
	private SingleAssetRegistry _unitPromotionMatAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F378", Offset="0x105F378")]
	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _gearTierMeritItemImageAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F388", Offset="0x105F388")]
	[FieldOffset(Offset="0x78")]
	private SingleAssetRegistry _skinItemIconAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F398", Offset="0x105F398")]
	[FieldOffset(Offset="0x80")]
	private SingleAssetRegistry _sorcererStoneAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F3A8", Offset="0x105F3A8")]
	[FieldOffset(Offset="0x88")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F3B8", Offset="0x105F3B8")]
	[FieldOffset(Offset="0x90")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F3C8", Offset="0x105F3C8")]
	[FieldOffset(Offset="0x98")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105F3D8", Offset="0x105F3D8")]
	[FieldOffset(Offset="0xA0")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x105F3E8", Offset="0x105F3E8")]
	[FieldOffset(Offset="0xA8")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105F3F8", Offset="0x105F3F8")]
	[FieldOffset(Offset="0xB0")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105F408", Offset="0x105F408")]
	[FieldOffset(Offset="0xB8")]
	private CardUnlockTrackerController _cardUnlockTrackerController;

	[FieldOffset(Offset="0xC0")]
	private UnitDetailsWorldSpaceComponent _worldSpaceComponent;

	[FieldOffset(Offset="0xC8")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0xD0")]
	private Gamedata.Unit? _unitDef;

	[FieldOffset(Offset="0xE8")]
	private List<UnitAbility?> _unitAbilities;

	[FieldOffset(Offset="0xF0")]
	private StringBuilder _primaryCategoryStringBuilder;

	[FieldOffset(Offset="0xF8")]
	private Sequence _abilityListRevealSequence;

	[FieldOffset(Offset="0x100")]
	private Sequence _statsEquippedTween;

	[FieldOffset(Offset="0x108")]
	private int _previewSkinIndex;

	[Attribute(Name="TupleElementNamesAttribute", RVA="0x105F418", Offset="0x105F418")]
	[FieldOffset(Offset="0x110")]
	private ValueTuple<ulong, ulong> _displayedUnitPrefab;

	private UnitDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x11E4D80", Offset="0x11E4D80", VA="0x11E4D80")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11EB6A8", Offset="0x11EB6A8", VA="0x11EB6A8")]
	public UnitDetailsView()
	{
	}

	[Address(RVA="0x11EAD80", Offset="0x11EAD80", VA="0x11EAD80")]
	private void AffinityPressed()
	{
	}

	[Address(RVA="0x11EAA2C", Offset="0x11EAA2C", VA="0x11EAA2C")]
	private void BindAbilityListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11EB58C", Offset="0x11EB58C", VA="0x11EB58C")]
	private void CycleSkinLeft()
	{
	}

	[Address(RVA="0x11EB61C", Offset="0x11EB61C", VA="0x11EB61C")]
	private void CycleSkinRight()
	{
	}

	[Address(RVA="0x11E91F0", Offset="0x11E91F0", VA="0x11E91F0")]
	private void DispatchViewAction(DUnitDetailsViewAction.Type actionType)
	{
	}

	[Address(RVA="0x11E2110", Offset="0x11E2110", VA="0x11E2110")]
	public void EnableCycleButtons(bool enable)
	{
	}

	[Address(RVA="0x11EADE4", Offset="0x11EADE4", VA="0x11EADE4")]
	private void GearTierMeritItemClicked()
	{
	}

	[Address(RVA="0x11E85FC", Offset="0x11E85FC", VA="0x11E85FC", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x11E2E28", Offset="0x11E2E28", VA="0x11E2E28")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x11EA950", Offset="0x11EA950", VA="0x11EA950")]
	private void InitializeAbilityListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11E9288", Offset="0x11E9288", VA="0x11E9288")]
	private void LoadUnitModelAndVisuals(Serverproto.Unit unit, Gamedata.Unit unitDef, bool playFullIntroAnimation, int skinIndex = -1)
	{
	}

	[Address(RVA="0x11E6284", Offset="0x11E6284", VA="0x11E6284")]
	private void PlayCelebrationAudio(UnitDetailsView.CelebrationType type)
	{
	}

	[Address(RVA="0x11E21C8", Offset="0x11E21C8", VA="0x11E21C8")]
	public void PlayGearEquipStatsAnimation(Serverproto.Unit oldUnit, Serverproto.Unit newUnit)
	{
	}

	[Address(RVA="0x11E0F80", Offset="0x11E0F80", VA="0x11E0F80")]
	public void PlayUnitCelebration(UnitDetailsView.CelebrationType celebrationType)
	{
	}

	[Address(RVA="0x11EAC38", Offset="0x11EAC38", VA="0x11EAC38")]
	private void PromotionMaterialButtonClicked()
	{
	}

	[Address(RVA="0x11E9E14", Offset="0x11E9E14", VA="0x11E9E14")]
	private void SetGearData(Serverproto.Unit unit, Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x11E964C", Offset="0x11E964C", VA="0x11E964C")]
	private void SetPromotionData(Serverproto.Unit unit, Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x11EAF88", Offset="0x11EAF88", VA="0x11EAF88")]
	private void SetSkinPreview()
	{
	}

	[Address(RVA="0x11EA670", Offset="0x11EA670", VA="0x11EA670")]
	private void SetSorcererStoneState()
	{
	}

	[Address(RVA="0x11E9470", Offset="0x11E9470", VA="0x11E9470")]
	private void SetTrainingData(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x11E20C8", Offset="0x11E20C8", VA="0x11E20C8")]
	public void SetUnit(Gamedata.Unit unitDef, bool playFullIntroAnimation)
	{
	}

	[Address(RVA="0x11E201C", Offset="0x11E201C", VA="0x11E201C")]
	public void SetUnit(Serverproto.Unit unit, bool playFullIntroAnimation)
	{
	}

	[Address(RVA="0x11E5064", Offset="0x11E5064", VA="0x11E5064")]
	private void SetUnitDefinitionData(Gamedata.Unit unitDef)
	{
	}

	[Address(RVA="0x11E5A6C", Offset="0x11E5A6C", VA="0x11E5A6C")]
	private void SetUnitInstanceData(Serverproto.Unit unit, Gamedata.Unit unitDef, bool playFullIntroAnimation)
	{
	}

	[Address(RVA="0x11E798C", Offset="0x11E798C", VA="0x11E798C")]
	private void ShowSkinsPreviewContainer(bool show)
	{
	}

	[Address(RVA="0x11E1418", Offset="0x11E1418", VA="0x11E1418")]
	public void ShowUiForUpgradeCelebration(bool show)
	{
	}

	[Address(RVA="0x11E3840", Offset="0x11E3840", VA="0x11E3840")]
	public void SkinEquipped(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x11E66F4", Offset="0x11E66F4", VA="0x11E66F4")]
	private void SkinsButtonClicked()
	{
	}

	[Address(RVA="0x11DF988", Offset="0x11DF988", VA="0x11DF988")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11E153C", Offset="0x11E153C", VA="0x11E153C")]
	public void TrainingViewShown(bool shown)
	{
	}

	[Address(RVA="0x11E605C", Offset="0x11E605C", VA="0x11E605C")]
	private void TryPlayUnitUnlockCelebration()
	{
	}

	[Address(RVA="0x11E67DC", Offset="0x11E67DC", VA="0x11E67DC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11E7C08", Offset="0x11E7C08", VA="0x11E7C08", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D08C", Offset="0x104D08C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static UnitDetailsView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<UnitAbility?> <>9__15_0;

		[Address(RVA="0x11EB770", Offset="0x11EB770", VA="0x11EB770")]
		static <>c()
		{
		}

		[Address(RVA="0x11EB7D4", Offset="0x11EB7D4", VA="0x11EB7D4")]
		public <>c()
		{
		}

		[Address(RVA="0x11EB7DC", Offset="0x11EB7DC", VA="0x11EB7DC")]
		internal int <SetUnitInstanceData>b__15_0(UnitAbility? a, UnitAbility? b)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D05C", Offset="0x104D05C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsView <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool itemFindUnlocked;

		[Address(RVA="0x11E7984", Offset="0x11E7984", VA="0x11E7984")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x11EB884", Offset="0x11EB884", VA="0x11EB884")]
		internal void <ViewAssetLoaded>b__0()
		{
		}

		[Address(RVA="0x11EB8B4", Offset="0x11EB8B4", VA="0x11EB8B4")]
		internal void <ViewAssetLoaded>b__1()
		{
		}

		[Address(RVA="0x11EBA84", Offset="0x11EBA84", VA="0x11EBA84")]
		internal void <ViewAssetLoaded>b__10()
		{
		}

		[Address(RVA="0x11EBAB4", Offset="0x11EBAB4", VA="0x11EBAB4")]
		internal void <ViewAssetLoaded>b__11()
		{
		}

		[Address(RVA="0x11EBB60", Offset="0x11EBB60", VA="0x11EBB60")]
		internal void <ViewAssetLoaded>b__12()
		{
		}

		[Address(RVA="0x11EBC0C", Offset="0x11EBC0C", VA="0x11EBC0C")]
		internal void <ViewAssetLoaded>b__13()
		{
		}

		[Address(RVA="0x11EBCB8", Offset="0x11EBCB8", VA="0x11EBCB8")]
		internal void <ViewAssetLoaded>b__14(UnityEngine.GameObject l)
		{
		}

		[Address(RVA="0x11EB8E4", Offset="0x11EB8E4", VA="0x11EB8E4")]
		internal void <ViewAssetLoaded>b__2()
		{
		}

		[Address(RVA="0x11EB914", Offset="0x11EB914", VA="0x11EB914")]
		internal void <ViewAssetLoaded>b__3()
		{
		}

		[Address(RVA="0x11EB944", Offset="0x11EB944", VA="0x11EB944")]
		internal void <ViewAssetLoaded>b__4()
		{
		}

		[Address(RVA="0x11EB994", Offset="0x11EB994", VA="0x11EB994")]
		internal void <ViewAssetLoaded>b__5()
		{
		}

		[Address(RVA="0x11EB9C4", Offset="0x11EB9C4", VA="0x11EB9C4")]
		internal void <ViewAssetLoaded>b__6()
		{
		}

		[Address(RVA="0x11EB9F4", Offset="0x11EB9F4", VA="0x11EB9F4")]
		internal void <ViewAssetLoaded>b__7()
		{
		}

		[Address(RVA="0x11EBA24", Offset="0x11EBA24", VA="0x11EBA24")]
		internal void <ViewAssetLoaded>b__8()
		{
		}

		[Address(RVA="0x11EBA54", Offset="0x11EBA54", VA="0x11EBA54")]
		internal void <ViewAssetLoaded>b__9()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D06C", Offset="0x104D06C")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public Gamedata.Unit unitDef;

		[Address(RVA="0x11E9278", Offset="0x11E9278", VA="0x11E9278")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x11EBCF4", Offset="0x11EBCF4", VA="0x11EBCF4")]
		internal void <SetUnitDefinitionData>b__0(Badge b)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D07C", Offset="0x104D07C")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public Serverproto.Unit unit;

		[Address(RVA="0x11E9280", Offset="0x11E9280", VA="0x11E9280")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x11EBD38", Offset="0x11EBD38", VA="0x11EBD38")]
		internal void <SetUnitInstanceData>b__1(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x11EBD74", Offset="0x11EBD74", VA="0x11EBD74")]
		internal void <SetUnitInstanceData>b__2(UnityEngine.GameObject o)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D09C", Offset="0x104D09C")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset="0x10")]
		public UnityEngine.Color gearColor;

		[Address(RVA="0x11EA948", Offset="0x11EA948", VA="0x11EA948")]
		public <>c__DisplayClass19_0()
		{
		}

		[Address(RVA="0x11EBDB0", Offset="0x11EBDB0", VA="0x11EBDB0")]
		internal void <SetGearData>b__0(Graphic g)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D04C", Offset="0x104D04C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public bool show;

		[Address(RVA="0x11E6584", Offset="0x11E6584", VA="0x11E6584")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x11EBE10", Offset="0x11EBE10", VA="0x11EBE10")]
		internal void <ShowUiForUpgradeCelebration>b__0(UnityEngine.GameObject o)
		{
		}
	}

	public enum CelebrationType
	{
		[FieldOffset(Offset="0x0")]
		Unlock,
		[FieldOffset(Offset="0x0")]
		Promote,
		[FieldOffset(Offset="0x0")]
		Train,
		[FieldOffset(Offset="0x0")]
		GearTierUp,
		[FieldOffset(Offset="0x0")]
		EquipAll
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C0FC", Offset="0x106C0FC")]
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public UiLabel UnitNameLabel;

		[FieldOffset(Offset="0x38")]
		public UnitRarityWidget UnitRarityWidget;

		[FieldOffset(Offset="0x40")]
		public Button CycleLeftButton;

		[FieldOffset(Offset="0x48")]
		public Button CycleRightButton;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject TrainingViewBgContainer;

		[Attribute(Name="HeaderAttribute", RVA="0x106C134", Offset="0x106C134")]
		[FieldOffset(Offset="0x58")]
		public UnitDetailsWorldSpaceComponent.SerializedFields WorldSpaceFields;

		[FieldOffset(Offset="0x60")]
		public List<UnityEngine.GameObject> WorldObjectsToHideForCelebration;

		[Attribute(Name="HeaderAttribute", RVA="0x106C16C", Offset="0x106C16C")]
		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject PromotionContainer;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject PromoteEnabledContainer;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject PromoteDisabledContainer;

		[FieldOffset(Offset="0x80")]
		public RawImage PromotionMaterialImage;

		[FieldOffset(Offset="0x88")]
		public UiLabel PromotionCountLabel;

		[FieldOffset(Offset="0x90")]
		public CostButton PromoteButton;

		[FieldOffset(Offset="0x98")]
		public LabelButton FindButton;

		[FieldOffset(Offset="0xA0")]
		public Button PromotionMaterialButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106C1A4", Offset="0x106C1A4")]
		[FieldOffset(Offset="0xA8")]
		public UnityEngine.GameObject TrainingContainer;

		[FieldOffset(Offset="0xB0")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0xB8")]
		public LabelButton TrainButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106C1DC", Offset="0x106C1DC")]
		[FieldOffset(Offset="0xC0")]
		public UnityEngine.GameObject GearContainer;

		[FieldOffset(Offset="0xC8")]
		public List<UnitDetailsGearSlot> GearSlots;

		[FieldOffset(Offset="0xD0")]
		public UnitGearSlotStateData GearSlotStateData;

		[FieldOffset(Offset="0xD8")]
		public UiLabel GearTierLabel;

		[FieldOffset(Offset="0xE0")]
		public Button EquipAllButton;

		[FieldOffset(Offset="0xE8")]
		public UiLabel GearStatsEquippedLabel;

		[FieldOffset(Offset="0xF0")]
		public Button GearTierUpButton;

		[FieldOffset(Offset="0xF8")]
		public RawImage GearTierMeritItemImage;

		[FieldOffset(Offset="0x100")]
		public UnityEngine.GameObject GearTierMeritItemLock;

		[FieldOffset(Offset="0x108")]
		public Button GearTierMeritItemButton;

		[FieldOffset(Offset="0x110")]
		public UnityEngine.GameObject NoGearTierMeritItem;

		[FieldOffset(Offset="0x118")]
		public List<Graphic> CurrentGearTierIndicators;

		[Attribute(Name="HeaderAttribute", RVA="0x106C214", Offset="0x106C214")]
		[FieldOffset(Offset="0x120")]
		public Button StatsButton;

		[FieldOffset(Offset="0x128")]
		public UiLabel PowerLabel;

		[FieldOffset(Offset="0x130")]
		public UnityEngine.GameObject PowerContainer;

		[Attribute(Name="HeaderAttribute", RVA="0x106C24C", Offset="0x106C24C")]
		[FieldOffset(Offset="0x138")]
		public WrappedScrollRect AbilityList;

		[Attribute(Name="HeaderAttribute", RVA="0x106C284", Offset="0x106C284")]
		[FieldOffset(Offset="0x140")]
		public UnityEngine.GameObject AffinityContainer;

		[FieldOffset(Offset="0x148")]
		public Image AffinityImage;

		[FieldOffset(Offset="0x150")]
		public UiLabel PrimaryCategoriesLabel;

		[FieldOffset(Offset="0x158")]
		public PressEventHandler AffinityPressHandler;

		[FieldOffset(Offset="0x160")]
		public SpriteSheetNameLookup UnitRoleSpriteLookup;

		[Attribute(Name="HeaderAttribute", RVA="0x106C2BC", Offset="0x106C2BC")]
		[FieldOffset(Offset="0x168")]
		public Button SkinsButton;

		[FieldOffset(Offset="0x170")]
		public UnityEngine.GameObject SkinsButtonCloseIndicator;

		[FieldOffset(Offset="0x178")]
		public UnityEngine.GameObject SkinsContainer;

		[FieldOffset(Offset="0x180")]
		public UnityEngine.GameObject SkinOwnedContainer;

		[FieldOffset(Offset="0x188")]
		public UnityEngine.GameObject SkinUnownedContainer;

		[FieldOffset(Offset="0x190")]
		public Button SkinEquipButton;

		[FieldOffset(Offset="0x198")]
		public Button SkinUnequipButton;

		[FieldOffset(Offset="0x1A0")]
		public Button SkinFindButton;

		[FieldOffset(Offset="0x1A8")]
		public Button SkinCycleLeftButton;

		[FieldOffset(Offset="0x1B0")]
		public Button SkinCycleRightButton;

		[FieldOffset(Offset="0x1B8")]
		public UiCarousel SkinCycleCarousel;

		[FieldOffset(Offset="0x1C0")]
		public RawImage SkinItemIcon;

		[FieldOffset(Offset="0x1C8")]
		public UiLabel SkinItemCountLabel;

		[FieldOffset(Offset="0x1D0")]
		public UiLabel SkinItemNameLabel;

		[FieldOffset(Offset="0x1D8")]
		public List<UnityEngine.GameObject> ObjectsToHideWhenShowingSkins;

		[Attribute(Name="HeaderAttribute", RVA="0x106C2F4", Offset="0x106C2F4")]
		[FieldOffset(Offset="0x1E0")]
		public UnityEngine.GameObject SorcererStoneContainer;

		[FieldOffset(Offset="0x1E8")]
		public Button SorcererStoneButton;

		[FieldOffset(Offset="0x1F0")]
		public RawImage SorcererStoneImage;

		[Attribute(Name="HeaderAttribute", RVA="0x106C32C", Offset="0x106C32C")]
		[FieldOffset(Offset="0x1F8")]
		public UnityEngine.GameObject LockedPromoContainer;

		[FieldOffset(Offset="0x200")]
		public RawImage LockedPromoRawImage;

		[FieldOffset(Offset="0x208")]
		public Image LockedPromoProgress;

		[FieldOffset(Offset="0x210")]
		public UiLabel LockedPromoProgressLabel;

		[FieldOffset(Offset="0x218")]
		public UiLabel LockedDescriptionLabel;

		[FieldOffset(Offset="0x220")]
		public Button LockedPromoFindButton;

		[FieldOffset(Offset="0x228")]
		public LabelButton UnlockButton;

		[FieldOffset(Offset="0x230")]
		public UnityEngine.GameObject LockedRarityContainer;

		[FieldOffset(Offset="0x238")]
		public UnitRarityWidget LockedRarityWidget;

		[FieldOffset(Offset="0x240")]
		public List<UnityEngine.GameObject> ItemFindLocks;

		[FieldOffset(Offset="0x248")]
		public List<UnityEngine.GameObject> AuxiliaryObjectsToShowWhenLocked;

		[FieldOffset(Offset="0x250")]
		public List<UnityEngine.GameObject> AuxiliaryObjectsToShowWhenUnlocked;

		[Attribute(Name="HeaderAttribute", RVA="0x106C364", Offset="0x106C364")]
		[FieldOffset(Offset="0x258")]
		public ParticleSystem HeroUnlockVfx;

		[FieldOffset(Offset="0x260")]
		public ParticleSystem VillainUnlockVfx;

		[FieldOffset(Offset="0x268")]
		public ParticleSystem TrainCelebrationVfx;

		[FieldOffset(Offset="0x270")]
		public ParticleSystem EquipSkinVfx;

		[FieldOffset(Offset="0x278")]
		public ParticleSystem StoneEquippedVfx;

		[FieldOffset(Offset="0x280")]
		public ParticleSystem EquipAllCelebrationVfx;

		[Attribute(Name="HeaderAttribute", RVA="0x106C39C", Offset="0x106C39C")]
		[FieldOffset(Offset="0x288")]
		public AudioClipGroup UnlockAudioHero;

		[FieldOffset(Offset="0x290")]
		public AudioClipGroup UnlockAudioVillain;

		[FieldOffset(Offset="0x298")]
		public AudioClipGroup PromoteAudioHero;

		[FieldOffset(Offset="0x2A0")]
		public AudioClipGroup PromoteAudioVillain;

		[FieldOffset(Offset="0x2A8")]
		public AudioClipGroup TrainAudioHero;

		[FieldOffset(Offset="0x2B0")]
		public AudioClipGroup TrainAudioVillain;

		[FieldOffset(Offset="0x2B8")]
		public AudioClipGroup GearTierUpAudioHero;

		[FieldOffset(Offset="0x2C0")]
		public AudioClipGroup GearTierUpAudioVillain;

		[Address(RVA="0x11EBE4C", Offset="0x11EBE4C", VA="0x11EBE4C")]
		public SerializedFields()
		{
		}
	}
}