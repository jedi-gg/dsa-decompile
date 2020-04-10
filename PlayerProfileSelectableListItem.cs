using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfileSelectableListItem : PlayerProfileListItem, IDispatchHandler<DPlayerProfileListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Image _selectedIcon;

	[FieldOffset(Offset="0x88")]
	private int _selectedDataIndex;

	[Address(RVA="0x13414A0", Offset="0x13414A0", VA="0x13414A0")]
	public PlayerProfileSelectableListItem()
	{
	}

	[Address(RVA="0x1341480", Offset="0x1341480", VA="0x1341480", Slot="9")]
	public void HandleDispatchAction(DPlayerProfileListItemAction action)
	{
	}

	[Address(RVA="0x134136C", Offset="0x134136C", VA="0x134136C", Slot="7")]
	public override void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x13413E8", Offset="0x13413E8", VA="0x13413E8", Slot="8")]
	public override void SetData(PlayerProfileSimple player)
	{
	}

	[Address(RVA="0x134140C", Offset="0x134140C", VA="0x134140C")]
	private void SetSelected()
	{
	}

	[Address(RVA="0x13413A8", Offset="0x13413A8", VA="0x13413A8", Slot="4")]
	public override void Shutdown()
	{
	}
}