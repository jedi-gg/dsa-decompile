using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MonoInstaller<TDerived, TParam1, TParam2, TParam3, TParam4, TParam5> : MonoInstallerBase
	where TDerived : MonoInstaller<TParam1, TParam2, TParam3, TParam4, TParam5, TDerived>
	{
		[Address(RVA="0x2359DCC", Offset="0x2359DCC", VA="0x2359DCC")]
		public MonoInstaller()
		{
		}

		[Address(RVA="0x2359B80", Offset="0x2359B80", VA="0x2359B80")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4, TParam5 p5)
		{
			return null;
		}

		[Address(RVA="0x2359C88", Offset="0x2359C88", VA="0x2359C88")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4, TParam5 p5)
		{
			return null;
		}
	}
}