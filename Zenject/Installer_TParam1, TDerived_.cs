using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class Installer<TParam1, TDerived> : InstallerBase
	where TDerived : Installer<TParam1, TDerived>
	{
		[Address(RVA="0x2350360", Offset="0x2350360", VA="0x2350360")]
		protected Installer()
		{
		}

		[Address(RVA="0x2350270", Offset="0x2350270", VA="0x2350270")]
		public static void Install(DiContainer container, TParam1 p1)
		{
		}
	}
}