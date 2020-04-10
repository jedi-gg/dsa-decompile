using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryBindInfo
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060058", Offset="0x1060058")]
		[FieldOffset(Offset="0x10")]
		private Type <FactoryType>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060068", Offset="0x1060068")]
		[FieldOffset(Offset="0x18")]
		private Func<DiContainer, IProvider> <ProviderFunc>k__BackingField;

		public Type FactoryType
		{
			[Address(RVA="0x1833F74", Offset="0x1833F74", VA="0x1833F74")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10724B4", Offset="0x10724B4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1833F6C", Offset="0x1833F6C", VA="0x1833F6C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10724C4", Offset="0x10724C4")]
			private set
			{
			}
		}

		public Func<DiContainer, IProvider> ProviderFunc
		{
			[Address(RVA="0x1833F7C", Offset="0x1833F7C", VA="0x1833F7C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10724D4", Offset="0x10724D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1833F84", Offset="0x1833F84", VA="0x1833F84")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10724E4", Offset="0x10724E4")]
			set
			{
			}
		}

		[Address(RVA="0x1833F40", Offset="0x1833F40", VA="0x1833F40")]
		public FactoryBindInfo(Type factoryType)
		{
		}
	}
}