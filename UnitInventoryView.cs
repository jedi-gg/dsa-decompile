using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitInventoryView : AStandardView, IDispatchHandler<DUnitListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10597D4", Offset="0x10597D4")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10597E4", Offset="0x10597E4")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10597F4", Offset="0x10597F4")]
	[FieldOffset(Offset="0x78")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x80")]
	private List<Unit?> _unitDefinitionList;

	[FieldOffset(Offset="0x88")]
	private List<Spell?> _spellDefinitionList;

	[FieldOffset(Offset="0x90")]
	private bool _hasActiveUnitFilter;

	[FieldOffset(Offset="0x91")]
	private bool _hasActiveUnitSort;

	[FieldOffset(Offset="0x94")]
	private InventoryGameState.Tab _selectedTab;

	[FieldOffset(Offset="0x98")]
	private Func<ulong, UiLabel, bool> _customSortLabelFunc;

	private UnitInventoryView.SerializedFields Fields
	{
		[Address(RVA="0x1505E64", Offset="0x1505E64", VA="0x1505E64")]
		get
		{
			return null;
		}
	}

	public InventoryGameState.Tab SelectedTab
	{
		[Address(RVA="0x1505DA8", Offset="0x1505DA8", VA="0x1505DA8")]
		get
		{
			return new InventoryGameState.Tab();
		}
	}

	[Address(RVA="0x1507E58", Offset="0x1507E58", VA="0x1507E58")]
	public UnitInventoryView()
	{
	}

	[Address(RVA="0x1507C80", Offset="0x1507C80", VA="0x1507C80")]
	private void BindSpellListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x150788C", Offset="0x150788C", VA="0x150788C")]
	private void BindUnitListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1507DF4", Offset="0x1507DF4", VA="0x1507DF4")]
	private void FilterSortClicked()
	{
	}

	[Address(RVA="0x1506BB8", Offset="0x1506BB8", VA="0x1506BB8", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1506784", Offset="0x1506784", VA="0x1506784", Slot="21")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x1505DB0", Offset="0x1505DB0", VA="0x1505DB0")]
	public void Initialize(List<Spell?> spellList, Func<ulong, UiLabel, bool> customSortLabelFunc)
	{
	}

	[Address(RVA="0x1507B9C", Offset="0x1507B9C", VA="0x1507B9C")]
	private void InitializeSpellListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x15077A8", Offset="0x15077A8", VA="0x15077A8")]
	private void InitializeUnitListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1506290", Offset="0x1506290", VA="0x1506290")]
	public void SelectTab(InventoryGameState.Tab tab)
	{
	}

	[Address(RVA="0x1505F44", Offset="0x1505F44", VA="0x1505F44")]
	public void SetData(List<Unit?> unitDefList, string activeFilterNameKey, string activeSortNameKey)
	{
	}

	[Address(RVA="0x15068B0", Offset="0x15068B0", VA="0x15068B0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1506AC0", Offset="0x1506AC0", VA="0x1506AC0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106ABBC", Offset="0x106ABBC")]
		[FieldOffset(Offset="0x28")]
		public Canvas UnitListCanvas;

		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect UnitListScrollRect;

		[FieldOffset(Offset="0x38")]
		public Canvas SpellListCanvas;

		[FieldOffset(Offset="0x40")]
		public WrappedScrollRect SpellListScrollRect;

		[FieldOffset(Offset="0x48")]
		public Button FilterSortButton;

		[FieldOffset(Offset="0x50")]
		public UiLabel NoUnitsLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel ActiveFilterLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel ActiveSortLabel;

		[FieldOffset(Offset="0x68")]
		public UiLabel ActiveTabTitleLabel;

		[Address(RVA="0x1507E60", Offset="0x1507E60", VA="0x1507E60")]
		public SerializedFields()
		{
		}
	}
}