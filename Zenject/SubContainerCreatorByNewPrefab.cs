using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefab : ISubContainerCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[FieldOffset(Offset="0x18")]
		private readonly IPrefabProvider _prefabProvider;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[Address(RVA="0x23356CC", Offset="0x23356CC", VA="0x23356CC")]
		public SubContainerCreatorByNewPrefab(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo)
		{
		}

		[Address(RVA="0x233570C", Offset="0x233570C", VA="0x233570C", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext parentContext)
		{
			return null;
		}
	}
}