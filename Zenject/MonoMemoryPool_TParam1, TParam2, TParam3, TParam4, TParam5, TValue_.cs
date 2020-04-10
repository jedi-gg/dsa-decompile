using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoMemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TValue> : MemoryPool<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
	where TValue : Component
	{
		[Address(RVA="0x235A47C", Offset="0x235A47C", VA="0x235A47C")]
		protected MonoMemoryPool()
		{
		}

		[Address(RVA="0x235A398", Offset="0x235A398", VA="0x235A398", Slot="12")]
		protected override void OnCreated(TValue item)
		{
		}

		[Address(RVA="0x235A430", Offset="0x235A430", VA="0x235A430", Slot="10")]
		protected override void OnDespawned(TValue item)
		{
		}

		[Address(RVA="0x235A3E4", Offset="0x235A3E4", VA="0x235A3E4", Slot="11")]
		protected override void OnSpawned(TValue item)
		{
		}
	}
}