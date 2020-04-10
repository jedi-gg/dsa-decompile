using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class FilterSortListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private FilterSortListItem.Type _type;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Image _checkboxBG;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Image _checkmark;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Color _selectedColor;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Color _unselectedColor;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _label;

	[Address(RVA="0x12C7F84", Offset="0x12C7F84", VA="0x12C7F84")]
	public FilterSortListItem()
	{
	}

	[Address(RVA="0x12C7F8C", Offset="0x12C7F8C", VA="0x12C7F8C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F774", Offset="0x106F774")]
	private void <Initialize>b__0_0()
	{
	}

	[Address(RVA="0x12C7D28", Offset="0x12C7D28", VA="0x12C7D28")]
	public void Initialize(WidgetDependencyContainer dependencies, FilterSortListItem.Type type)
	{
	}

	[Address(RVA="0x12C7E54", Offset="0x12C7E54", VA="0x12C7E54")]
	public void SetData(string labelText, bool selected)
	{
	}

	[Address(RVA="0x12C7EAC", Offset="0x12C7EAC", VA="0x12C7EAC")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x12C7DF8", Offset="0x12C7DF8", VA="0x12C7DF8", Slot="4")]
	public override void Shutdown()
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Filter,
		[FieldOffset(Offset="0x0")]
		Sort
	}
}