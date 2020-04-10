using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class SingleProviderBindingFinalizer : ProviderBindingFinalizer
	{
		[FieldOffset(Offset="0x18")]
		private readonly Func<DiContainer, Type, IProvider> _providerFactory;

		[Address(RVA="0x233294C", Offset="0x233294C", VA="0x233294C")]
		public SingleProviderBindingFinalizer(Zenject.BindInfo bindInfo, Func<DiContainer, Type, IProvider> providerFactory)
		{
		}

		[Address(RVA="0x2332978", Offset="0x2332978", VA="0x2332978", Slot="6")]
		protected override void OnFinalizeBinding(DiContainer container)
		{
		}
	}
}