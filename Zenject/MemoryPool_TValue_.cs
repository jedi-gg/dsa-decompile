using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPool<TValue> : MemoryPoolBase<TValue>, IMemoryPool<TValue>, IMemoryPool
	{
		[Address(RVA="0x2354C6C", Offset="0x2354C6C", VA="0x2354C6C")]
		public MemoryPool()
		{
		}

		[Address(RVA="0x2354C68", Offset="0x2354C68", VA="0x2354C68", Slot="15")]
		protected virtual void Reinitialize(TValue item)
		{
		}

		[Address(RVA="0x2354BFC", Offset="0x2354BFC", VA="0x2354BFC", Slot="13")]
		public TValue Spawn()
		{
			return null;
		}
	}
}