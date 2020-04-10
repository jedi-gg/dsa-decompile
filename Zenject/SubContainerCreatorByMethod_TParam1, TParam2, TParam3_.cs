using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByMethod<TParam1, TParam2, TParam3> : ISubContainerCreator
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<DiContainer, TParam1, TParam2, TParam3> _installMethod;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x2BAAF5C", Offset="0x2BAAF5C", VA="0x2BAAF5C")]
		public SubContainerCreatorByMethod(DiContainer container, Action<DiContainer, TParam1, TParam2, TParam3> installMethod)
		{
		}

		[Address(RVA="0x2BAAFA0", Offset="0x2BAAFA0", VA="0x2BAAFA0", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}