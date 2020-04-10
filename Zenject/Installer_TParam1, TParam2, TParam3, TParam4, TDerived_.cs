using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class Installer<TParam1, TParam2, TParam3, TParam4, TDerived> : InstallerBase
	where TDerived : Installer<TParam1, TParam2, TParam3, TParam4, TDerived>
	{
		[Address(RVA="0x23506F4", Offset="0x23506F4", VA="0x23506F4")]
		protected Installer()
		{
		}

		[Address(RVA="0x23505E4", Offset="0x23505E4", VA="0x23505E4")]
		public static void Install(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
		{
		}
	}
}