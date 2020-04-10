using Il2CppDummyDll;
using System;

public struct DClubDungeonDoorSelectViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubDungeonDoorSelectViewAction.Type ActionType;

	[Address(RVA="0xF0373C", Offset="0xF0373C", VA="0xF0373C")]
	public DClubDungeonDoorSelectViewAction(DClubDungeonDoorSelectViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue,
		[FieldOffset(Offset="0x0")]
		SkipAnimation
	}
}