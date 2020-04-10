using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TContract> : FactoryToChoiceBinder<TParam1, TParam2, TParam3, TContract>
	{
		[Address(RVA="0x2348B00", Offset="0x2348B00", VA="0x2348B00")]
		public FactoryToChoiceIdBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2348B54", Offset="0x2348B54", VA="0x2348B54")]
		public FactoryToChoiceBinder<TParam1, TParam2, TParam3, TContract> WithId(object identifier)
		{
			return null;
		}
	}
}