using Gamedata;
using Il2CppDummyDll;
using System;

public class PassportSeasonUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x105AF4C", Offset="0x105AF4C")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105AF5C", Offset="0x105AF5C")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Address(RVA="0x140A50C", Offset="0x140A50C", VA="0x140A50C")]
	public PassportSeasonUtility()
	{
	}

	[Address(RVA="0x13FB9C4", Offset="0x13FB9C4", VA="0x13FB9C4")]
	public PassportSeason? GetCurrentActivePassportSeason()
	{
		return null;
	}

	[Address(RVA="0x14086AC", Offset="0x14086AC", VA="0x14086AC")]
	public ulong? GetCurrentActivePassportSeasonId()
	{
		return null;
	}

	[Address(RVA="0x1408A24", Offset="0x1408A24", VA="0x1408A24")]
	public static int GetCurrentWeek(PassportSeason? season)
	{
		return new int();
	}

	[Address(RVA="0x1406EBC", Offset="0x1406EBC", VA="0x1406EBC")]
	public static DateTime GetEndTimeUtc(PassportSeason? season)
	{
		return new DateTime();
	}

	[Address(RVA="0x140A2CC", Offset="0x140A2CC", VA="0x140A2CC")]
	public ItemCount? GetNextLevelReward(PassportSeason? season)
	{
		return null;
	}

	[Address(RVA="0x1406824", Offset="0x1406824", VA="0x1406824")]
	public PassportSeason? GetNextUpcomingPassportSeason()
	{
		return null;
	}

	[Address(RVA="0x140A09C", Offset="0x140A09C", VA="0x140A09C")]
	public DateTime? GetNextWeekEndTimeOfSeason(PassportSeason? season)
	{
		return null;
	}

	[Address(RVA="0x13FECD4", Offset="0x13FECD4", VA="0x13FECD4")]
	public int GetPlayerPassportSeasonLevel(PassportSeason? season)
	{
		return new int();
	}

	[Address(RVA="0x1409D0C", Offset="0x1409D0C", VA="0x1409D0C")]
	public void GetPlayerPassportSeasonXpValues(PassportSeason? season, ref uint startLevelXp, ref uint nextLevelXp, ref long currentXp)
	{
	}

	[Address(RVA="0x1406E1C", Offset="0x1406E1C", VA="0x1406E1C")]
	public static DateTime GetStartTimeUtc(PassportSeason? season)
	{
		return new DateTime();
	}

	[Address(RVA="0x1406CC8", Offset="0x1406CC8", VA="0x1406CC8")]
	public static bool IsPassportSeasonActive(PassportSeason? season)
	{
		return new bool();
	}

	[Address(RVA="0x1409BB0", Offset="0x1409BB0", VA="0x1409BB0")]
	public static bool IsWeekUnlocked(PassportSeason? season, int weekIndex)
	{
		return new bool();
	}

	[Address(RVA="0x1409F30", Offset="0x1409F30", VA="0x1409F30")]
	public bool PlayerCanPurchasePassportSeasonLevel()
	{
		return new bool();
	}

	[Address(RVA="0x13FEED4", Offset="0x13FEED4", VA="0x13FEED4")]
	public bool PlayerIsEnrolledInCurrentPassportSeason()
	{
		return new bool();
	}
}