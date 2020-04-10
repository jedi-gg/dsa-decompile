using Il2CppDummyDll;
using System;

public struct DPassportSeasonPreviewViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPassportSeasonPreviewViewAction.Type ActionType;

	[Address(RVA="0xEFE618", Offset="0xEFE618", VA="0xEFE618")]
	public DPassportSeasonPreviewViewAction(DPassportSeasonPreviewViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Purchase
	}
}