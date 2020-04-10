using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByMethod<TParam1, TParam2, TParam3, TParam4, TParam5> : ISubContainerCreator
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> _installMethod;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x2BABA18", Offset="0x2BABA18", VA="0x2BABA18")]
		public SubContainerCreatorByMethod(DiContainer container, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installMethod)
		{
		}

		[Address(RVA="0x2BABA5C", Offset="0x2BABA5C", VA="0x2BABA5C", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}