using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByMethod : ISubContainerCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly Action<DiContainer> _installMethod;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[Address(RVA="0x2335570", Offset="0x2335570", VA="0x2335570")]
		public SubContainerCreatorByMethod(DiContainer container, Action<DiContainer> installMethod)
		{
		}

		[Address(RVA="0x23355A8", Offset="0x23355A8", VA="0x23355A8", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}