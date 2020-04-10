using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScopeConditionCopyNonLazyBinder : ConditionCopyNonLazyBinder
	{
		[Address(RVA="0x1834450", Offset="0x1834450", VA="0x1834450")]
		public ScopeConditionCopyNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x1847D78", Offset="0x1847D78", VA="0x1847D78")]
		public ConditionCopyNonLazyBinder AsCached()
		{
			return null;
		}

		[Address(RVA="0x1837640", Offset="0x1837640", VA="0x1837640")]
		public ConditionCopyNonLazyBinder AsSingle()
		{
			return null;
		}

		[Address(RVA="0x1847CE8", Offset="0x1847CE8", VA="0x1847CE8")]
		public ConditionCopyNonLazyBinder AsSingle(object concreteIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1847DB8", Offset="0x1847DB8", VA="0x1847DB8")]
		public ConditionCopyNonLazyBinder AsTransient()
		{
			return null;
		}
	}
}