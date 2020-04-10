using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabMethod : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x28")]
		private readonly Action<DiContainer> _installerMethod;

		[Address(RVA="0x2335F04", Offset="0x2335F04", VA="0x2335F04")]
		public SubContainerCreatorByNewPrefabMethod(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, Action<DiContainer> installerMethod)
		{
		}

		[Address(RVA="0x2335F50", Offset="0x2335F50", VA="0x2335F50", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}
	}
}