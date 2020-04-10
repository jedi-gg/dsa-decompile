using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScriptableObjectInstaller<TDerived, TParam1, TParam2, TParam3> : ScriptableObjectInstallerBase
	where TDerived : ScriptableObjectInstaller<TParam1, TParam2, TParam3, TDerived>
	{
		[Address(RVA="0x2BA4294", Offset="0x2BA4294", VA="0x2BA4294")]
		public ScriptableObjectInstaller()
		{
		}

		[Address(RVA="0x2BA4078", Offset="0x2BA4078", VA="0x2BA4078")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3)
		{
			return null;
		}

		[Address(RVA="0x2BA4168", Offset="0x2BA4168", VA="0x2BA4168")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2, TParam3 p3)
		{
			return null;
		}
	}
}