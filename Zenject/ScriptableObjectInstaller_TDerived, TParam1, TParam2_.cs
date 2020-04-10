using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScriptableObjectInstaller<TDerived, TParam1, TParam2> : ScriptableObjectInstallerBase
	where TDerived : ScriptableObjectInstaller<TParam1, TParam2, TDerived>
	{
		[Address(RVA="0x2BA404C", Offset="0x2BA404C", VA="0x2BA404C")]
		public ScriptableObjectInstaller()
		{
		}

		[Address(RVA="0x2BA3E48", Offset="0x2BA3E48", VA="0x2BA3E48")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1, TParam2 p2)
		{
			return null;
		}

		[Address(RVA="0x2BA3F28", Offset="0x2BA3F28", VA="0x2BA3F28")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1, TParam2 p2)
		{
			return null;
		}
	}
}