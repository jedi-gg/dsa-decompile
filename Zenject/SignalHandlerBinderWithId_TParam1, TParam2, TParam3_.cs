using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalHandlerBinderWithId<TParam1, TParam2, TParam3> : SignalHandlerBinder<TParam1, TParam2, TParam3>
	{
		[Address(RVA="0x2BA4F84", Offset="0x2BA4F84", VA="0x2BA4F84")]
		public SignalHandlerBinderWithId(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2BA4FE8", Offset="0x2BA4FE8", VA="0x2BA4FE8")]
		public SignalHandlerBinderWithId<TParam1, TParam2, TParam3> WithId(object identifier)
		{
			return null;
		}
	}
}