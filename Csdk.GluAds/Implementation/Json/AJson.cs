using Il2CppDummyDll;
using System;
using System.IO;

namespace Csdk.GluAds.Implementation.Json
{
	public static class AJson
	{
		[Address(RVA="0x1551CC8", Offset="0x1551CC8", VA="0x1551CC8")]
		public static JsonResult ParseBuffer(byte[] bytes)
		{
			return new JsonResult();
		}

		[Address(RVA="0x1551C68", Offset="0x1551C68", VA="0x1551C68")]
		public static JsonResult ParseBuffer(byte[] bytes, int index, int count)
		{
			return new JsonResult();
		}

		[Address(RVA="0x1551994", Offset="0x1551994", VA="0x1551994")]
		public static JsonResult ParseFile(string fileName)
		{
			return new JsonResult();
		}

		[Address(RVA="0x1551AC4", Offset="0x1551AC4", VA="0x1551AC4")]
		public static JsonResult ParseStream(Stream stream)
		{
			return new JsonResult();
		}

		[Address(RVA="0x15515B4", Offset="0x15515B4", VA="0x15515B4")]
		public static JsonResult ParseString(string str)
		{
			return new JsonResult();
		}

		[Address(RVA="0x15520C8", Offset="0x15520C8", VA="0x15520C8")]
		public static object ToObject(JsonResult json)
		{
			return null;
		}

		[Address(RVA="0x1551D5C", Offset="0x1551D5C", VA="0x1551D5C")]
		public static string Type(JsonResult json)
		{
			return null;
		}
	}
}