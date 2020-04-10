using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPool<TValue, TParam1, TParam2, TParam3, TParam4> : MemoryPoolBase<TValue>, IMemoryPool<TParam1, TParam2, TParam3, TParam4, TValue>, IMemoryPool
	{
		[Address(RVA="0x2355184", Offset="0x2355184", VA="0x2355184")]
		public MemoryPool()
		{
		}

		[Address(RVA="0x2355180", Offset="0x2355180", VA="0x2355180", Slot="15")]
		protected virtual void Reinitialize(TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4, TValue item)
		{
		}

		[Address(RVA="0x23550E4", Offset="0x23550E4", VA="0x23550E4", Slot="13")]
		public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
		{
			return null;
		}
	}
}