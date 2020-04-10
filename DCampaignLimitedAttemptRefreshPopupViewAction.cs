using Il2CppDummyDll;
using System;

public struct DCampaignLimitedAttemptRefreshPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DCampaignLimitedAttemptRefreshPopupViewAction.Type ActionType;

	[Address(RVA="0xF0323C", Offset="0xF0323C", VA="0xF0323C")]
	public DCampaignLimitedAttemptRefreshPopupViewAction(DCampaignLimitedAttemptRefreshPopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		RefreshClicked
	}
}