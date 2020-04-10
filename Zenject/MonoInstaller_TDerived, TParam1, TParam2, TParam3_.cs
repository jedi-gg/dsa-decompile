using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MonoInstaller<TDerived, TParam1, TParam2, TParam3> : MonoInstallerBase
	where TDerived : MonoInstaller<TParam1, TParam2, TParam3, TDerived>
	{
		[Address(RVA="0x23598F4", Offset="0x23598F4", VA="0x23598F4")]
		public MonoInstaller()
		{
		}

		[Address(RVA="0x23596D8", Offset="0x23596D8", VA="0x23596D8")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3)
		{
			return null;
		}

		[Address(RVA="0x23597C8", Offset="0x23597C8", VA="0x23597C8")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3)
		{
			return null;
		}
	}
}