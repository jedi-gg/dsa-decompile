using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ConcreteIdBinderGeneric<TContract> : ConcreteBinderGeneric<TContract>
	{
		[Address(RVA="0x1F4577C", Offset="0x1F4577C", VA="0x1F4577C")]
		public ConcreteIdBinderGeneric(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x1F457D0", Offset="0x1F457D0", VA="0x1F457D0")]
		public ConcreteBinderGeneric<TContract> WithId(object identifier)
		{
			return null;
		}
	}
}