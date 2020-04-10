using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LabelButton : InteractableOverrideButton
{
	[FieldOffset(Offset="0xF8")]
	private Color? _defaultLabelColor;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private Color _disabledLabelColor;

	public UiLabel Label
	{
		[Address(RVA="0x11C31FC", Offset="0x11C31FC", VA="0x11C31FC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D7AF4", Offset="0x11D7AF4", VA="0x11D7AF4")]
	public LabelButton()
	{
	}

	[Address(RVA="0x11D7928", Offset="0x11D7928", VA="0x11D7928", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x11D79CC", Offset="0x11D79CC", VA="0x11D79CC", Slot="26")]
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
	{
	}
}