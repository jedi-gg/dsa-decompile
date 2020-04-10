using Il2CppDummyDll;
using System;

namespace Zenject
{
	public static class MonoInstallerUtil
	{
		[Address(RVA="0x1575A58", Offset="0x1575A58", VA="0x1575A58")]
		public static TInstaller CreateInstaller<TInstaller>(string resourcePath, DiContainer container)
		where TInstaller : MonoInstallerBase
		{
			return null;
		}

		[Address(RVA="0x199CE14", Offset="0x199CE14", VA="0x199CE14")]
		public static string GetDefaultResourcePath<TInstaller>()
		where TInstaller : MonoInstallerBase
		{
			return null;
		}
	}
}