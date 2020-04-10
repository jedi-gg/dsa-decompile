using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPool<TValue, TParam1, TParam2, TParam3> : MemoryPoolBase<TValue>, IMemoryPool<TParam1, TParam2, TParam3, TValue>, IMemoryPool
	{
		[Address(RVA="0x23550A8", Offset="0x23550A8", VA="0x23550A8")]
		public MemoryPool()
		{
		}

		[Address(RVA="0x23550A4", Offset="0x23550A4", VA="0x23550A4", Slot="15")]
		protected virtual void Reinitialize(TParam1 p1, TParam2 p2, TParam3 p3, TValue item)
		{
		}

		[Address(RVA="0x2355010", Offset="0x2355010", VA="0x2355010", Slot="13")]
		public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3)
		{
			return null;
		}
	}
}