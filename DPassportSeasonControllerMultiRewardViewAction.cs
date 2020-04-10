using Il2CppDummyDll;
using System;

public struct DPassportSeasonControllerMultiRewardViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonControllerMultiRewardViewAction.Type ActionType;

	[Address(RVA="0xEFE5F4", Offset="0xEFE5F4", VA="0xEFE5F4")]
	public DPassportSeasonControllerMultiRewardViewAction(DPassportSeasonControllerMultiRewardViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		BuyLevel
	}
}