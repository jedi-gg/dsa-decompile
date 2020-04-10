using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubPage
{
	[FieldOffset(Offset="0x0")]
	public readonly FindClubsRequest Request;

	[FieldOffset(Offset="0x8")]
	public readonly int NumClubs;

	[Address(RVA="0xF0405C", Offset="0xF0405C", VA="0xF0405C")]
	public DClubPage(FindClubsRequest request, int numClubs)
	{
	}
}