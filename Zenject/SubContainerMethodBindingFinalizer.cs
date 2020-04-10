using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerMethodBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x20")]
		private readonly Action<DiContainer> _installMethod;

		[Address(RVA="0x2334F88", Offset="0x2334F88", VA="0x2334F88")]
		public SubContainerMethodBindingFinalizer(Zenject.BindInfo bindInfo, Action<DiContainer> installMethod, object subIdentifier)
		{
		}

		[Address(RVA="0x2337C30", Offset="0x2337C30", VA="0x2337C30")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x23379D4", Offset="0x23379D4", VA="0x23379D4")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x2337900", Offset="0x2337900", VA="0x2337900", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB58", Offset="0x104DB58")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerMethodBindingFinalizer <>4__this;

			[Address(RVA="0x2337EE0", Offset="0x2337EE0", VA="0x2337EE0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x2337F00", Offset="0x2337F00", VA="0x2337F00")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x2337FD4", Offset="0x2337FD4", VA="0x2337FD4")]
			internal IProvider <FinalizeBindingConcrete>b__1(Type contractType, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB68", Offset="0x104DB68")]
		private sealed class <>c__DisplayClass4_1
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorCached creator;

			[FieldOffset(Offset="0x18")]
			public SubContainerMethodBindingFinalizer.<>c__DisplayClass4_0 CS$<>8__locals1;

			[Address(RVA="0x2337EE8", Offset="0x2337EE8", VA="0x2337EE8")]
			public <>c__DisplayClass4_1()
			{
			}

			[Address(RVA="0x23380A0", Offset="0x23380A0", VA="0x23380A0")]
			internal IProvider <FinalizeBindingConcrete>b__2(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB78", Offset="0x104DB78")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerMethodBindingFinalizer <>4__this;

			[Address(RVA="0x2337EF0", Offset="0x2337EF0", VA="0x2337EF0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x233813C", Offset="0x233813C", VA="0x233813C")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x2338210", Offset="0x2338210", VA="0x2338210")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB88", Offset="0x104DB88")]
		private sealed class <>c__DisplayClass5_1
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorCached containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerMethodBindingFinalizer.<>c__DisplayClass5_0 CS$<>8__locals1;

			[Address(RVA="0x2337EF8", Offset="0x2337EF8", VA="0x2337EF8")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x23382DC", Offset="0x23382DC", VA="0x23382DC")]
			internal IProvider <FinalizeBindingSelf>b__2(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}