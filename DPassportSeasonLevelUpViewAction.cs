using Il2CppDummyDll;
using System;

public struct DPassportSeasonLevelUpViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonLevelUpViewAction.Type ActionType;

	[Address(RVA="0xEFE610", Offset="0xEFE610", VA="0xEFE610")]
	public DPassportSeasonLevelUpViewAction(DPassportSeasonLevelUpViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Upgrade,
		[FieldOffset(Offset="0x0")]
		Info
	}
}