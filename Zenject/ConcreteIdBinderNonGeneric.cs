using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ConcreteIdBinderNonGeneric : ConcreteBinderNonGeneric
	{
		[Address(RVA="0x15AF758", Offset="0x15AF758", VA="0x15AF758")]
		public ConcreteIdBinderNonGeneric(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x15AF780", Offset="0x15AF780", VA="0x15AF780")]
		public ConcreteBinderNonGeneric WithId(object identifier)
		{
			return null;
		}
	}
}