using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelectViewButton : LabelButton
{
	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private Image _icon;

	public Image Icon
	{
		[Address(RVA="0x11D8200", Offset="0x11D8200", VA="0x11D8200")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D8DEC", Offset="0x11D8DEC", VA="0x11D8DEC")]
	public LanguageSelectViewButton()
	{
	}
}