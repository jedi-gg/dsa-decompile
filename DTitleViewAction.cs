using Il2CppDummyDll;
using System;

public struct DTitleViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DTitleViewAction.Type ActionType;

	[Address(RVA="0xEFFA90", Offset="0xEFFA90", VA="0xEFFA90")]
	public DTitleViewAction(DTitleViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		IntroCinematicBeganPlaying,
		[FieldOffset(Offset="0x0")]
		PreCaseOpeningStateReached,
		[FieldOffset(Offset="0x0")]
		CaseOpeningCompleted,
		[FieldOffset(Offset="0x0")]
		CaseOpeningPlusDelayCompleted
	}
}