using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class AccountPrefs
{
	[FieldOffset(Offset="0x0")]
	private const string COLLECTION_DELIMITER = ";";

	[Attribute(Name="InjectAttribute", RVA="0x105B774", Offset="0x105B774")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x18")]
	private bool _dirty;

	[Address(RVA="0x1155C00", Offset="0x1155C00", VA="0x1155C00")]
	public AccountPrefs()
	{
	}

	[Address(RVA="0x11552D0", Offset="0x11552D0", VA="0x11552D0")]
	public void DeletePlayerKey(string key)
	{
	}

	[Address(RVA="0x1155880", Offset="0x1155880", VA="0x1155880")]
	public void GetCalendarDate(string key, out int year, out int month, out int day)
	{
		year = 0;
		month = 0;
		day = 0;
	}

	[Address(RVA="0x1155300", Offset="0x1155300", VA="0x1155300")]
	public bool GetPlayerBool(string key, bool defaultValue = false)
	{
		return new bool();
	}

	[Address(RVA="0x11556F4", Offset="0x11556F4", VA="0x11556F4")]
	public DateTime? GetPlayerDateTimeUtc(string key)
	{
		return null;
	}

	[Address(RVA="0x11555C0", Offset="0x11555C0", VA="0x11555C0")]
	public double GetPlayerDouble(string key, double defaultValue = 0)
	{
		return new double();
	}

	[Address(RVA="0x1155558", Offset="0x1155558", VA="0x1155558")]
	public float GetPlayerFloat(string key, float defaultValue = 0f)
	{
		return new float();
	}

	[Address(RVA="0x1155354", Offset="0x1155354", VA="0x1155354")]
	public int GetPlayerInt(string key, int defaultValue = 0)
	{
		return new int();
	}

	[Address(RVA="0x11551AC", Offset="0x11551AC", VA="0x11551AC")]
	private string GetPlayerKey(string key)
	{
		return null;
	}

	[Address(RVA="0x11553EC", Offset="0x11553EC", VA="0x11553EC")]
	public long GetPlayerLong(string key, long defaultValue = 0L)
	{
		return new long();
	}

	[Address(RVA="0x115549C", Offset="0x115549C", VA="0x115549C")]
	public string GetPlayerString(string key, string defaultValue = "")
	{
		return null;
	}

	[Address(RVA="0x1155964", Offset="0x1155964", VA="0x1155964")]
	public void GetUlongCollection(string key, ref SortedSet<ulong> sortedSet)
	{
	}

	[Address(RVA="0x1155194", Offset="0x1155194", VA="0x1155194")]
	public bool HasPlayerKey(string key)
	{
		return new bool();
	}

	[Address(RVA="0x115515C", Offset="0x115515C", VA="0x115515C")]
	public void Save()
	{
	}

	[Address(RVA="0x1155164", Offset="0x1155164", VA="0x1155164")]
	public void SaveIfDirty()
	{
	}

	[Address(RVA="0x115591C", Offset="0x115591C", VA="0x115591C")]
	public void SetCalendarDate(string key, int year, int month, int day)
	{
	}

	[Address(RVA="0x115537C", Offset="0x115537C", VA="0x115537C")]
	public void SetPlayerBool(string key, bool value)
	{
	}

	[Address(RVA="0x1155800", Offset="0x1155800", VA="0x1155800")]
	public void SetPlayerDateTimeUtc(string key, DateTime dateTime)
	{
	}

	[Address(RVA="0x1155698", Offset="0x1155698", VA="0x1155698")]
	public void SetPlayerDouble(string key, double value)
	{
	}

	[Address(RVA="0x1155580", Offset="0x1155580", VA="0x1155580")]
	public void SetPlayerFloat(string key, float value)
	{
	}

	[Address(RVA="0x11553B4", Offset="0x11553B4", VA="0x11553B4")]
	public void SetPlayerInt(string key, int value)
	{
	}

	[Address(RVA="0x11554C4", Offset="0x11554C4", VA="0x11554C4")]
	public void SetPlayerLong(string key, long value)
	{
	}

	[Address(RVA="0x1155520", Offset="0x1155520", VA="0x1155520")]
	public void SetPlayerString(string key, string value)
	{
	}

	[Address(RVA="0x1155B6C", Offset="0x1155B6C", VA="0x1155B6C")]
	public void SetUlongCollection(string key, SortedSet<ulong> sortedSet)
	{
	}
}