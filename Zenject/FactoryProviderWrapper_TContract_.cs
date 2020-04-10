using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryProviderWrapper<TContract> : IFactory<TContract>, IFactory
	{
		[FieldOffset(Offset="0x0")]
		private readonly IProvider _provider;

		[FieldOffset(Offset="0x0")]
		private readonly InjectContext _injectContext;

		[Address(RVA="0x1F4B764", Offset="0x1F4B764", VA="0x1F4B764")]
		public FactoryProviderWrapper(IProvider provider, InjectContext injectContext)
		{
		}

		[Address(RVA="0x1F4B7E4", Offset="0x1F4B7E4", VA="0x1F4B7E4", Slot="4")]
		public TContract Create()
		{
			return null;
		}
	}
}