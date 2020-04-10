using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerInstallerBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x20")]
		private readonly Type _installerType;

		[Address(RVA="0x2334E9C", Offset="0x2334E9C", VA="0x2334E9C")]
		public SubContainerInstallerBindingFinalizer(Zenject.BindInfo bindInfo, Type installerType, object subIdentifier)
		{
		}

		[Address(RVA="0x23373D4", Offset="0x23373D4", VA="0x23373D4")]
		private ISubContainerCreator CreateContainerCreator(DiContainer container)
		{
			return null;
		}

		[Address(RVA="0x23371A8", Offset="0x23371A8", VA="0x23371A8")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x2336F8C", Offset="0x2336F8C", VA="0x2336F8C")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x2336EB8", Offset="0x2336EB8", VA="0x2336EB8", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB18", Offset="0x104DB18")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerInstallerBindingFinalizer <>4__this;

			[Address(RVA="0x2337468", Offset="0x2337468", VA="0x2337468")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x2337488", Offset="0x2337488", VA="0x2337488")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x233755C", Offset="0x233755C", VA="0x233755C")]
			internal IProvider <FinalizeBindingConcrete>b__1(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB28", Offset="0x104DB28")]
		private sealed class <>c__DisplayClass5_1
		{
			[FieldOffset(Offset="0x10")]
			public ISubContainerCreator containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerInstallerBindingFinalizer.<>c__DisplayClass5_0 CS$<>8__locals1;

			[Address(RVA="0x2337470", Offset="0x2337470", VA="0x2337470")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x2337628", Offset="0x2337628", VA="0x2337628")]
			internal IProvider <FinalizeBindingConcrete>b__2(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB38", Offset="0x104DB38")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerInstallerBindingFinalizer <>4__this;

			[Address(RVA="0x2337478", Offset="0x2337478", VA="0x2337478")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x23376C4", Offset="0x23376C4", VA="0x23376C4")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x2337798", Offset="0x2337798", VA="0x2337798")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB48", Offset="0x104DB48")]
		private sealed class <>c__DisplayClass6_1
		{
			[FieldOffset(Offset="0x10")]
			public ISubContainerCreator containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerInstallerBindingFinalizer.<>c__DisplayClass6_0 CS$<>8__locals1;

			[Address(RVA="0x2337480", Offset="0x2337480", VA="0x2337480")]
			public <>c__DisplayClass6_1()
			{
			}

			[Address(RVA="0x2337864", Offset="0x2337864", VA="0x2337864")]
			internal IProvider <FinalizeBindingSelf>b__2(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}