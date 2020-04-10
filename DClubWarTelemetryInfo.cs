using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct DClubWarTelemetryInfo
{
	[FieldOffset(Offset="0x0")]
	public readonly string PlayerClubId;

	[FieldOffset(Offset="0x8")]
	public readonly string ClubWarId;

	[FieldOffset(Offset="0x10")]
	public readonly string MatchId;

	[FieldOffset(Offset="0x18")]
	public readonly ulong Points;

	[FieldOffset(Offset="0x20")]
	public readonly int NumNodesOwned;

	[FieldOffset(Offset="0x28")]
	public readonly Dictionary<string, object> Data;

	[Address(RVA="0xF04774", Offset="0xF04774", VA="0xF04774")]
	public DClubWarTelemetryInfo(string playerClubId, string clubWarId, string matchId, ulong points, int numNodesOwned)
	{
	}
}