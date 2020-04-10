using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinderWithParams<TContract> : FactorySubContainerBinderBase<TContract>
	{
		[Address(RVA="0x2343B24", Offset="0x2343B24", VA="0x2343B24")]
		public FactorySubContainerBinderWithParams(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x2AFB1C0", Offset="0x2AFB1C0", VA="0x2AFB1C0")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefab<TInstaller>(UnityEngine.Object prefab)
		where TInstaller : IInstaller
		{
			return null;
		}

		[Address(RVA="0x2343B88", Offset="0x2343B88", VA="0x2343B88")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefab(Type installerType, UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x2AFB270", Offset="0x2AFB270", VA="0x2AFB270")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResource<TInstaller>(string resourcePath)
		where TInstaller : IInstaller
		{
			return null;
		}

		[Address(RVA="0x2343DE0", Offset="0x2343DE0", VA="0x2343DE0")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResource(Type installerType, string resourcePath)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D838", Offset="0x104D838")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinderWithParams<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Type installerType;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[Address(RVA="0x2343854", Offset="0x2343854", VA="0x2343854")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2343880", Offset="0x2343880", VA="0x2343880")]
			internal IProvider <ByNewPrefab>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D848", Offset="0x104D848")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinderWithParams<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Type installerType;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[Address(RVA="0x23439BC", Offset="0x23439BC", VA="0x23439BC")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x23439E8", Offset="0x23439E8", VA="0x23439E8")]
			internal IProvider <ByNewPrefabResource>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}