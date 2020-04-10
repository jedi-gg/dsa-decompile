using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerSingletonProviderCreatorByInstaller
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Dictionary<SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId, ISubContainerCreator> _subContainerCreators;

		[Address(RVA="0x2333654", Offset="0x2333654", VA="0x2333654")]
		public SubContainerSingletonProviderCreatorByInstaller(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x2334268", Offset="0x2334268", VA="0x2334268")]
		public IProvider CreateProvider(Type resultType, object concreteIdentifier, Type installerType, object identifier)
		{
			return null;
		}

		private class InstallerSingletonId : IEquatable<SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId>
		{
			[FieldOffset(Offset="0x10")]
			public readonly object ConcreteIdentifier;

			[FieldOffset(Offset="0x18")]
			public readonly Type InstallerType;

			[Address(RVA="0x2339A30", Offset="0x2339A30", VA="0x2339A30")]
			public InstallerSingletonId(object concreteIdentifier, Type installerType)
			{
			}

			[Address(RVA="0x2339AC8", Offset="0x2339AC8", VA="0x2339AC8", Slot="0")]
			public override bool Equals(object other)
			{
				return new bool();
			}

			[Address(RVA="0x2339BD8", Offset="0x2339BD8", VA="0x2339BD8", Slot="4")]
			public bool Equals(SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId that)
			{
				return new bool();
			}

			[Address(RVA="0x2339A68", Offset="0x2339A68", VA="0x2339A68", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}

			[Address(RVA="0x2339B64", Offset="0x2339B64", VA="0x2339B64")]
			public static bool operator ==(SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId left, SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId right)
			{
				return new bool();
			}

			[Address(RVA="0x2339BDC", Offset="0x2339BDC", VA="0x2339BDC")]
			public static bool operator !=(SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId left, SubContainerSingletonProviderCreatorByInstaller.InstallerSingletonId right)
			{
				return new bool();
			}
		}
	}
}