using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinder<TContract, TParam1, TParam2> : FactorySubContainerBinderWithParams<TContract>
	{
		[Address(RVA="0x2345E78", Offset="0x2345E78", VA="0x2345E78")]
		public FactorySubContainerBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x2345EDC", Offset="0x2345EDC", VA="0x2345EDC")]
		public ConditionCopyNonLazyBinder ByMethod(Action<DiContainer, TParam1, TParam2> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2346058", Offset="0x2346058", VA="0x2346058")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabMethod(UnityEngine.Object prefab, Action<DiContainer, TParam1, TParam2> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2346244", Offset="0x2346244", VA="0x2346244")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceMethod(string resourcePath, Action<DiContainer, TParam1, TParam2> installerMethod)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D748", Offset="0x104D748")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1, TParam2> installerMethod;

			[Address(RVA="0x2345A10", Offset="0x2345A10", VA="0x2345A10")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x2345A3C", Offset="0x2345A3C", VA="0x2345A3C")]
			internal IProvider <ByMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D758", Offset="0x104D758")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1, TParam2> installerMethod;

			[Address(RVA="0x2345B60", Offset="0x2345B60", VA="0x2345B60")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2345B8C", Offset="0x2345B8C", VA="0x2345B8C")]
			internal IProvider <ByNewPrefabMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D768", Offset="0x104D768")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1, TParam2> installerMethod;

			[Address(RVA="0x2345CEC", Offset="0x2345CEC", VA="0x2345CEC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x2345D18", Offset="0x2345D18", VA="0x2345D18")]
			internal IProvider <ByNewPrefabResourceMethod>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}