using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceBinder<TParam1, TParam2, TParam3, TContract> : FactoryFromBinder<TParam1, TParam2, TParam3, TContract>
	{
		[Address(RVA="0x23485C0", Offset="0x23485C0", VA="0x23485C0")]
		public FactoryToChoiceBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF93B0", Offset="0x2AF93B0", VA="0x2AF93B0")]
		public FactoryFromBinder<TParam1, TParam2, TParam3, TConcrete> To<TConcrete>()
		where TConcrete : TContract
		{
			return null;
		}

		[Address(RVA="0x2348614", Offset="0x2348614", VA="0x2348614")]
		public FactoryFromBinder<TParam1, TParam2, TParam3, TContract> ToSelf()
		{
			return null;
		}
	}
}