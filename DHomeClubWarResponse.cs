using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeClubWarResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly HomeClubWarResponse ClubWarResponse;

	[Address(RVA="0xEFD80C", Offset="0xEFD80C", VA="0xEFD80C")]
	public DHomeClubWarResponse(HomeClubWarResponse clubWarResponse)
	{
	}
}