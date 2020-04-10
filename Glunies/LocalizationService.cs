using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies
{
	public class LocalizationService : ADataCacheService, ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x0")]
		private const string LOCALIZATION_URL_FORMAT = "{0}/localization/{1}/Loc_{2}.txt";

		[FieldOffset(Offset="0x0")]
		private const string CACHE_DIR = "localization";

		[FieldOffset(Offset="0x0")]
		private const string CACHE_FILE_NAME_FORMAT = "loc_{0}.bin";

		[FieldOffset(Offset="0x0")]
		private readonly static Dictionary<GameLanguage, string> SYSTEM_LANGUAGE_TO_RESOURCE_FILE;

		[Attribute(Name="InjectAttribute", RVA="0x106418C", Offset="0x106418C")]
		[FieldOffset(Offset="0x18")]
		private DispatchSystem _dispatch;

		public override LogCategory LogCategory
		{
			[Address(RVA="0x1529934", Offset="0x1529934", VA="0x1529934", Slot="5")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1529954", Offset="0x1529954", VA="0x1529954")]
		static LocalizationService()
		{
		}

		[Address(RVA="0x152994C", Offset="0x152994C", VA="0x152994C")]
		public LocalizationService()
		{
		}

		[Address(RVA="0x1527EB4", Offset="0x1527EB4", VA="0x1527EB4")]
		public void GetFallback(GameLanguage language, Action<string> finished)
		{
		}

		[Address(RVA="0x1527CF8", Offset="0x1527CF8", VA="0x1527CF8")]
		public void GetLocalization(GameLanguage language, string contentUrl, string version, Action<byte[]> finished, Action error)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F58", Offset="0x1050F58")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public LocalizationService <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action error;

			[Address(RVA="0x152993C", Offset="0x152993C", VA="0x152993C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1529BFC", Offset="0x1529BFC", VA="0x1529BFC")]
			internal void <GetLocalization>b__0(long errorCode, byte[] data)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F68", Offset="0x1050F68")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<string> finished;

			[Address(RVA="0x1529944", Offset="0x1529944", VA="0x1529944")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x1529D58", Offset="0x1529D58", VA="0x1529D58")]
			internal void <GetFallback>b__0(AsyncOperation asyncOp)
			{
			}
		}
	}
}