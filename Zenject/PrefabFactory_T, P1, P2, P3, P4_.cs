using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabFactory<T, P1, P2, P3, P4>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060178", Offset="0x1060178")]
		[FieldOffset(Offset="0x0")]
		protected readonly DiContainer _container;

		[Address(RVA="0x2BA3A50", Offset="0x2BA3A50", VA="0x2BA3A50")]
		public PrefabFactory()
		{
		}

		[Address(RVA="0x2BA36C4", Offset="0x2BA36C4", VA="0x2BA36C4", Slot="4")]
		public virtual T Create(UnityEngine.Object prefab, P1 param, P2 param2, P3 param3, P4 param4)
		{
			return null;
		}

		[Address(RVA="0x2BA38B4", Offset="0x2BA38B4", VA="0x2BA38B4", Slot="5")]
		public virtual T Create(string prefabResourceName, P1 param, P2 param2, P3 param3, P4 param4)
		{
			return null;
		}
	}
}