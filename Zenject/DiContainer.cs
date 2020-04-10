using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class DiContainer : IInstantiator
	{
		[FieldOffset(Offset="0x0")]
		public const string DependencyRootIdentifier = "DependencyRoot";

		[FieldOffset(Offset="0x10")]
		private readonly Dictionary<BindingId, List<DiContainer.ProviderInfo>> _providers;

		[FieldOffset(Offset="0x18")]
		private readonly List<DiContainer> _parentContainers;

		[FieldOffset(Offset="0x20")]
		private readonly List<DiContainer> _ancestorContainers;

		[FieldOffset(Offset="0x28")]
		private readonly Stack<DiContainer.LookupId> _resolvesInProgress;

		[FieldOffset(Offset="0x30")]
		private readonly Zenject.SingletonProviderCreator _singletonProviderCreator;

		[FieldOffset(Offset="0x38")]
		private readonly Zenject.SingletonMarkRegistry _singletonMarkRegistry;

		[FieldOffset(Offset="0x40")]
		private readonly LazyInstanceInjector _lazyInjector;

		[FieldOffset(Offset="0x48")]
		private readonly Queue<IBindingFinalizer> _currentBindings;

		[FieldOffset(Offset="0x50")]
		private readonly List<IBindingFinalizer> _childBindings;

		[FieldOffset(Offset="0x58")]
		private readonly List<ILazy> _lateBindingsToValidate;

		[FieldOffset(Offset="0x60")]
		private bool _isFinalizingBinding;

		[FieldOffset(Offset="0x61")]
		private bool _isValidating;

		[FieldOffset(Offset="0x62")]
		private bool _isInstalling;

		[FieldOffset(Offset="0x63")]
		private bool _hasDisplayedInstallWarning;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10606C4", Offset="0x10606C4")]
		[FieldOffset(Offset="0x64")]
		private bool <ShouldCheckForInstallWarning>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10606D4", Offset="0x10606D4")]
		[FieldOffset(Offset="0x65")]
		private bool <AssertOnNewGameObjects>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10606E4", Offset="0x10606E4")]
		[FieldOffset(Offset="0x68")]
		private Transform <DefaultParent>k__BackingField;

		public IEnumerable<BindingId> AllContracts
		{
			[Address(RVA="0x15B4A18", Offset="0x15B4A18", VA="0x15B4A18")]
			get
			{
				return null;
			}
		}

		public bool AssertOnNewGameObjects
		{
			[Address(RVA="0x15B49D0", Offset="0x15B49D0", VA="0x15B49D0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072BF8", Offset="0x1072BF8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x15B49D8", Offset="0x15B49D8", VA="0x15B49D8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072C08", Offset="0x1072C08")]
			set
			{
			}
		}

		public bool ChecksForCircularDependencies
		{
			[Address(RVA="0x15B49FC", Offset="0x15B49FC", VA="0x15B49FC")]
			get
			{
				return new bool();
			}
		}

		public Transform DefaultParent
		{
			[Address(RVA="0x15B49B0", Offset="0x15B49B0", VA="0x15B49B0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072C18", Offset="0x1072C18")]
			get
			{
				return null;
			}
			[Address(RVA="0x15B49B8", Offset="0x15B49B8", VA="0x15B49B8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072C28", Offset="0x1072C28")]
			set
			{
			}
		}

		public bool IsInstalling
		{
			[Address(RVA="0x15B4A04", Offset="0x15B4A04", VA="0x15B4A04")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x15B4A0C", Offset="0x15B4A0C", VA="0x15B4A0C")]
			set
			{
			}
		}

		public bool IsValidating
		{
			[Address(RVA="0x15A97A8", Offset="0x15A97A8", VA="0x15A97A8")]
			get
			{
				return new bool();
			}
		}

		public IEnumerable<DiContainer> ParentContainers
		{
			[Address(RVA="0x15B49F4", Offset="0x15B49F4", VA="0x15B49F4")]
			get
			{
				return null;
			}
		}

		public bool ShouldCheckForInstallWarning
		{
			[Address(RVA="0x15B49C8", Offset="0x15B49C8", VA="0x15B49C8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072BD8", Offset="0x1072BD8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x15B3840", Offset="0x15B3840", VA="0x15B3840")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072BE8", Offset="0x1072BE8")]
			set
			{
			}
		}

		internal Zenject.SingletonMarkRegistry SingletonMarkRegistry
		{
			[Address(RVA="0x15B49E4", Offset="0x15B49E4", VA="0x15B49E4")]
			get
			{
				return null;
			}
		}

		internal Zenject.SingletonProviderCreator SingletonProviderCreator
		{
			[Address(RVA="0x15B49EC", Offset="0x15B49EC", VA="0x15B49EC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15B362C", Offset="0x15B362C", VA="0x15B362C")]
		public DiContainer(bool isValidating)
		{
		}

		[Address(RVA="0x15B4014", Offset="0x15B4014", VA="0x15B4014")]
		public DiContainer()
		{
		}

		[Address(RVA="0x15B401C", Offset="0x15B401C", VA="0x15B401C")]
		public DiContainer(IEnumerable<DiContainer> parentContainers, bool isValidating)
		{
		}

		[Address(RVA="0x15B49C0", Offset="0x15B49C0", VA="0x15B49C0")]
		public DiContainer(IEnumerable<DiContainer> parentContainers)
		{
		}

		[Address(RVA="0x15BD060", Offset="0x15BD060", VA="0x15BD060")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072D00", Offset="0x1072D00")]
		private DiContainer.ProviderPair <GetLocalProviderPairs>b__60_0(DiContainer.ProviderInfo x)
		{
			return null;
		}

		[Address(RVA="0x15BD0D4", Offset="0x15BD0D4", VA="0x15BD0D4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072D10", Offset="0x1072D10")]
		private <>f__AnonymousType0<DiContainer.ProviderPair, int> <TryGetUniqueProvider>b__73_0(DiContainer.ProviderPair x)
		{
			return null;
		}

		[Address(RVA="0x2AF7530", Offset="0x2AF7530", VA="0x2AF7530")]
		public ConcreteIdBinderGeneric<TContract> Bind<TContract>()
		{
			return null;
		}

		[Address(RVA="0x2AF75F8", Offset="0x2AF75F8", VA="0x2AF75F8")]
		internal ConcreteIdBinderGeneric<TContract> Bind<TContract>(BindInfo bindInfo)
		{
			return null;
		}

		[Address(RVA="0x15B15C8", Offset="0x15B15C8", VA="0x15B15C8")]
		public ConcreteIdBinderNonGeneric Bind(params Type[] contractTypes)
		{
			return null;
		}

		[Address(RVA="0x15BB9C4", Offset="0x15BB9C4", VA="0x15BB9C4")]
		public ConcreteIdBinderNonGeneric Bind(IEnumerable<Type> contractTypes)
		{
			return null;
		}

		[Address(RVA="0x15BBBC4", Offset="0x15BBBC4", VA="0x15BBBC4")]
		public ConcreteIdBinderNonGeneric Bind(Action<ConventionSelectTypesBinder> generator)
		{
			return null;
		}

		[Address(RVA="0x16A6FF4", Offset="0x16A6FF4", VA="0x16A6FF4")]
		public void BindDisposableExecutionOrder<T>(int order)
		where T : IDisposable
		{
		}

		[Address(RVA="0x15BCC64", Offset="0x15BCC64", VA="0x15BCC64")]
		public void BindDisposableExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x16A7098", Offset="0x16A7098", VA="0x16A7098")]
		public void BindExecutionOrder<T>(int order)
		{
		}

		[Address(RVA="0x15BC8D8", Offset="0x15BC8D8", VA="0x15BC8D8")]
		public void BindExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x2AF9938", Offset="0x2AF9938", VA="0x2AF9938")]
		public FactoryToChoiceIdBinder<TContract> BindFactory<TContract, TFactory>()
		where TFactory : Factory<TContract>
		{
			return null;
		}

		[Address(RVA="0x2AF9B7C", Offset="0x2AF9B7C", VA="0x2AF9B7C")]
		public FactoryToChoiceIdBinder<TParam1, TContract> BindFactory<TParam1, TContract, TFactory>()
		where TFactory : Factory<TParam1, TContract>
		{
			return null;
		}

		[Address(RVA="0x2AF9DC0", Offset="0x2AF9DC0", VA="0x2AF9DC0")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TContract> BindFactory<TParam1, TParam2, TContract, TFactory>()
		where TFactory : Factory<TParam1, TParam2, TContract>
		{
			return null;
		}

		[Address(RVA="0x2AFA004", Offset="0x2AFA004", VA="0x2AFA004")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TContract> BindFactory<TParam1, TParam2, TParam3, TContract, TFactory>()
		where TFactory : Factory<TParam1, TParam2, TParam3, TContract>
		{
			return null;
		}

		[Address(RVA="0x2AFA248", Offset="0x2AFA248", VA="0x2AFA248")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TContract> BindFactory<TParam1, TParam2, TParam3, TParam4, TContract, TFactory>()
		where TFactory : Factory<TParam1, TParam2, TParam3, TParam4, TContract>
		{
			return null;
		}

		[Address(RVA="0x2AFA48C", Offset="0x2AFA48C", VA="0x2AFA48C")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> BindFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TContract, TFactory>()
		where TFactory : Factory<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>
		{
			return null;
		}

		[Address(RVA="0x2AF9970", Offset="0x2AF9970", VA="0x2AF9970")]
		public FactoryToChoiceIdBinder<TContract> BindFactoryContract<TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : Factory<TContract>, TFactoryContract
		{
			return null;
		}

		[Address(RVA="0x2AF9BB4", Offset="0x2AF9BB4", VA="0x2AF9BB4")]
		public FactoryToChoiceIdBinder<TParam1, TContract> BindFactoryContract<TParam1, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : Factory<TParam1, TContract>, TFactoryContract
		{
			return null;
		}

		[Address(RVA="0x2AF9DF8", Offset="0x2AF9DF8", VA="0x2AF9DF8")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TContract> BindFactoryContract<TParam1, TParam2, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : Factory<TParam1, TParam2, TContract>, TFactoryContract
		{
			return null;
		}

		[Address(RVA="0x2AFA03C", Offset="0x2AFA03C", VA="0x2AFA03C")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TContract> BindFactoryContract<TParam1, TParam2, TParam3, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : Factory<TParam1, TParam2, TParam3, TContract>, TFactoryContract
		{
			return null;
		}

		[Address(RVA="0x2AFA280", Offset="0x2AFA280", VA="0x2AFA280")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TContract> BindFactoryContract<TParam1, TParam2, TParam3, TParam4, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : Factory<TParam1, TParam2, TParam3, TParam4, TContract>, TFactoryContract
		{
			return null;
		}

		[Address(RVA="0x2AFA4C4", Offset="0x2AFA4C4", VA="0x2AFA4C4")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> BindFactoryContract<TParam1, TParam2, TParam3, TParam4, TParam5, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : Factory<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>, TFactoryContract
		{
			return null;
		}

		[Address(RVA="0x2AF99A8", Offset="0x2AF99A8", VA="0x2AF99A8")]
		private FactoryToChoiceIdBinder<TContract> BindFactoryInternal<TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : TFactoryContract, IFactory
		{
			return null;
		}

		[Address(RVA="0x2AF9BEC", Offset="0x2AF9BEC", VA="0x2AF9BEC")]
		private FactoryToChoiceIdBinder<TParam1, TContract> BindFactoryInternal<TParam1, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : TFactoryContract, IFactory
		{
			return null;
		}

		[Address(RVA="0x2AF9E30", Offset="0x2AF9E30", VA="0x2AF9E30")]
		private FactoryToChoiceIdBinder<TParam1, TParam2, TContract> BindFactoryInternal<TParam1, TParam2, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : TFactoryContract, IFactory
		{
			return null;
		}

		[Address(RVA="0x2AFA074", Offset="0x2AFA074", VA="0x2AFA074")]
		private FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TContract> BindFactoryInternal<TParam1, TParam2, TParam3, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : TFactoryContract, IFactory
		{
			return null;
		}

		[Address(RVA="0x2AFA2B8", Offset="0x2AFA2B8", VA="0x2AFA2B8")]
		private FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TContract> BindFactoryInternal<TParam1, TParam2, TParam3, TParam4, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : TFactoryContract, IFactory
		{
			return null;
		}

		[Address(RVA="0x2AFA4FC", Offset="0x2AFA4FC", VA="0x2AFA4FC")]
		private FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> BindFactoryInternal<TParam1, TParam2, TParam3, TParam4, TParam5, TContract, TFactoryContract, TFactoryConcrete>()
		where TFactoryContract : IFactory
		where TFactoryConcrete : TFactoryContract, IFactory
		{
			return null;
		}

		[Address(RVA="0x16A713C", Offset="0x16A713C", VA="0x16A713C")]
		public void BindFixedTickableExecutionOrder<T>(int order)
		where T : IFixedTickable
		{
		}

		[Address(RVA="0x15BCE20", Offset="0x15BCE20", VA="0x15BCE20")]
		public void BindFixedTickableExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x2AF9B44", Offset="0x2AF9B44", VA="0x2AF9B44")]
		public FactoryToChoiceIdBinder<TContract> BindIFactory<TContract>()
		{
			return null;
		}

		[Address(RVA="0x2AF9D88", Offset="0x2AF9D88", VA="0x2AF9D88")]
		public FactoryToChoiceIdBinder<TParam1, TContract> BindIFactory<TParam1, TContract>()
		{
			return null;
		}

		[Address(RVA="0x2AF9FCC", Offset="0x2AF9FCC", VA="0x2AF9FCC")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TContract> BindIFactory<TParam1, TParam2, TContract>()
		{
			return null;
		}

		[Address(RVA="0x2AFA210", Offset="0x2AFA210", VA="0x2AFA210")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TContract> BindIFactory<TParam1, TParam2, TParam3, TContract>()
		{
			return null;
		}

		[Address(RVA="0x2AFA454", Offset="0x2AFA454", VA="0x2AFA454")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TContract> BindIFactory<TParam1, TParam2, TParam3, TParam4, TContract>()
		{
			return null;
		}

		[Address(RVA="0x2AFA698", Offset="0x2AFA698", VA="0x2AFA698")]
		public FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> BindIFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>()
		{
			return null;
		}

		[Address(RVA="0x16A71E0", Offset="0x16A71E0", VA="0x16A71E0")]
		public void BindInitializableExecutionOrder<T>(int order)
		where T : IInitializable
		{
		}

		[Address(RVA="0x15BCB98", Offset="0x15BCB98", VA="0x15BCB98")]
		public void BindInitializableExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x2AFAC1C", Offset="0x2AFAC1C", VA="0x2AFAC1C")]
		public IdScopeConditionCopyNonLazyBinder BindInstance<TContract>(TContract instance)
		{
			return null;
		}

		[Address(RVA="0x15BC2B8", Offset="0x15BC2B8", VA="0x15BC2B8")]
		public void BindInstances(params object[] instances)
		{
		}

		[Address(RVA="0x2AFA9AC", Offset="0x2AFA9AC", VA="0x2AFA9AC")]
		public FromBinderNonGeneric BindInterfacesAndSelfTo<T>()
		{
			return null;
		}

		[Address(RVA="0x15BC068", Offset="0x15BC068", VA="0x15BC068")]
		public FromBinderNonGeneric BindInterfacesAndSelfTo(Type type)
		{
			return null;
		}

		[Address(RVA="0x2AFAA48", Offset="0x2AFAA48", VA="0x2AFAA48")]
		public FromBinderNonGeneric BindInterfacesTo<T>()
		{
			return null;
		}

		[Address(RVA="0x15BBE9C", Offset="0x15BBE9C", VA="0x15BBE9C")]
		public FromBinderNonGeneric BindInterfacesTo(Type type)
		{
			return null;
		}

		[Address(RVA="0x15BB9CC", Offset="0x15BB9CC", VA="0x15BB9CC")]
		private ConcreteIdBinderNonGeneric BindInternal(IEnumerable<Type> contractTypes, string contextInfo)
		{
			return null;
		}

		[Address(RVA="0x15BBA60", Offset="0x15BBA60", VA="0x15BBA60")]
		private ConcreteIdBinderNonGeneric BindInternal(BindInfo bindInfo)
		{
			return null;
		}

		[Address(RVA="0x16A7284", Offset="0x16A7284", VA="0x16A7284")]
		public void BindLateDisposableExecutionOrder<T>(int order)
		where T : ILateDisposable
		{
		}

		[Address(RVA="0x15BCD30", Offset="0x15BCD30", VA="0x15BCD30")]
		public void BindLateDisposableExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x16A7328", Offset="0x16A7328", VA="0x16A7328")]
		public void BindLateTickableExecutionOrder<T>(int order)
		where T : ILateTickable
		{
		}

		[Address(RVA="0x15BCF40", Offset="0x15BCF40", VA="0x15BCF40")]
		public void BindLateTickableExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x2AFB028", Offset="0x2AFB028", VA="0x2AFB028")]
		public MemoryPoolInitialSizeBinder<TItemContract> BindMemoryPool<TItemContract>()
		{
			return null;
		}

		[Address(RVA="0x2AFAFF0", Offset="0x2AFAFF0", VA="0x2AFAFF0")]
		public MemoryPoolInitialSizeBinder<TItemContract> BindMemoryPool<TItemContract, TPool>()
		where TPool : IMemoryPool
		{
			return null;
		}

		[Address(RVA="0x2AFADD4", Offset="0x2AFADD4", VA="0x2AFADD4")]
		public MemoryPoolInitialSizeBinder<TItemContract> BindMemoryPool<TItemContract, TPoolConcrete, TPoolContract>()
		where TPoolConcrete : TPoolContract, IMemoryPool
		where TPoolContract : IMemoryPool
		{
			return null;
		}

		[Address(RVA="0x16A73CC", Offset="0x16A73CC", VA="0x16A73CC")]
		public void BindRootResolve<TContract>()
		{
		}

		[Address(RVA="0x15BBDC8", Offset="0x15BBDC8", VA="0x15BBDC8")]
		public void BindRootResolve(IEnumerable<Type> rootTypes)
		{
		}

		[Address(RVA="0x16A7408", Offset="0x16A7408", VA="0x16A7408")]
		public void BindRootResolveId<TContract>(object identifier)
		{
		}

		[Address(RVA="0x15BBDD0", Offset="0x15BBDD0", VA="0x15BBDD0")]
		public void BindRootResolveId(IEnumerable<Type> rootTypes, object identifier)
		{
		}

		[Address(RVA="0x16A7520", Offset="0x16A7520", VA="0x16A7520")]
		public void BindTickableExecutionOrder<T>(int order)
		where T : ITickable
		{
		}

		[Address(RVA="0x15BCACC", Offset="0x15BCACC", VA="0x15BCACC")]
		public void BindTickableExecutionOrder(Type type, int order)
		{
		}

		[Address(RVA="0x15A97B0", Offset="0x15A97B0", VA="0x15A97B0")]
		public static bool CanCreateOrInjectDuringValidation(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x15B6284", Offset="0x15B6284", VA="0x15B6284")]
		private void CheckForInstallWarning(InjectContext context)
		{
		}

		[Address(RVA="0x15B8D98", Offset="0x15B8D98", VA="0x15B8D98")]
		internal GameObject CreateAndParentPrefab(UnityEngine.Object prefab, GameObjectCreationParameters gameObjectBindInfo, InjectContext context, out bool shouldMakeActive)
		{
			shouldMakeActive = false;
			return null;
		}

		[Address(RVA="0x15B8C18", Offset="0x15B8C18", VA="0x15B8C18")]
		internal GameObject CreateAndParentPrefabResource(string resourcePath, GameObjectCreationParameters gameObjectBindInfo, InjectContext context, out bool shouldMakeActive)
		{
			shouldMakeActive = false;
			return null;
		}

		[Address(RVA="0x15B9C24", Offset="0x15B9C24", VA="0x15B9C24", Slot="34")]
		public GameObject CreateEmptyGameObject(string name)
		{
			return null;
		}

		[Address(RVA="0x15AB0E4", Offset="0x15AB0E4", VA="0x15AB0E4")]
		public GameObject CreateEmptyGameObject(GameObjectCreationParameters gameObjectBindInfo, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15B3CE8", Offset="0x15B3CE8", VA="0x15B3CE8")]
		private object CreateLazyBinding(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15B5770", Offset="0x15B5770", VA="0x15B5770")]
		public DiContainer CreateSubContainer()
		{
			return null;
		}

		[Address(RVA="0x15B5778", Offset="0x15B5778", VA="0x15B5778")]
		private DiContainer CreateSubContainer(bool isValidating)
		{
			return null;
		}

		[Address(RVA="0x15B45A4", Offset="0x15B45A4", VA="0x15B45A4")]
		private List<DiContainer> FlattenInheritanceChain()
		{
			return null;
		}

		[Address(RVA="0x15B3AB8", Offset="0x15B3AB8", VA="0x15B3AB8")]
		public void FlushBindings()
		{
		}

		[Address(RVA="0x15B588C", Offset="0x15B588C", VA="0x15B588C")]
		public void FlushInjectQueue()
		{
		}

		[Address(RVA="0x15B5FF8", Offset="0x15B5FF8", VA="0x15B5FF8")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072C38", Offset="0x1072C38")]
		private IEnumerable<DiContainer> GetAllContainersToLookup(InjectSources sourceType)
		{
			return null;
		}

		[Address(RVA="0x15B5A68", Offset="0x15B5A68", VA="0x15B5A68")]
		internal List<IProvider> GetAllProviderMatches(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15B7BC4", Offset="0x15B7BC4", VA="0x15B7BC4")]
		private int GetContainerHeirarchyDistance(DiContainer container)
		{
			return new int();
		}

		[Address(RVA="0x15B7C38", Offset="0x15B7C38", VA="0x15B7C38")]
		private int? GetContainerHeirarchyDistance(DiContainer container, int depth)
		{
			return null;
		}

		[Address(RVA="0x135586C", Offset="0x135586C", VA="0x135586C")]
		public IEnumerable<Type> GetDependencyContracts<TContract>()
		{
			return null;
		}

		[Address(RVA="0x15B7E24", Offset="0x15B7E24", VA="0x15B7E24")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072C9C", Offset="0x1072C9C")]
		public IEnumerable<Type> GetDependencyContracts(Type contract)
		{
			return null;
		}

		[Address(RVA="0x15B6090", Offset="0x15B6090", VA="0x15B6090")]
		private IEnumerable<DiContainer.ProviderPair> GetLocalProviderPairs(BindingId bindingId)
		{
			return null;
		}

		[Address(RVA="0x15B6138", Offset="0x15B6138", VA="0x15B6138")]
		private List<DiContainer.ProviderInfo> GetLocalProviders(BindingId bindingId)
		{
			return null;
		}

		[Address(RVA="0x15B93F4", Offset="0x15B93F4", VA="0x15B93F4")]
		private GameObject GetPrefabAsGameObject(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x15B5B8C", Offset="0x15B5B8C", VA="0x15B5B8C")]
		private IEnumerable<DiContainer.ProviderPair> GetProviderMatchesInternal(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15B5CE4", Offset="0x15B5CE4", VA="0x15B5CE4")]
		private IEnumerable<DiContainer.ProviderPair> GetProvidersForContract(BindingId bindingId, InjectSources sourceType)
		{
			return null;
		}

		[Address(RVA="0x15B95E4", Offset="0x15B95E4", VA="0x15B95E4")]
		private Transform GetTransformGroup(GameObjectCreationParameters gameObjectBindInfo, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15BB700", Offset="0x15BB700", VA="0x15BB700")]
		public bool HasBinding(InjectContext context)
		{
			return new bool();
		}

		[Address(RVA="0x1352254", Offset="0x1352254", VA="0x1352254")]
		public bool HasBinding<TContract>()
		{
			return new bool();
		}

		[Address(RVA="0x15BB77C", Offset="0x15BB77C", VA="0x15BB77C")]
		public bool HasBinding(Type contractType)
		{
			return new bool();
		}

		[Address(RVA="0x13522F0", Offset="0x13522F0", VA="0x13522F0")]
		public bool HasBindingId<TContract>(object identifier)
		{
			return new bool();
		}

		[Address(RVA="0x15BB784", Offset="0x15BB784", VA="0x15BB784")]
		public bool HasBindingId(Type contractType, object identifier)
		{
			return new bool();
		}

		[Address(RVA="0x15B0AFC", Offset="0x15B0AFC", VA="0x15B0AFC")]
		public void Inject(object injectable)
		{
		}

		[Address(RVA="0x15BB0A4", Offset="0x15BB0A4", VA="0x15BB0A4")]
		public void Inject(object injectable, IEnumerable<object> extraArgs)
		{
		}

		[Address(RVA="0x15B8828", Offset="0x15B8828", VA="0x15B8828")]
		public void InjectExplicit(object injectable, List<TypeValuePair> extraArgs)
		{
		}

		[Address(RVA="0x15A9858", Offset="0x15A9858", VA="0x15A9858")]
		public void InjectExplicit(object injectable, Type injectableType, InjectArgs args)
		{
		}

		[Address(RVA="0x15BA2B8", Offset="0x15BA2B8", VA="0x15BA2B8")]
		public void InjectGameObject(GameObject gameObject)
		{
		}

		[Address(RVA="0x1573DD4", Offset="0x1573DD4", VA="0x1573DD4")]
		public T InjectGameObjectForComponent<T>(GameObject gameObject)
		where T : Component
		{
			return null;
		}

		[Address(RVA="0x1573E60", Offset="0x1573E60", VA="0x1573E60")]
		public T InjectGameObjectForComponent<T>(GameObject gameObject, IEnumerable<object> extraArgs)
		where T : Component
		{
			return null;
		}

		[Address(RVA="0x15BAC70", Offset="0x15BAC70", VA="0x15BAC70")]
		public object InjectGameObjectForComponent(GameObject gameObject, Type componentType, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BAD68", Offset="0x15BAD68", VA="0x15BAD68")]
		public Component InjectGameObjectForComponentExplicit(GameObject gameObject, Type componentType, InjectArgs args)
		{
			return null;
		}

		[Address(RVA="0x16A75C4", Offset="0x16A75C4", VA="0x16A75C4")]
		public void Install<TInstaller>()
		where TInstaller : Installer
		{
		}

		[Address(RVA="0x16A7618", Offset="0x16A7618", VA="0x16A7618")]
		public void Install<TInstaller>(object[] extraArgs)
		where TInstaller : Installer
		{
		}

		[Address(RVA="0x15B384C", Offset="0x15B384C", VA="0x15B384C")]
		private void InstallDefaultBindings()
		{
		}

		[Address(RVA="0x1573F98", Offset="0x1573F98", VA="0x1573F98", Slot="4")]
		public T Instantiate<T>()
		{
			return null;
		}

		[Address(RVA="0x157401C", Offset="0x157401C", VA="0x157401C", Slot="5")]
		public T Instantiate<T>(IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15B0A90", Offset="0x15B0A90", VA="0x15B0A90", Slot="6")]
		public object Instantiate(Type concreteType)
		{
			return null;
		}

		[Address(RVA="0x15B9CB4", Offset="0x15B9CB4", VA="0x15B9CB4", Slot="7")]
		public object Instantiate(Type concreteType, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15752AC", Offset="0x15752AC", VA="0x15752AC", Slot="8")]
		public TContract InstantiateComponent<TContract>(GameObject gameObject)
		where TContract : Component
		{
			return null;
		}

		[Address(RVA="0x1575338", Offset="0x1575338", VA="0x1575338", Slot="9")]
		public TContract InstantiateComponent<TContract>(GameObject gameObject, IEnumerable<object> extraArgs)
		where TContract : Component
		{
			return null;
		}

		[Address(RVA="0x15B9E30", Offset="0x15B9E30", VA="0x15B9E30", Slot="10")]
		public Component InstantiateComponent(Type componentType, GameObject gameObject)
		{
			return null;
		}

		[Address(RVA="0x15B9EAC", Offset="0x15B9EAC", VA="0x15B9EAC", Slot="11")]
		public Component InstantiateComponent(Type componentType, GameObject gameObject, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15B9EF4", Offset="0x15B9EF4", VA="0x15B9EF4")]
		public Component InstantiateComponentExplicit(Type componentType, GameObject gameObject, List<TypeValuePair> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15741D0", Offset="0x15741D0", VA="0x15741D0", Slot="12")]
		public T InstantiateComponentOnNewGameObject<T>()
		where T : Component
		{
			return null;
		}

		[Address(RVA="0x1574290", Offset="0x1574290", VA="0x1574290", Slot="14")]
		public T InstantiateComponentOnNewGameObject<T>(IEnumerable<object> extraArgs)
		where T : Component
		{
			return null;
		}

		[Address(RVA="0x1574358", Offset="0x1574358", VA="0x1574358", Slot="13")]
		public T InstantiateComponentOnNewGameObject<T>(string gameObjectName)
		where T : Component
		{
			return null;
		}

		[Address(RVA="0x15743E4", Offset="0x15743E4", VA="0x15743E4", Slot="15")]
		public T InstantiateComponentOnNewGameObject<T>(string gameObjectName, IEnumerable<object> extraArgs)
		where T : Component
		{
			return null;
		}

		[Address(RVA="0x1574468", Offset="0x1574468", VA="0x1574468")]
		public T InstantiateExplicit<T>(List<TypeValuePair> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15B9D54", Offset="0x15B9D54", VA="0x15B9D54")]
		public object InstantiateExplicit(Type concreteType, List<TypeValuePair> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BC43C", Offset="0x15BC43C", VA="0x15BC43C")]
		public object InstantiateExplicit(Type concreteType, bool autoInject, InjectArgs args)
		{
			return null;
		}

		[Address(RVA="0x15B7EBC", Offset="0x15B7EBC", VA="0x15B7EBC")]
		private object InstantiateInternal(Type concreteType, bool autoInject, InjectArgs args)
		{
			return null;
		}

		[Address(RVA="0x15B9FAC", Offset="0x15B9FAC", VA="0x15B9FAC", Slot="16")]
		public GameObject InstantiatePrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x15BA0B0", Offset="0x15BA0B0", VA="0x15BA0B0", Slot="17")]
		public GameObject InstantiatePrefab(UnityEngine.Object prefab, Transform parentTransform)
		{
			return null;
		}

		[Address(RVA="0x15BA144", Offset="0x15BA144", VA="0x15BA144")]
		public GameObject InstantiatePrefab(UnityEngine.Object prefab, Vector3 position, Quaternion rotation, Transform parentTransform)
		{
			return null;
		}

		[Address(RVA="0x15BA02C", Offset="0x15BA02C", VA="0x15BA02C")]
		public GameObject InstantiatePrefab(UnityEngine.Object prefab, GameObjectCreationParameters gameObjectBindInfo)
		{
			return null;
		}

		[Address(RVA="0x1574598", Offset="0x1574598", VA="0x1574598", Slot="20")]
		public T InstantiatePrefabForComponent<T>(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x15746EC", Offset="0x15746EC", VA="0x15746EC", Slot="21")]
		public T InstantiatePrefabForComponent<T>(UnityEngine.Object prefab, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x1574828", Offset="0x1574828", VA="0x1574828", Slot="22")]
		public T InstantiatePrefabForComponent<T>(UnityEngine.Object prefab, Transform parentTransform)
		{
			return null;
		}

		[Address(RVA="0x1574988", Offset="0x1574988", VA="0x1574988", Slot="23")]
		public T InstantiatePrefabForComponent<T>(UnityEngine.Object prefab, Transform parentTransform, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BA688", Offset="0x15BA688", VA="0x15BA688", Slot="24")]
		public object InstantiatePrefabForComponent(Type concreteType, UnityEngine.Object prefab, Transform parentTransform, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BA740", Offset="0x15BA740", VA="0x15BA740")]
		public object InstantiatePrefabForComponent(Type concreteType, UnityEngine.Object prefab, IEnumerable<object> extraArgs, GameObjectCreationParameters creationInfo)
		{
			return null;
		}

		[Address(RVA="0x15BC840", Offset="0x15BC840", VA="0x15BC840")]
		public object InstantiatePrefabForComponentExplicit(Type componentType, UnityEngine.Object prefab, List<TypeValuePair> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BA790", Offset="0x15BA790", VA="0x15BA790")]
		public object InstantiatePrefabForComponentExplicit(Type componentType, UnityEngine.Object prefab, List<TypeValuePair> extraArgs, GameObjectCreationParameters gameObjectBindInfo)
		{
			return null;
		}

		[Address(RVA="0x15BC6FC", Offset="0x15BC6FC", VA="0x15BC6FC")]
		public object InstantiatePrefabForComponentExplicit(Type componentType, UnityEngine.Object prefab, InjectArgs args, GameObjectCreationParameters gameObjectBindInfo)
		{
			return null;
		}

		[Address(RVA="0x15BA40C", Offset="0x15BA40C", VA="0x15BA40C", Slot="18")]
		public GameObject InstantiatePrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x15BA5F4", Offset="0x15BA5F4", VA="0x15BA5F4", Slot="19")]
		public GameObject InstantiatePrefabResource(string resourcePath, Transform parentTransform)
		{
			return null;
		}

		[Address(RVA="0x15BA48C", Offset="0x15BA48C", VA="0x15BA48C")]
		public GameObject InstantiatePrefabResource(string resourcePath, GameObjectCreationParameters creationInfo)
		{
			return null;
		}

		[Address(RVA="0x1574AD0", Offset="0x1574AD0", VA="0x1574AD0", Slot="25")]
		public T InstantiatePrefabResourceForComponent<T>(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1574C24", Offset="0x1574C24", VA="0x1574C24", Slot="26")]
		public T InstantiatePrefabResourceForComponent<T>(string resourcePath, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x1574D60", Offset="0x1574D60", VA="0x1574D60", Slot="27")]
		public T InstantiatePrefabResourceForComponent<T>(string resourcePath, Transform parentTransform)
		{
			return null;
		}

		[Address(RVA="0x1574EC0", Offset="0x1574EC0", VA="0x1574EC0", Slot="28")]
		public T InstantiatePrefabResourceForComponent<T>(string resourcePath, Transform parentTransform, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BA868", Offset="0x15BA868", VA="0x15BA868", Slot="29")]
		public object InstantiatePrefabResourceForComponent(Type concreteType, string resourcePath, Transform parentTransform, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BA960", Offset="0x15BA960", VA="0x15BA960")]
		public object InstantiatePrefabResourceForComponentExplicit(Type componentType, string resourcePath, List<TypeValuePair> extraArgs, GameObjectCreationParameters creationInfo)
		{
			return null;
		}

		[Address(RVA="0x15BC57C", Offset="0x15BC57C", VA="0x15BC57C")]
		public object InstantiatePrefabResourceForComponentExplicit(Type componentType, string resourcePath, InjectArgs args, GameObjectCreationParameters creationInfo)
		{
			return null;
		}

		[Address(RVA="0x1575008", Offset="0x1575008", VA="0x1575008", Slot="30")]
		public T InstantiateScriptableObjectResource<T>(string resourcePath)
		where T : ScriptableObject
		{
			return null;
		}

		[Address(RVA="0x1575094", Offset="0x1575094", VA="0x1575094", Slot="31")]
		public T InstantiateScriptableObjectResource<T>(string resourcePath, IEnumerable<object> extraArgs)
		where T : ScriptableObject
		{
			return null;
		}

		[Address(RVA="0x15BAA38", Offset="0x15BAA38", VA="0x15BAA38", Slot="32")]
		public object InstantiateScriptableObjectResource(Type scriptableObjectType, string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x15BAAAC", Offset="0x15BAAAC", VA="0x15BAAAC", Slot="33")]
		public object InstantiateScriptableObjectResource(Type scriptableObjectType, string resourcePath, IEnumerable<object> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15BAB38", Offset="0x15BAB38", VA="0x15BAB38")]
		public object InstantiateScriptableObjectResourceExplicit(Type scriptableObjectType, string resourcePath, List<TypeValuePair> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x15B58BC", Offset="0x15B58BC", VA="0x15B58BC")]
		internal void OnInstanceResolved(object instance)
		{
		}

		[Address(RVA="0x15B5854", Offset="0x15B5854", VA="0x15B5854")]
		public void QueueForInject(object instance)
		{
		}

		[Address(RVA="0x2AF7468", Offset="0x2AF7468", VA="0x2AF7468")]
		public ConcreteBinderGeneric<TContract> Rebind<TContract>()
		{
			return null;
		}

		[Address(RVA="0x15BB8B4", Offset="0x15BB8B4", VA="0x15BB8B4")]
		public ConcreteBinderNonGeneric Rebind(Type contractType)
		{
			return null;
		}

		[Address(RVA="0x2AF74A4", Offset="0x2AF74A4", VA="0x2AF74A4")]
		public ConcreteBinderGeneric<TContract> RebindId<TContract>(object identifier)
		{
			return null;
		}

		[Address(RVA="0x15BB8BC", Offset="0x15BB8BC", VA="0x15BB8BC")]
		public ConcreteBinderNonGeneric RebindId(Type contractType, object identifier)
		{
			return null;
		}

		[Address(RVA="0x15B58F4", Offset="0x15B58F4", VA="0x15B58F4")]
		public void RegisterProvider(BindingId bindingId, BindingCondition condition, IProvider provider)
		{
		}

		[Address(RVA="0x15B6FC0", Offset="0x15B6FC0", VA="0x15B6FC0")]
		public object Resolve(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x1575470", Offset="0x1575470", VA="0x1575470")]
		public TContract Resolve<TContract>()
		{
			return null;
		}

		[Address(RVA="0x15BB0DC", Offset="0x15BB0DC", VA="0x15BB0DC")]
		public object Resolve(Type contractType)
		{
			return null;
		}

		[Address(RVA="0x15B4BA8", Offset="0x15B4BA8", VA="0x15B4BA8")]
		public IList ResolveAll(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x13EC1DC", Offset="0x13EC1DC", VA="0x13EC1DC")]
		public List<TContract> ResolveAll<TContract>()
		{
			return null;
		}

		[Address(RVA="0x15BB1F0", Offset="0x15BB1F0", VA="0x15BB1F0")]
		public IList ResolveAll(Type contractType)
		{
			return null;
		}

		[Address(RVA="0x15B4A80", Offset="0x15B4A80", VA="0x15B4A80")]
		public List<object> ResolveDependencyRoots()
		{
			return null;
		}

		[Address(RVA="0x1575590", Offset="0x1575590", VA="0x1575590")]
		public TContract ResolveId<TContract>(object identifier)
		{
			return null;
		}

		[Address(RVA="0x15BB0E4", Offset="0x15BB0E4", VA="0x15BB0E4")]
		public object ResolveId(Type contractType, object identifier)
		{
			return null;
		}

		[Address(RVA="0x13EC2FC", Offset="0x13EC2FC", VA="0x13EC2FC")]
		public List<TContract> ResolveIdAll<TContract>(object identifier)
		{
			return null;
		}

		[Address(RVA="0x15BB1F8", Offset="0x15BB1F8", VA="0x15BB1F8")]
		public IList ResolveIdAll(Type contractType, object identifier)
		{
			return null;
		}

		[Address(RVA="0x199FA2C", Offset="0x199FA2C", VA="0x199FA2C")]
		public Type ResolveType<T>()
		{
			return null;
		}

		[Address(RVA="0x15B629C", Offset="0x15B629C", VA="0x15B629C")]
		public Type ResolveType(Type type)
		{
			return null;
		}

		[Address(RVA="0x15B6318", Offset="0x15B6318", VA="0x15B6318")]
		public Type ResolveType(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15B6D00", Offset="0x15B6D00", VA="0x15B6D00")]
		public List<Type> ResolveTypeAll(Type type)
		{
			return null;
		}

		[Address(RVA="0x15B6D08", Offset="0x15B6D08", VA="0x15B6D08")]
		public List<Type> ResolveTypeAll(Type type, object identifier)
		{
			return null;
		}

		[Address(RVA="0x15B6D88", Offset="0x15B6D88", VA="0x15B6D88")]
		public List<Type> ResolveTypeAll(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15B7834", Offset="0x15B7834", VA="0x15B7834")]
		private IEnumerable<object> SafeGetInstances(DiContainer.ProviderPair providerPair, InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x15BB804", Offset="0x15BB804", VA="0x15BB804")]
		public BindFinalizerWrapper StartBinding()
		{
			return null;
		}

		[Address(RVA="0x15B8970", Offset="0x15B8970", VA="0x15B8970")]
		private void StartCoroutine(object injectable, PostInjectableInfo method, List<object> paramValues)
		{
		}

		[Address(RVA="0x15B6878", Offset="0x15B6878", VA="0x15B6878")]
		private DiContainer.ProviderLookupResult TryGetUniqueProvider(InjectContext context, out DiContainer.ProviderPair providerPair)
		{
			providerPair = null;
			return new DiContainer.ProviderLookupResult();
		}

		[Address(RVA="0x15756C0", Offset="0x15756C0", VA="0x15756C0")]
		public TContract TryResolve<TContract>()
		where TContract : class
		{
			return null;
		}

		[Address(RVA="0x15BB164", Offset="0x15BB164", VA="0x15BB164")]
		public object TryResolve(Type contractType)
		{
			return null;
		}

		[Address(RVA="0x15757E0", Offset="0x15757E0", VA="0x15757E0")]
		public TContract TryResolveId<TContract>(object identifier)
		where TContract : class
		{
			return null;
		}

		[Address(RVA="0x15BB16C", Offset="0x15BB16C", VA="0x15BB16C")]
		public object TryResolveId(Type contractType, object identifier)
		{
			return null;
		}

		[Address(RVA="0x135244C", Offset="0x135244C", VA="0x135244C")]
		public bool Unbind<TContract>()
		{
			return new bool();
		}

		[Address(RVA="0x15BB2E4", Offset="0x15BB2E4", VA="0x15BB2E4")]
		public bool Unbind(Type contractType)
		{
			return new bool();
		}

		[Address(RVA="0x1352394", Offset="0x1352394", VA="0x1352394")]
		public bool Unbind<TContract, TConcrete>()
		{
			return new bool();
		}

		[Address(RVA="0x15BB420", Offset="0x15BB420", VA="0x15BB420")]
		public bool Unbind(Type contractType, Type concreteType)
		{
			return new bool();
		}

		[Address(RVA="0x15BB27C", Offset="0x15BB27C", VA="0x15BB27C")]
		public void UnbindAll()
		{
		}

		[Address(RVA="0x13525A8", Offset="0x13525A8", VA="0x13525A8")]
		public bool UnbindId<TContract>(object identifier)
		{
			return new bool();
		}

		[Address(RVA="0x15BB2EC", Offset="0x15BB2EC", VA="0x15BB2EC")]
		public bool UnbindId(Type contractType, object identifier)
		{
			return new bool();
		}

		[Address(RVA="0x13524E8", Offset="0x13524E8", VA="0x13524E8")]
		public bool UnbindId<TContract, TConcrete>(object identifier)
		{
			return new bool();
		}

		[Address(RVA="0x15BB428", Offset="0x15BB428", VA="0x15BB428")]
		public bool UnbindId(Type contractType, Type concreteType, object identifier)
		{
			return new bool();
		}

		[Address(RVA="0x16A767C", Offset="0x16A767C", VA="0x16A767C")]
		public void UnbindInterfacesTo<TConcrete>()
		{
		}

		[Address(RVA="0x15BB388", Offset="0x15BB388", VA="0x15BB388")]
		public void UnbindInterfacesTo(Type concreteType)
		{
		}

		[Address(RVA="0x15B4FDC", Offset="0x15B4FDC", VA="0x15B4FDC")]
		public void ValidateValidatables()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD18", Offset="0x104DD18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DiContainer.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<DiContainer, IEnumerable<IBindingFinalizer>> <>9__19_0;

			[FieldOffset(Offset="0x10")]
			public static Func<DiContainer.ProviderPair, IProvider> <>9__56_0;

			[FieldOffset(Offset="0x18")]
			public static Func<Type, bool> <>9__72_1;

			[FieldOffset(Offset="0x20")]
			public static Func<<>f__AnonymousType0<DiContainer.ProviderPair, int>, int> <>9__73_1;

			[FieldOffset(Offset="0x28")]
			public static Func<<>f__AnonymousType0<DiContainer.ProviderPair, int>, bool> <>9__73_3;

			[FieldOffset(Offset="0x30")]
			public static Func<<>f__AnonymousType0<DiContainer.ProviderPair, int>, DiContainer.ProviderPair> <>9__73_4;

			[FieldOffset(Offset="0x38")]
			public static Func<TypeValuePair, string> <>9__81_0;

			[FieldOffset(Offset="0x40")]
			public static Func<TypeValuePair, string> <>9__83_0;

			[FieldOffset(Offset="0x48")]
			public static Func<Type, bool> <>9__171_0;

			[FieldOffset(Offset="0x50")]
			public static Func<Type, bool> <>9__172_0;

			[Address(RVA="0x18310F8", Offset="0x18310F8", VA="0x18310F8")]
			static <>c()
			{
			}

			[Address(RVA="0x183115C", Offset="0x183115C", VA="0x183115C")]
			public <>c()
			{
			}

			[Address(RVA="0x1831164", Offset="0x1831164", VA="0x1831164")]
			internal IEnumerable<IBindingFinalizer> <.ctor>b__19_0(DiContainer x)
			{
				return null;
			}

			[Address(RVA="0x183144C", Offset="0x183144C", VA="0x183144C")]
			internal bool <Bind>b__172_0(Type x)
			{
				return new bool();
			}

			[Address(RVA="0x18313F0", Offset="0x18313F0", VA="0x18313F0")]
			internal bool <BindInternal>b__171_0(Type x)
			{
				return new bool();
			}

			[Address(RVA="0x1831190", Offset="0x1831190", VA="0x1831190")]
			internal IProvider <GetAllProviderMatches>b__56_0(DiContainer.ProviderPair x)
			{
				return null;
			}

			[Address(RVA="0x18313C0", Offset="0x18313C0", VA="0x18313C0")]
			internal string <InjectExplicit>b__83_0(TypeValuePair x)
			{
				return null;
			}

			[Address(RVA="0x1831390", Offset="0x1831390", VA="0x1831390")]
			internal string <InstantiateInternal>b__81_0(TypeValuePair x)
			{
				return null;
			}

			[Address(RVA="0x18311DC", Offset="0x18311DC", VA="0x18311DC")]
			internal bool <ResolveTypeAll>b__72_1(Type x)
			{
				return new bool();
			}

			[Address(RVA="0x1831248", Offset="0x1831248", VA="0x1831248")]
			internal int <TryGetUniqueProvider>b__73_1(<>f__AnonymousType0<DiContainer.ProviderPair, int> x)
			{
				return new int();
			}

			[Address(RVA="0x18312A4", Offset="0x18312A4", VA="0x18312A4")]
			internal bool <TryGetUniqueProvider>b__73_3(<>f__AnonymousType0<DiContainer.ProviderPair, int> x)
			{
				return new bool();
			}

			[Address(RVA="0x1831334", Offset="0x1831334", VA="0x1831334")]
			internal DiContainer.ProviderPair <TryGetUniqueProvider>b__73_4(<>f__AnonymousType0<DiContainer.ProviderPair, int> x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DDB8", Offset="0x104DDB8")]
		private sealed class <>c__DisplayClass154_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer <>4__this;

			[FieldOffset(Offset="0x18")]
			public Type contractType;

			[FieldOffset(Offset="0x20")]
			public object identifier;

			[FieldOffset(Offset="0x28")]
			public Type concreteType;

			[Address(RVA="0x18314A8", Offset="0x18314A8", VA="0x18314A8")]
			public <>c__DisplayClass154_0()
			{
			}

			[Address(RVA="0x18314B0", Offset="0x18314B0", VA="0x18314B0")]
			internal bool <UnbindId>b__0(DiContainer.ProviderInfo x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DDC8", Offset="0x104DDC8")]
		private sealed class <>c__DisplayClass181_0<TContract>
		{
			[FieldOffset(Offset="0x0")]
			public TContract instance;

			[Address(RVA="0x1F45D08", Offset="0x1F45D08", VA="0x1F45D08")]
			public <>c__DisplayClass181_0()
			{
			}

			[Address(RVA="0x1F45D34", Offset="0x1F45D34", VA="0x1F45D34")]
			internal IProvider <BindInstance>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD28", Offset="0x104DD28")]
		private sealed class <>c__DisplayClass49_0
		{
			[FieldOffset(Offset="0x10")]
			public InjectContext injectContext;

			[Address(RVA="0x1831600", Offset="0x1831600", VA="0x1831600")]
			public <>c__DisplayClass49_0()
			{
			}

			[Address(RVA="0x1831608", Offset="0x1831608", VA="0x1831608")]
			internal bool <ValidateValidatables>b__0(DiContainer.ProviderInfo x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD38", Offset="0x104DD38")]
		private sealed class <>c__DisplayClass57_0
		{
			[FieldOffset(Offset="0x10")]
			public InjectContext context;

			[Address(RVA="0x18316EC", Offset="0x18316EC", VA="0x18316EC")]
			public <>c__DisplayClass57_0()
			{
			}

			[Address(RVA="0x18316F4", Offset="0x18316F4", VA="0x18316F4")]
			internal bool <GetProviderMatchesInternal>b__0(DiContainer.ProviderPair x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD58", Offset="0x104DD58")]
		private sealed class <>c__DisplayClass61_0
		{
			[FieldOffset(Offset="0x10")]
			public BindingId bindingId;

			[Address(RVA="0x1831784", Offset="0x1831784", VA="0x1831784")]
			public <>c__DisplayClass61_0()
			{
			}

			[Address(RVA="0x183178C", Offset="0x183178C", VA="0x183178C")]
			internal IEnumerable<DiContainer.ProviderPair> <GetProvidersForContract>b__0(DiContainer x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD68", Offset="0x104DD68")]
		private sealed class <>c__DisplayClass65_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer <>4__this;

			[FieldOffset(Offset="0x18")]
			public InjectContext context;

			[Address(RVA="0x18317C4", Offset="0x18317C4", VA="0x18317C4")]
			public <>c__DisplayClass65_0()
			{
			}

			[Address(RVA="0x18317CC", Offset="0x18317CC", VA="0x18317CC")]
			internal IEnumerable<object> <ResolveAll>b__0(DiContainer.ProviderPair x)
			{
				return null;
			}

			[Address(RVA="0x1831810", Offset="0x1831810", VA="0x1831810")]
			internal object <ResolveAll>b__1(object x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD78", Offset="0x104DD78")]
		private sealed class <>c__DisplayClass72_0
		{
			[FieldOffset(Offset="0x10")]
			public InjectContext context;

			[Address(RVA="0x18318C8", Offset="0x18318C8", VA="0x18318C8")]
			public <>c__DisplayClass72_0()
			{
			}

			[Address(RVA="0x18318D0", Offset="0x18318D0", VA="0x18318D0")]
			internal Type <ResolveTypeAll>b__0(DiContainer.ProviderPair x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD88", Offset="0x104DD88")]
		private sealed class <>c__DisplayClass73_0
		{
			[FieldOffset(Offset="0x10")]
			public List<<>f__AnonymousType0<DiContainer.ProviderPair, int>> sortedProviders;

			[Address(RVA="0x18319B4", Offset="0x18319B4", VA="0x18319B4")]
			public <>c__DisplayClass73_0()
			{
			}

			[Address(RVA="0x18319BC", Offset="0x18319BC", VA="0x18319BC")]
			internal bool <TryGetUniqueProvider>b__2(<>f__AnonymousType0<DiContainer.ProviderPair, int> x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD98", Offset="0x104DD98")]
		private sealed class <>c__DisplayClass75_0
		{
			[FieldOffset(Offset="0x10")]
			public DiContainer.LookupId lookupId;

			[Address(RVA="0x1831A74", Offset="0x1831A74", VA="0x1831A74")]
			public <>c__DisplayClass75_0()
			{
			}

			[Address(RVA="0x1831A7C", Offset="0x1831A7C", VA="0x1831A7C")]
			internal bool <SafeGetInstances>b__0(DiContainer.LookupId x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD48", Offset="0x104DD48")]
		private sealed class <GetAllContainersToLookup>d__58 : IEnumerable<DiContainer>, IEnumerable, IEnumerator<DiContainer>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private DiContainer <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x24")]
			private InjectSources sourceType;

			[FieldOffset(Offset="0x28")]
			public InjectSources <>3__sourceType;

			[FieldOffset(Offset="0x30")]
			public DiContainer <>4__this;

			[FieldOffset(Offset="0x38")]
			private List<DiContainer>.Enumerator <>7__wrap1;

			private DiContainer System.Collections.Generic.IEnumerator<Zenject.DiContainer>.Current
			{
				[Address(RVA="0x183201C", Offset="0x183201C", VA="0x183201C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x183208C", Offset="0x183208C", VA="0x183208C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1831B34", Offset="0x1831B34", VA="0x1831B34")]
			[DebuggerHidden]
			public <GetAllContainersToLookup>d__58(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1831BC0", Offset="0x1831BC0", VA="0x1831BC0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1831C18", Offset="0x1831C18", VA="0x1831C18")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x1831C70", Offset="0x1831C70", VA="0x1831C70")]
			private void <>m__Finally3()
			{
			}

			[Address(RVA="0x1831CC8", Offset="0x1831CC8", VA="0x1831CC8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1832094", Offset="0x1832094", VA="0x1832094", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<DiContainer> System.Collections.Generic.IEnumerable<Zenject.DiContainer>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1832154", Offset="0x1832154", VA="0x1832154", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1832024", Offset="0x1832024", VA="0x1832024", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1831B6C", Offset="0x1831B6C", VA="0x1831B6C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DDA8", Offset="0x104DDA8")]
		private sealed class <GetDependencyContracts>d__79 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private Type <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public DiContainer <>4__this;

			[FieldOffset(Offset="0x30")]
			private Type contract;

			[FieldOffset(Offset="0x38")]
			public Type <>3__contract;

			[FieldOffset(Offset="0x40")]
			private IEnumerator<InjectableInfo> <>7__wrap1;

			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Address(RVA="0x183255C", Offset="0x183255C", VA="0x183255C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x18325CC", Offset="0x18325CC", VA="0x18325CC", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1832158", Offset="0x1832158", VA="0x1832158")]
			[DebuggerHidden]
			public <GetDependencyContracts>d__79(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x18321AC", Offset="0x18321AC", VA="0x18321AC")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x183226C", Offset="0x183226C", VA="0x183226C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x18325D4", Offset="0x18325D4", VA="0x18325D4", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1832694", Offset="0x1832694", VA="0x1832694", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1832564", Offset="0x1832564", VA="0x1832564", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1832190", Offset="0x1832190", VA="0x1832190", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		private struct LookupId
		{
			[FieldOffset(Offset="0x0")]
			public readonly IProvider Provider;

			[FieldOffset(Offset="0x8")]
			public readonly BindingId BindingId;

			[Address(RVA="0xF23E14", Offset="0xF23E14", VA="0xF23E14")]
			public LookupId(IProvider provider, BindingId bindingId)
			{
			}
		}

		public class ProviderInfo
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C814", Offset="0x106C814")]
			[FieldOffset(Offset="0x10")]
			private IProvider <Provider>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C824", Offset="0x106C824")]
			[FieldOffset(Offset="0x18")]
			private BindingCondition <Condition>k__BackingField;

			public BindingCondition Condition
			{
				[Address(RVA="0x183132C", Offset="0x183132C", VA="0x183132C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C60C", Offset="0x108C60C")]
				get
				{
					return null;
				}
				[Address(RVA="0x18326E0", Offset="0x18326E0", VA="0x18326E0")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C61C", Offset="0x108C61C")]
				private set
				{
				}
			}

			public IProvider Provider
			{
				[Address(RVA="0x18311D4", Offset="0x18311D4", VA="0x18311D4")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C5EC", Offset="0x108C5EC")]
				get
				{
					return null;
				}
				[Address(RVA="0x18326D8", Offset="0x18326D8", VA="0x18326D8")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C5FC", Offset="0x108C5FC")]
				private set
				{
				}
			}

			[Address(RVA="0x18326A0", Offset="0x18326A0", VA="0x18326A0")]
			public ProviderInfo(IProvider provider, BindingCondition condition)
			{
			}
		}

		public enum ProviderLookupResult
		{
			[FieldOffset(Offset="0x0")]
			Success,
			[FieldOffset(Offset="0x0")]
			Multiple,
			[FieldOffset(Offset="0x0")]
			None
		}

		private class ProviderPair
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C7F4", Offset="0x106C7F4")]
			[FieldOffset(Offset="0x10")]
			private DiContainer.ProviderInfo <ProviderInfo>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C804", Offset="0x106C804")]
			[FieldOffset(Offset="0x18")]
			private DiContainer <Container>k__BackingField;

			public DiContainer Container
			{
				[Address(RVA="0x1832730", Offset="0x1832730", VA="0x1832730")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C5CC", Offset="0x108C5CC")]
				get
				{
					return null;
				}
				[Address(RVA="0x1832728", Offset="0x1832728", VA="0x1832728")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C5DC", Offset="0x108C5DC")]
				private set
				{
				}
			}

			public DiContainer.ProviderInfo ProviderInfo
			{
				[Address(RVA="0x18311CC", Offset="0x18311CC", VA="0x18311CC")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C5AC", Offset="0x108C5AC")]
				get
				{
					return null;
				}
				[Address(RVA="0x1832720", Offset="0x1832720", VA="0x1832720")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108C5BC", Offset="0x108C5BC")]
				private set
				{
				}
			}

			[Address(RVA="0x18326E8", Offset="0x18326E8", VA="0x18326E8")]
			public ProviderPair(DiContainer.ProviderInfo providerInfo, DiContainer container)
			{
			}
		}
	}
}