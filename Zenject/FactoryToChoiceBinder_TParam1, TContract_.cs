using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceBinder<TParam1, TContract> : FactoryFromBinder<TParam1, TContract>
	{
		[Address(RVA="0x23483A0", Offset="0x23483A0", VA="0x23483A0")]
		public FactoryToChoiceBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF9000", Offset="0x2AF9000", VA="0x2AF9000")]
		public FactoryFromBinder<TParam1, TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x23483F4", Offset="0x23483F4", VA="0x23483F4")]
		public FactoryFromBinder<TParam1, TContract> ToSelf()
		{
			return null;
		}
	}
}