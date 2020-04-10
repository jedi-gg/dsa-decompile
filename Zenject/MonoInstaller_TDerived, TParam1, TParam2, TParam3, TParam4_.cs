using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MonoInstaller<TDerived, TParam1, TParam2, TParam3, TParam4> : MonoInstallerBase
	where TDerived : MonoInstaller<TParam1, TParam2, TParam3, TParam4, TDerived>
	{
		[Address(RVA="0x2359B54", Offset="0x2359B54", VA="0x2359B54")]
		public MonoInstaller()
		{
		}

		[Address(RVA="0x2359920", Offset="0x2359920", VA="0x2359920")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
		{
			return null;
		}

		[Address(RVA="0x2359A18", Offset="0x2359A18", VA="0x2359A18")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
		{
			return null;
		}
	}
}