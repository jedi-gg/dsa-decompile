using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.IO;

namespace Glunies
{
	public class LocalizationManager : ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x0")]
		public readonly static LocalizedNumberFormatters s_numberFormatters;

		[Attribute(Name="InjectAttribute", RVA="0x106417C", Offset="0x106417C")]
		[FieldOffset(Offset="0x10")]
		private LocalizationService _localizationService;

		[FieldOffset(Offset="0x18")]
		private GameLanguage? _pendingLanguage;

		[FieldOffset(Offset="0x20")]
		private GameLanguage _loadedLanguage;

		[FieldOffset(Offset="0x28")]
		private string _loadedVersion;

		[FieldOffset(Offset="0x30")]
		private Dictionary<string, string> _locKeyToText;

		[FieldOffset(Offset="0x38")]
		private Dictionary<string, string> _locKeyToTextFallback;

		[FieldOffset(Offset="0x40")]
		private FetchContentJob.FetchResult _lastFetchResult;

		public GameLanguage LoadedLanguage
		{
			[Address(RVA="0x152706C", Offset="0x152706C", VA="0x152706C")]
			get
			{
				return new GameLanguage();
			}
		}

		public string LoadedVersion
		{
			[Address(RVA="0x1527064", Offset="0x1527064", VA="0x1527064")]
			get
			{
				return null;
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x152705C", Offset="0x152705C", VA="0x152705C", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1528C9C", Offset="0x1528C9C", VA="0x1528C9C")]
		static LocalizationManager()
		{
		}

		[Address(RVA="0x1528C0C", Offset="0x1528C0C", VA="0x1528C0C")]
		public LocalizationManager()
		{
		}

		[Address(RVA="0x15289CC", Offset="0x15289CC", VA="0x15289CC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A354", Offset="0x108A354")]
		private void <SetLocalizedNumberSuffixes>g__SetLocalizedFormatter|17_10(string locKey, Action<char> setter)
		{
		}

		[Address(RVA="0x1527074", Offset="0x1527074", VA="0x1527074")]
		public void Initialize(Action finished)
		{
		}

		[Address(RVA="0x152710C", Offset="0x152710C", VA="0x152710C")]
		private void LoadFallback(GameLanguage language, Action finished)
		{
		}

		[Address(RVA="0x152754C", Offset="0x152754C", VA="0x152754C")]
		public void LoadLocalization(string contentUrl, string version, bool force, Action<FetchContentJob.FetchResult> finished)
		{
		}

		[Address(RVA="0x1527B60", Offset="0x1527B60", VA="0x1527B60")]
		private void LoadLocalization(GameLanguage language, string contentUrl, string version, Action finished)
		{
		}

		[Address(RVA="0x15277E4", Offset="0x15277E4", VA="0x15277E4")]
		public string Localize(string key)
		{
			return null;
		}

		[Address(RVA="0x15279B0", Offset="0x15279B0", VA="0x15279B0")]
		public string LocalizeOrNull(string key)
		{
			return null;
		}

		[Address(RVA="0x15280B4", Offset="0x15280B4", VA="0x15280B4")]
		private void ReadInto(TextReader reader, ref Dictionary<string, string> mapping)
		{
		}

		[Address(RVA="0x1527280", Offset="0x1527280", VA="0x1527280")]
		public void SetLanguage(GameLanguage language)
		{
		}

		[Address(RVA="0x1527314", Offset="0x1527314", VA="0x1527314")]
		private static void SetLocalizedNumberSeparators()
		{
		}

		[Address(RVA="0x1528248", Offset="0x1528248", VA="0x1528248")]
		private void SetLocalizedNumberSuffixes()
		{
		}

		[Address(RVA="0x1528AA8", Offset="0x1528AA8", VA="0x1528AA8")]
		private void SetLocalizedTimeSuffixes()
		{
		}

		[Address(RVA="0x15271F0", Offset="0x15271F0", VA="0x15271F0")]
		public void Shutdown()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F48", Offset="0x1050F48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static LocalizationManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action<char> <>9__17_0;

			[FieldOffset(Offset="0x10")]
			public static Action<char> <>9__17_1;

			[FieldOffset(Offset="0x18")]
			public static Action<char> <>9__17_2;

			[FieldOffset(Offset="0x20")]
			public static Action<char> <>9__17_3;

			[FieldOffset(Offset="0x28")]
			public static Action<char> <>9__17_4;

			[FieldOffset(Offset="0x30")]
			public static Action<char> <>9__17_5;

			[FieldOffset(Offset="0x38")]
			public static Action<char> <>9__17_6;

			[FieldOffset(Offset="0x40")]
			public static Action<char> <>9__17_7;

