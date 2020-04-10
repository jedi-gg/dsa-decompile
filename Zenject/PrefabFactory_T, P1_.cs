using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabFactory<T, P1>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060148", Offset="0x1060148")]
		[FieldOffset(Offset="0x0")]
		protected readonly DiContainer _container;

		[Address(RVA="0x2BA2F70", Offset="0x2BA2F70", VA="0x2BA2F70")]
		public PrefabFactory()
		{
		}

		[Address(RVA="0x2BA2C2C", Offset="0x2BA2C2C", VA="0x2BA2C2C", Slot="4")]
		public virtual T Create(UnityEngine.Object prefab, P1 param)
		{
			return null;
		}

		[Address(RVA="0x2BA2DFC", Offset="0x2BA2DFC", VA="0x2BA2DFC", Slot="5")]
		public virtual T Create(string prefabResourceName, P1 param)
		{
			return null;
		}
	}
}