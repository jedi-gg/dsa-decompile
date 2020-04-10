using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoMemoryPool<TParam1, TParam2, TParam3, TValue> : MemoryPool<TParam1, TParam2, TParam3, TValue>
	where TValue : Component
	{
		[Address(RVA="0x235A23C", Offset="0x235A23C", VA="0x235A23C")]
		protected MonoMemoryPool()
		{
		}

		[Address(RVA="0x235A158", Offset="0x235A158", VA="0x235A158", Slot="12")]
		protected override void OnCreated(TValue item)
		{
		}

		[Address(RVA="0x235A1F0", Offset="0x235A1F0", VA="0x235A1F0", Slot="10")]
		protected override void OnDespawned(TValue item)
		{
		}

		[Address(RVA="0x235A1A4", Offset="0x235A1A4", VA="0x235A1A4", Slot="11")]
		protected override void OnSpawned(TValue item)
		{
		}
	}
}