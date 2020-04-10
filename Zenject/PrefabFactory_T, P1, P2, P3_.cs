using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabFactory<T, P1, P2, P3>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060168", Offset="0x1060168")]
		[FieldOffset(Offset="0x0")]
		protected readonly DiContainer _container;

		[Address(RVA="0x2BA3698", Offset="0x2BA3698", VA="0x2BA3698")]
		public PrefabFactory()
		{
		}

		[Address(RVA="0x2BA3324", Offset="0x2BA3324", VA="0x2BA3324", Slot="4")]
		public virtual T Create(UnityEngine.Object prefab, P1 param, P2 param2, P3 param3)
		{
			return null;
		}

		[Address(RVA="0x2BA350C", Offset="0x2BA350C", VA="0x2BA350C", Slot="5")]
		public virtual T Create(string prefabResourceName, P1 param, P2 param2, P3 param3)
		{
			return null;
		}
	}
}