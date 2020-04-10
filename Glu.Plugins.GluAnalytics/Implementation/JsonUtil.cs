using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Glu.Plugins.GluAnalytics.Implementation
{
	public static class JsonUtil
	{
		[Address(RVA="0x14F3090", Offset="0x14F3090", VA="0x14F3090")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, Exception e)
		{
			return null;
		}

		[Address(RVA="0x14F31E8", Offset="0x14F31E8", VA="0x14F31E8")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IList val)
		{
			return null;
		}

		[Address(RVA="0x1E49B68", Offset="0x1E49B68", VA="0x1E49B68")]
		private static JsonStringer DoKeyValue<T>(JsonStringer json, string key, IDictionary<string, T> val)
		{
			return null;
		}

		[Address(RVA="0x14F34B4", Offset="0x14F34B4", VA="0x14F34B4")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IDictionary val)
		{
			return null;
		}

		[Address(RVA="0x14F2578", Offset="0x14F2578", VA="0x14F2578")]
		public static JsonStringer KeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x14F3B1C", Offset="0x14F3B1C", VA="0x14F3B1C")]
		public static JsonStringer OptionalKeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x14F24E8", Offset="0x14F24E8", VA="0x14F24E8")]
		public static string ToJson(object val)
		{
			return null;
		}

		[Address(RVA="0x14F2568", Offset="0x14F2568", VA="0x14F2568")]
		public static JsonStringer Value(JsonStringer json, object val)
		{
			return null;
		}
	}
}