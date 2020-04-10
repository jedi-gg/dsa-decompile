using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class ProviderBindingFinalizer : IBindingFinalizer
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10600F8", Offset="0x10600F8")]
		[FieldOffset(Offset="0x10")]
		private Zenject.BindInfo <BindInfo>k__BackingField;

		protected Zenject.BindInfo BindInfo
		{
			[Address(RVA="0x183E390", Offset="0x183E390", VA="0x183E390")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10725F4", Offset="0x10725F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1843984", Offset="0x1843984", VA="0x1843984")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072604", Offset="0x1072604")]
			private set
			{
			}
		}

		public bool CopyIntoAllSubContainers
		{
			[Address(RVA="0x184398C", Offset="0x184398C", VA="0x184398C", Slot="4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x183E2A0", Offset="0x183E2A0", VA="0x183E2A0")]
		public ProviderBindingFinalizer(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x18439BC", Offset="0x18439BC", VA="0x18439BC", Slot="5")]
		public void FinalizeBinding(DiContainer container)
		{
		}

		[Address(RVA="0x183E9E8", Offset="0x183E9E8", VA="0x183E9E8")]
		protected ScopeTypes GetScope()
		{
			return new ScopeTypes();
		}

		protected abstract void OnFinalizeBinding(DiContainer container);

		[Address(RVA="0x16A7718", Offset="0x16A7718", VA="0x16A7718")]
		protected void RegisterProvider<TContract>(DiContainer container, IProvider provider)
		{
		}

		[Address(RVA="0x1843C50", Offset="0x1843C50", VA="0x1843C50")]
		protected void RegisterProvider(DiContainer container, Type contractType, IProvider provider)
		{
		}

		[Address(RVA="0x1843EB4", Offset="0x1843EB4", VA="0x1843EB4")]
		protected void RegisterProviderForAllContracts(DiContainer container, IProvider provider)
		{
		}

		[Address(RVA="0x183F244", Offset="0x183F244", VA="0x183F244")]
		protected void RegisterProviderPerContract(DiContainer container, Func<DiContainer, Type, IProvider> providerFunc)
		{
		}

		[Address(RVA="0x183ECD8", Offset="0x183ECD8", VA="0x183ECD8")]
		protected void RegisterProvidersForAllContractsPerConcreteType(DiContainer container, List<Type> concreteTypes, Func<DiContainer, Type, IProvider> providerFunc)
		{
		}

		[Address(RVA="0x1843FFC", Offset="0x1843FFC", VA="0x1843FFC")]
		protected void RegisterProvidersPerContractAndConcreteType(DiContainer container, List<Type> concreteTypes, Func<Type, Type, IProvider> providerFunc)
		{
		}

		[Address(RVA="0x184433C", Offset="0x184433C", VA="0x184433C")]
		private bool ValidateBindTypes(Type concreteType, Type contractType)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DAD8", Offset="0x104DAD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ProviderBindingFinalizer.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Type, string> <>9__7_0;

			[FieldOffset(Offset="0x10")]
			public static Func<Type, Type> <>9__16_0;

			[Address(RVA="0x1844530", Offset="0x1844530", VA="0x1844530")]
			static <>c()
			{
			}

			[Address(RVA="0x1844594", Offset="0x1844594", VA="0x1844594")]
			public <>c()
			{
			}

			[Address(RVA="0x184459C", Offset="0x184459C", VA="0x184459C")]
			internal string <GetScope>b__7_0(Type x)
			{
				return null;
			}

			[Address(RVA="0x18445D0", Offset="0x18445D0", VA="0x18445D0")]
			internal Type <RegisterProvidersForAllContractsPerConcreteType>b__16_0(Type x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DAE8", Offset="0x104DAE8")]
		private sealed class <>c__DisplayClass16_0
		{
			[FieldOffset(Offset="0x10")]
			public Func<DiContainer, Type, IProvider> providerFunc;

			[FieldOffset(Offset="0x18")]
			public DiContainer container;

			[Address(RVA="0x1844528", Offset="0x1844528", VA="0x1844528")]
			public <>c__DisplayClass16_0()
			{
			}

			[Address(RVA="0x18445D8", Offset="0x18445D8", VA="0x18445D8")]
			internal IProvider <RegisterProvidersForAllContractsPerConcreteType>b__1(Type x)
			{
				return null;
			}
		}
	}
}