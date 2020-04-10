using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemDetailsDropListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x48")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x50")]
	private StoreItemDropDetail _detail;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private EmoteWidget _emoteWidget;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Graphic _bg;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Color _guaranteedBgColor;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Color _chanceBgColor;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private UiLabel _itemNameLabel;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private UiLabel _quantityLabel;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UiLabel _ownedLabel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _clubGift;

	[Address(RVA="0x1235C10", Offset="0x1235C10", VA="0x1235C10")]
	public StoreItemDetailsDropListItem()
	{
	}

	[Address(RVA="0x1235374", Offset="0x1235374", VA="0x1235374")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x123562C", Offset="0x123562C", VA="0x123562C")]
	public void SetData(StoreItemDropDetail detail, bool guaranteed)
	{
	}

	[Address(RVA="0x1235598", Offset="0x1235598", VA="0x1235598", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12355F0", Offset="0x12355F0", VA="0x12355F0", Slot="5")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CDDC", Offset="0x104CDDC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public WidgetDependencyContainer dependencies;

		[FieldOffset(Offset="0x18")]
		public StoreItemDetailsDropListItem <>4__this;

		[Address(RVA="0x130CCF0", Offset="0x130CCF0", VA="0x130CCF0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x130CCF8", Offset="0x130CCF8", VA="0x130CCF8")]
		internal void <Initialize>b__0()
		{
		}
	}
}