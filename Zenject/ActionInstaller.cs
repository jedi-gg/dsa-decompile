using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ActionInstaller : Installer<ActionInstaller>
	{
		[FieldOffset(Offset="0x18")]
		private readonly Action<DiContainer> _installMethod;

		[Address(RVA="0x15A9090", Offset="0x15A9090", VA="0x15A9090")]
		public ActionInstaller(Action<DiContainer> installMethod)
		{
		}

		[Address(RVA="0x15A90F4", Offset="0x15A90F4", VA="0x15A90F4", Slot="7")]
		public override void InstallBindings()
		{
		}
	}
}