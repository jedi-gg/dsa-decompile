using Il2CppDummyDll;
using System;

public struct DSquadSelectSpellSlotAction
{
	[FieldOffset(Offset="0x0")]
	public readonly int Index;

	[FieldOffset(Offset="0x4")]
	public readonly DSquadSelectSpellSlotAction.ActionType Type;

	[Address(RVA="0xEFF780", Offset="0xEFF780", VA="0xEFF780")]
	public DSquadSelectSpellSlotAction(int index, DSquadSelectSpellSlotAction.ActionType type)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Click,
		[FieldOffset(Offset="0x0")]
		LongPress,
		[FieldOffset(Offset="0x0")]
		InfoClicked
	}
}