using Il2CppDummyDll;
using System;

public struct DSavedSquadAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSavedSquadAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly int SquadSlot;

	[Address(RVA="0xEFEE6C", Offset="0xEFEE6C", VA="0xEFEE6C")]
	public DSavedSquadAction(DSavedSquadAction.Type type, int squadSlot)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Load,
		[FieldOffset(Offset="0x0")]
		Save
	}
}