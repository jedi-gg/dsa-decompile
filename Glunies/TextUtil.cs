using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;

namespace Glunies
{
	public static class TextUtil
	{
		[FieldOffset(Offset="0x0")]
		private readonly static char[] s_charBuffer;

		[Address(RVA="0x1616C60", Offset="0x1616C60", VA="0x1616C60")]
		static TextUtil()
		{
		}

		[Address(RVA="0x16163EC", Offset="0x16163EC", VA="0x16163EC")]
		public static void SetAbbreviatedFraction(UiLabel label, long numerator, long denominator, bool checkInsufficientColor = false, NumberFormatUtil.AbbreviationLevel abbreviation = 5)
		{
		}

		[Address(RVA="0x161652C", Offset="0x161652C", VA="0x161652C")]
		public static void SetAbbreviatedFraction(UiLabel label, ulong numerator, ulong denominator, bool checkInsufficientColor = false, NumberFormatUtil.AbbreviationLevel abbreviation = 5)
		{
		}

		[Address(RVA="0x1615F6C", Offset="0x1615F6C", VA="0x1615F6C")]
		public static void SetAbbreviatedNumber(UiLabel label, long number)
		{
		}

		[Address(RVA="0x1616078", Offset="0x1616078", VA="0x1616078")]
		public static void SetAbbreviatedNumber(UiLabel label, ulong number)
		{
		}

		[Address(RVA="0x161689C", Offset="0x161689C", VA="0x161689C")]
		public static void SetAbbreviatedRange(UiLabel label, long min, long max, NumberFormatUtil.AbbreviationLevel abbreviation = 5)
		{
		}

		[Address(RVA="0x16169F4", Offset="0x16169F4", VA="0x16169F4")]
		public static void SetAbbreviatedRange(UiLabel label, ulong min, ulong max, NumberFormatUtil.AbbreviationLevel abbreviation = 5)
		{
		}

		[Address(RVA="0x1616B4C", Offset="0x1616B4C", VA="0x1616B4C")]
		public static void SetClock(UiLabel label, uint hours, uint minutes)
		{
		}

		[Address(RVA="0x1616184", Offset="0x1616184", VA="0x1616184")]
		public static void SetFraction(UiLabel label, long numerator, long denominator, bool checkInsufficientColor = false)
		{
		}

		[Address(RVA="0x16162B8", Offset="0x16162B8", VA="0x16162B8")]
		public static void SetFraction(UiLabel label, ulong numerator, ulong denominator, bool checkInsufficientColor = false)
		{
		}

		[Address(RVA="0x1615AEC", Offset="0x1615AEC", VA="0x1615AEC")]
		public static void SetNumber(UiLabel label, long number)
		{
		}

		[Address(RVA="0x1615BF8", Offset="0x1615BF8", VA="0x1615BF8")]
		public static void SetNumber(UiLabel label, ulong number)
		{
		}

		[Address(RVA="0x1615D04", Offset="0x1615D04", VA="0x1615D04")]
		public static void SetNumberInFormatString(UiLabel label, string formatString, long number)
		{
		}

		[Address(RVA="0x1615E38", Offset="0x1615E38", VA="0x1615E38")]
		public static void SetNumberInFormatString(UiLabel label, string formatString, ulong number)
		{
		}

		[Address(RVA="0x161666C", Offset="0x161666C", VA="0x161666C")]
		public static void SetRange(UiLabel label, long min, long max)
		{
		}

		[Address(RVA="0x1616784", Offset="0x1616784", VA="0x1616784")]
		public static void SetRange(UiLabel label, ulong min, ulong max)
		{
		}
	}
}