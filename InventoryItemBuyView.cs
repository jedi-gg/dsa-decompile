using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemBuyView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1059894", Offset="0x1059894")]
	[FieldOffset(Offset="0x68")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x10598A4", Offset="0x10598A4")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10598B4", Offset="0x10598B4")]
	[FieldOffset(Offset="0x78")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x80")]
	private ulong _itemId;

	[FieldOffset(Offset="0x88")]
	public ItemOwnedWidget _itemOwnedWidget;

	private InventoryItemBuyView.SerializedFields Fields
	{
		[Address(RVA="0x136D65C", Offset="0x136D65C", VA="0x136D65C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136DEC8", Offset="0x136DEC8", VA="0x136DEC8")]
	public InventoryItemBuyView()
	{
	}

	[Address(RVA="0x136DDB8", Offset="0x136DDB8", VA="0x136DDB8")]
	private void BuyClicked()
	{
	}

	[Address(RVA="0x136DE40", Offset="0x136DE40", VA="0x136DE40")]
	private void ItemClicked()
	{
	}

	[Address(RVA="0x136D028", Offset="0x136D028", VA="0x136D028")]
	public void SetItem(InventoryItem item, ulong itemCount, InventoryItem costItem, ulong costCount)
	{
	}

	[Address(RVA="0x136D538", Offset="0x136D538", VA="0x136D538")]
	public void SetItemButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x136D974", Offset="0x136D974", VA="0x136D974", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x136DCA0", Offset="0x136DCA0", VA="0x136DCA0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106ABF4", Offset="0x106ABF4")]
		[FieldOffset(Offset="0x30")]
		public UiLabel ItemNameLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel ItemDescriptionLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel OwnedCountLabel;

		[FieldOffset(Offset="0x48")]
		public RawImage ItemImage;

		[FieldOffset(Offset="0x50")]
		public Button ItemButton;

		[FieldOffset(Offset="0x58")]
		public UnitGearUsedByWidget UnitGearUsedByWidget;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject CanBeUsedIndicator;

		[Attribute(Name="HeaderAttribute", RVA="0x106AC2C", Offset="0x106AC2C")]
		[FieldOffset(Offset="0x68")]
		public HudItemComponent HudItemComponent;

		[FieldOffset(Offset="0x70")]
		public UiLabel ItemCountLabel;

		[FieldOffset(Offset="0x78")]
		public CostButton BuyButton;

		[Address(RVA="0x136DED0", Offset="0x136DED0", VA="0x136DED0")]
		public SerializedFields()
		{
		}
	}
}