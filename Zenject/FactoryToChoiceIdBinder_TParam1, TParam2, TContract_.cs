using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceIdBinder<TParam1, TParam2, TContract> : FactoryToChoiceBinder<TParam1, TParam2, TContract>
	{
		[Address(RVA="0x2348A50", Offset="0x2348A50", VA="0x2348A50")]
		public FactoryToChoiceIdBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2348AA4", Offset="0x2348AA4", VA="0x2348AA4")]
		public FactoryToChoiceBinder<TParam1, TParam2, TContract> WithId(object identifier)
		{
			return null;
		}
	}
}