using Il2CppDummyDll;
using System;

public struct DPassportSeasonTabViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonTabViewAction.Type ActionType;

	[Address(RVA="0xEFE620", Offset="0xEFE620", VA="0xEFE620")]
	public DPassportSeasonTabViewAction(DPassportSeasonTabViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		UpgradeToPremium,
		[FieldOffset(Offset="0x0")]
		InfoClicked,
		[FieldOffset(Offset="0x0")]
		SeasonExpired
	}
}