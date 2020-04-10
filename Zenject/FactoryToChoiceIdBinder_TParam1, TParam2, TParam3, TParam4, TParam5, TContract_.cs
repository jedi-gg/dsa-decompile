using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> : FactoryToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>
	{
		[Address(RVA="0x2348C60", Offset="0x2348C60", VA="0x2348C60")]
		public FactoryToChoiceIdBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2348CB4", Offset="0x2348CB4", VA="0x2348CB4")]
		public FactoryToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> WithId(object identifier)
		{
			return null;
		}
	}
}