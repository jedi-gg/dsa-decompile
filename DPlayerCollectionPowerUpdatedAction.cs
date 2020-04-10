using Il2CppDummyDll;
using System;

public struct DPlayerCollectionPowerUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong OldValue;

	[FieldOffset(Offset="0x8")]
	public readonly ulong NewValue;

	[Address(RVA="0xEFE8A4", Offset="0xEFE8A4", VA="0xEFE8A4")]
	public DPlayerCollectionPowerUpdatedAction(ulong oldValue, ulong newValue)
	{
	}
}