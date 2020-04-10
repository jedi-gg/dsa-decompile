using Il2CppDummyDll;
using ModestTree.Util;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinder<TContract, TParam1, TParam2, TParam3, TParam4> : FactorySubContainerBinderWithParams<TContract>
	{
		[Address(RVA="0x23472B8", Offset="0x23472B8", VA="0x23472B8")]
		public FactorySubContainerBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x234731C", Offset="0x234731C", VA="0x234731C")]
		public ConditionCopyNonLazyBinder ByMethod(ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2347498", Offset="0x2347498", VA="0x2347498")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabMethod(UnityEngine.Object prefab, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2347684", Offset="0x2347684", VA="0x2347684")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceMethod(string resourcePath, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D7A8", Offset="0x104D7A8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod;

			[Address(RVA="0x2346E50", Offset="0x2346E50", VA="0x2346E50")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x2346E7C", Offset="0x2346E7C", VA="0x2346E7C")]
			internal IProvider <ByMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D7B8", Offset="0x104D7B8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod;

			[Address(RVA="0x2346FA0", Offset="0x2346FA0", VA="0x2346FA0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2346FCC", Offset="0x2346FCC", VA="0x2346FCC")]
			internal IProvider <ByNewPrefabMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D7C8", Offset="0x104D7C8")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod;

			[Address(RVA="0x234712C", Offset="0x234712C", VA="0x234712C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x2347158", Offset="0x2347158", VA="0x2347158")]
			internal IProvider <ByNewPrefabResourceMethod>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}