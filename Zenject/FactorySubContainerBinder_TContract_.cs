using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinder<TContract> : FactorySubContainerBinderBase<TContract>
	{
		[Address(RVA="0x2344690", Offset="0x2344690", VA="0x2344690")]
		public FactorySubContainerBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x23446F4", Offset="0x23446F4", VA="0x23446F4")]
		public ConditionCopyNonLazyBinder ByMethod(Action<DiContainer> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2344C48", Offset="0x2344C48", VA="0x2344C48")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x2344870", Offset="0x2344870", VA="0x2344870")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabMethod(UnityEngine.Object prefab, Action<DiContainer> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2344E1C", Offset="0x2344E1C", VA="0x2344E1C")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x2344A5C", Offset="0x2344A5C", VA="0x2344A5C")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceMethod(string resourcePath, Action<DiContainer> installerMethod)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D6C8", Offset="0x104D6C8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer> installerMethod;

			[Address(RVA="0x2343FCC", Offset="0x2343FCC", VA="0x2343FCC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x2343FF8", Offset="0x2343FF8", VA="0x2343FF8")]
			internal IProvider <ByMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D6D8", Offset="0x104D6D8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer> installerMethod;

			[Address(RVA="0x2344100", Offset="0x2344100", VA="0x2344100")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x234412C", Offset="0x234412C", VA="0x234412C")]
			internal IProvider <ByNewPrefabMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D6E8", Offset="0x104D6E8")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Action<DiContainer> installerMethod;

			[Address(RVA="0x234426C", Offset="0x234426C", VA="0x234426C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x2344298", Offset="0x2344298", VA="0x2344298")]
			internal IProvider <ByNewPrefabResourceMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D6F8", Offset="0x104D6F8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[Address(RVA="0x23443D8", Offset="0x23443D8", VA="0x23443D8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x2344404", Offset="0x2344404", VA="0x2344404")]
			internal IProvider <ByNewPrefab>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D708", Offset="0x104D708")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinder<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[Address(RVA="0x2344534", Offset="0x2344534", VA="0x2344534")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x2344560", Offset="0x2344560", VA="0x2344560")]
			internal IProvider <ByNewPrefabResource>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}