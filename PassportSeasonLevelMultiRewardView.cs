using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonLevelMultiRewardView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B0D4", Offset="0x105B0D4")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B0E4", Offset="0x105B0E4")]
	[FieldOffset(Offset="0x70")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105B0F4", Offset="0x105B0F4")]
	[FieldOffset(Offset="0x78")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x80")]
	private PassportSeasonLevelRewards? _rewards;

	[FieldOffset(Offset="0x98")]
	private PassportSeasonLevelMultiRewardController.Context.RewardsType _typeOfRewards;

	[FieldOffset(Offset="0xA0")]
	private ItemOwnedWidget _itemOwnedWidget;

	[FieldOffset(Offset="0xA8")]
	private int _selectedIndex;

	private PassportSeasonLevelMultiRewardView.SerializedFields Fields
	{
		[Address(RVA="0x13FF434", Offset="0x13FF434", VA="0x13FF434")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1400584", Offset="0x1400584", VA="0x1400584")]
	public PassportSeasonLevelMultiRewardView()
	{
	}

	[Address(RVA="0x140024C", Offset="0x140024C", VA="0x140024C")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x14004FC", Offset="0x14004FC", VA="0x14004FC")]
	private void BuyLevelClicked()
	{
	}

	[Address(RVA="0x13FFB48", Offset="0x13FFB48", VA="0x13FFB48")]
	private int FindIndexOfItemId(ulong itemId)
	{
		return new int();
	}

	[Address(RVA="0x14000BC", Offset="0x14000BC", VA="0x14000BC")]
	private ItemCount? GetItemCount(int index)
	{
		return null;
	}

	[Address(RVA="0x13FFA48", Offset="0x13FFA48", VA="0x13FFA48", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x1400150", Offset="0x1400150", VA="0x1400150")]
	private void InitializeRewardItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x140040C", Offset="0x140040C", VA="0x140040C")]
	private void ItemButtonClicked()
	{
	}

	[Address(RVA="0x13FF514", Offset="0x13FF514", VA="0x13FF514")]
	private void SelectItemIndex(int index)
	{
	}

	[Address(RVA="0x13FEFA4", Offset="0x13FEFA4", VA="0x13FEFA4")]
	public void SetRewards(PassportSeasonLevelRewards? rewards, PassportSeasonLevelMultiRewardController.Context.RewardsType typeOfRewards, int rewardIndex, int playerPassportLevel, bool playerIsPremium)
	{
	}

	[Address(RVA="0x13FFD18", Offset="0x13FFD18", VA="0x13FFD18", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x13FFFB0", Offset="0x13FFFB0", VA="0x13FFFB0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B28C", Offset="0x106B28C")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect RewardScrollList;

		[FieldOffset(Offset="0x38")]
		public RectTransform SelectedBorder;

		[FieldOffset(Offset="0x40")]
		public UiLabel ItemNameLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel OwnedCountLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel ItemDescriptionLabel;

		[FieldOffset(Offset="0x58")]
		public RawImage ItemImage;

		[FieldOffset(Offset="0x60")]
		public Button ItemButton;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject CanBeUsedIndicator;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject BuyLevelContainer;

		[FieldOffset(Offset="0x78")]
		public CostButton BuyLevelButton;

		[FieldOffset(Offset="0x80")]
		public UnityEngine.GameObject CannotBuyLevelContainer;

		[FieldOffset(Offset="0x88")]
		public UiLabel CannotBuyLevelLabel;

		[Address(RVA="0x1400594", Offset="0x1400594", VA="0x1400594")]
		public SerializedFields()
		{
		}
	}
}