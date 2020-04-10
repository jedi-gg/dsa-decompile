using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceBinder<TParam1, TParam2, TContract> : FactoryFromBinder<TParam1, TParam2, TContract>
	{
		[Address(RVA="0x23484B0", Offset="0x23484B0", VA="0x23484B0")]
		public FactoryToChoiceBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF91D8", Offset="0x2AF91D8", VA="0x2AF91D8")]
		public FactoryFromBinder<TParam1, TParam2, TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x2348504", Offset="0x2348504", VA="0x2348504")]
		public FactoryFromBinder<TParam1, TParam2, TContract> ToSelf()
		{
			return null;
		}
	}
}