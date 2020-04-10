using Il2CppDummyDll;
using System;

public struct DAbilityUpgradeViewCycleAction
{
	[FieldOffset(Offset="0x0")]
	public DAbilityUpgradeViewCycleAction.Direction CycleDirection;

	[Address(RVA="0xF02344", Offset="0xF02344", VA="0xF02344")]
	public DAbilityUpgradeViewCycleAction(DAbilityUpgradeViewCycleAction.Direction direction)
	{
	}

	public enum Direction
	{
		[FieldOffset(Offset="0x0")]
		Left,
		[FieldOffset(Offset="0x0")]
		Right
	}
}