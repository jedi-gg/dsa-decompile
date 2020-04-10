using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinder<TContract, TParam1> : FactorySubContainerBinderWithParams<TContract>
	{
		[Address(RVA="0x2345458", Offset="0x2345458", VA="0x2345458")]
		public FactorySubContainerBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x23454BC", Offset="0x23454BC", VA="0x23454BC")]
		public ConditionCopyNonLazyBinder ByMethod(Action<DiContainer, TParam1> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2345638", Offset="0x2345638", VA="0x2345638")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabMethod(UnityEngine.Object prefab, Action<DiContainer, TParam1> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2345824", Offset="0x2345824", VA="0x2345824")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceMethod(string resourcePath, Action<DiContainer, TParam1> installerMethod)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D718", Offset="0x104D718")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1> installerMethod;

			[Address(RVA="0x2344FF0", Offset="0x2344FF0", VA="0x2344FF0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x234501C", Offset="0x234501C", VA="0x234501C")]
			internal IProvider <ByMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D728", Offset="0x104D728")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1> installerMethod;

			[Address(RVA="0x2345140", Offset="0x2345140", VA="0x2345140")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x234516C", Offset="0x234516C", VA="0x234516C")]
			internal IProvider <ByNewPrefabMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D738", Offset="0x104D738")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TParam1, TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer, TParam1> installerMethod;

			[Address(RVA="0x23452CC", Offset="0x23452CC", VA="0x23452CC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x23452F8", Offset="0x23452F8", VA="0x23452F8")]
			internal IProvider <ByNewPrefabResourceMethod>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}