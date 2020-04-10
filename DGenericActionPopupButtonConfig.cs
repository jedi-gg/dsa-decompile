using Il2CppDummyDll;
using System;
using UnityEngine.Events;

public struct DGenericActionPopupButtonConfig
{
	[FieldOffset(Offset="0x0")]
	public readonly DGenericActionPopupButtonConfig.ButtonType Type;

	[FieldOffset(Offset="0x8")]
	public readonly string LocalizationKey;

	[FieldOffset(Offset="0x10")]
	public readonly UnityAction ClickAction;

	[FieldOffset(Offset="0x18")]
	public readonly bool RequireConfirmation;

	[Address(RVA="0xEFD458", Offset="0xEFD458", VA="0xEFD458")]
	public DGenericActionPopupButtonConfig(DGenericActionPopupButtonConfig.ButtonType type, string localizationKey, UnityAction clickAction, bool requireConfirmation = false)
	{
	}

	public enum ButtonType
	{
		[FieldOffset(Offset="0x0")]
		Standard,
		[FieldOffset(Offset="0x0")]
		Action,
		[FieldOffset(Offset="0x0")]
		Negative
	}
}