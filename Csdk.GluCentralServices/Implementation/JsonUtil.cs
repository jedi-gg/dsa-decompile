using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csdk.GluCentralServices.Implementation
{
	public static class JsonUtil
	{
		[Address(RVA="0x21DAAF0", Offset="0x21DAAF0", VA="0x21DAAF0")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, Exception e)
		{
			return null;
		}

		[Address(RVA="0x21DAC48", Offset="0x21DAC48", VA="0x21DAC48")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IList val)
		{
			return null;
		}

		[Address(RVA="0x25CA0C0", Offset="0x25CA0C0", VA="0x25CA0C0")]
		private static JsonStringer DoKeyValue<T>(JsonStringer json, string key, IDictionary<string, T> val)
		{
			return null;
		}

		[Address(RVA="0x21DAF14", Offset="0x21DAF14", VA="0x21DAF14")]
		private static JsonStringer DoKeyValue(JsonStringer json, string key, IDictionary val)
		{
			return null;
		}

		[Address(RVA="0x21D9FD8", Offset="0x21D9FD8", VA="0x21D9FD8")]
		public static JsonStringer KeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x21DB57C", Offset="0x21DB57C", VA="0x21DB57C")]
		public static JsonStringer OptionalKeyValue(JsonStringer json, string key, object val)
		{
			return null;
		}

		[Address(RVA="0x21D9F48", Offset="0x21D9F48", VA="0x21D9F48")]
		public static string ToJson(object val)
		{
			return null;
		}

		[Address(RVA="0x21D9FC8", Offset="0x21D9FC8", VA="0x21D9FC8")]
		public static JsonStringer Value(JsonStringer json, object val)
		{
			return null;
		}
	}
}