using Il2CppDummyDll;
using System;

public struct DUnitGearIngredientItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DUnitGearIngredientItemAction.ActionType Type;

	[FieldOffset(Offset="0x8")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x10")]
	public readonly int ColumnIndex;

	[Address(RVA="0xEFFD20", Offset="0xEFFD20", VA="0xEFFD20")]
	public DUnitGearIngredientItemAction(DUnitGearIngredientItemAction.ActionType type, ulong itemId, int columnIndex)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Click,
		[FieldOffset(Offset="0x0")]
		LongPress
	}
}