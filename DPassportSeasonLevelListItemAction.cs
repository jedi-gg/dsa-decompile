using Il2CppDummyDll;
using System;

public struct DPassportSeasonLevelListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonLevelListItemAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly int LevelDataIndex;

	[Address(RVA="0xEFE5FC", Offset="0xEFE5FC", VA="0xEFE5FC")]
	public DPassportSeasonLevelListItemAction(DPassportSeasonLevelListItemAction.Type actionType, int index)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		PremiumClicked,
		[FieldOffset(Offset="0x0")]
		FreeClicked,
		[FieldOffset(Offset="0x0")]
		BuyLevelClicked,
		[FieldOffset(Offset="0x0")]
		BuyLevelConfirmShowStarted,
		[FieldOffset(Offset="0x0")]
		BuyLevelConfirmHideStarted
	}
}