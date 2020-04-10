using Il2CppDummyDll;
using System;
using System.IO;

namespace Csdk.GluCentralServices.Implementation.Json
{
	public static class AJson
	{
		[Address(RVA="0x155D300", Offset="0x155D300", VA="0x155D300")]
		public static JsonResult ParseBuffer(byte[] bytes)
		{
			return new JsonResult();
		}

		[Address(RVA="0x155D2A0", Offset="0x155D2A0", VA="0x155D2A0")]
		public static JsonResult ParseBuffer(byte[] bytes, int index, int count)
		{
			return new JsonResult();
		}

		[Address(RVA="0x155CFCC", Offset="0x155CFCC", VA="0x155CFCC")]
		public static JsonResult ParseFile(string fileName)
		{
			return new JsonResult();
		}

		[Address(RVA="0x155D0FC", Offset="0x155D0FC", VA="0x155D0FC")]
		public static JsonResult ParseStream(Stream stream)
		{
			return new JsonResult();
		}

		[Address(RVA="0x155CEBC", Offset="0x155CEBC", VA="0x155CEBC")]
		public static JsonResult ParseString(string str)
		{
			return new JsonResult();
		}

		[Address(RVA="0x155D4F0", Offset="0x155D4F0", VA="0x155D4F0")]
		public static object ToObject(JsonResult json)
		{
			return null;
		}

		[Address(RVA="0x155D394", Offset="0x155D394", VA="0x155D394")]
		public static string Type(JsonResult json)
		{
			return null;
		}
	}
}