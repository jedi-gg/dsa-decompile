using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScriptableObjectInstaller<TDerived> : ScriptableObjectInstaller
	where TDerived : ScriptableObjectInstaller<TDerived>
	{
		[Address(RVA="0x2BA3C04", Offset="0x2BA3C04", VA="0x2BA3C04")]
		public ScriptableObjectInstaller()
		{
		}

		[Address(RVA="0x2BA3A7C", Offset="0x2BA3A7C", VA="0x2BA3A7C")]
		public static TDerived InstallFromResource(DiContainer container)
		{
			return null;
		}

		[Address(RVA="0x2BA3B44", Offset="0x2BA3B44", VA="0x2BA3B44")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container)
		{
			return null;
		}
	}
}