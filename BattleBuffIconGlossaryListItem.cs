using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleBuffIconGlossaryListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _root;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Image _icon;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _name;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _description;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _durationLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Image _bg;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _unselectedContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x1054730", Offset="0x1054730")]
	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Color _oddBgColor;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Color _evenBgColor;

	[Address(RVA="0x1136FF8", Offset="0x1136FF8", VA="0x1136FF8")]
	public BattleBuffIconGlossaryListItem()
	{
	}

	[Address(RVA="0x1136D00", Offset="0x1136D00", VA="0x1136D00")]
	public void SetData(BattleBuffIconUiDatum datum, bool isPermanent, uint duration, bool selected, LocalizationManager lm)
	{
	}

	[Address(RVA="0x1136FC4", Offset="0x1136FC4", VA="0x1136FC4")]
	public void SetEmpty()
	{
	}
}