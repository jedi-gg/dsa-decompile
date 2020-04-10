using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class ScopableBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly SingletonTypes _singletonType;

		[FieldOffset(Offset="0x20")]
		private readonly Func<DiContainer, Type, IProvider> _providerFactory;

		[FieldOffset(Offset="0x28")]
		private readonly object _singletonSpecificId;

		[Address(RVA="0x1834400", Offset="0x1834400", VA="0x1834400")]
		public ScopableBindingFinalizer(Zenject.BindInfo bindInfo, SingletonTypes singletonType, object singletonSpecificId, Func<DiContainer, Type, IProvider> providerFactory)
		{
		}

		[Address(RVA="0x18474E0", Offset="0x18474E0", VA="0x18474E0")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x1847398", Offset="0x1847398", VA="0x1847398")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x18472D4", Offset="0x18472D4", VA="0x18472D4", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DAF8", Offset="0x104DAF8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public ScopableBindingFinalizer <>4__this;

			[Address(RVA="0x1847668", Offset="0x1847668", VA="0x1847668")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1847678", Offset="0x1847678", VA="0x1847678")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x18477E0", Offset="0x18477E0", VA="0x18477E0")]
			internal IProvider <FinalizeBindingConcrete>b__1(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB08", Offset="0x104DB08")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public ScopableBindingFinalizer <>4__this;

			[Address(RVA="0x1847670", Offset="0x1847670", VA="0x1847670")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x1847898", Offset="0x1847898", VA="0x1847898")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x1847A00", Offset="0x1847A00", VA="0x1847A00")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}