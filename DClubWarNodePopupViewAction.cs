using Il2CppDummyDll;
using System;

public struct DClubWarNodePopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarNodePopupViewAction.Type ActionType;

	[Address(RVA="0xF0444C", Offset="0xF0444C", VA="0xF0444C")]
	public DClubWarNodePopupViewAction(DClubWarNodePopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		CycleLeft,
		[FieldOffset(Offset="0x0")]
		CycleRight,
		[FieldOffset(Offset="0x0")]
		SetTarget,
		[FieldOffset(Offset="0x0")]
		Capture,
		[FieldOffset(Offset="0x0")]
		RebuildTimerExpired
	}
}