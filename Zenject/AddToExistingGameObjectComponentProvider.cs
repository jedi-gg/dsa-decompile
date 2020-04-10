using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class AddToExistingGameObjectComponentProvider : AddToGameObjectComponentProviderBase
	{
		[FieldOffset(Offset="0x30")]
		private readonly GameObject _gameObject;

		protected override bool ShouldToggleActive
		{
			[Address(RVA="0x15AA968", Offset="0x15AA968", VA="0x15AA968", Slot="6")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x15AA89C", Offset="0x15AA89C", VA="0x15AA89C")]
		public AddToExistingGameObjectComponentProvider(GameObject gameObject, DiContainer container, Type componentType, object concreteIdentifier, List<TypeValuePair> extraArguments)
		{
		}

		[Address(RVA="0x15AA970", Offset="0x15AA970", VA="0x15AA970", Slot="7")]
		protected override GameObject GetGameObject(InjectContext context)
		{
			return null;
		}
	}
}