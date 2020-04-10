using Il2CppDummyDll;
using Serverproto;
using System;

public struct DNewClubInviteAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubInvite Invite;

	[Address(RVA="0xEFE4B8", Offset="0xEFE4B8", VA="0xEFE4B8")]
	public DNewClubInviteAction(ClubInvite invite)
	{
	}
}