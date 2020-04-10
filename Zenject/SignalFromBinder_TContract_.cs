using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class SignalFromBinder<TContract> : ScopeArgNonLazyBinder
	{
		[FieldOffset(Offset="0x0")]
		private readonly Zenject.BindInfo _info;

		[FieldOffset(Offset="0x0")]
		private readonly FromBinderGeneric<TContract> _subBinder;

		[Address(RVA="0x2BA4520", Offset="0x2BA4520", VA="0x2BA4520")]
		public SignalFromBinder(Zenject.BindInfo info, FromBinderGeneric<TContract> subBinder)
		{
		}

		[Address(RVA="0x2BA46C4", Offset="0x2BA46C4", VA="0x2BA46C4")]
		public ScopeArgNonLazyBinder FromComponentInHierarchy()
		{
			return null;
		}

		[Address(RVA="0x2BA4B2C", Offset="0x2BA4B2C", VA="0x2BA4B2C")]
		public NameTransformScopeArgNonLazyBinder FromComponentInNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x2BA4BE4", Offset="0x2BA4BE4", VA="0x2BA4BE4")]
		public NameTransformScopeArgNonLazyBinder FromComponentInNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x2AFB9EC", Offset="0x2AFB9EC", VA="0x2AFB9EC")]
		public ScopeArgNonLazyBinder FromFactory<TFactory>()
		where TFactory : IFactory<TContract>
		{
			return null;
		}

		[Address(RVA="0x2BA4874", Offset="0x2BA4874", VA="0x2BA4874")]
		public ScopeArgNonLazyBinder FromFactory(Type factoryType)
		{
			return null;
		}

		[Address(RVA="0x2BA4620", Offset="0x2BA4620", VA="0x2BA4620")]
		public ScopeNonLazyBinder FromInstance(TContract instance)
		{
			return null;
		}

		[Address(RVA="0x2BA4568", Offset="0x2BA4568", VA="0x2BA4568")]
		public ScopeArgNonLazyBinder FromMethod(Func<InjectContext, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2BA45C4", Offset="0x2BA45C4", VA="0x2BA45C4")]
		public ScopeArgNonLazyBinder FromMethodMultiple(Func<InjectContext, IEnumerable<TContract>> method)
		{
			return null;
		}

		[Address(RVA="0x2BA4DC8", Offset="0x2BA4DC8", VA="0x2BA4DC8")]
		public ScopeArgNonLazyBinder FromMethodUntyped(Func<InjectContext, object> method)
		{
			return null;
		}

		[Address(RVA="0x2BA4720", Offset="0x2BA4720", VA="0x2BA4720")]
		public ScopeArgNonLazyBinder FromNew()
		{
			return null;
		}

		[Address(RVA="0x2BA48C0", Offset="0x2BA48C0", VA="0x2BA48C0")]
		public ScopeArgNonLazyBinder FromNewComponentOn(GameObject gameObject)
		{
			return null;
		}

		[Address(RVA="0x2BA4A7C", Offset="0x2BA4A7C", VA="0x2BA4A7C")]
		public NameTransformScopeArgNonLazyBinder FromNewComponentOnNewGameObject()
		{
			return null;
		}

		[Address(RVA="0x2BA490C", Offset="0x2BA490C", VA="0x2BA490C")]
		public NameTransformScopeArgNonLazyBinder FromNewComponentOnNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x2BA49C4", Offset="0x2BA49C4", VA="0x2BA49C4")]
		public NameTransformScopeArgNonLazyBinder FromNewComponentOnNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x2BA4C9C", Offset="0x2BA4C9C", VA="0x2BA4C9C")]
		public ScopeArgNonLazyBinder FromNewScriptableObjectResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x2BA475C", Offset="0x2BA475C", VA="0x2BA475C")]
		public ScopeNonLazyBinder FromResolve()
		{
			return null;
		}

		[Address(RVA="0x2BA47E0", Offset="0x2BA47E0", VA="0x2BA47E0")]
		public ScopeNonLazyBinder FromResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x2AFBE80", Offset="0x2AFBE80", VA="0x2AFBE80")]
		public ScopeNonLazyBinder FromResolveGetter<TObj>(Func<TObj, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2AFBF20", Offset="0x2AFBF20", VA="0x2AFBF20")]
		public ScopeNonLazyBinder FromResolveGetter<TObj>(object identifier, Func<TObj, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2BA4D34", Offset="0x2BA4D34", VA="0x2BA4D34")]
		public ScopeNonLazyBinder FromResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x2BA4CE8", Offset="0x2BA4CE8", VA="0x2BA4CE8")]
		public ScopeArgNonLazyBinder FromScriptableObjectResource(string resourcePath)
		{
			return null;
		}
	}
}