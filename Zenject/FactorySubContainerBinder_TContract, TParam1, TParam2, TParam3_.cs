using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinder<TContract, TParam1, TParam2, TParam3> : FactorySubContainerBinderWithParams<TContract>
	{
		[Address(RVA="0x2346898", Offset="0x2346898", VA="0x2346898")]
		public FactorySubContainerBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x23468FC", Offset="0x23468FC", VA="0x23468FC")]
		public ConditionCopyNonLazyBinder ByMethod(Action<DiContainer, TParam1, TParam2, TParam3> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2346A78", Offset="0x2346A78", VA="0x2346A78")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabMethod(UnityEngine.Object prefab, Action<DiContainer, TParam1, TParam2, TParam3> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2346C64", Offset="0x2346C64", VA="0x2346C64")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceMethod(string resourcePath, Action<DiContainer, TParam1, TParam2, TParam3> installerMethod)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D778", Offset="0x104D778")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1, TParam2, TParam3> installerMethod;

			[Address(RVA="0x2346430", Offset="0x2346430", VA="0x2346430")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x234645C", Offset="0x234645C", VA="0x234645C")]
			internal IProvider <ByMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D788", Offset="0x104D788")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1, TParam2, TParam3> installerMethod;

			[Address(RVA="0x2346580", Offset="0x2346580", VA="0x2346580")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x23465AC", Offset="0x23465AC", VA="0x23465AC")]
			internal IProvider <ByNewPrefabMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D798", Offset="0x104D798")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TParam2, TParam3, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1, TParam2, TParam3> installerMethod;

			[Address(RVA="0x234670C", Offset="0x234670C", VA="0x234670C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x2346738", Offset="0x2346738", VA="0x2346738")]
			internal IProvider <ByNewPrefabResourceMethod>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}