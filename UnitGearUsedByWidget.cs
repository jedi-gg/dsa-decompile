using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitGearUsedByWidget : MonoBehaviour, IDispatchHandler<DUnitListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_UNIT_COUNT_LABEL_TRUNCATE = 9;

	[FieldOffset(Offset="0x18")]
	private WidgetDependencyContainer _dependencyContainer;

	[FieldOffset(Offset="0x20")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x38")]
	private UnitSorter _unitSorter;

	[FieldOffset(Offset="0x40")]
	private List<Unit> _units;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private WrappedScrollRect _unitScrollRect;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _unitCountLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _noOtherUnitsLabel;

	public bool HasUnits
	{
		[Address(RVA="0x11F54FC", Offset="0x11F54FC", VA="0x11F54FC")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11F5CD0", Offset="0x11F5CD0", VA="0x11F5CD0")]
	public UnitGearUsedByWidget()
	{
	}

	[Address(RVA="0x11F5BD0", Offset="0x11F5BD0", VA="0x11F5BD0")]
	private void BindUnitListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11F59F4", Offset="0x11F59F4", VA="0x11F59F4", Slot="4")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x11F555C", Offset="0x11F555C", VA="0x11F555C")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11F5B0C", Offset="0x11F5B0C", VA="0x11F5B0C")]
	private void InitializeUnitListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11F5730", Offset="0x11F5730", VA="0x11F5730")]
	public void SetGear(ulong gearId)
	{
	}

	[Address(RVA="0x11F5738", Offset="0x11F5738", VA="0x11F5738")]
	public void SetGear(ulong gearId, ulong ignoredUnitId)
	{
	}

	[Address(RVA="0x11F56CC", Offset="0x11F56CC", VA="0x11F56CC")]
	public void Shutdown()
	{
	}
}