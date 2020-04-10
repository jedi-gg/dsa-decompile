using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoMemoryPool<TParam1, TParam2, TParam3, TParam4, TValue> : MemoryPool<TParam1, TParam2, TParam3, TParam4, TValue>
	where TValue : Component
	{
		[Address(RVA="0x235A35C", Offset="0x235A35C", VA="0x235A35C")]
		protected MonoMemoryPool()
		{
		}

		[Address(RVA="0x235A278", Offset="0x235A278", VA="0x235A278", Slot="12")]
		protected override void OnCreated(TValue item)
		{
		}

		[Address(RVA="0x235A310", Offset="0x235A310", VA="0x235A310", Slot="10")]
		protected override void OnDespawned(TValue item)
		{
		}

		[Address(RVA="0x235A2C4", Offset="0x235A2C4", VA="0x235A2C4", Slot="11")]
		protected override void OnSpawned(TValue item)
		{
		}
	}
}