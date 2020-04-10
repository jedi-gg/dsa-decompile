using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class AddToNewGameObjectComponentProvider : AddToGameObjectComponentProviderBase
	{
		[FieldOffset(Offset="0x30")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		protected override bool ShouldToggleActive
		{
			[Address(RVA="0x15AAFEC", Offset="0x15AAFEC", VA="0x15AAFEC", Slot="6")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x15AAFC4", Offset="0x15AAFC4", VA="0x15AAFC4")]
		public AddToNewGameObjectComponentProvider(DiContainer container, Type componentType, object concreteIdentifier, List<TypeValuePair> extraArguments, GameObjectCreationParameters gameObjectBindInfo)
		{
		}

		[Address(RVA="0x15AAFF4", Offset="0x15AAFF4", VA="0x15AAFF4", Slot="7")]
		protected override GameObject GetGameObject(InjectContext context)
		{
			return null;
		}
	}
}