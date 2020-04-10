using Il2CppDummyDll;
using System;

public struct DPinPageItemDetailsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPinPageItemDetailsViewAction.Type ActionType;

	[Address(RVA="0xEFE694", Offset="0xEFE694", VA="0xEFE694")]
	public DPinPageItemDetailsViewAction(DPinPageItemDetailsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		AchievementLink,
		[FieldOffset(Offset="0x0")]
		SetProfileIcon
	}
}