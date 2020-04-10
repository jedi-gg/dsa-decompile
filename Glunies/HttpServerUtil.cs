using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public static class HttpServerUtil
	{
		[FieldOffset(Offset="0x0")]
		public readonly static string SERVER_EXE_PATH;

		[Address(RVA="0x1428A84", Offset="0x1428A84", VA="0x1428A84")]
		static HttpServerUtil()
		{
		}

		[Address(RVA="0x14284E0", Offset="0x14284E0", VA="0x14284E0")]
		public static List<HttpServerUtil.HostAddress> GetHostAddresses()
		{
			return null;
		}

		[Address(RVA="0x14289A8", Offset="0x14289A8", VA="0x14289A8")]
		public static int GetPort(HttpServerUtil.Server server)
		{
			return new int();
		}

		public class HostAddress
		{
			[FieldOffset(Offset="0x10")]
			public string Address;

			[FieldOffset(Offset="0x18")]
			public string Description;

			[Address(RVA="0x14289A0", Offset="0x14289A0", VA="0x14289A0")]
			public HostAddress()
			{
			}
		}

		public enum Server
		{
			[FieldOffset(Offset="0x0")]
			GameAssetServer,
			[FieldOffset(Offset="0x0")]
			InfernoAssetServer
		}
	}
}