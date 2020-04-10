using Il2CppDummyDll;
using System;

public struct DClubDungeonNodeAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubDungeonNodeAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong NodeId;

	[Address(RVA="0xF037A4", Offset="0xF037A4", VA="0xF037A4")]
	public DClubDungeonNodeAction(DClubDungeonNodeAction.Type actionType, ulong nodeId)
	{
	}

	[Address(RVA="0xF037B0", Offset="0xF037B0", VA="0xF037B0")]
	public DClubDungeonNodeAction(DClubDungeonNodeAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Select,
		[FieldOffset(Offset="0x0")]
		Deselect,
		[FieldOffset(Offset="0x0")]
		ShowPlayers
	}
}