using Il2CppDummyDll;
using System;

public static class NumberFormatUtil
{
	[FieldOffset(Offset="0x0")]
	public const int INT_32_MAX_CHAR_BUFFER_LENGTH = 14;

	[FieldOffset(Offset="0x0")]
	public const int UINT_32_MAX_CHAR_BUFFER_LENGTH = 13;

	[FieldOffset(Offset="0x0")]
	public const int INT_64_MAX_CHAR_BUFFER_LENGTH = 26;

	[FieldOffset(Offset="0x0")]
	public const int UINT_64_MAX_CHAR_BUFFER_LENGTH = 26;

	[FieldOffset(Offset="0x0")]
	public const int ABBREVIATED_NUMBER_CHAR_BUFFER_LENGTH = 9;

	[FieldOffset(Offset="0x0")]
	public const NumberFormatUtil.AbbreviationLevel DEFAULT_ABBREVIATION_LEVEL = NumberFormatUtil.AbbreviationLevel.Millions;

	[FieldOffset(Offset="0x0")]
	public const int FRACTION_CHAR_BUFFER_LENGTH = 55;

	[FieldOffset(Offset="0x0")]
	public const int INSUFFICIENT_FRACTION_CHAR_BUFFER_LENGTH = 72;

	[FieldOffset(Offset="0x0")]
	private const ulong QUINTILLION = 1000000000000000000L;

	[FieldOffset(Offset="0x0")]
	private const ulong QUADRILLION = 1000000000000000L;

	[FieldOffset(Offset="0x0")]
	private const ulong TRILLION = 1000000000000L;

	[FieldOffset(Offset="0x0")]
	private const ulong BILLION = 1000000000L;

	[FieldOffset(Offset="0x0")]
	private const ulong MILLION = 1000000L;

	[FieldOffset(Offset="0x0")]
	private const ulong THOUSAND = 1000L;

	[FieldOffset(Offset="0x0")]
	private const int MAX_ABBREVIATED_DECIMAL_DIGITS = 2;

	[FieldOffset(Offset="0x0")]
	private readonly static char[] s_insufficientFractionColorTag;

	[FieldOffset(Offset="0x8")]
	private readonly static char[] s_insufficientFractionColorEndTag;

	[Address(RVA="0x12FF8C4", Offset="0x12FF8C4", VA="0x12FF8C4")]
	static NumberFormatUtil()
	{
	}

	[Address(RVA="0x12FF7E8", Offset="0x12FF7E8", VA="0x12FF7E8")]
	private static int AddCharArrayToBuffer(char[] charArray, char[] buffer, int bufferIndex)
	{
		return new int();
	}

	[Address(RVA="0x12FDE6C", Offset="0x12FDE6C", VA="0x12FDE6C")]
	private static void FinalizeCharBuffer(char[] buffer, int bufferIndex)
	{
	}

