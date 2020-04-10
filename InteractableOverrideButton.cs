using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InteractableOverrideButton : Button
{
	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private bool _allowInputOnDisable;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private ButtonRequireConfirmation _confirmationComponent;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private ButtonRequireCooldown _cooldownComponent;

	public ButtonRequireConfirmation RequireConfirmationComponent
	{
		[Address(RVA="0x136BA8C", Offset="0x136BA8C", VA="0x136BA8C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136BD34", Offset="0x136BD34", VA="0x136BD34")]
	public InteractableOverrideButton()
	{
	}

	[Address(RVA="0x136BA94", Offset="0x136BA94", VA="0x136BA94", Slot="41")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}
}