using Il2CppDummyDll;
using Serverproto;
using System;

public struct DCampaignAddress
{
	[FieldOffset(Offset="0x0")]
	public static DCampaignAddress s_invalid;

	[FieldOffset(Offset="0x0")]
	public ulong CampaignId;

	[FieldOffset(Offset="0x8")]
	public int MapIndex;

	[FieldOffset(Offset="0xC")]
	public int NodeIndex;

	[FieldOffset(Offset="0x10")]
	public int BattleIndex;

	[Address(RVA="0x153D9AC", Offset="0x153D9AC", VA="0x153D9AC")]
	static DCampaignAddress()
	{
	}

	[Address(RVA="0xF031D0", Offset="0xF031D0", VA="0xF031D0")]
	public DCampaignAddress(ulong campaignId, int mapIndex = 0, int nodeIndex = 0, int battleIndex = 0)
	{
	}

	[Address(RVA="0x153D7E4", Offset="0x153D7E4", VA="0x153D7E4")]
	public static DCampaignAddress FromProto(CampaignIdentifier cid)
	{
		return new DCampaignAddress();
	}

	[Address(RVA="0xF031E0", Offset="0xF031E0", VA="0xF031E0")]
	public CampaignIdentifier ToProto()
	{
		return null;
	}
}