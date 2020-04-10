using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabFactory<T, P1, P2>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060158", Offset="0x1060158")]
		[FieldOffset(Offset="0x0")]
		protected readonly DiContainer _container;

		[Address(RVA="0x2BA32F8", Offset="0x2BA32F8", VA="0x2BA32F8")]
		public PrefabFactory()
		{
		}

		[Address(RVA="0x2BA2F9C", Offset="0x2BA2F9C", VA="0x2BA2F9C", Slot="4")]
		public virtual T Create(UnityEngine.Object prefab, P1 param, P2 param2)
		{
			return null;
		}

		[Address(RVA="0x2BA3174", Offset="0x2BA3174", VA="0x2BA3174", Slot="5")]
		public virtual T Create(string prefabResourceName, P1 param, P2 param2)
		{
			return null;
		}
	}
}