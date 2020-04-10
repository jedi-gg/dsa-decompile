using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemDetailsView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105D378", Offset="0x105D378")]
	[FieldOffset(Offset="0x68")]
	private AccountPrefs _accountPrefs;

	[FieldOffset(Offset="0x70")]
	private StoreItemDetail _details;

	[FieldOffset(Offset="0x78")]
	private UiTimerLabel _uiTimerLabel;

	[FieldOffset(Offset="0x80")]
	private Sequence _popInSequence;

	private StoreItemDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x130CE5C", Offset="0x130CE5C", VA="0x130CE5C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x130E4B8", Offset="0x130E4B8", VA="0x130E4B8")]
	public StoreItemDetailsView()
	{
	}

	[Address(RVA="0x130E1D4", Offset="0x130E1D4", VA="0x130E1D4")]
	private void BindChanceDropListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x130E0C0", Offset="0x130E0C0", VA="0x130E0C0")]
	private void BindGuaranteedDropListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x130E2E8", Offset="0x130E2E8", VA="0x130E2E8")]
	private void BuyClicked()
	{
	}

	[Address(RVA="0x130E3A0", Offset="0x130E3A0", VA="0x130E3A0")]
	private void ClubGiftAnonToggled(bool isOn)
	{
	}

	[Address(RVA="0x130DF38", Offset="0x130DF38", VA="0x130DF38", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x130E430", Offset="0x130E430", VA="0x130E430")]
	private void InfoClicked()
	{
	}

	[Address(RVA="0x130DFE0", Offset="0x130DFE0", VA="0x130DFE0")]
	private void InitializeDropListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x130D7A8", Offset="0x130D7A8", VA="0x130D7A8")]
	public void LoadTexture(string texture)
	{
	}

	[Address(RVA="0x130D850", Offset="0x130D850", VA="0x130D850")]
	public void SetCost(ulong count, InventoryItem? costItem)
	{
	}

	[Address(RVA="0x130CF3C", Offset="0x130CF3C", VA="0x130CF3C")]
	public void SetData(StoreItemDetail details)
	{
	}

	[Address(RVA="0x130D444", Offset="0x130D444", VA="0x130D444")]
	public void SetItem(StoreItemData storeItem)
	{
	}

	[Address(RVA="0x130D8D4", Offset="0x130D8D4", VA="0x130D8D4")]
	public void ShowPurchaseAgainPrompt(bool show)
	{
	}

	[Address(RVA="0x130CD9C", Offset="0x130CD9C", VA="0x130CD9C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x130D91C", Offset="0x130D91C", VA="0x130D91C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x130DE50", Offset="0x130DE50", VA="0x130DE50", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x130DCF4", Offset="0x130DCF4", VA="0x130DCF4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public RectTransform PopupRoot;

		[FieldOffset(Offset="0x38")]
		public RectTransform ResizingWindowRoot;

		[FieldOffset(Offset="0x40")]
		public CanvasGroup TweenRoot;

		[FieldOffset(Offset="0x48")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel DescriptionLabel;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject GuaranteedDropsRoot;

		[FieldOffset(Offset="0x60")]
		public WrappedScrollRect GuaranteedDropsScrollRect;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject ChanceDropsRoot;

		[FieldOffset(Offset="0x70")]
		public WrappedScrollRect ChanceDropsScrollRect;

		[FieldOffset(Offset="0x78")]
		public Button InfoButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106BEAC", Offset="0x106BEAC")]
		[FieldOffset(Offset="0x80")]
		public RawImage Icon;

		[FieldOffset(Offset="0x88")]
		public StoreItemBuyButtons BuyButtons;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject PurchaseAgainPrompt;

		[FieldOffset(Offset="0x98")]
		public UnityEngine.GameObject TimerRoot;

		[FieldOffset(Offset="0xA0")]
		public UiLabel TimerLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106BEE4", Offset="0x106BEE4")]
		[FieldOffset(Offset="0xA8")]
		public UnityEngine.GameObject ClubGiftAnonRoot;

		[FieldOffset(Offset="0xB0")]
		public Toggle ClubGiftAnonToggle;

		[Address(RVA="0x130E4C0", Offset="0x130E4C0", VA="0x130E4C0")]
		public SerializedFields()
		{
		}
	}
}