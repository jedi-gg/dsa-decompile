using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MonoInstaller<TDerived, TParam1, TParam2> : MonoInstallerBase
	where TDerived : MonoInstaller<TParam1, TParam2, TDerived>
	{
		[Address(RVA="0x23596AC", Offset="0x23596AC", VA="0x23596AC")]
		public MonoInstaller()
		{
		}

		[Address(RVA="0x23594A8", Offset="0x23594A8", VA="0x23594A8")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2)
		{
			return null;
		}

		[Address(RVA="0x2359588", Offset="0x2359588", VA="0x2359588")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2)
		{
			return null;
		}
	}
}