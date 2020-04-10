using Il2CppDummyDll;
using System;

public struct DClubHubViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubHubViewAction.Type ActionType;

	[Address(RVA="0xF03B44", Offset="0xF03B44", VA="0xF03B44")]
	public DClubHubViewAction(DClubHubViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		FindClubs,
		[FieldOffset(Offset="0x0")]
		JoinClub,
		[FieldOffset(Offset="0x0")]
		CancelJoinClub,
		[FieldOffset(Offset="0x0")]
		ChangeSettings,
		[FieldOffset(Offset="0x0")]
		ManageInvites,
		[FieldOffset(Offset="0x0")]
		ClubDungeon,
		[FieldOffset(Offset="0x0")]
		InviteFriends,
		[FieldOffset(Offset="0x0")]
		ClubWar,
		[FieldOffset(Offset="0x0")]
		LeaveClub
	}
}