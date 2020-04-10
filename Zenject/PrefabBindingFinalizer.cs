using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class PrefabBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[FieldOffset(Offset="0x20")]
		private readonly UnityEngine.Object _prefab;

		[FieldOffset(Offset="0x28")]
		private readonly Func<Type, IPrefabInstantiator, IProvider> _providerFactory;

		[Address(RVA="0x1835148", Offset="0x1835148", VA="0x1835148")]
		public PrefabBindingFinalizer(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectBindInfo, UnityEngine.Object prefab, Func<Type, IPrefabInstantiator, IProvider> providerFactory)
		{
		}

		[Address(RVA="0x183E6C0", Offset="0x183E6C0", VA="0x183E6C0")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x183E398", Offset="0x183E398", VA="0x183E398")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x183E2CC", Offset="0x183E2CC", VA="0x183E2CC", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA58", Offset="0x104DA58")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public PrefabBindingFinalizer <>4__this;

			[Address(RVA="0x183E9E0", Offset="0x183E9E0", VA="0x183E9E0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x183F3CC", Offset="0x183F3CC", VA="0x183F3CC")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x183F500", Offset="0x183F500", VA="0x183F500")]
			internal IProvider <FinalizeBindingConcrete>b__1(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA68", Offset="0x104DA68")]
		private sealed class <>c__DisplayClass5_1
		{
			[FieldOffset(Offset="0x10")]
			public PrefabInstantiatorCached prefabCreator;

			[FieldOffset(Offset="0x18")]
			public PrefabBindingFinalizer.<>c__DisplayClass5_0 CS$<>8__locals1;

			[Address(RVA="0x183F17C", Offset="0x183F17C", VA="0x183F17C")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x183F658", Offset="0x183F658", VA="0x183F658")]
			internal IProvider <FinalizeBindingConcrete>b__2(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA78", Offset="0x104DA78")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public PrefabBindingFinalizer <>4__this;

			[Address(RVA="0x183F23C", Offset="0x183F23C", VA="0x183F23C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x183F720", Offset="0x183F720", VA="0x183F720")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x183F854", Offset="0x183F854", VA="0x183F854")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA88", Offset="0x104DA88")]
		private sealed class <>c__DisplayClass6_1
		{
			[FieldOffset(Offset="0x10")]
			public PrefabInstantiatorCached prefabCreator;

			[FieldOffset(Offset="0x18")]
			public PrefabBindingFinalizer.<>c__DisplayClass6_0 CS$<>8__locals1;

			[Address(RVA="0x183F3C4", Offset="0x183F3C4", VA="0x183F3C4")]
			public <>c__DisplayClass6_1()
			{
			}

			[Address(RVA="0x183F9AC", Offset="0x183F9AC", VA="0x183F9AC")]
			internal IProvider <FinalizeBindingSelf>b__2(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}