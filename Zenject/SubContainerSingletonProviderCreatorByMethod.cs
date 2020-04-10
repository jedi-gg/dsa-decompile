using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerSingletonProviderCreatorByMethod
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Dictionary<SubContainerSingletonProviderCreatorByMethod.MethodSingletonId, ISubContainerCreator> _subContainerCreators;

		[Address(RVA="0x23335CC", Offset="0x23335CC", VA="0x23335CC")]
		public SubContainerSingletonProviderCreatorByMethod(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x2334070", Offset="0x2334070", VA="0x2334070")]
		public IProvider CreateProvider(Type resultType, object concreteIdentifier, Action<DiContainer> installMethod, object identifier)
		{
			return null;
		}

		private class MethodSingletonId : IEquatable<SubContainerSingletonProviderCreatorByMethod.MethodSingletonId>
		{
			[FieldOffset(Offset="0x10")]
			public readonly object ConcreteIdentifier;

			[FieldOffset(Offset="0x18")]
			public readonly Delegate InstallerDelegate;

			[Address(RVA="0x2339C18", Offset="0x2339C18", VA="0x2339C18")]
			public MethodSingletonId(object concreteIdentifier, Delegate installerMethod)
			{
			}

			[Address(RVA="0x2339D00", Offset="0x2339D00", VA="0x2339D00", Slot="0")]
			public override bool Equals(object other)
			{
				return new bool();
			}

			[Address(RVA="0x2339E7C", Offset="0x2339E7C", VA="0x2339E7C", Slot="4")]
			public bool Equals(SubContainerSingletonProviderCreatorByMethod.MethodSingletonId that)
			{
				return new bool();
			}

			[Address(RVA="0x2339C50", Offset="0x2339C50", VA="0x2339C50", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}

			[Address(RVA="0x2339D9C", Offset="0x2339D9C", VA="0x2339D9C")]
			public static bool operator ==(SubContainerSingletonProviderCreatorByMethod.MethodSingletonId left, SubContainerSingletonProviderCreatorByMethod.MethodSingletonId right)
			{
				return new bool();
			}

			[Address(RVA="0x2339E80", Offset="0x2339E80", VA="0x2339E80")]
			public static bool operator !=(SubContainerSingletonProviderCreatorByMethod.MethodSingletonId left, SubContainerSingletonProviderCreatorByMethod.MethodSingletonId right)
			{
				return new bool();
			}
		}
	}
}