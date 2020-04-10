using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByMethod<TParam1, TParam2> : ISubContainerCreator
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<DiContainer, TParam1, TParam2> _installMethod;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x2BAAB80", Offset="0x2BAAB80", VA="0x2BAAB80")]
		public SubContainerCreatorByMethod(DiContainer container, Action<DiContainer, TParam1, TParam2> installMethod)
		{
		}

		[Address(RVA="0x2BAABC4", Offset="0x2BAABC4", VA="0x2BAABC4", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}