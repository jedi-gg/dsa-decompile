using Il2CppDummyDll;
using System;

public struct DPvpLeaderboardPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPvpLeaderboardPopupViewAction.Type ActionType;

	[Address(RVA="0xEFEB30", Offset="0xEFEB30", VA="0xEFEB30")]
	public DPvpLeaderboardPopupViewAction(DPvpLeaderboardPopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		GlobalClicked,
		[FieldOffset(Offset="0x0")]
		LocalClicked
	}
}