using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScriptableObjectInstaller<TDerived, TParam1> : ScriptableObjectInstallerBase
	where TDerived : ScriptableObjectInstaller<TParam1, TDerived>
	{
		[Address(RVA="0x2BA3E1C", Offset="0x2BA3E1C", VA="0x2BA3E1C")]
		public ScriptableObjectInstaller()
		{
		}

		[Address(RVA="0x2BA3C30", Offset="0x2BA3C30", VA="0x2BA3C30")]
		public static TDerived InstallFromResource(DiContainer container, TParam1 p1)
		{
			return null;
		}

		[Address(RVA="0x2BA3D08", Offset="0x2BA3D08", VA="0x2BA3D08")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, TParam1 p1)
		{
			return null;
		}
	}
}