	[Address(RVA="0x12FE0B0", Offset="0x12FE0B0", VA="0x12FE0B0")]
	public static void IntoAbbreviatedCharArray(char[] buffer, long number, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x12FE578", Offset="0x12FE578", VA="0x12FE578")]
	public static void IntoAbbreviatedCharArray(char[] buffer, ulong number, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x12FE1B4", Offset="0x12FE1B4", VA="0x12FE1B4")]
	private static int IntoAbbreviatedCharBuffer(char[] buffer, NumberFormatUtil.DSignedUlong number, LocalizedNumberFormatters numberFormatters, int startingBufferIndex, NumberFormatUtil.AbbreviationLevel level)
	{
		return new int();
	}

	[Address(RVA="0x12FF39C", Offset="0x12FF39C", VA="0x12FF39C")]
	private static int IntoAbbreviatedSegments(char[] buffer, int integralValue, int decimalValue, char abbreviatedLetterSuffix, char decimalSeparator, bool negative, int startingBufferIndex)
	{
		return new int();
	}

	[Address(RVA="0x12FDBCC", Offset="0x12FDBCC", VA="0x12FDBCC")]
	public static void IntoCharArray(char[] buffer, long number, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x12FDFB0", Offset="0x12FDFB0", VA="0x12FDFB0")]
	public static void IntoCharArray(char[] buffer, ulong number, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x12FF1A8", Offset="0x12FF1A8", VA="0x12FF1A8")]
	private static int IntoClock(char[] buffer, NumberFormatUtil.DSignedUlong hours, NumberFormatUtil.DSignedUlong minutes, LocalizedNumberFormatters numberFormatters)
	{
		return new int();
	}

	[Address(RVA="0x12FF0A0", Offset="0x12FF0A0", VA="0x12FF0A0")]
	public static void IntoClockCharArray(char[] buffer, ulong hours, ulong minutes, LocalizedNumberFormatters numberFormatters)
	{
	}

	[Address(RVA="0x12FE7B8", Offset="0x12FE7B8", VA="0x12FE7B8")]
	private static int IntoFraction(char[] buffer, NumberFormatUtil.DSignedUlong numerator, NumberFormatUtil.DSignedUlong denominator, LocalizedNumberFormatters numberFormatters, bool useInsufficientColorTags, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
		return new int();
	}

	[Address(RVA="0x12FE670", Offset="0x12FE670", VA="0x12FE670")]
	public static void IntoFractionCharArray(char[] buffer, long numerator, long denominator, LocalizedNumberFormatters numberFormatters, bool useInsufficientColorTags, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
	}

	[Address(RVA="0x12FEA50", Offset="0x12FEA50", VA="0x12FEA50")]
	public static void IntoFractionCharArray(char[] buffer, ulong numerator, ulong denominator, LocalizedNumberFormatters numberFormatters, bool useInsufficientColorTags, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
	}

	[Address(RVA="0x12FDCE4", Offset="0x12FDCE4", VA="0x12FDCE4")]
	private static int IntoNumberCharBuffer(char[] buffer, NumberFormatUtil.DSignedUlong number, LocalizedNumberFormatters numberFormatters, int startingBufferIndex)
	{
		return new int();
	}

	[Address(RVA="0x12FECB4", Offset="0x12FECB4", VA="0x12FECB4")]
	private static int IntoRange(char[] buffer, NumberFormatUtil.DSignedUlong min, NumberFormatUtil.DSignedUlong max, LocalizedNumberFormatters numberFormatters, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
		return new int();
	}

	[Address(RVA="0x12FEB80", Offset="0x12FEB80", VA="0x12FEB80")]
	public static void IntoRangeCharArray(char[] buffer, long min, long max, LocalizedNumberFormatters numberFormatters, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
	}

	[Address(RVA="0x12FEF90", Offset="0x12FEF90", VA="0x12FEF90")]
	public static void IntoRangeCharArray(char[] buffer, ulong min, ulong max, LocalizedNumberFormatters numberFormatters, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
	}

	[Address(RVA="0x12FF318", Offset="0x12FF318", VA="0x12FF318")]
	public static bool IsNumberAbbreviated(long number)
	{
		return new bool();
	}

	[Address(RVA="0x12FF388", Offset="0x12FF388", VA="0x12FF388")]
	public static bool IsNumberAbbreviated(ulong number)
	{
		return new bool();
	}

	[Address(RVA="0x12FF674", Offset="0x12FF674", VA="0x12FF674")]
	private static bool ShouldAbbreviate(NumberFormatUtil.DSignedUlong number, NumberFormatUtil.AbbreviationLevel abbreviation)
	{
		return new bool();
	}

	public enum AbbreviationLevel
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Quintillions,
		[FieldOffset(Offset="0x0")]
		Quadrillions,
		[FieldOffset(Offset="0x0")]
		Trillions,
		[FieldOffset(Offset="0x0")]
		Billions,
		[FieldOffset(Offset="0x0")]
		Millions,
		[FieldOffset(Offset="0x0")]
		Thousands
	}

	private struct DSignedUlong
	{
		[FieldOffset(Offset="0x0")]
		public ulong Value;

		[FieldOffset(Offset="0x8")]
		public bool Negative;

		[Address(RVA="0xF00348", Offset="0xF00348", VA="0xF00348")]
		public DSignedUlong(long value)
		{
		}

		[Address(RVA="0xF00360", Offset="0xF00360", VA="0xF00360")]
		public DSignedUlong(ulong value)
		{
		}
	}
}