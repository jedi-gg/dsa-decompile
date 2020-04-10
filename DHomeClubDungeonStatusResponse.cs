using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeClubDungeonStatusResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly string DungeonId;

	[FieldOffset(Offset="0x8")]
	public readonly bool IsPlayable;

	[FieldOffset(Offset="0x10")]
	public readonly ulong Rank;

	[FieldOffset(Offset="0x18")]
	public readonly ulong EndTimestamp;

	[FieldOffset(Offset="0x20")]
	public readonly ulong CompletedAttemptsToday;

	[FieldOffset(Offset="0x28")]
	public readonly ulong MaxAttemptsToday;

	[Address(RVA="0xEFD730", Offset="0xEFD730", VA="0xEFD730")]
	public DHomeClubDungeonStatusResponse(HomeClubDungeonStatusResponse homeClubDungeonStatus)
	{
	}
}