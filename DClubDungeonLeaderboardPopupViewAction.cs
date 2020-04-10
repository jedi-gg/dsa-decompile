using Il2CppDummyDll;
using System;

public struct DClubDungeonLeaderboardPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubDungeonLeaderboardPopupViewAction.Type ActionType;

	[Address(RVA="0xF0379C", Offset="0xF0379C", VA="0xF0379C")]
	public DClubDungeonLeaderboardPopupViewAction(DClubDungeonLeaderboardPopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		AllClubsClicked,
		[FieldOffset(Offset="0x0")]
		MyClubClicked
	}
}