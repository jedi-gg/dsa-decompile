using Il2CppDummyDll;
using ModestTree.Util;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinder<TContract, TParam1, TParam2, TParam3, TParam4, TParam5> : FactorySubContainerBinderWithParams<TContract>
	{
		[Address(RVA="0x2347CD8", Offset="0x2347CD8", VA="0x2347CD8")]
		public FactorySubContainerBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x2347D3C", Offset="0x2347D3C", VA="0x2347D3C")]
		public ConditionCopyNonLazyBinder ByMethod(ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2347EB8", Offset="0x2347EB8", VA="0x2347EB8")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabMethod(UnityEngine.Object prefab, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x23480A4", Offset="0x23480A4", VA="0x23480A4")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceMethod(string resourcePath, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D7D8", Offset="0x104D7D8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod;

			[Address(RVA="0x2347870", Offset="0x2347870", VA="0x2347870")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x234789C", Offset="0x234789C", VA="0x234789C")]
			internal IProvider <ByMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D7E8", Offset="0x104D7E8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod;

			[Address(RVA="0x23479C0", Offset="0x23479C0", VA="0x23479C0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x23479EC", Offset="0x23479EC", VA="0x23479EC")]
			internal IProvider <ByNewPrefabMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D7F8", Offset="0x104D7F8")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod;

			[Address(RVA="0x2347B4C", Offset="0x2347B4C", VA="0x2347B4C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x2347B78", Offset="0x2347B78", VA="0x2347B78")]
			internal IProvider <ByNewPrefabResourceMethod>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}