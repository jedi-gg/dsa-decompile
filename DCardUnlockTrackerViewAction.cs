using Il2CppDummyDll;
using System;

public struct DCardUnlockTrackerViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DCardUnlockTrackerViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong CardDefId;

	[Address(RVA="0xF03344", Offset="0xF03344", VA="0xF03344")]
	public DCardUnlockTrackerViewAction(DCardUnlockTrackerViewAction.Type actionType, ulong cardDefId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Close,
		[FieldOffset(Offset="0x0")]
		Unit,
		[FieldOffset(Offset="0x0")]
		Spell
	}
}