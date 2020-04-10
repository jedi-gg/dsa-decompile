using Il2CppDummyDll;
using Serverproto;
using System;

public struct DCampaignFirstTimeCompletedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.CampaignIdentifier CampaignIdentifier;

	[Address(RVA="0xF03234", Offset="0xF03234", VA="0xF03234")]
	public DCampaignFirstTimeCompletedAction(Serverproto.CampaignIdentifier campaignIdentifier)
	{
	}
}