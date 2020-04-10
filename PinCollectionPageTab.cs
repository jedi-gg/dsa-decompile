using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PinCollectionPageTab : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Graphic _background;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private RawImage _icon;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private RectTransform _container;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private float _selectedXOffset;

	[FieldOffset(Offset="0x5C")]
	[SerializeField]
	private float _unselectedXOffset;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Badge _badge;

	[Address(RVA="0x140CB98", Offset="0x140CB98", VA="0x140CB98")]
	public PinCollectionPageTab()
	{
	}

	[Address(RVA="0x140CB08", Offset="0x140CB08", VA="0x140CB08")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x140C860", Offset="0x140C860", VA="0x140C860")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x140C998", Offset="0x140C998", VA="0x140C998")]
	public void SetData(Color tabColor, string icon, bool selected, bool shouldBadge)
	{
	}

	[Address(RVA="0x140C950", Offset="0x140C950", VA="0x140C950", Slot="4")]
	public override void Shutdown()
	{
	}
}