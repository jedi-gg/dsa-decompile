using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Helpshift
{
	public class HelpshiftInternalLogger
	{
		[FieldOffset(Offset="0x0")]
		private static string TAG;

		[FieldOffset(Offset="0x8")]
		private static AndroidJavaClass hsInternalLogger;

		[Address(RVA="0x12E5358", Offset="0x12E5358", VA="0x12E5358")]
		static HelpshiftInternalLogger()
		{
		}

		[Address(RVA="0x12E5350", Offset="0x12E5350", VA="0x12E5350")]
		public HelpshiftInternalLogger()
		{
		}

		[Address(RVA="0x12E2CF0", Offset="0x12E2CF0", VA="0x12E2CF0")]
		public static void d(string message)
		{
		}

		[Address(RVA="0x12E4F48", Offset="0x12E4F48", VA="0x12E4F48")]
		public static void e(string message)
		{
		}

		[Address(RVA="0x12E51F8", Offset="0x12E51F8", VA="0x12E51F8")]
		public static void f(string message)
		{
		}

		[Address(RVA="0x12E50A0", Offset="0x12E50A0", VA="0x12E50A0")]
		public static void w(string message)
		{
		}
	}
}