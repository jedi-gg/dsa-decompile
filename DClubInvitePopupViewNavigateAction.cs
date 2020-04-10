using Il2CppDummyDll;
using System;

public struct DClubInvitePopupViewNavigateAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubInvitePopupViewNavigateAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string ClubOrPlayerId;

	[Address(RVA="0xF03C88", Offset="0xF03C88", VA="0xF03C88")]
	public DClubInvitePopupViewNavigateAction(DClubInvitePopupViewNavigateAction.Type actionType, string clubOrPlayerId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Player,
		[FieldOffset(Offset="0x0")]
		Club
	}
}