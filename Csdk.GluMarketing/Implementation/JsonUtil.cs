using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csdk.GluMarketing.Implementation
{
	public static class JsonUtil
	{
		[Address(RVA="0x1539498", Offset="0x1539498", VA="0x1539498")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, Exception e)
		{
			return null;
		}

		[Address(RVA="0x15395F0", Offset="0x15395F0", VA="0x15395F0")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IList val)
		{
			return null;
		}

		[Address(RVA="0x25CBB18", Offset="0x25CBB18", VA="0x25CBB18")]
		private static JsonStringer DoKeyValue<T>(JsonStringer json, string key, IDictionary<string, T> val)
		{
			return null;
		}

		[Address(RVA="0x15398BC", Offset="0x15398BC", VA="0x15398BC")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IDictionary val)
		{
			return null;
		}

		[Address(RVA="0x1538980", Offset="0x1538980", VA="0x1538980")]
		public static JsonStringer KeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x1539F24", Offset="0x1539F24", VA="0x1539F24")]
		public static JsonStringer OptionalKeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x15388F0", Offset="0x15388F0", VA="0x15388F0")]
		public static string ToJson(object val)
		{
			return null;
		}

		[Address(RVA="0x1538970", Offset="0x1538970", VA="0x1538970")]
		public static JsonStringer Value(JsonStringer json, object val)
		{
			return null;
		}
	}
}