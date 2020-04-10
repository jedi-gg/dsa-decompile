using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoMemoryPool<TParam1, TParam2, TValue> : MemoryPool<TParam1, TParam2, TValue>
	where TValue : Component
	{
		[Address(RVA="0x235A11C", Offset="0x235A11C", VA="0x235A11C")]
		protected MonoMemoryPool()
		{
		}

		[Address(RVA="0x235A038", Offset="0x235A038", VA="0x235A038", Slot="12")]
		protected override void OnCreated(TValue item)
		{
		}

		[Address(RVA="0x235A0D0", Offset="0x235A0D0", VA="0x235A0D0", Slot="10")]
		protected override void OnDespawned(TValue item)
		{
		}

		[Address(RVA="0x235A084", Offset="0x235A084", VA="0x235A084", Slot="11")]
		protected override void OnSpawned(TValue item)
		{
		}
	}
}