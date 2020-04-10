using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByMethod<TParam1> : ISubContainerCreator
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<DiContainer, TParam1> _installMethod;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x2BAA8AC", Offset="0x2BAA8AC", VA="0x2BAA8AC")]
		public SubContainerCreatorByMethod(DiContainer container, Action<DiContainer, TParam1> installMethod)
		{
		}

		[Address(RVA="0x2BAA8F0", Offset="0x2BAA8F0", VA="0x2BAA8F0", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}