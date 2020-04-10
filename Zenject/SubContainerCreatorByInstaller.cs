using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByInstaller : ISubContainerCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly Type _installerType;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly List<TypeValuePair> _extraArgs;

		[Address(RVA="0x2335208", Offset="0x2335208", VA="0x2335208")]
		public SubContainerCreatorByInstaller(DiContainer container, Type installerType, List<TypeValuePair> extraArgs)
		{
		}

		[Address(RVA="0x23352A4", Offset="0x23352A4", VA="0x23352A4")]
		public SubContainerCreatorByInstaller(DiContainer container, Type installerType)
		{
		}

		[Address(RVA="0x2335328", Offset="0x2335328", VA="0x2335328", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context)
		{
			return null;
		}
	}
}