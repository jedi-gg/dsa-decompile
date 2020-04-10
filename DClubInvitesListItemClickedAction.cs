using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubInvitesListItemClickedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubInvitesListItemClickedAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ClubInvite Invite;

	[Address(RVA="0xF03D34", Offset="0xF03D34", VA="0xF03D34")]
	public DClubInvitesListItemClickedAction(DClubInvitesListItemClickedAction.Type actionType, ClubInvite invite)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ViewInvite,
		[FieldOffset(Offset="0x0")]
		ViewClub,
		[FieldOffset(Offset="0x0")]
		CancelInvite
	}
}