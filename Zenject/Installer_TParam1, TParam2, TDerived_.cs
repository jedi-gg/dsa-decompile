using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class Installer<TParam1, TParam2, TDerived> : InstallerBase
	where TDerived : Installer<TParam1, TParam2, TDerived>
	{
		[Address(RVA="0x2350484", Offset="0x2350484", VA="0x2350484")]
		protected Installer()
		{
		}

		[Address(RVA="0x235038C", Offset="0x235038C", VA="0x235038C")]
		public static void Install(DiContainer container, TParam1 p1, TParam2 p2)
		{
		}
	}
}