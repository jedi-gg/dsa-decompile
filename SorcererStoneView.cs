using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorcererStoneView : AStandardView, IDispatchHandler<DSorcererStoneCollectionTabAction>, IDispatchHandler, IDispatchHandler<DSorcererStoneListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105C6D0", Offset="0x105C6D0")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C6E0", Offset="0x105C6E0")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C6F0", Offset="0x105C6F0")]
	[FieldOffset(Offset="0x78")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105C700", Offset="0x105C700")]
	[FieldOffset(Offset="0x80")]
	private SingleAssetRegistry _equippedStoneAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105C710", Offset="0x105C710")]
	[FieldOffset(Offset="0x88")]
	private SingleAssetRegistry _unequipCostIconAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105C720", Offset="0x105C720")]
	[FieldOffset(Offset="0x90")]
	private UnitStatCalculator _unitStatCalculator;

	[Attribute(Name="InjectAttribute", RVA="0x105C730", Offset="0x105C730")]
	[FieldOffset(Offset="0x98")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0xA0")]
	private List<SorcererStoneCollection?> _stoneCollections;

	[FieldOffset(Offset="0xA8")]
	private List<SorcererStoneCollectionTab> _collectionTabs;

	[FieldOffset(Offset="0xB0")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0xB8")]
	private UnitDetailsWorldSpaceComponent _worldSpaceComponent;

	[FieldOffset(Offset="0xC0")]
	private int _selectedTabIndex;

	[FieldOffset(Offset="0xC8")]
	private ulong _selectedStoneId;

	private SorcererStoneCollection? CurrentCollection
	{
		[Address(RVA="0x123D070", Offset="0x123D070", VA="0x123D070")]
		get
		{
			return null;
		}
	}

	private SorcererStoneView.SerializedFields Fields
	{
		[Address(RVA="0x123CF90", Offset="0x123CF90", VA="0x123CF90")]
		get
		{
			return null;
		}
	}

	public int SelectedTabIndex
	{
		[Address(RVA="0x12382D8", Offset="0x12382D8", VA="0x12382D8")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x124038C", Offset="0x124038C", VA="0x124038C")]
	public SorcererStoneView()
	{
	}

	[Address(RVA="0x1240938", Offset="0x1240938", VA="0x1240938")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070934", Offset="0x1070934")]
	private void <InitializeTabs>b__15_0(AssetCollection assetCollection)
	{
	}

	[Address(RVA="0x123F9A8", Offset="0x123F9A8", VA="0x123F9A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070944", Offset="0x1070944")]
	private void <SetEquippedStatLabelColors>g__SetStatColor|19_0(SorcererStoneView.StatRow statRow, bool equippedStoneBenefitsStat)
	{
	}

	[Address(RVA="0x123FFE8", Offset="0x123FFE8", VA="0x123FFE8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070974", Offset="0x1070974")]
	private void <SetStatDeltas>g__UpdatePowerLabel|20_2(Gamedata.InventoryItem? stoneItem)
	{
	}

	[Address(RVA="0x123FB24", Offset="0x123FB24", VA="0x123FB24")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070954", Offset="0x1070954")]
	private bool <SetStatDeltas>g__UpdateStatLabelInt|20_0(Gamedata.InventoryItem? stoneItem, UnitStatCalculator.StatType statType, ulong currentValue, UiLabel label)
	{
		return new bool();
	}

	[Address(RVA="0x123FD5C", Offset="0x123FD5C", VA="0x123FD5C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070964", Offset="0x1070964")]
	private bool <SetStatDeltas>g__UpdateStatLabelPercent|20_1(Gamedata.InventoryItem? stoneItem, UnitStatCalculator.StatType statType, double currentValue, UiLabel label)
	{
		return new bool();
	}

	[Address(RVA="0x1240424", Offset="0x1240424", VA="0x1240424")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10708B4", Offset="0x10708B4")]
	private void <ViewAssetLoaded>b__13_0()
	{
	}

	[Address(RVA="0x12404AC", Offset="0x12404AC", VA="0x12404AC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10708C4", Offset="0x10708C4")]
	private void <ViewAssetLoaded>b__13_1()
	{
	}

	[Address(RVA="0x1240534", Offset="0x1240534", VA="0x1240534")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10708D4", Offset="0x10708D4")]
	private void <ViewAssetLoaded>b__13_2()
	{
	}

	[Address(RVA="0x12405BC", Offset="0x12405BC", VA="0x12405BC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10708E4", Offset="0x10708E4")]
	private void <ViewAssetLoaded>b__13_3()
	{
	}

	[Address(RVA="0x1240644", Offset="0x1240644", VA="0x1240644")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10708F4", Offset="0x10708F4")]
	private void <ViewAssetLoaded>b__13_4()
	{
	}

	[Address(RVA="0x12406CC", Offset="0x12406CC", VA="0x12406CC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070904", Offset="0x1070904")]
	private void <ViewAssetLoaded>b__13_5()
	{
	}

	[Address(RVA="0x1240754", Offset="0x1240754", VA="0x1240754")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070914", Offset="0x1070914")]
	private void <ViewAssetLoaded>b__13_6()
	{
	}

	[Address(RVA="0x1240860", Offset="0x1240860", VA="0x1240860")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070924", Offset="0x1070924")]
	private void <ViewAssetLoaded>b__13_7()
	{
	}

	[Address(RVA="0x123EB20", Offset="0x123EB20", VA="0x123EB20")]
	private void BindStonesListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x1239F74", Offset="0x1239F74", VA="0x1239F74")]
	public void CelebrateEquip()
	{
	}

	[Address(RVA="0x1239058", Offset="0x1239058", VA="0x1239058")]
	public void ClearSelectedStone()
	{
	}

	[Address(RVA="0x1239BA4", Offset="0x1239BA4", VA="0x1239BA4")]
	public void EnableCycleButtons(bool enable)
	{
	}

	[Address(RVA="0x123DD50", Offset="0x123DD50", VA="0x123DD50", Slot="21")]
	public void HandleDispatchAction(DSorcererStoneCollectionTabAction action)
	{
	}

	[Address(RVA="0x123DD58", Offset="0x123DD58", VA="0x123DD58", Slot="22")]
	public void HandleDispatchAction(DSorcererStoneListItemAction action)
	{
	}

	[Address(RVA="0x12395EC", Offset="0x12395EC", VA="0x12395EC")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x123EA44", Offset="0x123EA44", VA="0x123EA44")]
	private void InitializeStonesListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x123E22C", Offset="0x123E22C", VA="0x123E22C")]
	private void InitializeTabs()
	{
	}

	[Address(RVA="0x123998C", Offset="0x123998C", VA="0x123998C")]
	public void SelectCollectionTab(int tabIndex, ulong selectedStone = 0L)
	{
	}

	[Address(RVA="0x123D130", Offset="0x123D130", VA="0x123D130")]
	private void SelectStone(ulong stoneId)
	{
	}

	[Address(RVA="0x123D544", Offset="0x123D544", VA="0x123D544")]
	private void SetButtonStates()
	{
	}

	[Address(RVA="0x123ED78", Offset="0x123ED78", VA="0x123ED78")]
	private void SetEquippedStatLabelColors()
	{
	}

	[Address(RVA="0x1239060", Offset="0x1239060", VA="0x1239060")]
	public void SetOwnedStoneCountOnTabs()
	{
	}

	[Address(RVA="0x123F324", Offset="0x123F324", VA="0x123F324")]
	private bool SetStatDeltas()
	{
		return new bool();
	}

	[Address(RVA="0x123838C", Offset="0x123838C", VA="0x123838C")]
	public void SetUnit(Serverproto.Unit unit)
	{
	}

	[Address(RVA="0x1237FB8", Offset="0x1237FB8", VA="0x1237FB8")]
	public void StoneCrafted()
	{
	}

	[Address(RVA="0x123764C", Offset="0x123764C", VA="0x123764C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x123DD70", Offset="0x123DD70", VA="0x123DD70", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x123E6B0", Offset="0x123E6B0", VA="0x123E6B0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106BA3C", Offset="0x106BA3C")]
		[FieldOffset(Offset="0x28")]
		public UnitRarityWidget UnitRarityWidget;

		[FieldOffset(Offset="0x30")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0x38")]
		public Graphic CurrentGearTierIndicator;

		[FieldOffset(Offset="0x40")]
		public Button CycleLeftButton;

		[FieldOffset(Offset="0x48")]
		public Button CycleRightButton;

		[FieldOffset(Offset="0x50")]
		public Button InfoButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106BA74", Offset="0x106BA74")]
		[FieldOffset(Offset="0x58")]
		public UnitDetailsWorldSpaceComponent.SerializedFields WorldSpaceFields;

		[Attribute(Name="HeaderAttribute", RVA="0x106BAAC", Offset="0x106BAAC")]
		[FieldOffset(Offset="0x60")]
		public SorcererStoneView.StatRow Offense;

		[FieldOffset(Offset="0x68")]
		public SorcererStoneView.StatRow Defense;

		[FieldOffset(Offset="0x70")]
		public SorcererStoneView.StatRow Health;

		[FieldOffset(Offset="0x78")]
		public SorcererStoneView.StatRow Recovery;

		[FieldOffset(Offset="0x80")]
		public SorcererStoneView.StatRow CritChance;

		[FieldOffset(Offset="0x88")]
		public SorcererStoneView.StatRow CritPower;

		[FieldOffset(Offset="0x90")]
		public SorcererStoneView.StatRow Speed;

		[FieldOffset(Offset="0x98")]
		public SorcererStoneView.StatRow Potency;

		[FieldOffset(Offset="0xA0")]
		public SorcererStoneView.StatRow Tenacity;

		[FieldOffset(Offset="0xA8")]
		public SorcererStoneView.StatRow Accuracy;

		[FieldOffset(Offset="0xB0")]
		public SorcererStoneView.StatRow Evasion;

		[FieldOffset(Offset="0xB8")]
		public SorcererStoneView.StatRow UnitPower;

		[FieldOffset(Offset="0xC0")]
		public UnityEngine.Color EquippedStatBonusColor;

		[FieldOffset(Offset="0xD0")]
		public UnityEngine.Color DefaultStatColor;

		[FieldOffset(Offset="0xE0")]
		public UnityEngine.Color StatIncreaseColor;

		[FieldOffset(Offset="0xF0")]
		public UnityEngine.Color StatDecreaseColor;

		[Attribute(Name="HeaderAttribute", RVA="0x106BAE4", Offset="0x106BAE4")]
		[FieldOffset(Offset="0x100")]
		public RawImage CurrentStoneImage;

		[FieldOffset(Offset="0x108")]
		public CostButton UnequipButton;

		[FieldOffset(Offset="0x110")]
		public CostButton SwapButton;

		[FieldOffset(Offset="0x118")]
		public UiLabel LevelRequirementLevel;

		[FieldOffset(Offset="0x120")]
		public UiLabel RarityRequirementLabel;

		[FieldOffset(Offset="0x128")]
		public UiLabel GearTierRequirementLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106BB1C", Offset="0x106BB1C")]
		[FieldOffset(Offset="0x130")]
		public Transform SelectedContextContainer;

		[FieldOffset(Offset="0x138")]
		public DOTweenAnimation SelectedContextContainerTween;

		[FieldOffset(Offset="0x140")]
		public Button EquipButton;

		[FieldOffset(Offset="0x148")]
		public Button CraftingButton;

		[FieldOffset(Offset="0x150")]
		public Button FindButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106BB54", Offset="0x106BB54")]
		[FieldOffset(Offset="0x158")]
		public SorcererStoneCollectionTab TabArchetype;

		[FieldOffset(Offset="0x160")]
		public UiLabel CurrentTabName;

		[FieldOffset(Offset="0x168")]
		public WrappedScrollRect StonesScrollRect;

		[Attribute(Name="HeaderAttribute", RVA="0x106BB8C", Offset="0x106BB8C")]
		[FieldOffset(Offset="0x170")]
		public ParticleSystem EquipVfx;

		[FieldOffset(Offset="0x178")]
		public ParticleSystem CraftVfx;

		[FieldOffset(Offset="0x180")]
		public ParticleSystem StoneEquippedVfx;

		[Address(RVA="0x1240AE8", Offset="0x1240AE8", VA="0x1240AE8")]
		public SerializedFields()
		{
		}
	}

	[Serializable]
	public class StatRow
	{
		[FieldOffset(Offset="0x10")]
		public UiLabel StatNameLabel;

		[FieldOffset(Offset="0x18")]
		public UiLabel CurrentValueLabel;

		[FieldOffset(Offset="0x20")]
		public UiLabel NewValueLabel;

		[Address(RVA="0x1240AF0", Offset="0x1240AF0", VA="0x1240AF0")]
		public StatRow()
		{
		}
	}
}