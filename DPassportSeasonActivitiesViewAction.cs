using Il2CppDummyDll;
using System;

public struct DPassportSeasonActivitiesViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonActivitiesViewAction.Type ActionType;

	[Address(RVA="0xEFE5EC", Offset="0xEFE5EC", VA="0xEFE5EC")]
	public DPassportSeasonActivitiesViewAction(DPassportSeasonActivitiesViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		BuyLevel,
		[FieldOffset(Offset="0x0")]
		BuyLevelConfirmShowStarted,
		[FieldOffset(Offset="0x0")]
		BuyLevelConfirmHideStarted
	}
}