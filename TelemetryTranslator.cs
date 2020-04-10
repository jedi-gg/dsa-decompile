using Il2CppDummyDll;
using Serverproto;
using System;

public class TelemetryTranslator
{
	[Attribute(Name="InjectAttribute", RVA="0x105C080", Offset="0x105C080")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDc;

	[Address(RVA="0x1324AD4", Offset="0x1324AD4", VA="0x1324AD4")]
	public TelemetryTranslator()
	{
	}

	[Address(RVA="0x1324514", Offset="0x1324514", VA="0x1324514")]
	public string GetUserAttributeKey(ulong itemId)
	{
		return null;
	}

	[Address(RVA="0x1323F60", Offset="0x1323F60", VA="0x1323F60")]
	public double PenguinCampaignId(CampaignIdentifier campaignIdentifier)
	{
		return new double();
	}

	[Address(RVA="0x13237FC", Offset="0x13237FC", VA="0x13237FC")]
	public string TelemetryActivityType(PlayerActivityType activityType)
	{
		return null;
	}

	[Address(RVA="0x132386C", Offset="0x132386C", VA="0x132386C")]
	public string TelemetryBattleId(CampaignIdentifier campaignIdentifier)
	{
		return null;
	}

	[Address(RVA="0x1323BB0", Offset="0x1323BB0", VA="0x1323BB0")]
	public string TelemetryBattleId(int mapIndex, int nodeIndex)
	{
		return null;
	}

	[Address(RVA="0x1323C48", Offset="0x1323C48", VA="0x1323C48")]
	public string TelemetryBattleId(EventIdentifier eventIdentifier)
	{
		return null;
	}

	[Address(RVA="0x1323D1C", Offset="0x1323D1C", VA="0x1323D1C")]
	public string TelemetryBattleId(TowerIdentifier towerIdentifier)
	{
		return null;
	}

	[Address(RVA="0x1323DF0", Offset="0x1323DF0", VA="0x1323DF0")]
	public string TelemetryBattleId(TowerIdentifier towerIdentifier, int nodeIndex)
	{
		return null;
	}

	[Address(RVA="0x1323EE8", Offset="0x1323EE8", VA="0x1323EE8")]
	public string TelemetryBattleOutcome(bool win, bool quit)
	{
		return null;
	}

	[Address(RVA="0x1324900", Offset="0x1324900", VA="0x1324900")]
	public string TelemetryClubWarMatchId(string clubAId, string clubBId, string clubCId, ulong warStartTime)
	{
		return null;
	}

	[Address(RVA="0x13243B0", Offset="0x13243B0", VA="0x13243B0")]
	public string TelemetryCurrencyName(ulong itemId)
	{
		return null;
	}

	[Address(RVA="0x132401C", Offset="0x132401C", VA="0x132401C")]
	public string TelemetryInventoryItemEvent(ulong itemId, long count)
	{
		return null;
	}

	[Address(RVA="0x13242B0", Offset="0x13242B0", VA="0x13242B0")]
	public string TelemetryItemCategory(ulong itemId)
	{
		return null;
	}

	[Address(RVA="0x1324110", Offset="0x1324110", VA="0x1324110")]
	public string TelemetryItemName(ulong itemId)
	{
		return null;
	}

	[Address(RVA="0x132487C", Offset="0x132487C", VA="0x132487C")]
	public string TelemtryClubWarId(string clubId, ulong warStartTime)
	{
		return null;
	}
}