using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ScopeNonLazyBinder : NonLazyBinder
	{
		[Address(RVA="0x1847DF8", Offset="0x1847DF8", VA="0x1847DF8")]
		public ScopeNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x1847EBC", Offset="0x1847EBC", VA="0x1847EBC")]
		public NonLazyBinder AsCached()
		{
			return null;
		}

		[Address(RVA="0x1847E24", Offset="0x1847E24", VA="0x1847E24")]
		public NonLazyBinder AsSingle()
		{
			return null;
		}

		[Address(RVA="0x1847E2C", Offset="0x1847E2C", VA="0x1847E2C")]
		public NonLazyBinder AsSingle(object concreteIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1847EFC", Offset="0x1847EFC", VA="0x1847EFC")]
		public NonLazyBinder AsTransient()
		{
			return null;
		}
	}
}