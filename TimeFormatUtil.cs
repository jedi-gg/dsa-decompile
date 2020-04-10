using Il2CppDummyDll;
using System;

public static class TimeFormatUtil
{
	[FieldOffset(Offset="0x0")]
	public const int FULL_DATETIME_BUFFER_SIZE = 20;

	[FieldOffset(Offset="0x0")]
	private const int MAX_TIME_COMPONENTS = 2;

	[FieldOffset(Offset="0x0")]
	private const int MAX_TIME_COMPONENT_DIGITS = 3;

	[FieldOffset(Offset="0x0")]
	private const char SPACE_CHAR = ' ';

	[FieldOffset(Offset="0x0")]
	private const char TERMINATE_CHAR = '\0';

	[Address(RVA="0x13268AC", Offset="0x13268AC", VA="0x13268AC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071260", Offset="0x1071260")]
	internal static void <IntoFullDateTime>g__SetCharInt|4_0(int bufferIndex, int val, ref TimeFormatUtil.<>c__DisplayClass4_0 _)
	{
	}

	[Address(RVA="0x1325E64", Offset="0x1325E64", VA="0x1325E64")]
	public static string FormatTimeSpan(TimeSpan time, LocalizedNumberFormatters numberFormatters, bool showSeconds = true)
	{
		return null;
	}

	[Address(RVA="0x1325CE0", Offset="0x1325CE0", VA="0x1325CE0")]
	public static int GetMaxTimeSpanCharArraySize(LocalizedNumberFormatters numberFormatters)
	{
		return new int();
	}

	[Address(RVA="0x13262BC", Offset="0x13262BC", VA="0x13262BC")]
	private static int InsertCharInBuffer(char[] buffer, char c, int startingIndex)
	{
		return new int();
	}

	[Address(RVA="0x1326398", Offset="0x1326398", VA="0x1326398")]
	private static void InsertDaysInBuffer(char[] buffer, TimeSpan timeSpan, ref int bufferIndex, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x132631C", Offset="0x132631C", VA="0x132631C")]
	private static void InsertHoursInBuffer(char[] buffer, TimeSpan timeSpan, ref int bufferIndex, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x1326240", Offset="0x1326240", VA="0x1326240")]
	private static void InsertMinutesInBuffer(char[] buffer, TimeSpan timeSpan, ref int bufferIndex, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x1326910", Offset="0x1326910", VA="0x1326910")]
	private static int InsertNumberInBuffer(char[] buffer, int number, int startingIndex)
	{
		return new int();
	}

	[Address(RVA="0x13261C4", Offset="0x13261C4", VA="0x13261C4")]
	private static void InsertSecondsInBuffer(char[] buffer, TimeSpan timeSpan, ref int bufferIndex, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x1326B30", Offset="0x1326B30", VA="0x1326B30")]
	private static int InsertStringInBuffer(char[] buffer, string str, int startingIndex)
	{
		return new int();
	}

	[Address(RVA="0x1326414", Offset="0x1326414", VA="0x1326414")]
	public static void IntoFullDateTime(char[] buffer, DateTime dateTime, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x1325F68", Offset="0x1325F68", VA="0x1325F68")]
	public static int IntoTimeSpanCharArray(char[] buffer, TimeSpan time, TimeSpan previousTime, LocalizedNumberFormatters numberFormatters, bool showSeconds = true)
	{
		return new int();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D20C", Offset="0x104D20C")]
	private struct <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x0")]
		public char[] buffer;
	}
}