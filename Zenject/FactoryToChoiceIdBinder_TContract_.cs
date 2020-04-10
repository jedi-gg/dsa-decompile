using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryToChoiceIdBinder<TContract> : FactoryToChoiceBinder<TContract>
	{
		[Address(RVA="0x23488F0", Offset="0x23488F0", VA="0x23488F0")]
		public FactoryToChoiceIdBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2348944", Offset="0x2348944", VA="0x2348944")]
		public FactoryToChoiceBinder<TContract> WithId(object identifier)
		{
			return null;
		}
	}
}