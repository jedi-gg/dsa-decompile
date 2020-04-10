using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByMethod<TParam1, TParam2, TParam3, TParam4> : ISubContainerCreator
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> _installMethod;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x2BAB43C", Offset="0x2BAB43C", VA="0x2BAB43C")]
		public SubContainerCreatorByMethod(DiContainer container, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installMethod)
		{
		}

		[Address(RVA="0x2BAB480", Offset="0x2BAB480", VA="0x2BAB480", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}