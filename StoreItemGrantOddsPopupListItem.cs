using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class StoreItemGrantOddsPopupListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x38")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x40")]
	private StoreItemGrantOption _option;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private InventoryItemListItem _itemListItem;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _chanceLabel;

	[Address(RVA="0x130EEC8", Offset="0x130EEC8", VA="0x130EEC8")]
	public StoreItemGrantOddsPopupListItem()
	{
	}

	[Address(RVA="0x130E8C8", Offset="0x130E8C8", VA="0x130E8C8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x130ED7C", Offset="0x130ED7C", VA="0x130ED7C")]
	private void ItemClicked()
	{
	}

	[Address(RVA="0x130EA5C", Offset="0x130EA5C", VA="0x130EA5C")]
	public void SetData(StoreItemGrantOption option)
	{
	}

	[Address(RVA="0x130EA10", Offset="0x130EA10", VA="0x130EA10", Slot="4")]
	public override void Shutdown()
	{
	}
}