using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceIdBinder<TParam1, TContract> : FactoryToChoiceBinder<TParam1, TContract>
	{
		[Address(RVA="0x23489A0", Offset="0x23489A0", VA="0x23489A0")]
		public FactoryToChoiceIdBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x23489F4", Offset="0x23489F4", VA="0x23489F4")]
		public FactoryToChoiceBinder<TParam1, TContract> WithId(object identifier)
		{
			return null;
		}
	}
}