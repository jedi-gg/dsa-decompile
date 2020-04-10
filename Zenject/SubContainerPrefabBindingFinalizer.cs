using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class SubContainerPrefabBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly UnityEngine.Object _prefab;

		[FieldOffset(Offset="0x20")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x28")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[Address(RVA="0x23350A4", Offset="0x23350A4", VA="0x23350A4")]
		public SubContainerPrefabBindingFinalizer(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectBindInfo, UnityEngine.Object prefab, object subIdentifier)
		{
		}

		[Address(RVA="0x23386D8", Offset="0x23386D8", VA="0x23386D8")]
		private void FinalizeBindingConcrete(DiContainer container, List<Type> concreteTypes)
		{
		}

		[Address(RVA="0x233844C", Offset="0x233844C", VA="0x233844C")]
		private void FinalizeBindingSelf(DiContainer container)
		{
		}

		[Address(RVA="0x2338378", Offset="0x2338378", VA="0x2338378", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DB98", Offset="0x104DB98")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabBindingFinalizer <>4__this;

			[Address(RVA="0x233896C", Offset="0x233896C", VA="0x233896C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x233898C", Offset="0x233898C", VA="0x233898C")]
			internal IProvider <FinalizeBindingConcrete>b__0(DiContainer _, Type concreteType)
			{
				return null;
			}

			[Address(RVA="0x2338A90", Offset="0x2338A90", VA="0x2338A90")]
			internal IProvider <FinalizeBindingConcrete>b__1(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DBA8", Offset="0x104DBA8")]
		private sealed class <>c__DisplayClass5_1
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorCached containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabBindingFinalizer.<>c__DisplayClass5_0 CS$<>8__locals1;

			[Address(RVA="0x2338974", Offset="0x2338974", VA="0x2338974")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x2338B94", Offset="0x2338B94", VA="0x2338B94")]
			internal IProvider <FinalizeBindingConcrete>b__2(DiContainer _, Type concreteType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DBB8", Offset="0x104DBB8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer container;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabBindingFinalizer <>4__this;

			[Address(RVA="0x233897C", Offset="0x233897C", VA="0x233897C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x2338C30", Offset="0x2338C30", VA="0x2338C30")]
			internal IProvider <FinalizeBindingSelf>b__0(DiContainer _, Type contractType)
			{
				return null;
			}

			[Address(RVA="0x2338D34", Offset="0x2338D34", VA="0x2338D34")]
			internal IProvider <FinalizeBindingSelf>b__1(DiContainer _, Type contractType)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DBC8", Offset="0x104DBC8")]
		private sealed class <>c__DisplayClass6_1
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorCached containerCreator;

			[FieldOffset(Offset="0x18")]
			public SubContainerPrefabBindingFinalizer.<>c__DisplayClass6_0 CS$<>8__locals1;

			[Address(RVA="0x2338984", Offset="0x2338984", VA="0x2338984")]
			public <>c__DisplayClass6_1()
			{
			}

			[Address(RVA="0x2338E38", Offset="0x2338E38", VA="0x2338E38")]
			internal IProvider <FinalizeBindingSelf>b__2(DiContainer _, Type contractType)
			{
				return null;
			}
		}
	}
}