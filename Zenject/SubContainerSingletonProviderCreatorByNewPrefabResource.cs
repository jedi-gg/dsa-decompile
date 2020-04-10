using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerSingletonProviderCreatorByNewPrefabResource
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Dictionary<SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId, SubContainerSingletonProviderCreatorByNewPrefabResource.CreatorInfo> _subContainerCreators;

		[Address(RVA="0x2333764", Offset="0x2333764", VA="0x2333764")]
		public SubContainerSingletonProviderCreatorByNewPrefabResource(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x23347B0", Offset="0x23347B0", VA="0x23347B0")]
		public IProvider CreateProvider(Type resultType, object concreteIdentifier, string resourcePath, object identifier, GameObjectCreationParameters gameObjectBindInfo)
		{
			return null;
		}

		private class CreatorInfo
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C894", Offset="0x106C894")]
			[FieldOffset(Offset="0x10")]
			private GameObjectCreationParameters <GameObjectCreationParameters>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C8A4", Offset="0x106C8A4")]
			[FieldOffset(Offset="0x18")]
			private ISubContainerCreator <Creator>k__BackingField;

			public ISubContainerCreator Creator
			{
				[Address(RVA="0x233A198", Offset="0x233A198", VA="0x233A198")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D32C", Offset="0x108D32C")]
				get
				{
					return null;
				}
				[Address(RVA="0x233A1A8", Offset="0x233A1A8", VA="0x233A1A8")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D33C", Offset="0x108D33C")]
				private set
				{
				}
			}

			public GameObjectCreationParameters GameObjectCreationParameters
			{
				[Address(RVA="0x233A158", Offset="0x233A158", VA="0x233A158")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D30C", Offset="0x108D30C")]
				get
				{
					return null;
				}
				[Address(RVA="0x233A1A0", Offset="0x233A1A0", VA="0x233A1A0")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D31C", Offset="0x108D31C")]
				private set
				{
				}
			}

			[Address(RVA="0x233A160", Offset="0x233A160", VA="0x233A160")]
			public CreatorInfo(GameObjectCreationParameters creationParameters, ISubContainerCreator creator)
			{
			}
		}

		private class CustomSingletonId : IEquatable<SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId>
		{
			[FieldOffset(Offset="0x10")]
			public readonly object ConcreteIdentifier;

			[FieldOffset(Offset="0x18")]
			public readonly string ResourcePath;

			[Address(RVA="0x233A114", Offset="0x233A114", VA="0x233A114")]
			public CustomSingletonId(object concreteIdentifier, string resourcePath)
			{
			}

			[Address(RVA="0x233A210", Offset="0x233A210", VA="0x233A210", Slot="0")]
			public override bool Equals(object other)
			{
				return new bool();
			}

			[Address(RVA="0x233A320", Offset="0x233A320", VA="0x233A320", Slot="4")]
			public bool Equals(SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId that)
			{
				return new bool();
			}

			[Address(RVA="0x233A1B0", Offset="0x233A1B0", VA="0x233A1B0", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}

			[Address(RVA="0x233A2AC", Offset="0x233A2AC", VA="0x233A2AC")]
			public static bool operator ==(SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId left, SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId right)
			{
				return new bool();
			}

			[Address(RVA="0x233A324", Offset="0x233A324", VA="0x233A324")]
			public static bool operator !=(SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId left, SubContainerSingletonProviderCreatorByNewPrefabResource.CustomSingletonId right)
			{
				return new bool();
			}
		}
	}
}