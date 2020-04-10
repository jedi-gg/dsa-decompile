using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoMemoryPool<TValue> : MemoryPool<TValue>
	where TValue : Component
	{
		[Address(RVA="0x2359EDC", Offset="0x2359EDC", VA="0x2359EDC")]
		protected MonoMemoryPool()
		{
		}

		[Address(RVA="0x2359DF8", Offset="0x2359DF8", VA="0x2359DF8", Slot="12")]
		protected override void OnCreated(TValue item)
		{
		}

		[Address(RVA="0x2359E90", Offset="0x2359E90", VA="0x2359E90", Slot="10")]
		protected override void OnDespawned(TValue item)
		{
		}

		[Address(RVA="0x2359E44", Offset="0x2359E44", VA="0x2359E44", Slot="11")]
		protected override void OnSpawned(TValue item)
		{
		}
	}
}