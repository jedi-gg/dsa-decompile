using Il2CppDummyDll;
using System;
using System.IO;

namespace Csdk.GluIAP.Implementation.Json
{
	public static class AJson
	{
		[Address(RVA="0x21E38CC", Offset="0x21E38CC", VA="0x21E38CC")]
		public static JsonResult ParseBuffer(byte[] bytes)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21E386C", Offset="0x21E386C", VA="0x21E386C")]
		public static JsonResult ParseBuffer(byte[] bytes, int index, int count)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21E3598", Offset="0x21E3598", VA="0x21E3598")]
		public static JsonResult ParseFile(string fileName)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21E36C8", Offset="0x21E36C8", VA="0x21E36C8")]
		public static JsonResult ParseStream(Stream stream)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21E31B8", Offset="0x21E31B8", VA="0x21E31B8")]
		public static JsonResult ParseString(string str)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21E3CCC", Offset="0x21E3CCC", VA="0x21E3CCC")]
		public static object ToObject(JsonResult json)
		{
			return null;
		}

		[Address(RVA="0x21E3960", Offset="0x21E3960", VA="0x21E3960")]
		public static string Type(JsonResult json)
		{
			return null;
		}
	}
}