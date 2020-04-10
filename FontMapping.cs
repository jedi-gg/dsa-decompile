using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FontMapping : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private List<FontMapping.LanguageFonts> _languageFonts;

	[Address(RVA="0x12CAD70", Offset="0x12CAD70", VA="0x12CAD70")]
	public FontMapping()
	{
	}

	[Address(RVA="0x12CA9EC", Offset="0x12CA9EC", VA="0x12CA9EC")]
	public TMP_FontAsset GetPrimaryFont(GameLanguage language)
	{
		return null;
	}

	[Serializable]
	public class LanguageFonts
	{
		[FieldOffset(Offset="0x10")]
		public GameLanguage Language;

		[FieldOffset(Offset="0x18")]
		public TMP_FontAsset PrimaryFont;

		[Address(RVA="0x12CAD78", Offset="0x12CAD78", VA="0x12CAD78")]
		public LanguageFonts()
		{
		}
	}
}