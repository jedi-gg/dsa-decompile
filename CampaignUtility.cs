using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;

public class CampaignUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x105B444", Offset="0x105B444")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105B454", Offset="0x105B454")]
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105B464", Offset="0x105B464")]
	[FieldOffset(Offset="0x20")]
	private FeatureLockController _featureLockController;

	[Address(RVA="0x11894D4", Offset="0x11894D4", VA="0x11894D4")]
	public CampaignUtility()
	{
	}

	[Address(RVA="0x1187FC4", Offset="0x1187FC4", VA="0x1187FC4")]
	public uint GetCampaignAttemptsRemaining(DCampaignAddress address)
	{
		return new uint();
	}

	[Address(RVA="0x1187FFC", Offset="0x1187FFC", VA="0x1187FFC")]
	public CampaignUtility.DLimitedAttemptInfo GetCampaignLimitedAttemptInfo(DCampaignAddress address)
	{
		return new CampaignUtility.DLimitedAttemptInfo();
	}

	[Address(RVA="0x1188E34", Offset="0x1188E34", VA="0x1188E34")]
	public CampaignIdentifier GetFurthestAvailableInstantWinBattle(ulong campaignId)
	{
		return null;
	}

	[Address(RVA="0x1188304", Offset="0x1188304", VA="0x1188304")]
	private uint GetMaxAttempts(Campaign? campaign)
	{
		return new uint();
	}

	[Address(RVA="0x1188638", Offset="0x1188638", VA="0x1188638")]
	public bool HasAvailableInstantWinBattle(ulong campaignId)
	{
		return new bool();
	}

	[Address(RVA="0x1188500", Offset="0x1188500", VA="0x1188500")]
	public bool IsCampaignUnlocked(ulong campaignId, bool showLockedMessage = false)
	{
		return new bool();
	}

	public struct DLimitedAttemptInfo
	{
		[FieldOffset(Offset="0x0")]
		public ulong ResetTime;

		[FieldOffset(Offset="0x8")]
		public uint MaxAttempts;

		[FieldOffset(Offset="0xC")]
		public uint AttemptsRemaining;

		[FieldOffset(Offset="0x10")]
		public ulong RefreshCost;

		[FieldOffset(Offset="0x18")]
		public ulong RefreshCostItem;
	}
}