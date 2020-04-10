using Il2CppDummyDll;
using System;

namespace Zenject
{
	public static class ScriptableObjectInstallerUtil
	{
		[Address(RVA="0x1575BFC", Offset="0x1575BFC", VA="0x1575BFC")]
		public static TInstaller CreateInstaller<TInstaller>(string resourcePath, DiContainer container)
		where TInstaller : ScriptableObjectInstallerBase
		{
			return null;
		}

		[Address(RVA="0x199CEA8", Offset="0x199CEA8", VA="0x199CEA8")]
		public static string GetDefaultResourcePath<TInstaller>()
		where TInstaller : ScriptableObjectInstallerBase
		{
			return null;
		}
	}
}