using Il2CppDummyDll;
using System;

public struct DDailyRewardViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DDailyRewardViewAction.Type ActionType;

	[Address(RVA="0xF04B04", Offset="0xF04B04", VA="0xF04B04")]
	public DDailyRewardViewAction(DDailyRewardViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Claim
	}
}