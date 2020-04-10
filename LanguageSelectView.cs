using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class LanguageSelectView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private Dictionary<GameLanguage, LanguageSelectViewButton> _languageButtons;

	private LanguageSelectView.SerializedFields Fields
	{
		[Address(RVA="0x11D8A04", Offset="0x11D8A04", VA="0x11D8A04")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D8CE0", Offset="0x11D8CE0", VA="0x11D8CE0")]
	public LanguageSelectView()
	{
	}

	[Address(RVA="0x11D804C", Offset="0x11D804C", VA="0x11D804C")]
	public void SetSelectedLanguage(GameLanguage language)
	{
	}

	[Address(RVA="0x11D8208", Offset="0x11D8208", VA="0x11D8208", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11D8AEC", Offset="0x11D8AEC", VA="0x11D8AEC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C3AC", Offset="0x104C3AC")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public GameLanguage language;

		[FieldOffset(Offset="0x18")]
		public LanguageSelectView <>4__this;

		[Address(RVA="0x11D8AE4", Offset="0x11D8AE4", VA="0x11D8AE4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x11D8D50", Offset="0x11D8D50", VA="0x11D8D50")]
		internal void <ViewAssetLoaded>b__0()
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public LanguageSelectViewButton LanguageButtonArchetype;

		[FieldOffset(Offset="0x38")]
		public Transform LanguageButtonParent;

		[FieldOffset(Offset="0x40")]
		public List<GameLanguage> SortedLanguages;

		[Address(RVA="0x11D8DE4", Offset="0x11D8DE4", VA="0x11D8DE4")]
		public SerializedFields()
		{
		}
	}
}