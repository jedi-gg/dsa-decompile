using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x0")]
	private readonly static List<InventoryItemListItem.AlertData> s_alertData;

	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x40")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x48")]
	private Sprite _defaultBgSprite;

	[FieldOffset(Offset="0x50")]
	private ulong _itemId;

	[FieldOffset(Offset="0x58")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x60")]
	private bool _useWideIcon;

	[FieldOffset(Offset="0x61")]
	private bool _isVipExclusive;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private AudioClipGroup _clickAudioClipGroup;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Button _clickHandler;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Image _bg;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Sprite _vipBgSprite;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _alertRoot;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Image _alertBackground;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UiLabel _alertLabel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _canBeUsedIndicator;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private GameObject _exclusiveContainer;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiLabel _exclusiveLabel;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private GameObject _chanceDropIcon;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private UiLabel _chanceLabel;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private EmoteWidget _emoteWidget;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private GameObject _persistentRewardProgressContainer;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private UiLabel _persistentRewardProgressLabel;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private GameObject _persistentRewardCompletedContainer;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private UiLabel _persistentRewardCompletedLabel;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private GameObject _vipExclusiveContainer;

	public Button ClickHandler
	{
		[Address(RVA="0x136FF30", Offset="0x136FF30", VA="0x136FF30")]
		get
		{
			return null;
		}
	}

	public ulong ItemId
	{
		[Address(RVA="0x136FF28", Offset="0x136FF28", VA="0x136FF28")]
		get
		{
			return new ulong();
		}
	}

	[Address(RVA="0x13714F8", Offset="0x13714F8", VA="0x13714F8")]
	static InventoryItemListItem()
	{
	}

	[Address(RVA="0x13714F0", Offset="0x13714F0", VA="0x13714F0")]
	public InventoryItemListItem()
	{
	}

	[Address(RVA="0x1370F1C", Offset="0x1370F1C", VA="0x1370F1C")]
	private void ConfigureAlert(InventoryItemListItem.AlertType alertType)
	{
	}

	[Address(RVA="0x1370AF0", Offset="0x1370AF0", VA="0x1370AF0")]
	private void ConfigureAlert(LootTag lootTag)
	{
	}

	[Address(RVA="0x137126C", Offset="0x137126C", VA="0x137126C")]
	private static InventoryItemListItem.AlertType FromLootTag(LootTag lootTag)
	{
		return new InventoryItemListItem.AlertType();
	}

	[Address(RVA="0x136A7F4", Offset="0x136A7F4", VA="0x136A7F4")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x1371314", Offset="0x1371314", VA="0x1371314")]
	private void ListItemClicked()
	{
	}

	[Address(RVA="0x136AF74", Offset="0x136AF74", VA="0x136AF74")]
	public void SetAlertFraction(long numerator, long denominator)
	{
	}

	[Address(RVA="0x13711E8", Offset="0x13711E8", VA="0x13711E8")]
	public void SetImageColor(UnityEngine.Color color)
	{
	}

	[Address(RVA="0x136AE08", Offset="0x136AE08", VA="0x136AE08")]
	public void SetItem(Gamedata.InventoryItem item, long labelCount)
	{
	}

	[Address(RVA="0x1370850", Offset="0x1370850", VA="0x1370850")]
	public void SetItem(Gamedata.InventoryItem item, ulong labelCount)
	{
	}

	[Address(RVA="0x13708FC", Offset="0x13708FC", VA="0x13708FC")]
	public void SetItem(Gamedata.InventoryItem item, long numerator, long denominator, bool checkInsufficientColor = true)
	{
	}

	[Address(RVA="0x13709C4", Offset="0x13709C4", VA="0x13709C4")]
	public void SetItem(Gamedata.InventoryItem item, Serverproto.ItemCount itemCount)
	{
	}

	[Address(RVA="0x1370C64", Offset="0x1370C64", VA="0x1370C64")]
	public void SetItem(Gamedata.InventoryItem item, ItemCountRange itemCountRange, NumberFormatUtil.AbbreviationLevel abbreviationLevel = 6)
	{
	}

	[Address(RVA="0x136B07C", Offset="0x136B07C", VA="0x136B07C")]
	public void SetItem(Gamedata.InventoryItem item, Serverproto.InventoryItem protoItem)
	{
	}

	[Address(RVA="0x1370258", Offset="0x1370258", VA="0x1370258")]
	private void SetItem(Gamedata.InventoryItem item)
	{
	}

	[Address(RVA="0x13705C4", Offset="0x13705C4", VA="0x13705C4")]
	public void SetPersistentRewardLabel(bool completed, LootTag lootTag)
	{
	}

	[Address(RVA="0x1371260", Offset="0x1371260", VA="0x1371260")]
	public void SetUseWideIcon(bool useWideIcon)
	{
	}

	[Address(RVA="0x136AEB4", Offset="0x136AEB4", VA="0x136AEB4")]
	public void ShowAlert(InventoryItemListItem.AlertType alertType)
	{
	}

	[Address(RVA="0x1370BB4", Offset="0x1370BB4", VA="0x1370BB4")]
	public void ShowChanceIcon(bool show)
	{
	}

	[Address(RVA="0x136FF38", Offset="0x136FF38", VA="0x136FF38")]
	private void ShowVip(bool show)
	{
	}

	[Address(RVA="0x1370088", Offset="0x1370088", VA="0x1370088", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x13701BC", Offset="0x13701BC", VA="0x13701BC", Slot="5")]
	public override void TickUpdate()
	{
	}

	private class AlertData
	{
		[FieldOffset(Offset="0x10")]
		public InventoryItemListItem.AlertType Type;

		[FieldOffset(Offset="0x14")]
		public UnityEngine.Color BackgroundColor;

		[FieldOffset(Offset="0x24")]
		public UnityEngine.Color TextColor;

		[Address(RVA="0x1371940", Offset="0x1371940", VA="0x1371940")]
		public AlertData()
		{
		}
	}

	public enum AlertType
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		ItemFind,
		[FieldOffset(Offset="0x0")]
		FirstTimeLoot,
		[FieldOffset(Offset="0x0")]
		Bonus,
		[FieldOffset(Offset="0x0")]
		ShardShopConversion
	}
}