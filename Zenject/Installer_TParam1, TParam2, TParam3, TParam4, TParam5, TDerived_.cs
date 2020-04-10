using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class Installer<TParam1, TParam2, TParam3, TParam4, TParam5, TDerived> : InstallerBase
	where TDerived : Installer<TParam1, TParam2, TParam3, TParam4, TParam5, TDerived>
	{
		[Address(RVA="0x2350840", Offset="0x2350840", VA="0x2350840")]
		protected Installer()
		{
		}

		[Address(RVA="0x2350720", Offset="0x2350720", VA="0x2350720")]
		public static void Install(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4, TParam5 p5)
		{
		}
	}
}