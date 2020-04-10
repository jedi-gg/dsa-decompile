using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubInviteListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubInvite Invite;

	[FieldOffset(Offset="0x8")]
	public readonly DClubInviteListItemAction.Type ActionType;

	[Address(RVA="0xF03BEC", Offset="0xF03BEC", VA="0xF03BEC")]
	public DClubInviteListItemAction(ClubInvite invite, DClubInviteListItemAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Approve,
		[FieldOffset(Offset="0x0")]
		Reject
	}
}