using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubInviteAcceptedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.Club Club;

	[FieldOffset(Offset="0x8")]
	public readonly ClubInvite Invite;

	[Address(RVA="0xF03B98", Offset="0xF03B98", VA="0xF03B98")]
	public DClubInviteAcceptedAction(Serverproto.Club club, ClubInvite invite)
	{
	}
}