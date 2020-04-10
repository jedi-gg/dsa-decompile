using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubDungeonProgressAction
{
	[FieldOffset(Offset="0x0")]
	public string DungeonId;

	[FieldOffset(Offset="0x8")]
	public ulong ClubCurrentMap;

	[FieldOffset(Offset="0x10")]
	public ulong ClubCurrentNode;

	[FieldOffset(Offset="0x18")]
	public ulong PlayerCurrentMap;

	[FieldOffset(Offset="0x20")]
	public ulong PlayerCurrentNode;

	[FieldOffset(Offset="0x28")]
	public bool CanParticipate;

	[FieldOffset(Offset="0x30")]
	public ulong AttemptsRemaining;

	[Address(RVA="0xF03940", Offset="0xF03940", VA="0xF03940")]
	public DClubDungeonProgressAction(ClubDungeonStatusResponse response)
	{
	}
}