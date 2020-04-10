using Il2CppDummyDll;
using System;

public struct DPlayerActivityChooseRewardAction
{
	[FieldOffset(Offset="0x0")]
	public readonly PlayerActivityChooseRewardController.Option Option;

	[FieldOffset(Offset="0x8")]
	public readonly DPlayerActivityChooseRewardAction.Type ActionType;

	[Address(RVA="0xEFE72C", Offset="0xEFE72C", VA="0xEFE72C")]
	public DPlayerActivityChooseRewardAction(PlayerActivityChooseRewardController.Option option, DPlayerActivityChooseRewardAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Claim
	}
}