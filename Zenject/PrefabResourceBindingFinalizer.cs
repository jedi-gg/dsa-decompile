using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class PrefabResourceBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[FieldOffset(Offset="0x20")]
		private readonly string _resourcePath;

		[FieldOffset(Offset="0x28")]
		private readonly Func<Type, IPrefabInstantiator, IProvider> _providerFactory;

		[Address(RVA="0x1834EEC", Offset="0x1834EEC", VA="0x1834EEC")]
		public PrefabResourceBindingFinalizer(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectBindInfo, string resourcePath, Func<Type, IPrefabInstantiator, IProvider> providerFactory)
		{
		}

		[Address(RVA="0x1841100", Offset="0x1841100", VA="0x1841100")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x1840DE4", Offset="0x1840DE4", VA="0x1840DE4")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x1840D20", Offset="0x1840D20", VA="0x1840D20", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA98", Offset="0x104DA98")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public PrefabResourceBindingFinalizer <>4__this;

			[Address(RVA="0x1841414", Offset="0x1841414", VA="0x1841414")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1841434", Offset="0x1841434", VA="0x1841434")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x1841568", Offset="0x1841568", VA="0x1841568")]
			internal IProvider <FinalizeBindingConcrete>b__1(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DAA8", Offset="0x104DAA8")]
		private sealed class <>c__DisplayClass5_1
		{
			[FieldOffset(Offset="0x10")]
			public PrefabInstantiatorCached prefabCreator;

			[FieldOffset(Offset="0x18")]
			public PrefabResourceBindingFinalizer.<>c__DisplayClass5_0 CS$<>8__locals1;

			[Address(RVA="0x184141C", Offset="0x184141C", VA="0x184141C")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x18416B4", Offset="0x18416B4", VA="0x18416B4")]
			internal IProvider <FinalizeBindingConcrete>b__2(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DAB8", Offset="0x104DAB8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public PrefabResourceBindingFinalizer <>4__this;

			[Address(RVA="0x1841424", Offset="0x1841424", VA="0x1841424")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x184177C", Offset="0x184177C", VA="0x184177C")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x18418B0", Offset="0x18418B0", VA="0x18418B0")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DAC8", Offset="0x104DAC8")]
		private sealed class <>c__DisplayClass6_1
		{
			[FieldOffset(Offset="0x10")]
			public PrefabInstantiatorCached prefabCreator;

			[FieldOffset(Offset="0x18")]
			public PrefabResourceBindingFinalizer.<>c__DisplayClass6_0 CS$<>8__locals1;

			[Address(RVA="0x184142C", Offset="0x184142C", VA="0x184142C")]
			public <>c__DisplayClass6_1()
			{
			}

			[Address(RVA="0x18419FC", Offset="0x18419FC", VA="0x18419FC")]
			internal IProvider <FinalizeBindingSelf>b__2(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}