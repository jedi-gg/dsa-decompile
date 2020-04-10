using Il2CppDummyDll;
using System;

public struct DMatchmakingPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DMatchmakingPopupViewAction.Type ActionType;

	[Address(RVA="0xEFE3C4", Offset="0xEFE3C4", VA="0xEFE3C4")]
	public DMatchmakingPopupViewAction(DMatchmakingPopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		CancelMatchmaking
	}
}