using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class AProfanityFilter
{
	[FieldOffset(Offset="0x10")]
	protected List<AProfanityFilter.BadWord> _badWords;

	[FieldOffset(Offset="0x18")]
	protected Dictionary<string, List<string>> _falsePositiveMap;

	[Address(RVA="0x10F3068", Offset="0x10F3068", VA="0x10F3068")]
	public AProfanityFilter()
	{
	}

	[Address(RVA="0x10F26CC", Offset="0x10F26CC", VA="0x10F26CC")]
	protected void AddFalsePositiveEntry(string badWord, List<string> allGoodWords)
	{
	}

	[Address(RVA="0x10F1B9C", Offset="0x10F1B9C", VA="0x10F1B9C")]
	public bool ContainsProfanity(string text)
	{
		return new bool();
	}

	[Address(RVA="0x10F2D50", Offset="0x10F2D50", VA="0x10F2D50")]
	private bool IsFalsePositive(AProfanityFilter.BadWord badWord, int badWordIndex, int badWordMatchLen, string originalText, string sanitizedText)
	{
		return new bool();
	}

	[Address(RVA="0x10F26C8", Offset="0x10F26C8", VA="0x10F26C8", Slot="4")]
	public virtual void LogWarning(string text)
	{
	}

	[Address(RVA="0x10F26C0", Offset="0x10F26C0", VA="0x10F26C0")]
	public string ReplaceProfanity(string text)
	{
		return null;
	}

	[Address(RVA="0x10F28E8", Offset="0x10F28E8", VA="0x10F28E8")]
	private string SanitizeText(string unsanitizedText)
	{
		return null;
	}

	[Address(RVA="0x10F1BC8", Offset="0x10F1BC8", VA="0x10F1BC8")]
	protected string SearchAndReplace(string text, bool earlyOut)
	{
		return null;
	}

	protected class BadWord
	{
		[FieldOffset(Offset="0x10")]
		public string Word;

		[FieldOffset(Offset="0x18")]
		public bool ExactMatchOnly;

		[FieldOffset(Offset="0x20")]
		private Regex _regex;

		[Address(RVA="0x10F3100", Offset="0x10F3100", VA="0x10F3100")]
		public BadWord(string word, bool exactMatchOnly)
		{
		}

		[Address(RVA="0x10F2D2C", Offset="0x10F2D2C", VA="0x10F2D2C")]
		public MatchCollection Matches(string originalText, string sanitizedText)
		{
			return null;
		}
	}
}