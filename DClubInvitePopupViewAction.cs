using Il2CppDummyDll;
using System;

public struct DClubInvitePopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubInvitePopupViewAction.Type ActionType;

	[Address(RVA="0xF03BF8", Offset="0xF03BF8", VA="0xF03BF8")]
	public DClubInvitePopupViewAction(DClubInvitePopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Accept,
		[FieldOffset(Offset="0x0")]
		Decline
	}
}