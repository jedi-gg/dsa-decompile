using Il2CppDummyDll;
using System;

public struct DPassportSeasonLevelMultiRewardViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonLevelMultiRewardViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong ItemId;

	[Address(RVA="0xEFE604", Offset="0xEFE604", VA="0xEFE604")]
	public DPassportSeasonLevelMultiRewardViewAction(DPassportSeasonLevelMultiRewardViewAction.Type actionType, ulong itemId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Go,
		[FieldOffset(Offset="0x0")]
		BuyLevel
	}
}