using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalSettings
	{
		[FieldOffset(Offset="0x10")]
		public bool RequiresHandler;

		[Address(RVA="0x2331FF0", Offset="0x2331FF0", VA="0x2331FF0")]
		public SignalSettings()
		{
		}
	}
}