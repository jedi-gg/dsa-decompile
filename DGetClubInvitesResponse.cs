using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DGetClubInvitesResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<ClubInvite> Invites;

	[Address(RVA="0xEFD4B8", Offset="0xEFD4B8", VA="0xEFD4B8")]
	public DGetClubInvitesResponse(GetClubInvitesResponse clubInvites)
	{
	}
}