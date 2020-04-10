using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class Installer<TParam1, TParam2, TParam3, TDerived> : InstallerBase
	where TDerived : Installer<TParam1, TParam2, TParam3, TDerived>
	{
		[Address(RVA="0x23505B8", Offset="0x23505B8", VA="0x23505B8")]
		protected Installer()
		{
		}

		[Address(RVA="0x23504B0", Offset="0x23504B0", VA="0x23504B0")]
		public static void Install(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3)
		{
		}
	}
}