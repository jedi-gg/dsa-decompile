using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TContract> : FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TContract>
	{
		[Address(RVA="0x23486D0", Offset="0x23486D0", VA="0x23486D0")]
		public FactoryToChoiceBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF9588", Offset="0x2AF9588", VA="0x2AF9588")]
		public FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x2348724", Offset="0x2348724", VA="0x2348724")]
		public FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TContract> ToSelf()
		{
			return null;
		}
	}
}