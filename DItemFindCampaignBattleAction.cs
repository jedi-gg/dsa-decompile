using Il2CppDummyDll;
using Serverproto;
using System;

public struct DItemFindCampaignBattleAction
{
	[FieldOffset(Offset="0x0")]
	public readonly CampaignIdentifier CampaignId;

	[FieldOffset(Offset="0x8")]
	public readonly bool InstantBattle;

	[Address(RVA="0xEFE11C", Offset="0xEFE11C", VA="0xEFE11C")]
	public DItemFindCampaignBattleAction(CampaignIdentifier campaignId, bool instantBattle)
	{
	}
}