using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabFactory<T>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060138", Offset="0x1060138")]
		[FieldOffset(Offset="0x0")]
		protected readonly DiContainer _container;

		[Address(RVA="0x2BA2C00", Offset="0x2BA2C00", VA="0x2BA2C00")]
		public PrefabFactory()
		{
		}

		[Address(RVA="0x2BA297C", Offset="0x2BA297C", VA="0x2BA297C")]
		public T Create(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x2BA2A88", Offset="0x2BA2A88", VA="0x2BA2A88", Slot="4")]
		public virtual T Create(string prefabResourceName)
		{
			return null;
		}
	}
}