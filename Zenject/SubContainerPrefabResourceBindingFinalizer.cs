using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerPrefabResourceBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly string _resourcePath;

		[FieldOffset(Offset="0x20")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x28")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[Address(RVA="0x23351C8", Offset="0x23351C8", VA="0x23351C8")]
		public SubContainerPrefabResourceBindingFinalizer(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectBindInfo, string resourcePath, object subIdentifier)
		{
		}

		[Address(RVA="0x2339234", Offset="0x2339234", VA="0x2339234")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x2338FA8", Offset="0x2338FA8", VA="0x2338FA8")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x2338ED4", Offset="0x2338ED4", VA="0x2338ED4", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DBD8", Offset="0x104DBD8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabResourceBindingFinalizer <>4__this;

			[Address(RVA="0x23394C8", Offset="0x23394C8", VA="0x23394C8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x23394E8", Offset="0x23394E8", VA="0x23394E8")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x23395EC", Offset="0x23395EC", VA="0x23395EC")]
			internal IProvider <FinalizeBindingConcrete>b__1(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DBE8", Offset="0x104DBE8")]
		private sealed class <>c__DisplayClass5_1
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorCached containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabResourceBindingFinalizer.<>c__DisplayClass5_0 CS$<>8__locals1;

			[Address(RVA="0x23394D0", Offset="0x23394D0", VA="0x23394D0")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x23396F0", Offset="0x23396F0", VA="0x23396F0")]
			internal IProvider <FinalizeBindingConcrete>b__2(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DBF8", Offset="0x104DBF8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabResourceBindingFinalizer <>4__this;

			[Address(RVA="0x23394D8", Offset="0x23394D8", VA="0x23394D8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x233978C", Offset="0x233978C", VA="0x233978C")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x2339890", Offset="0x2339890", VA="0x2339890")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC08", Offset="0x104DC08")]
		private sealed class <>c__DisplayClass6_1
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorCached containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabResourceBindingFinalizer.<>c__DisplayClass6_0 CS$<>8__locals1;

			[Address(RVA="0x23394E0", Offset="0x23394E0", VA="0x23394E0")]
			public <>c__DisplayClass6_1()
			{
			}

			[Address(RVA="0x2339994", Offset="0x2339994", VA="0x2339994")]
			internal IProvider <FinalizeBindingSelf>b__2(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}