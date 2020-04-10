using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorCached : ISubContainerCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly ISubContainerCreator _subCreator;

		[FieldOffset(Offset="0x18")]
		private bool _isLookingUp;

		[FieldOffset(Offset="0x20")]
		private DiContainer _subContainer;

		[Address(RVA="0x2336964", Offset="0x2336964", VA="0x2336964")]
		public SubContainerCreatorCached(ISubContainerCreator subCreator)
		{
		}

		[Address(RVA="0x2336990", Offset="0x2336990", VA="0x2336990", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}