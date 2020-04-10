using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AAbilityUpgradeView : AStandardView, IDispatchHandler<DAbilityUpgradeLevelItemAction>, IDispatchHandler, IDispatchHandler<DInventoryItemListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052350", Offset="0x1052350")]
	[FieldOffset(Offset="0x68")]
	protected GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1052360", Offset="0x1052360")]
	[FieldOffset(Offset="0x70")]
	protected PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1052370", Offset="0x1052370")]
	[FieldOffset(Offset="0x78")]
	protected AbilityDescriptionFormatUtil _descFormatUtil;

	[FieldOffset(Offset="0x80")]
	protected UnitDetailsWorldSpaceComponent _worldSpaceComponent;

	[FieldOffset(Offset="0x88")]
	protected AAbilityUpgradeViewModel _viewModel;

	[FieldOffset(Offset="0x90")]
	private int _selectedAbilityLevelIndex;

	[FieldOffset(Offset="0x94")]
	private AAbilityUpgradeView.UpgradePreventReason _upgradePreventReason;

	[FieldOffset(Offset="0x98")]
	private List<AbilityUpgradeLevelPreviewListItem> _levelPreviewItems;

	[FieldOffset(Offset="0xA0")]
	private Dictionary<int, string> _currentLevelDescriptionCachedLinks;

	[FieldOffset(Offset="0xA8")]
	private RectTransform _abilityLevelsLayoutGroupTransform;

	private int AbilityLevelDataIndexOffset
	{
		[Address(RVA="0x10DBBD0", Offset="0x10DBBD0", VA="0x10DBBD0")]
		get
		{
			return new int();
		}
	}

	protected AAbilityUpgradeView.SerializedFields Fields
	{
		[Address(RVA="0x10DC340", Offset="0x10DC340", VA="0x10DC340")]
		get
		{
			return null;
		}
	}

	public override string PrefabName
	{
		[Address(RVA="0x10DB860", Offset="0x10DB860", VA="0x10DB860", Slot="8")]
		get
		{
			return null;
		}
	}

	public int SelectedAbilityLevelIndex
	{
		[Address(RVA="0x10DB8A8", Offset="0x10DB8A8", VA="0x10DB8A8")]
		get
		{
			return new int();
		}
	}

	protected abstract bool ShowLevel1
	{
		get;
	}

	[Address(RVA="0x10DE4B8", Offset="0x10DE4B8", VA="0x10DE4B8")]
	protected AAbilityUpgradeView()
	{
	}

	[Address(RVA="0x10DE550", Offset="0x10DE550", VA="0x10DE550")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DF48", Offset="0x106DF48")]
	private void <ViewAssetLoaded>b__16_0()
	{
	}

	[Address(RVA="0x10DE5D4", Offset="0x10DE5D4", VA="0x10DE5D4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DF58", Offset="0x106DF58")]
	private void <ViewAssetLoaded>b__16_1()
	{
	}

	[Address(RVA="0x10DC420", Offset="0x10DC420", VA="0x10DC420")]
	public void AbilityUpgraded(AAbilityUpgradeViewModel viewModel)
	{
	}

	[Address(RVA="0x10DDB98", Offset="0x10DDB98", VA="0x10DDB98")]
	private void BindIngredientListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x10DD228", Offset="0x10DD228", VA="0x10DD228", Slot="29")]
	protected virtual void CelebrateUpgrade()
	{
	}

	[Address(RVA="0x10DE178", Offset="0x10DE178", VA="0x10DE178")]
	private void CurrentLevelDescriptionPressed()
	{
	}

	[Address(RVA="0x10DC5A8", Offset="0x10DC5A8", VA="0x10DC5A8")]
	public void EnableCycleButtons(bool enable)
	{
	}

	protected abstract void EvaluateSelectedAbilityLevelRequirements(int selectedLevelIndex, ref AAbilityUpgradeView.UpgradePreventReason upgradePreventReason);

	[Address(RVA="0x10DE434", Offset="0x10DE434", VA="0x10DE434")]
	private void FindMissingIngredientClicked()
	{
	}

	[Address(RVA="0x10DC660", Offset="0x10DC660", VA="0x10DC660", Slot="21")]
	public void HandleDispatchAction(DAbilityUpgradeLevelItemAction action)
	{
	}

	[Address(RVA="0x10DC664", Offset="0x10DC664", VA="0x10DC664", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	public abstract void Initialize(Action finished);

	[Address(RVA="0x10DDA9C", Offset="0x10DDA9C", VA="0x10DDA9C")]
	private void InitializeIngredientListItem(WrappedScrollRectListItem listItem)
	{
	}

	protected abstract void LoadWorldModel();

	[Address(RVA="0x10DD28C", Offset="0x10DD28C", VA="0x10DD28C")]
	private void PopulateAbilityLevelsPreviewScrollRect()
	{
	}

	protected abstract void SetAbilityCard();

	[Address(RVA="0x10DB9D0", Offset="0x10DB9D0", VA="0x10DB9D0")]
	private void SetCurrentAbilityLevel()
	{
	}

	[Address(RVA="0x10DB8C4", Offset="0x10DB8C4", VA="0x10DB8C4")]
	public void SetData(AAbilityUpgradeViewModel viewModel, int selectedIndex, bool allowUpgrade)
	{
	}

	protected abstract void SetIngredientContainer();

	[Address(RVA="0x10DBBF8", Offset="0x10DBBF8", VA="0x10DBBF8")]
	private void SetSelectedAbilityLevelIndex(int abilityLevelIndex)
	{
	}

	[Address(RVA="0x10DB8B0", Offset="0x10DB8B0", VA="0x10DB8B0")]
	public void TickUpdate()
	{
	}

	protected abstract void UpdateSelectedRequirementsLabels(UnitRequirements? requirements);

	[Address(RVA="0x10DDD98", Offset="0x10DDD98", VA="0x10DDD98")]
	private void UpgradeButtonClicked()
	{
	}

	[Address(RVA="0x10DC818", Offset="0x10DC818", VA="0x10DC818", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10DCDF8", Offset="0x10DCDF8", VA="0x10DCDF8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD5C", Offset="0x104AD5C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static AAbilityUpgradeView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<AbilityUpgradeLevelPreviewListItem> <>9__17_0;

		[Address(RVA="0x10DE658", Offset="0x10DE658", VA="0x10DE658")]
		static <>c()
		{
		}

		[Address(RVA="0x10DE6BC", Offset="0x10DE6BC", VA="0x10DE6BC")]
		public <>c()
		{
		}

		[Address(RVA="0x10DE6C4", Offset="0x10DE6C4", VA="0x10DE6C4")]
		internal void <ViewShuttingDown>b__17_0(AbilityUpgradeLevelPreviewListItem l)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106962C", Offset="0x106962C")]
		[FieldOffset(Offset="0x28")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x30")]
		public UnitDetailsWorldSpaceComponent.SerializedFields WorldSpaceFields;

		[FieldOffset(Offset="0x38")]
		public Graphic CurrentGearTierIndicator;

		[Attribute(Name="HeaderAttribute", RVA="0x1069664", Offset="0x1069664")]
		[FieldOffset(Offset="0x40")]
		public AbilityLevelsPreviewLayoutGroup AbilityLevelsPreviewLayoutGroup;

		[FieldOffset(Offset="0x48")]
		public AbilityUpgradeLevelPreviewListItem AbilityUpgradeLevelPreviewListItem;

		[Attribute(Name="HeaderAttribute", RVA="0x106969C", Offset="0x106969C")]
		[FieldOffset(Offset="0x50")]
		public UnitDetailsAbilityListItem AbilityListItem;

		[FieldOffset(Offset="0x58")]
		public Button CycleLeftButton;

		[FieldOffset(Offset="0x60")]
		public Button CycleRightButton;

		[Attribute(Name="HeaderAttribute", RVA="0x10696D4", Offset="0x10696D4")]
		[FieldOffset(Offset="0x68")]
		public UiLabel CurrentLevelLabel;

		[FieldOffset(Offset="0x70")]
		public UiLabel CurrentLevelDescriptionLabel;

		[FieldOffset(Offset="0x78")]
		public PressEventHandler CurrentLevelDescriptionPressHandler;

		[FieldOffset(Offset="0x80")]
		public UiLabel SelectedLevelRequiresUnitUnlockLabel;

		[FieldOffset(Offset="0x88")]
		public UnityEngine.GameObject SelectedLevelRequirementsContainer;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.Color RequirementsUnmetLabelColor;

		[FieldOffset(Offset="0xA0")]
		public UnityEngine.Color RequirementsMetLabelColor;

		[FieldOffset(Offset="0xB0")]
		public UiLabel SelectedLevelRequirementLevelLabel;

		[FieldOffset(Offset="0xB8")]
		public UiLabel SelectedLevelRequirementGearLabel;

		[FieldOffset(Offset="0xC0")]
		public UnityEngine.GameObject SelectedLevelOwnedContainer;

		[FieldOffset(Offset="0xC8")]
		public WrappedScrollRect SelectedLevelIngredientScrollRect;

		[FieldOffset(Offset="0xD0")]
		public LabelButton UpgradeButton;

		[FieldOffset(Offset="0xD8")]
		public Button FindMissingIngredientButton;

		[FieldOffset(Offset="0xE0")]
		public UnityEngine.GameObject DefaultIngredientContainer;

		[Attribute(Name="HeaderAttribute", RVA="0x106970C", Offset="0x106970C")]
		[FieldOffset(Offset="0xE8")]
		public UnityEngine.GameObject LockedSpellIngredientContainer;

		[FieldOffset(Offset="0xF0")]
		public RawImage LockedSpellRawImage;

		[FieldOffset(Offset="0xF8")]
		public Image LockedSpellProgress;

		[FieldOffset(Offset="0x100")]
		public UiLabel LockedSpellProgressLabel;

		[FieldOffset(Offset="0x108")]
		public UiLabel LockedSpellDescriptionLabel;

		[FieldOffset(Offset="0x110")]
		public Button LockedSpellFindButton;

		[FieldOffset(Offset="0x118")]
		public LabelButton LockedSpellUnlockButton;

		[Attribute(Name="HeaderAttribute", RVA="0x1069744", Offset="0x1069744")]
		[FieldOffset(Offset="0x120")]
		public AudioClipGroup SpellUnlockAudio;

		[FieldOffset(Offset="0x128")]
		public AudioClipGroup SpellUpgradeAudio;

		[Attribute(Name="HeaderAttribute", RVA="0x106977C", Offset="0x106977C")]
		[FieldOffset(Offset="0x130")]
		public ParticleSystem UnlockParticles;

		[FieldOffset(Offset="0x138")]
		public ParticleSystem UpgradeParticles;

		[Address(RVA="0x10DE6F8", Offset="0x10DE6F8", VA="0x10DE6F8")]
		public SerializedFields()
		{
		}
	}

	[Flags]
	public enum UpgradePreventReason
	{
		[FieldOffset(Offset="0x0")]
		None = 0,
		[FieldOffset(Offset="0x0")]
		UpgradesBlocked = 1,
		[FieldOffset(Offset="0x0")]
		UnmetLevelRequirements = 2,
		[FieldOffset(Offset="0x0")]
		UnmetGearTierRequirements = 4,
		[FieldOffset(Offset="0x0")]
		MissingIngredients = 8,
		[FieldOffset(Offset="0x0")]
		NeedPreviousLevelUpgrade = 16,
		[FieldOffset(Offset="0x0")]
		LockedUnit = 32,
		[FieldOffset(Offset="0x0")]
		LockedSpell = 64
	}
}