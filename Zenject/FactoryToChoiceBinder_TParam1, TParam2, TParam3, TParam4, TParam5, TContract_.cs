using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> : FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>
	{
		[Address(RVA="0x23487E0", Offset="0x23487E0", VA="0x23487E0")]
		public FactoryToChoiceBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF9760", Offset="0x2AF9760", VA="0x2AF9760")]
		public FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x2348834", Offset="0x2348834", VA="0x2348834")]
		public FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> ToSelf()
		{
			return null;
		}
	}
}