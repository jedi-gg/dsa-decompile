using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemOddsPopupListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	private StoreItemGrant _grant;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiInputSquish _uiInputSquish;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _groupPrefixLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private InventoryItemListItem _guaranteedItem;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private GameObject _grantIcon;

	[Address(RVA="0x1310588", Offset="0x1310588", VA="0x1310588")]
	public StoreItemOddsPopupListItem()
	{
	}

	[Address(RVA="0x1310378", Offset="0x1310378", VA="0x1310378")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x130FACC", Offset="0x130FACC", VA="0x130FACC")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1310400", Offset="0x1310400", VA="0x1310400")]
	private void ItemClicked()
	{
	}

	[Address(RVA="0x130FCF0", Offset="0x130FCF0", VA="0x130FCF0")]
	public void SetData(StoreItemGrant grant, string grantName = "")
	{
	}

	[Address(RVA="0x130FC74", Offset="0x130FC74", VA="0x130FC74", Slot="4")]
	public override void Shutdown()
	{
	}
}