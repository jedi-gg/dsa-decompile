using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class PoolCleanupChecker : ILateDisposable
	{
		[FieldOffset(Offset="0x10")]
		private readonly List<IMemoryPool> _poolFactories;

		[Address(RVA="0x183DE38", Offset="0x183DE38", VA="0x183DE38")]
		public PoolCleanupChecker([Attribute(Name="InjectAttribute", RVA="0x1091500", Offset="0x1091500")] List<IMemoryPool> poolFactories)
		{
		}

		[Address(RVA="0x183DE64", Offset="0x183DE64", VA="0x183DE64", Slot="4")]
		public void LateDispose()
		{
		}
	}
}