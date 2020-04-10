using Il2CppDummyDll;
using System;

public struct DPassportSeasonUpgradePreviewViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonUpgradePreviewViewAction.Type ActionType;

	[Address(RVA="0xEFE628", Offset="0xEFE628", VA="0xEFE628")]
	public DPassportSeasonUpgradePreviewViewAction(DPassportSeasonUpgradePreviewViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Purchase
	}
}