using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class PrefabSingletonProviderCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Dictionary<PrefabSingletonProviderCreator.PrefabId, IPrefabInstantiator> _prefabCreators;

		[Address(RVA="0x18420CC", Offset="0x18420CC", VA="0x18420CC")]
		public PrefabSingletonProviderCreator(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x1842154", Offset="0x1842154", VA="0x1842154")]
		public IProvider CreateProvider(UnityEngine.Object prefab, Type resultType, GameObjectCreationParameters gameObjectBindInfo, List<TypeValuePair> extraArguments, object concreteIdentifier, Func<Type, IPrefabInstantiator, IProvider> providerFactory)
		{
			return null;
		}

		private class PrefabId : IEquatable<PrefabSingletonProviderCreator.PrefabId>
		{
			[FieldOffset(Offset="0x10")]
			public readonly object ConcreteIdentifier;

			[FieldOffset(Offset="0x18")]
			public readonly UnityEngine.Object Prefab;

			[Address(RVA="0x18424EC", Offset="0x18424EC", VA="0x18424EC")]
			public PrefabId(object concreteIdentifier, UnityEngine.Object prefab)
			{
			}

			[Address(RVA="0x18425B4", Offset="0x18425B4", VA="0x18425B4", Slot="0")]
			public override bool Equals(object other)
			{
				return new bool();
			}

			[Address(RVA="0x18426C4", Offset="0x18426C4", VA="0x18426C4", Slot="4")]
			public bool Equals(PrefabSingletonProviderCreator.PrefabId that)
			{
				return new bool();
			}

			[Address(RVA="0x1842530", Offset="0x1842530", VA="0x1842530", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}

			[Address(RVA="0x1842650", Offset="0x1842650", VA="0x1842650")]
			public static bool operator ==(PrefabSingletonProviderCreator.PrefabId left, PrefabSingletonProviderCreator.PrefabId right)
			{
				return new bool();
			}

			[Address(RVA="0x18426C8", Offset="0x18426C8", VA="0x18426C8")]
			public static bool operator !=(PrefabSingletonProviderCreator.PrefabId left, PrefabSingletonProviderCreator.PrefabId right)
			{
				return new bool();
			}
		}
	}
}