using Il2CppDummyDll;
using System;

public struct DClubItemDonateViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubItemDonateViewAction.Type ActionType;

	[Address(RVA="0xF03D98", Offset="0xF03D98", VA="0xF03D98")]
	public DClubItemDonateViewAction(DClubItemDonateViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		FulfillAllClubSupport
	}
}