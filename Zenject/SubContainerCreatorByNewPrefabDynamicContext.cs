using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class SubContainerCreatorByNewPrefabDynamicContext : ISubContainerCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[FieldOffset(Offset="0x18")]
		private readonly IPrefabProvider _prefabProvider;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[Address(RVA="0x23358C4", Offset="0x23358C4", VA="0x23358C4")]
		public SubContainerCreatorByNewPrefabDynamicContext(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo)
		{
		}

		protected abstract void AddInstallers(List<TypeValuePair> args, GameObjectContext context);

		[Address(RVA="0x2335904", Offset="0x2335904", VA="0x2335904", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext parentContext)
		{
			return null;
		}
	}
}