using Il2CppDummyDll;
using Serverproto;
using System;

public struct DUnitGearTierUpAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Unit OldUnit;

	[FieldOffset(Offset="0x8")]
	public readonly Unit NewUnit;

	[Address(RVA="0xEFFD84", Offset="0xEFFD84", VA="0xEFFD84")]
	public DUnitGearTierUpAction(Unit oldUnit, Unit newUnit)
	{
	}
}