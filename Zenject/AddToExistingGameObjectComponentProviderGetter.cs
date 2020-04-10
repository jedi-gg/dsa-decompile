using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class AddToExistingGameObjectComponentProviderGetter : AddToGameObjectComponentProviderBase
	{
		[FieldOffset(Offset="0x30")]
		private readonly Func<InjectContext, GameObject> _gameObjectGetter;

		protected override bool ShouldToggleActive
		{
			[Address(RVA="0x15AA9B0", Offset="0x15AA9B0", VA="0x15AA9B0", Slot="6")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x15AA978", Offset="0x15AA978", VA="0x15AA978")]
		public AddToExistingGameObjectComponentProviderGetter(Func<InjectContext, GameObject> gameObjectGetter, DiContainer container, Type componentType, object concreteIdentifier, List<TypeValuePair> extraArguments)
		{
		}

		[Address(RVA="0x15AA9B8", Offset="0x15AA9B8", VA="0x15AA9B8", Slot="7")]
		protected override GameObject GetGameObject(InjectContext context)
		{
			return null;
		}
	}
}