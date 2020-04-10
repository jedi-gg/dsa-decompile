using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScopeArgNonLazyBinder : ArgNonLazyBinder
	{
		[Address(RVA="0x1847BC8", Offset="0x1847BC8", VA="0x1847BC8")]
		public ScopeArgNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x1847C68", Offset="0x1847C68", VA="0x1847C68")]
		public ArgNonLazyBinder AsCached()
		{
			return null;
		}

		[Address(RVA="0x1847BD0", Offset="0x1847BD0", VA="0x1847BD0")]
		public ArgNonLazyBinder AsSingle()
		{
			return null;
		}

		[Address(RVA="0x1847BD8", Offset="0x1847BD8", VA="0x1847BD8")]
		public ArgNonLazyBinder AsSingle(object concreteIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1847CA8", Offset="0x1847CA8", VA="0x1847CA8")]
		public ArgNonLazyBinder AsTransient()
		{
			return null;
		}
	}
}