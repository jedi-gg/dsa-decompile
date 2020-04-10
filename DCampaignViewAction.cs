using Il2CppDummyDll;
using System;

public struct DCampaignViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DCampaignViewAction.Type ActionType;

	[Address(RVA="0xF032C8", Offset="0xF032C8", VA="0xF032C8")]
	public DCampaignViewAction(DCampaignViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShowEventDetails,
		[FieldOffset(Offset="0x0")]
		ShowInfo,
		[FieldOffset(Offset="0x0")]
		HideInfo,
		[FieldOffset(Offset="0x0")]
		Inventory
	}
}