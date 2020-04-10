using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorcererStoneCraftingView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105C770", Offset="0x105C770")]
	[FieldOffset(Offset="0x68")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105C780", Offset="0x105C780")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C790", Offset="0x105C790")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C7A0", Offset="0x105C7A0")]
	[FieldOffset(Offset="0x80")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105C7B0", Offset="0x105C7B0")]
	[FieldOffset(Offset="0x88")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x90")]
	private InventoryItem? _item;

	private SorcererStoneCraftingView.SerializedFields Fields
	{
		[Address(RVA="0x123BDC0", Offset="0x123BDC0", VA="0x123BDC0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x123C66C", Offset="0x123C66C", VA="0x123C66C")]
	public SorcererStoneCraftingView()
	{
	}

	[Address(RVA="0x123C674", Offset="0x123C674", VA="0x123C674")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070984", Offset="0x1070984")]
	private void <ViewAssetLoaded>b__2_0()
	{
	}

	[Address(RVA="0x123C510", Offset="0x123C510", VA="0x123C510")]
	private void CraftClicked()
	{
	}

	[Address(RVA="0x123BEA0", Offset="0x123BEA0", VA="0x123BEA0", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x123B200", Offset="0x123B200", VA="0x123B200")]
	public void SetItem(InventoryItem? item)
	{
	}

	[Address(RVA="0x123BFCC", Offset="0x123BFCC", VA="0x123BFCC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x123C2D0", Offset="0x123C2D0", VA="0x123C2D0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class RecipeItem
	{
		[FieldOffset(Offset="0x10")]
		public UnityEngine.GameObject Container;

		[FieldOffset(Offset="0x18")]
		public InventoryItemListItem InventoryItem;

		[FieldOffset(Offset="0x20")]
		public UnityEngine.GameObject FindIcon;

		[Address(RVA="0x123C720", Offset="0x123C720", VA="0x123C720")]
		public RecipeItem()
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106BBC4", Offset="0x106BBC4")]
		[FieldOffset(Offset="0x30")]
		public UiLabel StoneNameLabel;

		[FieldOffset(Offset="0x38")]
		public CostButton CraftButton;

		[FieldOffset(Offset="0x40")]
		public Button FindButton;

		[FieldOffset(Offset="0x48")]
		public InventoryItemListItem ResultStoneItem;

		[FieldOffset(Offset="0x50")]
		public List<SorcererStoneCraftingView.RecipeItem> RecipeItems;

		[Address(RVA="0x123C728", Offset="0x123C728", VA="0x123C728")]
		public SerializedFields()
		{
		}
	}
}