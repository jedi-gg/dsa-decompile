using Il2CppDummyDll;
using System;

public struct DEnergyRefreshAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong EnergyItemId;

	[FieldOffset(Offset="0x8")]
	public readonly ulong DailyPurchases;

	[Address(RVA="0xF04F7C", Offset="0xF04F7C", VA="0xF04F7C")]
	public DEnergyRefreshAction(ulong energyItemId, ulong dailyPurchases)
	{
	}
}