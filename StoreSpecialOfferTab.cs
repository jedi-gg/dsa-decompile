using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StoreSpecialOfferTab : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Graphic _bg;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Color _bgSelectedColor;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Color _bgUnselectedColor;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Color _labelSelectedColor;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Color _labelUnselectedColor;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private GameObject _badge;

	[Address(RVA="0x13160DC", Offset="0x13160DC", VA="0x13160DC")]
	public StoreSpecialOfferTab()
	{
	}

	[Address(RVA="0x1315E28", Offset="0x1315E28", VA="0x1315E28")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1315F7C", Offset="0x1315F7C", VA="0x1315F7C")]
	public void SetData(string text, bool selected, bool showBadge)
	{
	}

	[Address(RVA="0x1315F28", Offset="0x1315F28", VA="0x1315F28", Slot="4")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD4C", Offset="0x104CD4C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public WidgetDependencyContainer dependencies;

		[FieldOffset(Offset="0x18")]
		public StoreSpecialOfferTab <>4__this;

		[Address(RVA="0x1315F20", Offset="0x1315F20", VA="0x1315F20")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x13160E4", Offset="0x13160E4", VA="0x13160E4")]
		internal void <Initialize>b__0()
		{
		}
	}
}