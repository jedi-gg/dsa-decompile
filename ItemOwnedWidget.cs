using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ItemOwnedWidget
{
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDomainController;

	[FieldOffset(Offset="0x18")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x20")]
	private LocalizationManager _locManager;

	[FieldOffset(Offset="0x28")]
	private UiLabel _label;

	[FieldOffset(Offset="0x30")]
	private GameObject _canBeUsedIndicator;

	[Address(RVA="0x11C7894", Offset="0x11C7894", VA="0x11C7894")]
	public ItemOwnedWidget(UiLabel label, GameObject canBeUsedIndicator, WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11C7974", Offset="0x11C7974", VA="0x11C7974")]
	public void SetData(ulong itemId)
	{
	}
}