using Il2CppDummyDll;
using System;

namespace ModestTree
{
	public static class Log
	{
		[Address(RVA="0x12F6130", Offset="0x12F6130", VA="0x12F6130")]
		[Attribute(Name="ConditionalAttribute", RVA="0x107187C", Offset="0x107187C")]
		public static void Debug(string message, params object[] args)
		{
		}

		[Address(RVA="0x12F6334", Offset="0x12F6334", VA="0x12F6334")]
		public static void Error(string message, params object[] args)
		{
		}

		[Address(RVA="0x12F624C", Offset="0x12F624C", VA="0x12F624C")]
		public static void ErrorException(Exception e)
		{
		}

		[Address(RVA="0x12F62B4", Offset="0x12F62B4", VA="0x12F62B4")]
		public static void ErrorException(string message, Exception e)
		{
		}

		[Address(RVA="0x12F6134", Offset="0x12F6134", VA="0x12F6134")]
		public static void Info(string message, params object[] args)
		{
		}

		[Address(RVA="0x12F61C0", Offset="0x12F61C0", VA="0x12F61C0")]
		public static void Trace(string message, params object[] args)
		{
		}

		[Address(RVA="0x12F5A74", Offset="0x12F5A74", VA="0x12F5A74")]
		public static void Warn(string message, params object[] args)
		{
		}
	}
}