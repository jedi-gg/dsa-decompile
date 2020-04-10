using Il2CppDummyDll;
using System;

public struct DDailyPvpRewardAction
{
	[FieldOffset(Offset="0x0")]
	public DDailyPvpRewardAction.Type ActionType;

	[Address(RVA="0xF04AA8", Offset="0xF04AA8", VA="0xF04AA8")]
	public DDailyPvpRewardAction(DDailyPvpRewardAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Claim,
		[FieldOffset(Offset="0x0")]
		Refresh
	}
}