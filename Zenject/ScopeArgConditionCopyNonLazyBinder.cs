using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScopeArgConditionCopyNonLazyBinder : ArgConditionCopyNonLazyBinder
	{
		[Address(RVA="0x18340B8", Offset="0x18340B8", VA="0x18340B8")]
		public ScopeArgConditionCopyNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x1847B48", Offset="0x1847B48", VA="0x1847B48")]
		public ArgConditionCopyNonLazyBinder AsCached()
		{
			return null;
		}

		[Address(RVA="0x1837604", Offset="0x1837604", VA="0x1837604")]
		public ArgConditionCopyNonLazyBinder AsSingle()
		{
			return null;
		}

		[Address(RVA="0x1847AB8", Offset="0x1847AB8", VA="0x1847AB8")]
		public ArgConditionCopyNonLazyBinder AsSingle(object concreteIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1847B88", Offset="0x1847B88", VA="0x1847B88")]
		public ArgConditionCopyNonLazyBinder AsTransient()
		{
			return null;
		}
	}
}