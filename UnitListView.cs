using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitListView : APopupView, IDispatchHandler<DUnitListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<Serverproto.Unit> _units;

	[FieldOffset(Offset="0x70")]
	private IReadOnlyList<Serverproto.Unit> _selectedUnits;

	[FieldOffset(Offset="0x78")]
	private IReadOnlyList<Serverproto.Unit> _ineligibleUnits;

	[FieldOffset(Offset="0x80")]
	private IReadOnlyList<Serverproto.Unit> _activeBonusUnits;

	[FieldOffset(Offset="0x88")]
	private PersistedPlayerBattleUnits _unitsBattleInfo;

	[FieldOffset(Offset="0x90")]
	private Serverproto.Unit _unitBeingReplaced;

	[FieldOffset(Offset="0x98")]
	private BattleRestriction? _battleRestriction;

	private UnitListView.SerializedFields Fields
	{
		[Address(RVA="0x1509F48", Offset="0x1509F48", VA="0x1509F48")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x150B33C", Offset="0x150B33C", VA="0x150B33C")]
	public UnitListView()
	{
	}

	[Address(RVA="0x150A8E0", Offset="0x150A8E0", VA="0x150A8E0")]
	private void BindListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x150A2D8", Offset="0x150A2D8", VA="0x150A2D8", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x150A028", Offset="0x150A028", VA="0x150A028", Slot="22")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x150A7FC", Offset="0x150A7FC", VA="0x150A7FC")]
	private void InitializeListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1508824", Offset="0x1508824", VA="0x1508824")]
	public void SetUnitList(IReadOnlyList<Serverproto.Unit> units, IReadOnlyList<Serverproto.Unit> selectedUnits, IReadOnlyList<Serverproto.Unit> ineligibleUnits, IReadOnlyList<Serverproto.Unit> activeBonusUnits, PersistedPlayerBattleUnits unitsBattleInfo, Serverproto.Unit unitBeingReplaced, BattleRestriction? battleRestriction)
	{
	}

	[Address(RVA="0x150A154", Offset="0x150A154", VA="0x150A154", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x150A258", Offset="0x150A258", VA="0x150A258", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C61C", Offset="0x106C61C")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect ScrollRect;

		[Address(RVA="0x150B344", Offset="0x150B344", VA="0x150B344")]
		public SerializedFields()
		{
		}
	}
}