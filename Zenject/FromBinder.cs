using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public abstract class FromBinder : ScopeArgConditionCopyNonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF28", Offset="0x105FF28")]
		[FieldOffset(Offset="0x18")]
		private BindFinalizerWrapper <FinalizerWrapper>k__BackingField;

		protected IEnumerable<Type> AllParentTypes
		{
			[Address(RVA="0x1834108", Offset="0x1834108", VA="0x1834108")]
			get
			{
				return null;
			}
		}

		protected IEnumerable<Type> ConcreteTypes
		{
			[Address(RVA="0x18341A0", Offset="0x18341A0", VA="0x18341A0")]
			get
			{
				return null;
			}
		}

		protected BindFinalizerWrapper FinalizerWrapper
		{
			[Address(RVA="0x18340C8", Offset="0x18340C8", VA="0x18340C8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072234", Offset="0x1072234")]
			get
			{
				return null;
			}
			[Address(RVA="0x18340C0", Offset="0x18340C0", VA="0x18340C0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072244", Offset="0x1072244")]
			private set
			{
			}
		}

		protected IBindingFinalizer SubFinalizer
		{
			[Address(RVA="0x18340D0", Offset="0x18340D0", VA="0x18340D0")]
			set
			{
			}
		}

		[Address(RVA="0x183408C", Offset="0x183408C", VA="0x183408C")]
		public FromBinder(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFAB80", Offset="0x2AFAB80", VA="0x2AFAB80")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072264", Offset="0x1072264")]
		private IProvider <FromFactoryBase>b__37_0<TConcrete, TFactory>(DiContainer container, Type type)
		where TFactory : IFactory<TConcrete>
		{
			return null;
		}

		[Address(RVA="0x1835BF4", Offset="0x1835BF4", VA="0x1835BF4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072254", Offset="0x1072254")]
		private IProvider <FromNewComponentSibling>b__19_0(DiContainer container, Type type)
		{
			return null;
		}

		[Address(RVA="0x1835194", Offset="0x1835194", VA="0x1835194")]
		public NameTransformScopeArgConditionCopyNonLazyBinder FromComponentInNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x1835208", Offset="0x1835208", VA="0x1835208")]
		internal NameTransformScopeArgConditionCopyNonLazyBinder FromComponentInNewPrefab(UnityEngine.Object prefab, GameObjectCreationParameters gameObjectInfo)
		{
			return null;
		}

		[Address(RVA="0x1835394", Offset="0x1835394", VA="0x1835394")]
		public NameTransformScopeArgConditionCopyNonLazyBinder FromComponentInNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1835408", Offset="0x1835408", VA="0x1835408")]
		internal NameTransformScopeArgConditionCopyNonLazyBinder FromComponentInNewPrefabResource(string resourcePath, GameObjectCreationParameters gameObjectInfo)
		{
			return null;
		}

		[Address(RVA="0x1834500", Offset="0x1834500", VA="0x1834500")]
		public ScopeArgConditionCopyNonLazyBinder FromFactory(Type factoryType)
		{
			return null;
		}

		[Address(RVA="0x2AFB320", Offset="0x2AFB320", VA="0x2AFB320")]
		protected ScopeArgConditionCopyNonLazyBinder FromFactoryBase<TConcrete, TFactory>()
		where TFactory : IFactory<TConcrete>
		{
			return null;
		}

		[Address(RVA="0x1835A70", Offset="0x1835A70", VA="0x1835A70")]
		protected ScopeConditionCopyNonLazyBinder FromInstanceBase(object instance)
		{
			return null;
		}

		[Address(RVA="0x2AFB50C", Offset="0x2AFB50C", VA="0x2AFB50C")]
		protected ScopeArgConditionCopyNonLazyBinder FromMethodBase<TConcrete>(Func<InjectContext, TConcrete> method)
		{
			return null;
		}

		[Address(RVA="0x2AFB6FC", Offset="0x2AFB6FC", VA="0x2AFB6FC")]
		protected ScopeArgConditionCopyNonLazyBinder FromMethodMultipleBase<TConcrete>(Func<InjectContext, IEnumerable<TConcrete>> method)
		{
			return null;
		}

		[Address(RVA="0x1835930", Offset="0x1835930", VA="0x1835930")]
		public ScopeArgConditionCopyNonLazyBinder FromMethodUntyped(Func<InjectContext, object> method)
		{
			return null;
		}

		[Address(RVA="0x1834278", Offset="0x1834278", VA="0x1834278")]
		public ScopeArgConditionCopyNonLazyBinder FromNew()
		{
			return null;
		}

		[Address(RVA="0x18346A0", Offset="0x18346A0", VA="0x18346A0")]
		public ScopeArgConditionCopyNonLazyBinder FromNewComponentOn(GameObject gameObject)
		{
			return null;
		}

		[Address(RVA="0x183484C", Offset="0x183484C", VA="0x183484C")]
		public ScopeArgConditionCopyNonLazyBinder FromNewComponentOn(Func<InjectContext, GameObject> gameObjectGetter)
		{
			return null;
		}

		[Address(RVA="0x1834AE4", Offset="0x1834AE4", VA="0x1834AE4")]
		public NameTransformScopeArgConditionCopyNonLazyBinder FromNewComponentOnNewGameObject()
		{
			return null;
		}

		[Address(RVA="0x1834B50", Offset="0x1834B50", VA="0x1834B50")]
		internal NameTransformScopeArgConditionCopyNonLazyBinder FromNewComponentOnNewGameObject(GameObjectCreationParameters gameObjectInfo)
		{
			return null;
		}

		[Address(RVA="0x1834F38", Offset="0x1834F38", VA="0x1834F38")]
		public NameTransformScopeArgConditionCopyNonLazyBinder FromNewComponentOnNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x1834FAC", Offset="0x1834FAC", VA="0x1834FAC")]
		internal NameTransformScopeArgConditionCopyNonLazyBinder FromNewComponentOnNewPrefab(UnityEngine.Object prefab, GameObjectCreationParameters gameObjectInfo)
		{
			return null;
		}

		[Address(RVA="0x1834CDC", Offset="0x1834CDC", VA="0x1834CDC")]
		public NameTransformScopeArgConditionCopyNonLazyBinder FromNewComponentOnNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1834D50", Offset="0x1834D50", VA="0x1834D50")]
		internal NameTransformScopeArgConditionCopyNonLazyBinder FromNewComponentOnNewPrefabResource(string resourcePath, GameObjectCreationParameters gameObjectInfo)
		{
			return null;
		}

		[Address(RVA="0x18349CC", Offset="0x18349CC", VA="0x18349CC")]
		public ArgConditionCopyNonLazyBinder FromNewComponentSibling()
		{
			return null;
		}

		[Address(RVA="0x1835594", Offset="0x1835594", VA="0x1835594")]
		public ScopeArgConditionCopyNonLazyBinder FromNewScriptableObjectResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x18342B4", Offset="0x18342B4", VA="0x18342B4")]
		public ScopeConditionCopyNonLazyBinder FromResolve()
		{
			return null;
		}

		[Address(RVA="0x18342BC", Offset="0x18342BC", VA="0x18342BC")]
		public ScopeConditionCopyNonLazyBinder FromResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x2AFBA3C", Offset="0x2AFBA3C", VA="0x2AFBA3C")]
		protected ScopeConditionCopyNonLazyBinder FromResolveGetterBase<TObj, TResult>(object identifier, Func<TObj, TResult> method)
		{
			return null;
		}

		[Address(RVA="0x18357BC", Offset="0x18357BC", VA="0x18357BC")]
		public ScopeConditionCopyNonLazyBinder FromResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x18357AC", Offset="0x18357AC", VA="0x18357AC")]
		public ScopeArgConditionCopyNonLazyBinder FromScriptableObjectResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x183559C", Offset="0x183559C", VA="0x183559C")]
		private ScopeArgConditionCopyNonLazyBinder FromScriptableObjectResourceInternal(string resourcePath, bool createNew)
		{
			return null;
		}

		[Address(RVA="0x1834458", Offset="0x1834458", VA="0x1834458")]
		public SubContainerBinder FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1834460", Offset="0x1834460", VA="0x1834460")]
		public SubContainerBinder FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D958", Offset="0x104D958")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FromBinder.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Type, IPrefabInstantiator, IProvider> <>9__23_0;

			[FieldOffset(Offset="0x10")]
			public static Func<Type, IPrefabInstantiator, IProvider> <>9__25_0;

			[FieldOffset(Offset="0x18")]
			public static Func<Type, IPrefabInstantiator, IProvider> <>9__27_0;

			[FieldOffset(Offset="0x20")]
			public static Func<Type, IPrefabInstantiator, IProvider> <>9__29_0;

			[Address(RVA="0x1835CC0", Offset="0x1835CC0", VA="0x1835CC0")]
			static <>c()
			{
			}

			[Address(RVA="0x1835D24", Offset="0x1835D24", VA="0x1835D24")]
			public <>c()
			{
			}

			[Address(RVA="0x1835E44", Offset="0x1835E44", VA="0x1835E44")]
			internal IProvider <FromComponentInNewPrefab>b__27_0(Type contractType, IPrefabInstantiator instantiator)
			{
				return null;
			}

			[Address(RVA="0x1835EEC", Offset="0x1835EEC", VA="0x1835EEC")]
			internal IProvider <FromComponentInNewPrefabResource>b__29_0(Type contractType, IPrefabInstantiator instantiator)
			{
				return null;
			}

			[Address(RVA="0x1835DD4", Offset="0x1835DD4", VA="0x1835DD4")]
			internal IProvider <FromNewComponentOnNewPrefab>b__25_0(Type contractType, IPrefabInstantiator instantiator)
			{
				return null;
			}

			[Address(RVA="0x1835D2C", Offset="0x1835D2C", VA="0x1835D2C")]
			internal IProvider <FromNewComponentOnNewPrefabResource>b__23_0(Type contractType, IPrefabInstantiator instantiator)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D908", Offset="0x104D908")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public object subIdentifier;

			[Address(RVA="0x18343F8", Offset="0x18343F8", VA="0x18343F8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x1835F5C", Offset="0x1835F5C", VA="0x1835F5C")]
			internal IProvider <FromResolve>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D918", Offset="0x104D918")]
		private sealed class <>c__DisplayClass16_0
		{
			[FieldOffset(Offset="0x10")]
			public Type factoryType;

			[FieldOffset(Offset="0x18")]
			public FromBinder <>4__this;

			[Address(RVA="0x1834698", Offset="0x1834698", VA="0x1834698")]
			public <>c__DisplayClass16_0()
			{
			}

			[Address(RVA="0x183603C", Offset="0x183603C", VA="0x183603C")]
			internal IProvider <FromFactory>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D928", Offset="0x104D928")]
		private sealed class <>c__DisplayClass17_0
		{
			[FieldOffset(Offset="0x10")]
			public GameObject gameObject;

			[FieldOffset(Offset="0x18")]
			public FromBinder <>4__this;

			[Address(RVA="0x1834844", Offset="0x1834844", VA="0x1834844")]
			public <>c__DisplayClass17_0()
			{
			}

			[Address(RVA="0x18360E8", Offset="0x18360E8", VA="0x18360E8")]
			internal IProvider <FromNewComponentOn>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D938", Offset="0x104D938")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public Func<InjectContext, GameObject> gameObjectGetter;

			[FieldOffset(Offset="0x18")]
			public FromBinder <>4__this;

			[Address(RVA="0x18349C4", Offset="0x18349C4", VA="0x18349C4")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x18361D8", Offset="0x18361D8", VA="0x18361D8")]
			internal IProvider <FromNewComponentOn>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D948", Offset="0x104D948")]
		private sealed class <>c__DisplayClass21_0
		{
			[FieldOffset(Offset="0x10")]
			public FromBinder <>4__this;

			[FieldOffset(Offset="0x18")]
			public GameObjectCreationParameters gameObjectInfo;

			[Address(RVA="0x1834CCC", Offset="0x1834CCC", VA="0x1834CCC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Address(RVA="0x18362C8", Offset="0x18362C8", VA="0x18362C8")]
			internal IProvider <FromNewComponentOnNewGameObject>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D968", Offset="0x104D968")]
		private sealed class <>c__DisplayClass32_0
		{
			[FieldOffset(Offset="0x10")]
			public string resourcePath;

			[FieldOffset(Offset="0x18")]
			public FromBinder <>4__this;

			[FieldOffset(Offset="0x20")]
			public bool createNew;

			[Address(RVA="0x18357B4", Offset="0x18357B4", VA="0x18357B4")]
			public <>c__DisplayClass32_0()
			{
			}

			[Address(RVA="0x18363BC", Offset="0x18363BC", VA="0x18363BC")]
			internal IProvider <FromScriptableObjectResourceInternal>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D978", Offset="0x104D978")]
		private sealed class <>c__DisplayClass33_0
		{
			[FieldOffset(Offset="0x10")]
			public string resourcePath;

			[Address(RVA="0x1835928", Offset="0x1835928", VA="0x1835928")]
			public <>c__DisplayClass33_0()
			{
			}

			[Address(RVA="0x183655C", Offset="0x183655C", VA="0x183655C")]
			internal IProvider <FromResource>b__0(DiContainer _, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D988", Offset="0x104D988")]
		private sealed class <>c__DisplayClass34_0
		{
			[FieldOffset(Offset="0x10")]
			public Func<InjectContext, object> method;

			[Address(RVA="0x1835A68", Offset="0x1835A68", VA="0x1835A68")]
			public <>c__DisplayClass34_0()
			{
			}

			[Address(RVA="0x1836608", Offset="0x1836608", VA="0x1836608")]
			internal IProvider <FromMethodUntyped>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D998", Offset="0x104D998")]
		private sealed class <>c__DisplayClass35_0<TConcrete>
		{
			[FieldOffset(Offset="0x0")]
			public Func<InjectContext, TConcrete> method;

			[Address(RVA="0x234A7B0", Offset="0x234A7B0", VA="0x234A7B0")]
			public <>c__DisplayClass35_0()
			{
			}

			[Address(RVA="0x234A7DC", Offset="0x234A7DC", VA="0x234A7DC")]
			internal IProvider <FromMethodBase>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D9A8", Offset="0x104D9A8")]
		private sealed class <>c__DisplayClass36_0<TConcrete>
		{
			[FieldOffset(Offset="0x0")]
			public Func<InjectContext, IEnumerable<TConcrete>> method;

			[Address(RVA="0x234A850", Offset="0x234A850", VA="0x234A850")]
			public <>c__DisplayClass36_0()
			{
			}

			[Address(RVA="0x234A87C", Offset="0x234A87C", VA="0x234A87C")]
			internal IProvider <FromMethodMultipleBase>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D9B8", Offset="0x104D9B8")]
		private sealed class <>c__DisplayClass38_0<TObj, TResult>
		{
			[FieldOffset(Offset="0x0")]
			public object identifier;

			[FieldOffset(Offset="0x0")]
			public Func<TObj, TResult> method;

			[Address(RVA="0x234A8F0", Offset="0x234A8F0", VA="0x234A8F0")]
			public <>c__DisplayClass38_0()
			{
			}

			[Address(RVA="0x234A91C", Offset="0x234A91C", VA="0x234A91C")]
			internal IProvider <FromResolveGetterBase>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D9C8", Offset="0x104D9C8")]
		private sealed class <>c__DisplayClass39_0
		{
			[FieldOffset(Offset="0x10")]
			public object instance;

			[Address(RVA="0x1835BEC", Offset="0x1835BEC", VA="0x1835BEC")]
			public <>c__DisplayClass39_0()
			{
			}

			[Address(RVA="0x18366B4", Offset="0x18366B4", VA="0x18366B4")]
			internal IProvider <FromInstanceBase>b__0(DiContainer container, Type type)
			{
				return null;
			}
		}
	}
}