using Il2CppDummyDll;
using System;

public struct DCampaignNodeDetailsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DCampaignNodeDetailsViewAction.Type ActionType;

	[Address(RVA="0xF03264", Offset="0xF03264", VA="0xF03264")]
	public DCampaignNodeDetailsViewAction(DCampaignNodeDetailsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		SelectHeroesClicked,
		[FieldOffset(Offset="0x0")]
		SimClicked,
		[FieldOffset(Offset="0x0")]
		RefreshAttemptsClicked
	}
}