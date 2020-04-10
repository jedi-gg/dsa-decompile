using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies
{
	public static class GameLanguageUtility
	{
		[Address(RVA="0x1422208", Offset="0x1422208", VA="0x1422208")]
		public static string GetCultureInfoName(GameLanguage language)
		{
			return null;
		}

		[Address(RVA="0x1422278", Offset="0x1422278", VA="0x1422278")]
		public static GameLanguage GetGameLanguageFromSystemLanguage(SystemLanguage systemLanguage)
		{
			return new GameLanguage();
		}

		[Address(RVA="0x14222F4", Offset="0x14222F4", VA="0x14222F4")]
		public static string GetIosPlistName(GameLanguage language)
		{
			return null;
		}

		[Address(RVA="0x142235C", Offset="0x142235C", VA="0x142235C")]
		public static string GetLanguageNameText(GameLanguage language)
		{
			return null;
		}

		[Address(RVA="0x1421F84", Offset="0x1421F84", VA="0x1421F84")]
		public static GameLanguage GetPreferredLanguage()
		{
			return new GameLanguage();
		}
	}
}