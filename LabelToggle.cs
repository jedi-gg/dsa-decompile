using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LabelToggle : Toggle
{
	[FieldOffset(Offset="0xFC")]
	private Color? _defaultLabelColor;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private Color _disabledLabelColor;

	public UiLabel Label
	{
		[Address(RVA="0x11D7B68", Offset="0x11D7B68", VA="0x11D7B68")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D7D3C", Offset="0x11D7D3C", VA="0x11D7D3C")]
	public LabelToggle()
	{
	}

	[Address(RVA="0x11D7B70", Offset="0x11D7B70", VA="0x11D7B70", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x11D7C14", Offset="0x11D7C14", VA="0x11D7C14", Slot="26")]
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
	{
	}
}