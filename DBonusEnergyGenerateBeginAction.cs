using Il2CppDummyDll;
using System;

public struct DBonusEnergyGenerateBeginAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong EnergyItemId;

	[FieldOffset(Offset="0x8")]
	public readonly ulong EndTimestamp;

	[Address(RVA="0xF03070", Offset="0xF03070", VA="0xF03070")]
	public DBonusEnergyGenerateBeginAction(ulong energyItemId, ulong endTimestamp)
	{
	}
}