using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MonoArchetypePool<TArchetype>
where TArchetype : MonoBehaviour, IMonoArchetypePooledItem
{
	[FieldOffset(Offset="0x0")]
	private MonoArchetypePool<TArchetype>.Pool _pool;

	[FieldOffset(Offset="0x0")]
	private List<TArchetype> _activePoolItems;

	public IReadOnlyList<TArchetype> ActiveItems
	{
		[Address(RVA="0x1D9B4FC", Offset="0x1D9B4FC", VA="0x1D9B4FC")]
		get
		{
			return null;
		}
	}

	public int NumActive
	{
		[Address(RVA="0x1D9B4DC", Offset="0x1D9B4DC", VA="0x1D9B4DC")]
		get
		{
			return new int();
		}
	}

	public int NumInactive
	{
		[Address(RVA="0x1D9B49C", Offset="0x1D9B49C", VA="0x1D9B49C")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x1D9B504", Offset="0x1D9B504", VA="0x1D9B504")]
	public MonoArchetypePool(DiContainer container, TArchetype archetype, int initialSize = 10, PoolExpandMethods expandMethod = 0)
	{
	}

	[Address(RVA="0x1D9BB74", Offset="0x1D9BB74", VA="0x1D9BB74")]
	public void Despawn(TArchetype instance)
	{
	}

	[Address(RVA="0x1D9BCA0", Offset="0x1D9BCA0", VA="0x1D9BCA0")]
	public void DespawnAllActiveItems()
	{
	}

	[Address(RVA="0x1D9BBF4", Offset="0x1D9BBF4", VA="0x1D9BBF4")]
	public void DespawnAtIndex(int i)
	{
	}

	[Address(RVA="0x1D9B730", Offset="0x1D9B730", VA="0x1D9B730")]
	public void Destroy()
	{
	}

	[Address(RVA="0x1D9BD3C", Offset="0x1D9BD3C", VA="0x1D9BD3C")]
	public TArchetype GetActiveItem(int index)
	{
		return null;
	}

	[Address(RVA="0x1D9BAF0", Offset="0x1D9BAF0", VA="0x1D9BAF0")]
	public TArchetype Spawn()
	{
		return null;
	}

	private class Factory : IFactory<TArchetype>, IFactory
	{
		[FieldOffset(Offset="0x0")]
		private DiContainer _diContainer;

		[FieldOffset(Offset="0x0")]
		private TArchetype _archetype;

		[Address(RVA="0x1D9B18C", Offset="0x1D9B18C", VA="0x1D9B18C")]
		public Factory(DiContainer container, TArchetype archetype)
		{
		}

		[Address(RVA="0x1D9B1D0", Offset="0x1D9B1D0", VA="0x1D9B1D0", Slot="4")]
		public TArchetype Create()
		{
			return null;
		}
	}

	private class Pool : MonoMemoryPool<TArchetype>
	{
		[Address(RVA="0x1D9B460", Offset="0x1D9B460", VA="0x1D9B460")]
		public Pool()
		{
		}

		[Address(RVA="0x1D9B3AC", Offset="0x1D9B3AC", VA="0x1D9B3AC", Slot="15")]
		protected override void Reinitialize(TArchetype item)
		{
		}
	}
}