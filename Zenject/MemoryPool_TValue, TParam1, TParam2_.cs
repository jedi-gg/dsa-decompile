using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPool<TValue, TParam1, TParam2> : MemoryPoolBase<TValue>, IMemoryPool<TParam1, TParam2, TValue>, IMemoryPool
	{
		[Address(RVA="0x2354F10", Offset="0x2354F10", VA="0x2354F10")]
		public MemoryPool()
		{
		}

		[Address(RVA="0x2354F0C", Offset="0x2354F0C", VA="0x2354F0C", Slot="15")]
		protected virtual void Reinitialize(TParam1 p1, TParam2 p2, TValue item)
		{
		}

		[Address(RVA="0x2354E40", Offset="0x2354E40", VA="0x2354E40", Slot="13")]
		public TValue Spawn(TParam1 param1, TParam2 param2)
		{
			return null;
		}
	}
}