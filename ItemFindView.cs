using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemFindView : AStandardView, IItemFindListView
{
	[Attribute(Name="InjectAttribute", RVA="0x105A1BC", Offset="0x105A1BC")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105A1CC", Offset="0x105A1CC")]
	[FieldOffset(Offset="0x70")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x78")]
	private ItemFindListIndexTutorialPointAtLookup _itemFindPointAtLookup;

	private ItemFindView.SerializedFields Fields
	{
		[Address(RVA="0x11C6F18", Offset="0x11C6F18", VA="0x11C6F18")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11C7874", Offset="0x11C7874", VA="0x11C7874")]
	public ItemFindView()
	{
	}

	[Address(RVA="0x11C7578", Offset="0x11C7578", VA="0x11C7578", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x11C7368", Offset="0x11C7368", VA="0x11C7368", Slot="24")]
	public long? GetItemGoalCount()
	{
		return null;
	}

	[Address(RVA="0x11C7794", Offset="0x11C7794", VA="0x11C7794")]
	private void InitializeItemFindListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11C7374", Offset="0x11C7374", VA="0x11C7374", Slot="25")]
	public void RebindItemFindList()
	{
	}

	[Address(RVA="0x11C70B0", Offset="0x11C70B0", VA="0x11C70B0", Slot="23")]
	public void SetItemFindResults(ulong itemId, int itemFindListCount)
	{
	}

	[Address(RVA="0x11C6FF8", Offset="0x11C6FF8", VA="0x11C6FF8", Slot="21")]
	public void SetListItemBindDataDelegate(WrappedScrollRect.BindDataDelegate bindDataDelegate)
	{
	}

	[Address(RVA="0x11C70A8", Offset="0x11C70A8", VA="0x11C70A8", Slot="22")]
	public void SetTutorialPointAtLookup(ItemFindListIndexTutorialPointAtLookup lookup)
	{
	}

	[Address(RVA="0x11C6E54", Offset="0x11C6E54", VA="0x11C6E54")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11C73B4", Offset="0x11C73B4", VA="0x11C73B4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11C751C", Offset="0x11C751C", VA="0x11C751C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AC9C", Offset="0x106AC9C")]
		[FieldOffset(Offset="0x28")]
		public RawImage ItemImage;

		[FieldOffset(Offset="0x30")]
		public UiLabel ItemNameLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel NoLocationsLabel;

		[FieldOffset(Offset="0x40")]
		public WrappedScrollRect ItemFindScrollRect;

		[Address(RVA="0x11C787C", Offset="0x11C787C", VA="0x11C787C")]
		public SerializedFields()
		{
		}
	}
}