using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class PlaceholderFactory<TValue> : IPlaceholderFactory, IValidatable
	{
		[FieldOffset(Offset="0x0")]
		private IProvider _provider;

		[FieldOffset(Offset="0x0")]
		private InjectContext _injectContext;

		protected abstract IEnumerable<Type> ParamTypes
		{
			get;
		}

		[Address(RVA="0x235AAD0", Offset="0x235AAD0", VA="0x235AAD0")]
		protected PlaceholderFactory()
		{
		}

		[Address(RVA="0x235A728", Offset="0x235A728", VA="0x235A728")]
		[Attribute(Name="InjectAttribute", RVA="0x10728EC", Offset="0x10728EC")]
		private void Construct(IProvider provider, InjectContext injectContext)
		{
		}

		[Address(RVA="0x235A770", Offset="0x235A770", VA="0x235A770")]
		protected TValue CreateInternal(List<TypeValuePair> extraArgs)
		{
			return null;
		}

		[Address(RVA="0x235AA40", Offset="0x235AA40", VA="0x235AA40", Slot="5")]
		public virtual void Validate()
		{
		}
	}
}