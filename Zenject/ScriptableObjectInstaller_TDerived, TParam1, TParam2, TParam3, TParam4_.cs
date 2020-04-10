using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScriptableObjectInstaller<TDerived, TParam1, TParam2, TParam3, TParam4> : ScriptableObjectInstallerBase
	where TDerived : ScriptableObjectInstaller<TParam1, TParam2, TParam3, TParam4, TDerived>
	{
		[Address(RVA="0x2BA44F4", Offset="0x2BA44F4", VA="0x2BA44F4")]
		public ScriptableObjectInstaller()
		{
		}

		[Address(RVA="0x2BA42C0", Offset="0x2BA42C0", VA="0x2BA42C0")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
		{
			return null;
		}

		[Address(RVA="0x2BA43B8", Offset="0x2BA43B8", VA="0x2BA43B8")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
		{
			return null;
		}
	}
}