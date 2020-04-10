using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DHomeClubDonationsResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong DonationsRemaining;

	[FieldOffset(Offset="0x8")]
	public readonly DateTime DonationsResetTime;

	[FieldOffset(Offset="0x10")]
	public readonly IList<ClubItemRequest> ItemRequests;

	[FieldOffset(Offset="0x18")]
	public readonly DateTime NextItemRequestTime;

	[FieldOffset(Offset="0x20")]
	public readonly IList<ClubSupportRequest> SupportRequests;

	[Address(RVA="0xEFD650", Offset="0xEFD650", VA="0xEFD650")]
	public DHomeClubDonationsResponse(HomeClubDonationsResponse homeClubDonations)
	{
	}
}