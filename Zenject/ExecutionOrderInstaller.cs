using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class ExecutionOrderInstaller : Installer<List<Type>, ExecutionOrderInstaller>
	{
		[FieldOffset(Offset="0x18")]
		private List<Type> _typeOrder;

		[Address(RVA="0x1833D6C", Offset="0x1833D6C", VA="0x1833D6C")]
		public ExecutionOrderInstaller(List<Type> typeOrder)
		{
		}

		[Address(RVA="0x1833DD0", Offset="0x1833DD0", VA="0x1833DD0", Slot="7")]
		public override void InstallBindings()
		{
		}
	}
}