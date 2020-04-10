using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPoolInitialSizeBinder<TContract> : MemoryPoolExpandBinder<TContract>
	{
		[Address(RVA="0x2354A80", Offset="0x2354A80", VA="0x2354A80")]
		public MemoryPoolInitialSizeBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo, Zenject.MemoryPoolBindInfo poolBindInfo)
		{
		}

		[Address(RVA="0x2354B50", Offset="0x2354B50", VA="0x2354B50")]
		public FactoryToChoiceIdBinder<TContract> WithFixedSize(int size)
		{
			return null;
		}

		[Address(RVA="0x2354AE4", Offset="0x2354AE4", VA="0x2354AE4")]
		public MemoryPoolExpandBinder<TContract> WithInitialSize(int size)
		{
			return null;
		}
	}
}