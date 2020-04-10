using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceBinder<TContract> : FactoryFromBinder<TContract>
	{
		[Address(RVA="0x2348290", Offset="0x2348290", VA="0x2348290")]
		public FactoryToChoiceBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF8E28", Offset="0x2AF8E28", VA="0x2AF8E28")]
		public FactoryFromBinder<TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x23482E4", Offset="0x23482E4", VA="0x23482E4")]
		public FactoryFromBinder<TContract> ToSelf()
		{
			return null;
		}
	}
}