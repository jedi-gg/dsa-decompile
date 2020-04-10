using Il2CppDummyDll;
using System;

public struct DClubWarSquadRosterPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarSquadRosterPopupViewAction.Type ActionType;

	[Address(RVA="0xF0468C", Offset="0xF0468C", VA="0xF0468C")]
	public DClubWarSquadRosterPopupViewAction(DClubWarSquadRosterPopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ToggleFilter
	}
}