using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class PrefabResourceSingletonProviderCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Dictionary<PrefabResourceSingletonProviderCreator.PrefabId, IPrefabInstantiator> _prefabCreators;

		[Address(RVA="0x1841AC4", Offset="0x1841AC4", VA="0x1841AC4")]
		public PrefabResourceSingletonProviderCreator(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x1841B4C", Offset="0x1841B4C", VA="0x1841B4C")]
		public IProvider CreateProvider(string resourcePath, Type resultType, GameObjectCreationParameters gameObjectBindInfo, List<TypeValuePair> extraArguments, object concreteIdentifier, Func<Type, IPrefabInstantiator, IProvider> providerFactory)
		{
			return null;
		}

		private class PrefabId : IEquatable<PrefabResourceSingletonProviderCreator.PrefabId>
		{
			[FieldOffset(Offset="0x10")]
			public readonly object ConcreteIdentifier;

			[FieldOffset(Offset="0x18")]
			public readonly string ResourcePath;

			[Address(RVA="0x1841ED8", Offset="0x1841ED8", VA="0x1841ED8")]
			public PrefabId(object concreteIdentifier, string resourcePath)
			{
			}

			[Address(RVA="0x1841F7C", Offset="0x1841F7C", VA="0x1841F7C", Slot="0")]
			public override bool Equals(object other)
			{
				return new bool();
			}

			[Address(RVA="0x184208C", Offset="0x184208C", VA="0x184208C", Slot="4")]
			public bool Equals(PrefabResourceSingletonProviderCreator.PrefabId that)
			{
				return new bool();
			}

			[Address(RVA="0x1841F1C", Offset="0x1841F1C", VA="0x1841F1C", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}

			[Address(RVA="0x1842018", Offset="0x1842018", VA="0x1842018")]
			public static bool operator ==(PrefabResourceSingletonProviderCreator.PrefabId left, PrefabResourceSingletonProviderCreator.PrefabId right)
			{
				return new bool();
			}

			[Address(RVA="0x1842090", Offset="0x1842090", VA="0x1842090")]
			public static bool operator !=(PrefabResourceSingletonProviderCreator.PrefabId left, PrefabResourceSingletonProviderCreator.PrefabId right)
			{
				return new bool();
			}
		}
	}
}