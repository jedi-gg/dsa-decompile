using Il2CppDummyDll;
using System;

public class SharedPrefs
{
	[Address(RVA="0x14BACC0", Offset="0x14BACC0", VA="0x14BACC0")]
	public SharedPrefs()
	{
	}

	[Address(RVA="0x14BAB08", Offset="0x14BAB08", VA="0x14BAB08")]
	public void DeleteKey(string key)
	{
	}

	[Address(RVA="0x14B9FEC", Offset="0x14B9FEC", VA="0x14B9FEC")]
	public bool GetBool(string key, bool defaultValue = false)
	{
		return new bool();
	}

	[Address(RVA="0x14BAB6C", Offset="0x14BAB6C", VA="0x14BAB6C")]
	public DateTime? GetDateTimeUtc(string key)
	{
		return null;
	}

	[Address(RVA="0x14BAB34", Offset="0x14BAB34", VA="0x14BAB34")]
	public float GetFloat(string key, float defaultValue = 0f)
	{
		return new float();
	}

	[Address(RVA="0x14BAB14", Offset="0x14BAB14", VA="0x14BAB14")]
	public int GetInt(string key, int defaultValue = 0)
	{
		return new int();
	}

	[Address(RVA="0x14BAB4C", Offset="0x14BAB4C", VA="0x14BAB4C")]
	public string GetString(string key, string defaultValue = "")
	{
		return null;
	}

	[Address(RVA="0x14BAAFC", Offset="0x14BAAFC", VA="0x14BAAFC")]
	public bool HasKey(string key)
	{
		return new bool();
	}

	[Address(RVA="0x14BA528", Offset="0x14BA528", VA="0x14BA528")]
	public void Save()
	{
	}

	[Address(RVA="0x14BA514", Offset="0x14BA514", VA="0x14BA514")]
	public void SetBool(string key, bool value)
	{
	}

	[Address(RVA="0x14BAC5C", Offset="0x14BAC5C", VA="0x14BAC5C")]
	public void SetDateTimeUtc(string key, DateTime dateTime)
	{
	}

	[Address(RVA="0x14BAB40", Offset="0x14BAB40", VA="0x14BAB40")]
	public void SetFloat(string key, float value)
	{
	}

	[Address(RVA="0x14BAB24", Offset="0x14BAB24", VA="0x14BAB24")]
	public void SetInt(string key, int value)
	{
	}

	[Address(RVA="0x14BAB5C", Offset="0x14BAB5C", VA="0x14BAB5C")]
	public void SetString(string key, string value)
	{
	}
}