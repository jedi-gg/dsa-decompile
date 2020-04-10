using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csdk.GluAds.Implementation
{
	public static class JsonUtil
	{
		[Address(RVA="0x1558150", Offset="0x1558150", VA="0x1558150")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, Exception e)
		{
			return null;
		}

		[Address(RVA="0x15582A8", Offset="0x15582A8", VA="0x15582A8")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IList val)
		{
			return null;
		}

		[Address(RVA="0x25C8668", Offset="0x25C8668", VA="0x25C8668")]
		private static JsonStringer DoKeyValue<T>(JsonStringer json, string key, IDictionary<string, T> val)
		{
			return null;
		}

		[Address(RVA="0x1558574", Offset="0x1558574", VA="0x1558574")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IDictionary val)
		{
			return null;
		}

		[Address(RVA="0x1557638", Offset="0x1557638", VA="0x1557638")]
		public static JsonStringer KeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x154EAD0", Offset="0x154EAD0", VA="0x154EAD0")]
		public static JsonStringer OptionalKeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x154E9BC", Offset="0x154E9BC", VA="0x154E9BC")]
		public static string ToJson(object val)
		{
			return null;
		}

		[Address(RVA="0x1557628", Offset="0x1557628", VA="0x1557628")]
		public static JsonStringer Value(JsonStringer json, object val)
		{
			return null;
		}
	}
}