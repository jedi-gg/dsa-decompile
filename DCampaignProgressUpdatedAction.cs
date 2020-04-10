using Il2CppDummyDll;
using Serverproto;
using System;

public struct DCampaignProgressUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.CampaignProgress CampaignProgress;

	public Serverproto.CampaignIdentifier CampaignIdentifier
	{
		[Address(RVA="0xF032B8", Offset="0xF032B8", VA="0xF032B8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0xF032C0", Offset="0xF032C0", VA="0xF032C0")]
	public DCampaignProgressUpdatedAction(Serverproto.CampaignProgress campaignProgress)
	{
	}
}