using Il2CppDummyDll;
using System;
using System.IO;

namespace Csdk.GluMarketing.Implementation.Json
{
	public static class AJson
	{
		[Address(RVA="0x21EDDF0", Offset="0x21EDDF0", VA="0x21EDDF0")]
		public static JsonResult ParseBuffer(byte[] bytes)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21EDD90", Offset="0x21EDD90", VA="0x21EDD90")]
		public static JsonResult ParseBuffer(byte[] bytes, int index, int count)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21EDABC", Offset="0x21EDABC", VA="0x21EDABC")]
		public static JsonResult ParseFile(string fileName)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21EDBEC", Offset="0x21EDBEC", VA="0x21EDBEC")]
		public static JsonResult ParseStream(Stream stream)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21ED6DC", Offset="0x21ED6DC", VA="0x21ED6DC")]
		public static JsonResult ParseString(string str)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21EE1F0", Offset="0x21EE1F0", VA="0x21EE1F0")]
		public static object ToObject(JsonResult json)
		{
			return null;
		}

		[Address(RVA="0x21EDE84", Offset="0x21EDE84", VA="0x21EDE84")]
		public static string Type(JsonResult json)
		{
			return null;
		}
	}
}