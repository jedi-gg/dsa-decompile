using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ShipmentListItem : WrappedScrollRectListItem, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x0")]
	private const float DISABLED_ALPHA = 0.5f;

	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDomainController;

	[FieldOffset(Offset="0x38")]
	private LocalizationManager _localizationManager;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _itemImageRegistry;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _costImageRegistry;

	[FieldOffset(Offset="0x50")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x58")]
	private ItemOwnedWidget _itemOwnedWidget;

	[FieldOffset(Offset="0x60")]
	private ShipmentItem _currentShipmentItem;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Button _buyButton;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _itemLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _itemCountLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private RawImage _itemImage;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _ownedLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UiLabel _costLabel;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private RawImage _costImage;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private GameObject _purchaseIndicator;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private GameObject _canBeUsedIndicator;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _exclusiveContainer;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private GameObject _singleItemContainer;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private GameObject _storeItemContainer;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private RawImage _storeItemImage;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private GameObject _saleContainer;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private GameObject _lockedContainer;

	public LogCategory LogCategory
	{
		[Address(RVA="0x14C0338", Offset="0x14C0338", VA="0x14C0338", Slot="7")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x14C0F24", Offset="0x14C0F24", VA="0x14C0F24")]
	public ShipmentListItem()
	{
	}

	[Address(RVA="0x14C0E9C", Offset="0x14C0E9C", VA="0x14C0E9C")]
	private void BuyClicked()
	{
	}

	[Address(RVA="0x14C0340", Offset="0x14C0340", VA="0x14C0340")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x14C05AC", Offset="0x14C05AC", VA="0x14C05AC")]
	public void SetData(ShipmentItem shipmentItem)
	{
	}

	[Address(RVA="0x14C052C", Offset="0x14C052C", VA="0x14C052C", Slot="4")]
	public override void Shutdown()
	{
	}
}