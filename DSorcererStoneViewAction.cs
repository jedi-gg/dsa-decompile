using Il2CppDummyDll;
using System;

public struct DSorcererStoneViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSorcererStoneViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong StoneId;

	[Address(RVA="0xEFF5D4", Offset="0xEFF5D4", VA="0xEFF5D4")]
	public DSorcererStoneViewAction(DSorcererStoneViewAction.Type actionType, ulong stoneId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Equip,
		[FieldOffset(Offset="0x0")]
		Unequip,
		[FieldOffset(Offset="0x0")]
		Swap,
		[FieldOffset(Offset="0x0")]
		Find,
		[FieldOffset(Offset="0x0")]
		CycleLeft,
		[FieldOffset(Offset="0x0")]
		CycleRight
	}
}