			[FieldOffset(Offset="0x48")]
			public static Action<char> <>9__17_8;

			[FieldOffset(Offset="0x50")]
			public static Action<char> <>9__17_9;

			[Address(RVA="0x1528D08", Offset="0x1528D08", VA="0x1528D08")]
			static <>c()
			{
			}

			[Address(RVA="0x1528D6C", Offset="0x1528D6C", VA="0x1528D6C")]
			public <>c()
			{
			}

			[Address(RVA="0x1528D74", Offset="0x1528D74", VA="0x1528D74")]
			internal void <SetLocalizedNumberSuffixes>b__17_0(char c)
			{
			}

			[Address(RVA="0x1528DF8", Offset="0x1528DF8", VA="0x1528DF8")]
			internal void <SetLocalizedNumberSuffixes>b__17_1(char c)
			{
			}

			[Address(RVA="0x1528E7C", Offset="0x1528E7C", VA="0x1528E7C")]
			internal void <SetLocalizedNumberSuffixes>b__17_2(char c)
			{
			}

			[Address(RVA="0x1528F00", Offset="0x1528F00", VA="0x1528F00")]
			internal void <SetLocalizedNumberSuffixes>b__17_3(char c)
			{
			}

			[Address(RVA="0x1528F84", Offset="0x1528F84", VA="0x1528F84")]
			internal void <SetLocalizedNumberSuffixes>b__17_4(char c)
			{
			}

			[Address(RVA="0x1529008", Offset="0x1529008", VA="0x1529008")]
			internal void <SetLocalizedNumberSuffixes>b__17_5(char c)
			{
			}

			[Address(RVA="0x152908C", Offset="0x152908C", VA="0x152908C")]
			internal void <SetLocalizedNumberSuffixes>b__17_6(char c)
			{
			}

			[Address(RVA="0x1529110", Offset="0x1529110", VA="0x1529110")]
			internal void <SetLocalizedNumberSuffixes>b__17_7(char c)
			{
			}

			[Address(RVA="0x1529194", Offset="0x1529194", VA="0x1529194")]
			internal void <SetLocalizedNumberSuffixes>b__17_8(char c)
			{
			}

			[Address(RVA="0x1529218", Offset="0x1529218", VA="0x1529218")]
			internal void <SetLocalizedNumberSuffixes>b__17_9(char c)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F08", Offset="0x1050F08")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public LocalizationManager <>4__this;

			[FieldOffset(Offset="0x18")]
			public string contentUrl;

			[FieldOffset(Offset="0x20")]
			public string version;

			[FieldOffset(Offset="0x28")]
			public Action<FetchContentJob.FetchResult> finished;

			[Address(RVA="0x15277D4", Offset="0x15277D4", VA="0x15277D4")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x152929C", Offset="0x152929C", VA="0x152929C")]
			internal void <LoadLocalization>b__2()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F18", Offset="0x1050F18")]
		private sealed class <>c__DisplayClass10_1
		{
			[FieldOffset(Offset="0x10")]
			public GameLanguage language;

			[FieldOffset(Offset="0x18")]
			public LocalizationManager.<>c__DisplayClass10_0 CS$<>8__locals1;

			[Address(RVA="0x15277DC", Offset="0x15277DC", VA="0x15277DC")]
			public <>c__DisplayClass10_1()
			{
			}

			[Address(RVA="0x1529344", Offset="0x1529344", VA="0x1529344")]
			internal void <LoadLocalization>b__0(Action executed)
			{
			}

			[Address(RVA="0x152939C", Offset="0x152939C", VA="0x152939C")]
			internal void <LoadLocalization>b__1(Action executed)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F28", Offset="0x1050F28")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public LocalizationManager <>4__this;

			[FieldOffset(Offset="0x18")]
			public GameLanguage language;

			[FieldOffset(Offset="0x20")]
			public string version;

			[FieldOffset(Offset="0x28")]
			public Action finished;

			[Address(RVA="0x1527CF0", Offset="0x1527CF0", VA="0x1527CF0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x1529444", Offset="0x1529444", VA="0x1529444")]
			internal void <LoadLocalization>b__0(byte[] data)
			{
			}

			[Address(RVA="0x1529728", Offset="0x1529728", VA="0x1529728")]
			internal void <LoadLocalization>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F38", Offset="0x1050F38")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x10")]
			public LocalizationManager <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action finished;

			[Address(RVA="0x1527EAC", Offset="0x1527EAC", VA="0x1527EAC")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x15297CC", Offset="0x15297CC", VA="0x15297CC")]
			internal void <LoadFallback>b__0(string text)
			{
			}
		}
	}
}