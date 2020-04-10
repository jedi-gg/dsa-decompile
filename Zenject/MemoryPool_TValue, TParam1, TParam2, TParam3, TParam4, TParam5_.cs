using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPool<TValue, TParam1, TParam2, TParam3, TParam4, TParam5> : MemoryPoolBase<TValue>, IMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>, IMemoryPool
	{
		[Address(RVA="0x2355270", Offset="0x2355270", VA="0x2355270")]
		public MemoryPool()
		{
		}

		[Address(RVA="0x235526C", Offset="0x235526C", VA="0x235526C", Slot="15")]
		protected virtual void Reinitialize(TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4, TParam5 p5, TValue item)
		{
		}

		[Address(RVA="0x23551C0", Offset="0x23551C0", VA="0x23551C0", Slot="13")]
		public TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
		{
			return null;
		}
	}
}