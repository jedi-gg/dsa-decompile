using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MonoInstaller<TDerived> : MonoInstaller
	where TDerived : MonoInstaller<TDerived>
	{
		[Address(RVA="0x2359264", Offset="0x2359264", VA="0x2359264")]
		public MonoInstaller()
		{
		}

		[Address(RVA="0x2358F30", Offset="0x2358F30", VA="0x2358F30")]
		public static TDerived InstallFromResource(DiContainer container)
		{
			return null;
		}

		[Address(RVA="0x2358FF8", Offset="0x2358FF8", VA="0x2358FF8")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container)
		{
			return null;
		}

		[Address(RVA="0x23590C4", Offset="0x23590C4", VA="0x23590C4")]
		public static TDerived InstallFromResource(DiContainer container, object[] extraArgs)
		{
			return null;
		}

		[Address(RVA="0x235919C", Offset="0x235919C", VA="0x235919C")]
		public static TDerived InstallFromResource(string resourcePath, DiContainer container, object[] extraArgs)
		{
			return null;
		}
	}
}