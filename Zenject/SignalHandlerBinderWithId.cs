using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalHandlerBinderWithId : SignalHandlerBinder
	{
		[Address(RVA="0x233243C", Offset="0x233243C", VA="0x233243C")]
		public SignalHandlerBinderWithId(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x233247C", Offset="0x233247C", VA="0x233247C")]
		public SignalHandlerBinder WithId(object identifier)
		{
			return null;
		}
	}
}