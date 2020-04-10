using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubActivityPlayerListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Image _icon;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _valueLabel;

	[Attribute(Name="TooltipAttribute", RVA="0x105674C", Offset="0x105674C")]
	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Color[] _iconColors;

	[Address(RVA="0x146519C", Offset="0x146519C", VA="0x146519C")]
	public ClubActivityPlayerListItem()
	{
	}

	[Address(RVA="0x1464F7C", Offset="0x1464F7C", VA="0x1464F7C")]
	public void SetData(ClubActivityPlayerData player)
	{
	}
}