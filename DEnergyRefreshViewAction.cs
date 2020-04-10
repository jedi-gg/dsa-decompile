using Il2CppDummyDll;
using System;

public struct DEnergyRefreshViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DEnergyRefreshViewAction.Type ActionType;

	[Address(RVA="0xF04F84", Offset="0xF04F84", VA="0xF04F84")]
	public DEnergyRefreshViewAction(DEnergyRefreshViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Refresh,
		[FieldOffset(Offset="0x0")]
		Bonus,
		[FieldOffset(Offset="0x0")]
		BonusGenerate
	}
}