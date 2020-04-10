using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoMemoryPool<TParam1, TValue> : MemoryPool<TParam1, TValue>
	where TValue : Component
	{
		[Address(RVA="0x2359FFC", Offset="0x2359FFC", VA="0x2359FFC")]
		protected MonoMemoryPool()
		{
		}

		[Address(RVA="0x2359F18", Offset="0x2359F18", VA="0x2359F18", Slot="12")]
		protected override void OnCreated(TValue item)
		{
		}

		[Address(RVA="0x2359FB0", Offset="0x2359FB0", VA="0x2359FB0", Slot="10")]
		protected override void OnDespawned(TValue item)
		{
		}

		[Address(RVA="0x2359F64", Offset="0x2359F64", VA="0x2359F64", Slot="11")]
		protected override void OnSpawned(TValue item)
		{
		}
	}
}