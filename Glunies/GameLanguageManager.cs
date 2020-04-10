using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class GameLanguageManager
	{
		[Attribute(Name="InjectAttribute", RVA="0x106415C", Offset="0x106415C")]
		[FieldOffset(Offset="0x10")]
		private SharedPrefs _sharedPrefs;

		[Attribute(Name="InjectAttribute", RVA="0x106416C", Offset="0x106416C")]
		[FieldOffset(Offset="0x18")]
		private LocalizationManager _localizationManager;

		[FieldOffset(Offset="0x20")]
		private GameLanguage _language;

		public GameLanguage Language
		{
			[Address(RVA="0x1421F54", Offset="0x1421F54", VA="0x1421F54")]
			get
			{
				return new GameLanguage();
			}
		}

		[Address(RVA="0x1422270", Offset="0x1422270", VA="0x1422270")]
		public GameLanguageManager()
		{
		}

		[Address(RVA="0x1421F5C", Offset="0x1421F5C", VA="0x1421F5C")]
		public void Initialize()
		{
		}

		[Address(RVA="0x1421FF0", Offset="0x1421FF0", VA="0x1421FF0")]
		public void SetLanguage(GameLanguage language)
		{
		}
	}
}