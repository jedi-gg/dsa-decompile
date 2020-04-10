using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalHandlerBinderWithId<TParam1, TParam2, TParam3, TParam4> : SignalHandlerBinder<TParam1, TParam2, TParam3, TParam4>
	{
		[Address(RVA="0x2BA503C", Offset="0x2BA503C", VA="0x2BA503C")]
		public SignalHandlerBinderWithId(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2BA50A0", Offset="0x2BA50A0", VA="0x2BA50A0")]
		public SignalHandlerBinderWithId<TParam1, TParam2, TParam3, TParam4> WithId(object identifier)
		{
			return null;
		}
	}
}