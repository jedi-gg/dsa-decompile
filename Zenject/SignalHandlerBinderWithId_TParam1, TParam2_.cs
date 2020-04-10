using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SignalHandlerBinderWithId<TParam1, TParam2> : SignalHandlerBinder<TParam1, TParam2>
	{
		[Address(RVA="0x2BA4ECC", Offset="0x2BA4ECC", VA="0x2BA4ECC")]
		public SignalHandlerBinderWithId(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2BA4F30", Offset="0x2BA4F30", VA="0x2BA4F30")]
		public SignalHandlerBinderWithId<TParam1, TParam2> WithId(object identifier)
		{
			return null;
		}
	}
}