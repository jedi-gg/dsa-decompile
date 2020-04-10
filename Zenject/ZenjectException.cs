using Il2CppDummyDll;
using System;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public class ZenjectException : Exception
	{
		[Address(RVA="0x233DF1C", Offset="0x233DF1C", VA="0x233DF1C")]
		public ZenjectException(string message)
		{
		}

		[Address(RVA="0x2340448", Offset="0x2340448", VA="0x2340448")]
		public ZenjectException(string message, Exception innerException)
		{
		}
	}
}