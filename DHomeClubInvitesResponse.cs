using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DHomeClubInvitesResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<ClubInvite> Invites;

	[Address(RVA="0xEFD784", Offset="0xEFD784", VA="0xEFD784")]
	public DHomeClubInvitesResponse(HomeClubInvitesResponse homeClubInvites)
	{
	}
}