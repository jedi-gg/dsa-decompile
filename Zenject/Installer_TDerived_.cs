using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class Installer<TDerived> : InstallerBase
	where TDerived : Installer<TDerived>
	{
		[Address(RVA="0x2350244", Offset="0x2350244", VA="0x2350244")]
		protected Installer()
		{
		}

		[Address(RVA="0x23501B4", Offset="0x23501B4", VA="0x23501B4")]
		public static void Install(DiContainer container)
		{
		}
	}
}