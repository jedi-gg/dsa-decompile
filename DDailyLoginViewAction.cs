using Il2CppDummyDll;
using System;

public struct DDailyLoginViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DDailyLoginViewAction.Type ActionType;

	[Address(RVA="0xF04AA0", Offset="0xF04AA0", VA="0xF04AA0")]
	public DDailyLoginViewAction(DDailyLoginViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Claim,
		[FieldOffset(Offset="0x0")]
		BuyExpired,
		[FieldOffset(Offset="0x0")]
		ClaimBonus,
		[FieldOffset(Offset="0x0")]
		VipClicked
	}
}