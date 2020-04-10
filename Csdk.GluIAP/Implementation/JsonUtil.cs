using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csdk.GluIAP.Implementation
{
	public static class JsonUtil
	{
		[Address(RVA="0x21E9DD4", Offset="0x21E9DD4", VA="0x21E9DD4")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, Exception e)
		{
			return null;
		}

		[Address(RVA="0x21E9F2C", Offset="0x21E9F2C", VA="0x21E9F2C")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IList val)
		{
			return null;
		}

		[Address(RVA="0x25CADEC", Offset="0x25CADEC", VA="0x25CADEC")]
		private static JsonStringer DoKeyValue<T>(JsonStringer json, string key, IDictionary<string, T> val)
		{
			return null;
		}

		[Address(RVA="0x21EA1F8", Offset="0x21EA1F8", VA="0x21EA1F8")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IDictionary val)
		{
			return null;
		}

		[Address(RVA="0x21E92BC", Offset="0x21E92BC", VA="0x21E92BC")]
		public static JsonStringer KeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x21EA860", Offset="0x21EA860", VA="0x21EA860")]
		public static JsonStringer OptionalKeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x21E922C", Offset="0x21E922C", VA="0x21E922C")]
		public static string ToJson(object val)
		{
			return null;
		}

		[Address(RVA="0x21E92AC", Offset="0x21E92AC", VA="0x21E92AC")]
		public static JsonStringer Value(JsonStringer json, object val)
		{
			return null;
		}
	}
}