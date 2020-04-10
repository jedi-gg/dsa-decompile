using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class MemoryPoolBindingFinalizer<TContract> : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x0")]
		private readonly MemoryPoolBindInfo _poolBindInfo;

		[FieldOffset(Offset="0x0")]
		private readonly FactoryBindInfo _factoryBindInfo;

		[Address(RVA="0x23545B8", Offset="0x23545B8", VA="0x23545B8")]
		public MemoryPoolBindingFinalizer(Zenject.BindInfo bindInfo, FactoryBindInfo factoryBindInfo, MemoryPoolBindInfo poolBindInfo)
		{
		}

		[Address(RVA="0x2354668", Offset="0x2354668", VA="0x2354668", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}
	}
}