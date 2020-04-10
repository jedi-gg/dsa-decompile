using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MonoInstaller<TDerived, TParam1> : MonoInstallerBase
	where TDerived : MonoInstaller<TParam1, TDerived>
	{
		[Address(RVA="0x235947C", Offset="0x235947C", VA="0x235947C")]
		public MonoInstaller()
		{
		}

		[Address(RVA="0x2359290", Offset="0x2359290", VA="0x2359290")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1)
		{
			return null;
		}

		[Address(RVA="0x2359368", Offset="0x2359368", VA="0x2359368")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1)
		{
			return null;
		}
	}
}