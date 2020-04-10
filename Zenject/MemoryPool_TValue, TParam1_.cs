using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPool<TValue, TParam1> : MemoryPoolBase<TValue>, IMemoryPool<TParam1, TValue>, IMemoryPool
	{
		[Address(RVA="0x2354D48", Offset="0x2354D48", VA="0x2354D48")]
		public MemoryPool()
		{
		}

		[Address(RVA="0x2354D44", Offset="0x2354D44", VA="0x2354D44", Slot="15")]
		protected virtual void Reinitialize(TParam1 p1, TValue item)
		{
		}

		[Address(RVA="0x2354CA8", Offset="0x2354CA8", VA="0x2354CA8", Slot="13")]
		public TValue Spawn(TParam1 param)
		{
			return null;
		}
	}
}