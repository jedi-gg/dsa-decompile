using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TContract> : FactoryToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TContract>
	{
		[Address(RVA="0x2348BB0", Offset="0x2348BB0", VA="0x2348BB0")]
		public FactoryToChoiceIdBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2348C04", Offset="0x2348C04", VA="0x2348C04")]
		public FactoryToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TContract> WithId(object identifier)
		{
			return null;
		}
	}
}