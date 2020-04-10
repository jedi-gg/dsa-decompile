using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class FromBinderNonGeneric : FromBinder
	{
		[Address(RVA="0x1836770", Offset="0x1836770", VA="0x1836770")]
		public FromBinderNonGeneric(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFB924", Offset="0x2AFB924", VA="0x2AFB924")]
		public ScopeArgConditionCopyNonLazyBinder FromFactory<TConcrete, TFactory>()
		where TFactory : IFactory<TConcrete>
		{
			return null;
		}

		[Address(RVA="0x183679C", Offset="0x183679C", VA="0x183679C")]
		public ScopeConditionCopyNonLazyBinder FromInstance(object instance)
		{
			return null;
		}

		[Address(RVA="0x2AFB95C", Offset="0x2AFB95C", VA="0x2AFB95C")]
		public ScopeArgConditionCopyNonLazyBinder FromMethod<TConcrete>(Func<InjectContext, TConcrete> method)
		{
			return null;
		}

		[Address(RVA="0x2AFB9A4", Offset="0x2AFB9A4", VA="0x2AFB9A4")]
		public ScopeArgConditionCopyNonLazyBinder FromMethodMultiple<TConcrete>(Func<InjectContext, IEnumerable<TConcrete>> method)
		{
			return null;
		}

		[Address(RVA="0x2AFBD48", Offset="0x2AFBD48", VA="0x2AFBD48")]
		public ScopeConditionCopyNonLazyBinder FromResolveGetter<TObj, TContract>(Func<TObj, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2AFBD94", Offset="0x2AFBD94", VA="0x2AFBD94")]
		public ScopeConditionCopyNonLazyBinder FromResolveGetter<TObj, TContract>(object identifier, Func<TObj, TContract> method)
		{
			return null;
		}
	}
}