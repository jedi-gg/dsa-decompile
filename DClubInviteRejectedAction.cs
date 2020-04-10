using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubInviteRejectedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubInvite Invite;

	[Address(RVA="0xF03CE0", Offset="0xF03CE0", VA="0xF03CE0")]
	public DClubInviteRejectedAction(ClubInvite invite)
	{
	}
}