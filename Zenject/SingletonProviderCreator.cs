using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class SingletonProviderCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly StandardSingletonProviderCreator _standardProviderCreator;

		[FieldOffset(Offset="0x18")]
		private readonly SubContainerSingletonProviderCreatorByMethod _subContainerMethodProviderCreator;

		[FieldOffset(Offset="0x20")]
		private readonly SubContainerSingletonProviderCreatorByInstaller _subContainerInstallerProviderCreator;

		[FieldOffset(Offset="0x28")]
		private readonly SubContainerSingletonProviderCreatorByNewPrefab _subContainerPrefabProviderCreator;

		[FieldOffset(Offset="0x30")]
		private readonly SubContainerSingletonProviderCreatorByNewPrefabResource _subContainerPrefabResourceProviderCreator;

		[FieldOffset(Offset="0x38")]
		private readonly PrefabSingletonProviderCreator _prefabProviderCreator;

		[FieldOffset(Offset="0x40")]
		private readonly PrefabResourceSingletonProviderCreator _prefabResourceProviderCreator;

		[Address(RVA="0x23333E0", Offset="0x23333E0", VA="0x23333E0")]
		public SingletonProviderCreator(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x23343E8", Offset="0x23343E8", VA="0x23343E8")]
		public IProvider CreateProviderForPrefab(UnityEngine.Object prefab, Type resultType, GameObjectCreationParameters gameObjectBindInfo, List<TypeValuePair> extraArguments, object concreteIdentifier, Func<Type, IPrefabInstantiator, IProvider> providerFactory)
		{
			return null;
		}

		[Address(RVA="0x2334460", Offset="0x2334460", VA="0x2334460")]
		public IProvider CreateProviderForPrefabResource(string resourcePath, Type resultType, GameObjectCreationParameters gameObjectBindInfo, List<TypeValuePair> extraArguments, object concreteIdentifier, Func<Type, IPrefabInstantiator, IProvider> providerFactory)
		{
			return null;
		}

		[Address(RVA="0x233420C", Offset="0x233420C", VA="0x233420C")]
		public IProvider CreateProviderForSubContainerInstaller(Type resultType, object concreteIdentifier, Type installerType, object identifier)
		{
			return null;
		}

		[Address(RVA="0x2334014", Offset="0x2334014", VA="0x2334014")]
		public IProvider CreateProviderForSubContainerMethod(Type resultType, object concreteIdentifier, Action<DiContainer> installMethod, object identifier)
		{
			return null;
		}

		[Address(RVA="0x23344D8", Offset="0x23344D8", VA="0x23344D8")]
		public IProvider CreateProviderForSubContainerPrefab(Type resultType, object concreteIdentifier, GameObjectCreationParameters gameObjectBindInfo, UnityEngine.Object prefab, object identifier)
		{
			return null;
		}

		[Address(RVA="0x233474C", Offset="0x233474C", VA="0x233474C")]
		public IProvider CreateProviderForSubContainerPrefabResource(Type resultType, object concreteIdentifier, GameObjectCreationParameters gameObjectBindInfo, string resourcePath, object identifier)
		{
			return null;
		}

		[Address(RVA="0x23337EC", Offset="0x23337EC", VA="0x23337EC")]
		public IProvider CreateProviderStandard(StandardSingletonDeclaration dec, Func<DiContainer, Type, IProvider> providerCreator)
		{
			return null;
		}
	}
}