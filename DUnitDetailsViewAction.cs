using Il2CppDummyDll;
using System;

public struct DUnitDetailsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DUnitDetailsViewAction.Type ActionType;

	[Address(RVA="0xEFFD0C", Offset="0xEFFD0C", VA="0xEFFD0C")]
	public DUnitDetailsViewAction(DUnitDetailsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Unlock,
		[FieldOffset(Offset="0x0")]
		Promote,
		[FieldOffset(Offset="0x0")]
		Train,
		[FieldOffset(Offset="0x0")]
		GearTierUp,
		[FieldOffset(Offset="0x0")]
		Stats,
		[FieldOffset(Offset="0x0")]
		Find,
		[FieldOffset(Offset="0x0")]
		CycleLeft,
		[FieldOffset(Offset="0x0")]
		CycleRight,
		[FieldOffset(Offset="0x0")]
		SorcererStone,
		[FieldOffset(Offset="0x0")]
		EquipAll
	}
}