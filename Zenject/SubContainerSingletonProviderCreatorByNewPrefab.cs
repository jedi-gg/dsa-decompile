using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class SubContainerSingletonProviderCreatorByNewPrefab
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Dictionary<SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId, SubContainerSingletonProviderCreatorByNewPrefab.CreatorInfo> _subContainerCreators;

		[Address(RVA="0x23336DC", Offset="0x23336DC", VA="0x23336DC")]
		public SubContainerSingletonProviderCreatorByNewPrefab(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x233453C", Offset="0x233453C", VA="0x233453C")]
		public IProvider CreateProvider(Type resultType, object concreteIdentifier, UnityEngine.Object prefab, object identifier, GameObjectCreationParameters gameObjectBindInfo)
		{
			return null;
		}

		private class CreatorInfo
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C874", Offset="0x106C874")]
			[FieldOffset(Offset="0x10")]
			private GameObjectCreationParameters <GameObjectCreationParameters>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C884", Offset="0x106C884")]
			[FieldOffset(Offset="0x18")]
			private ISubContainerCreator <Creator>k__BackingField;

			public ISubContainerCreator Creator
			{
				[Address(RVA="0x2339F34", Offset="0x2339F34", VA="0x2339F34")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D2EC", Offset="0x108D2EC")]
				get
				{
					return null;
				}
				[Address(RVA="0x2339F44", Offset="0x2339F44", VA="0x2339F44")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D2FC", Offset="0x108D2FC")]
				private set
				{
				}
			}

			public GameObjectCreationParameters GameObjectCreationParameters
			{
				[Address(RVA="0x2339EF4", Offset="0x2339EF4", VA="0x2339EF4")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D2CC", Offset="0x108D2CC")]
				get
				{
					return null;
				}
				[Address(RVA="0x2339F3C", Offset="0x2339F3C", VA="0x2339F3C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D2DC", Offset="0x108D2DC")]
				private set
				{
				}
			}

			[Address(RVA="0x2339EFC", Offset="0x2339EFC", VA="0x2339EFC")]
			public CreatorInfo(GameObjectCreationParameters gameObjectBindInfo, ISubContainerCreator creator)
			{
			}
		}

		private class CustomSingletonId : IEquatable<SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId>
		{
			[FieldOffset(Offset="0x10")]
			public readonly object ConcreteIdentifier;

			[FieldOffset(Offset="0x18")]
			public readonly UnityEngine.Object Prefab;

			[Address(RVA="0x2339EBC", Offset="0x2339EBC", VA="0x2339EBC")]
			public CustomSingletonId(object concreteIdentifier, UnityEngine.Object prefab)
			{
			}

			[Address(RVA="0x2339FC4", Offset="0x2339FC4", VA="0x2339FC4", Slot="0")]
			public override bool Equals(object other)
			{
				return new bool();
			}

			[Address(RVA="0x233A0D4", Offset="0x233A0D4", VA="0x233A0D4", Slot="4")]
			public bool Equals(SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId that)
			{
				return new bool();
			}

			[Address(RVA="0x2339F4C", Offset="0x2339F4C", VA="0x2339F4C", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}

			[Address(RVA="0x233A060", Offset="0x233A060", VA="0x233A060")]
			public static bool operator ==(SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId left, SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId right)
			{
				return new bool();
			}

			[Address(RVA="0x233A0D8", Offset="0x233A0D8", VA="0x233A0D8")]
			public static bool operator !=(SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId left, SubContainerSingletonProviderCreatorByNewPrefab.CustomSingletonId right)
			{
				return new bool();
			}
		}
	}
}