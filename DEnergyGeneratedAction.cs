using Il2CppDummyDll;
using System;

public struct DEnergyGeneratedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong EnergyItemId;

	[FieldOffset(Offset="0x8")]
	public readonly uint GeneratedAmount;

	[Address(RVA="0xF04F70", Offset="0xF04F70", VA="0xF04F70")]
	public DEnergyGeneratedAction(ulong energyItemId, uint generatedAmount)
	{
	}
}