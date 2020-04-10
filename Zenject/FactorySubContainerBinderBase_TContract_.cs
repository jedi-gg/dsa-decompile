using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class FactorySubContainerBinderBase<TContract>
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FED8", Offset="0x105FED8")]
		[FieldOffset(Offset="0x0")]
		private Zenject.FactoryBindInfo <FactoryBindInfo>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FEE8", Offset="0x105FEE8")]
		[FieldOffset(Offset="0x0")]
		private Zenject.BindInfo <BindInfo>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FEF8", Offset="0x105FEF8")]
		[FieldOffset(Offset="0x0")]
		private object <SubIdentifier>k__BackingField;

		protected Zenject.BindInfo BindInfo
		{
			[Address(RVA="0x2343144", Offset="0x2343144", VA="0x2343144")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072140", Offset="0x1072140")]
			get
			{
				return null;
			}
			[Address(RVA="0x234314C", Offset="0x234314C", VA="0x234314C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072150", Offset="0x1072150")]
			private set
			{
			}
		}

		protected Type ContractType
		{
			[Address(RVA="0x2343164", Offset="0x2343164", VA="0x2343164")]
			get
			{
				return null;
			}
		}

		protected Zenject.FactoryBindInfo FactoryBindInfo
		{
			[Address(RVA="0x234307C", Offset="0x234307C", VA="0x234307C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072120", Offset="0x1072120")]
			get
			{
				return null;
			}
			[Address(RVA="0x2343084", Offset="0x2343084", VA="0x2343084")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072130", Offset="0x1072130")]
			private set
			{
			}
		}

		protected Func<DiContainer, IProvider> ProviderFunc
		{
			[Address(RVA="0x234308C", Offset="0x234308C", VA="0x234308C")]
			get
			{
				return null;
			}
			[Address(RVA="0x23430E0", Offset="0x23430E0", VA="0x23430E0")]
			set
			{
			}
		}

		protected object SubIdentifier
		{
			[Address(RVA="0x2343154", Offset="0x2343154", VA="0x2343154")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072160", Offset="0x1072160")]
			get
			{
				return null;
			}
			[Address(RVA="0x234315C", Offset="0x234315C", VA="0x234315C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072170", Offset="0x1072170")]
			private set
			{
			}
		}

		[Address(RVA="0x2342F74", Offset="0x2342F74", VA="0x2342F74")]
		public FactorySubContainerBinderBase(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, object subIdentifier)
		{
		}

		[Address(RVA="0x2AF7030", Offset="0x2AF7030", VA="0x2AF7030")]
		public ArgConditionCopyNonLazyBinder ByInstaller<TInstaller>()
		where TInstaller : InstallerBase
		{
			return null;
		}

		[Address(RVA="0x23431D8", Offset="0x23431D8", VA="0x23431D8")]
		public ArgConditionCopyNonLazyBinder ByInstaller(Type installerType)
		{
			return null;
		}

		[Address(RVA="0x2AFB060", Offset="0x2AFB060", VA="0x2AFB060")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabInstaller<TInstaller>(UnityEngine.Object prefab)
		where TInstaller : InstallerBase
		{
			return null;
		}

		[Address(RVA="0x23433C4", Offset="0x23433C4", VA="0x23433C4")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabInstaller(UnityEngine.Object prefab, Type installerType)
		{
			return null;
		}

		[Address(RVA="0x2AFB110", Offset="0x2AFB110", VA="0x2AFB110")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceInstaller<TInstaller>(string resourcePath)
		where TInstaller : InstallerBase
		{
			return null;
		}

		[Address(RVA="0x23435F8", Offset="0x23435F8", VA="0x23435F8")]
		public NameTransformConditionCopyNonLazyBinder ByNewPrefabResourceInstaller(string resourcePath, Type installerType)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D808", Offset="0x104D808")]
		private sealed class <>c__DisplayClass19_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public Type installerType;

			[Address(RVA="0x2342A8C", Offset="0x2342A8C", VA="0x2342A8C")]
			public <>c__DisplayClass19_0()
			{
			}

			[Address(RVA="0x2342AB8", Offset="0x2342AB8", VA="0x2342AB8")]
			internal IProvider <ByInstaller>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D818", Offset="0x104D818")]
		private sealed class <>c__DisplayClass21_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Type installerType;

			[Address(RVA="0x2342C04", Offset="0x2342C04", VA="0x2342C04")]
			public <>c__DisplayClass21_0()
			{
			}

			[Address(RVA="0x2342C30", Offset="0x2342C30", VA="0x2342C30")]
			internal IProvider <ByNewPrefabInstaller>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D828", Offset="0x104D828")]
		private sealed class <>c__DisplayClass23_0
		{
			[FieldOffset(Offset="0x0")]
			public FactorySubContainerBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public Type installerType;

			[Address(RVA="0x2342DBC", Offset="0x2342DBC", VA="0x2342DBC")]
			public <>c__DisplayClass23_0()
			{
			}

			[Address(RVA="0x2342DE8", Offset="0x2342DE8", VA="0x2342DE8")]
			internal IProvider <ByNewPrefabResourceInstaller>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}