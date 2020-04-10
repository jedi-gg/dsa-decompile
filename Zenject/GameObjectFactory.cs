using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class GameObjectFactory : IFactory<GameObject>, IFactory
	{
		[FieldOffset(Offset="0x10")]
		private DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private UnityEngine.Object _prefab;

		[Address(RVA="0x1837C78", Offset="0x1837C78", VA="0x1837C78")]
		public GameObjectFactory()
		{
		}

		[Address(RVA="0x1837C3C", Offset="0x1837C3C", VA="0x1837C3C")]
		[Attribute(Name="InjectAttribute", RVA="0x10728CC", Offset="0x10728CC")]
		public void Construct(UnityEngine.Object prefab, DiContainer container)
		{
		}

		[Address(RVA="0x1837C44", Offset="0x1837C44", VA="0x1837C44", Slot="4")]
		public GameObject Create()
		{
			return null;
		}
	}
}