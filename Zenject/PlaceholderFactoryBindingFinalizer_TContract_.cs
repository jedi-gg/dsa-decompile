using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class PlaceholderFactoryBindingFinalizer<TContract> : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x0")]
		private readonly FactoryBindInfo _factoryBindInfo;

		[Address(RVA="0x235A4B8", Offset="0x235A4B8", VA="0x235A4B8")]
		public PlaceholderFactoryBindingFinalizer(Zenject.BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x235A55C", Offset="0x235A55C", VA="0x235A55C", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}
	}
}