using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class MemoryPoolBase<TContract> : IValidatable, IMemoryPool
	{
		[FieldOffset(Offset="0x0")]
		private Stack<TContract> _inactiveItems;

		[FieldOffset(Offset="0x0")]
		private IFactory<TContract> _factory;

		[FieldOffset(Offset="0x0")]
		private MemoryPoolSettings _settings;

		[FieldOffset(Offset="0x0")]
		private int _activeCount;

		public IEnumerable<TContract> InactiveItems
		{
			[Address(RVA="0x2353AEC", Offset="0x2353AEC", VA="0x2353AEC")]
			get
			{
				return null;
			}
		}

		public Type ItemType
		{
			[Address(RVA="0x2353BB0", Offset="0x2353BB0", VA="0x2353BB0", Slot="8")]
			get
			{
				return null;
			}
		}

		public int NumActive
		{
			[Address(RVA="0x2353BA8", Offset="0x2353BA8", VA="0x2353BA8", Slot="6")]
			get
			{
				return new int();
			}
		}

		public int NumInactive
		{
			[Address(RVA="0x2353B68", Offset="0x2353B68", VA="0x2353B68", Slot="7")]
			get
			{
				return new int();
			}
		}

		public int NumTotal
		{
			[Address(RVA="0x2353AF4", Offset="0x2353AF4", VA="0x2353AF4", Slot="5")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x235458C", Offset="0x235458C", VA="0x235458C")]
		protected MemoryPoolBase()
		{
		}

		[Address(RVA="0x2353D18", Offset="0x2353D18", VA="0x2353D18")]
		private TContract AllocNew()
		{
			return null;
		}

		[Address(RVA="0x23539D8", Offset="0x23539D8", VA="0x23539D8")]
		[Attribute(Name="InjectAttribute", RVA="0x10728FC", Offset="0x10728FC")]
		private void Construct(IFactory<TContract> factory, DiContainer container, MemoryPoolSettings settings)
		{
		}

		[Address(RVA="0x2353C24", Offset="0x2353C24", VA="0x2353C24", Slot="9")]
		public void Despawn(TContract item)
		{
		}

		[Address(RVA="0x23542E4", Offset="0x23542E4", VA="0x23542E4")]
		private void ExpandPool()
		{
		}

		[Address(RVA="0x2354200", Offset="0x2354200", VA="0x2354200")]
		protected TContract GetInternal()
		{
			return null;
		}

		[Address(RVA="0x2354588", Offset="0x2354588", VA="0x2354588", Slot="12")]
		protected virtual void OnCreated(TContract item)
		{
		}

		[Address(RVA="0x2354580", Offset="0x2354580", VA="0x2354580", Slot="10")]
		protected virtual void OnDespawned(TContract item)
		{
		}

		[Address(RVA="0x2354584", Offset="0x2354584", VA="0x2354584", Slot="11")]
		protected virtual void OnSpawned(TContract item)
		{
		}

		[Address(RVA="0x2354000", Offset="0x2354000", VA="0x2354000", Slot="4")]
		private void Zenject.IValidatable.Validate()
		{
		}
	}
}