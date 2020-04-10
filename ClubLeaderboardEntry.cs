using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubLeaderboardEntry
{
	[FieldOffset(Offset="0x10")]
	public readonly int Rank;

	[FieldOffset(Offset="0x18")]
	public readonly Serverproto.ClubLeaderboardEntry Data;

	[FieldOffset(Offset="0x20")]
	public readonly Gamedata.InventoryItem? Icon;

	[FieldOffset(Offset="0x38")]
	public readonly bool IsLocalPlayersClub;

	[Address(RVA="0x12593F4", Offset="0x12593F4", VA="0x12593F4")]
	public ClubLeaderboardEntry(int rank, Serverproto.ClubLeaderboardEntry data, Gamedata.InventoryItem? icon, bool isLocalPlayersClub)
	{
	}
}