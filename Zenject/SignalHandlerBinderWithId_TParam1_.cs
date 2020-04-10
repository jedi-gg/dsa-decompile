using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalHandlerBinderWithId<TParam1> : SignalHandlerBinder<TParam1>
	{
		[Address(RVA="0x2BA4E14", Offset="0x2BA4E14", VA="0x2BA4E14")]
		public SignalHandlerBinderWithId(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2BA4E78", Offset="0x2BA4E78", VA="0x2BA4E78")]
		public SignalHandlerBinder<TParam1> WithId(object identifier)
		{
			return null;
		}
	}
}