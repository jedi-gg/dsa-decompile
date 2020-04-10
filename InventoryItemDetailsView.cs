using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDetailsView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1059914", Offset="0x1059914")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059924", Offset="0x1059924")]
	[FieldOffset(Offset="0x70")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1059934", Offset="0x1059934")]
	[FieldOffset(Offset="0x78")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x80")]
	private InventoryItem _item;

	[FieldOffset(Offset="0x90")]
	private ItemOwnedWidget _itemOwnedWidget;

	[FieldOffset(Offset="0x98")]
	private UiTimerLabel _requestTimerLabel;

	[FieldOffset(Offset="0xA0")]
	private bool _allowNavigateAway;

	private InventoryItemDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x136F500", Offset="0x136F500", VA="0x136F500")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136FC24", Offset="0x136FC24", VA="0x136FC24")]
	public InventoryItemDetailsView()
	{
	}

	[Address(RVA="0x136FC2C", Offset="0x136FC2C", VA="0x136FC2C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070054", Offset="0x1070054")]
	private void <ViewAssetLoaded>b__4_0()
	{
	}

	[Address(RVA="0x136FCC0", Offset="0x136FCC0", VA="0x136FCC0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070064", Offset="0x1070064")]
	private void <ViewAssetLoaded>b__4_1()
	{
	}

	[Address(RVA="0x136FD54", Offset="0x136FD54", VA="0x136FD54")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070074", Offset="0x1070074")]
	private void <ViewAssetLoaded>b__4_2()
	{
	}

	[Address(RVA="0x136FDE8", Offset="0x136FDE8", VA="0x136FDE8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070084", Offset="0x1070084")]
	private void <ViewAssetLoaded>b__4_3()
	{
	}

	[Address(RVA="0x136FE7C", Offset="0x136FE7C", VA="0x136FE7C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070094", Offset="0x1070094")]
	private void <ViewAssetLoaded>b__4_4()
	{
	}

	[Address(RVA="0x136E9F8", Offset="0x136E9F8", VA="0x136E9F8")]
	public void RefreshRequestButtonAndTimer()
	{
	}

	[Address(RVA="0x136EE90", Offset="0x136EE90", VA="0x136EE90")]
	public void SetItem(InventoryItem item, bool allowNavigateAway, ulong ignoreUnitUsedById, bool isVipExclusive)
	{
	}

	[Address(RVA="0x136F430", Offset="0x136F430", VA="0x136F430")]
	public void SetItemButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x136E2EC", Offset="0x136E2EC", VA="0x136E2EC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x136F5E0", Offset="0x136F5E0", VA="0x136F5E0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x136FA2C", Offset="0x136FA2C", VA="0x136FA2C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AC64", Offset="0x106AC64")]
		[FieldOffset(Offset="0x30")]
		public UiLabel ItemNameLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel OwnedCountLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel ItemDescriptionLabel;

		[FieldOffset(Offset="0x48")]
		public RawImage ItemImage;

		[FieldOffset(Offset="0x50")]
		public LabelButton FindButton;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject ItemFindLock;

		[FieldOffset(Offset="0x60")]
		public UnitGearUsedByWidget UnitGearUsedByWidget;

		[FieldOffset(Offset="0x68")]
		public LabelButton RequestButton;

		[FieldOffset(Offset="0x70")]
		public UiLabel RequestTimerLabel;

		[FieldOffset(Offset="0x78")]
		public Button ItemButton;

		[FieldOffset(Offset="0x80")]
		public UnityEngine.GameObject CanBeUsedIndicator;

		[FieldOffset(Offset="0x88")]
		public EmoteWidget EmoteWidget;

		[FieldOffset(Offset="0x90")]
		public Button DeepLinkButton;

		[FieldOffset(Offset="0x98")]
		public UnityEngine.GameObject VipExclusiveContainer;

		[FieldOffset(Offset="0xA0")]
		public Button VipExclusiveButton;

		[Address(RVA="0x136FF10", Offset="0x136FF10", VA="0x136FF10")]
		public SerializedFields()
		{
		}
	}
}