using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class LazyInstanceInjector
	{
		[FieldOffset(Offset="0x10")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private readonly HashSet<object> _instancesToInject;

		public IEnumerable<object> Instances
		{
			[Address(RVA="0x183D380", Offset="0x183D380", VA="0x183D380")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x183D2FC", Offset="0x183D2FC", VA="0x183D2FC")]
		public LazyInstanceInjector(DiContainer container)
		{
		}

		[Address(RVA="0x183D388", Offset="0x183D388", VA="0x183D388")]
		public void AddInstance(object instance)
		{
		}

		[Address(RVA="0x183D3F8", Offset="0x183D3F8", VA="0x183D3F8")]
		public void AddInstances(IEnumerable<object> instances)
		{
		}

		[Address(RVA="0x183D50C", Offset="0x183D50C", VA="0x183D50C")]
		public void LazyInjectAll()
		{
		}

		[Address(RVA="0x183D468", Offset="0x183D468", VA="0x183D468")]
		public void OnInstanceResolved(object instance)
		{
		}
	}
}