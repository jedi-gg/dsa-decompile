using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csdk.GluAppTracking.Implementation
{
	public static class JsonUtil
	{
		[Address(RVA="0x155B9B8", Offset="0x155B9B8", VA="0x155B9B8")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, Exception e)
		{
			return null;
		}

		[Address(RVA="0x155BB10", Offset="0x155BB10", VA="0x155BB10")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IList val)
		{
			return null;
		}

		[Address(RVA="0x25C9394", Offset="0x25C9394", VA="0x25C9394")]
		private static JsonStringer DoKeyValue<T>(JsonStringer json, string key, IDictionary<string, T> val)
		{
			return null;
		}

		[Address(RVA="0x155BDDC", Offset="0x155BDDC", VA="0x155BDDC")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IDictionary val)
		{
			return null;
		}

		[Address(RVA="0x155AEA0", Offset="0x155AEA0", VA="0x155AEA0")]
		public static JsonStringer KeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x155C444", Offset="0x155C444", VA="0x155C444")]
		public static JsonStringer OptionalKeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x155AE10", Offset="0x155AE10", VA="0x155AE10")]
		public static string ToJson(object val)
		{
			return null;
		}

		[Address(RVA="0x155AE90", Offset="0x155AE90", VA="0x155AE90")]
		public static JsonStringer Value(JsonStringer json, object val)
		{
			return null;
		}
	}
}