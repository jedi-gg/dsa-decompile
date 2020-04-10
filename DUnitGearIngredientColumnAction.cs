using Il2CppDummyDll;
using System;

public struct DUnitGearIngredientColumnAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DUnitGearIngredientColumnAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong ItemId;

	[Address(RVA="0xEFFD14", Offset="0xEFFD14", VA="0xEFFD14")]
	public DUnitGearIngredientColumnAction(DUnitGearIngredientColumnAction.Type type, ulong itemId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Craft
	}
}