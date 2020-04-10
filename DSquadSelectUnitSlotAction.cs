using Il2CppDummyDll;
using System;

public struct DSquadSelectUnitSlotAction
{
	[FieldOffset(Offset="0x0")]
	public readonly int Index;

	[FieldOffset(Offset="0x4")]
	public readonly DSquadSelectUnitSlotAction.ActionType Type;

	[Address(RVA="0xEFF788", Offset="0xEFF788", VA="0xEFF788")]
	public DSquadSelectUnitSlotAction(int index, DSquadSelectUnitSlotAction.ActionType type)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Click,
		[FieldOffset(Offset="0x0")]
		LongPress,
		[FieldOffset(Offset="0x0")]
		SelectLeader,
		[FieldOffset(Offset="0x0")]
		Info
	}
}