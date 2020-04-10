using Il2CppDummyDll;
using System;

namespace Zenject
{
	[Attribute(Name="ZenjectAllowDuringValidationAttribute", RVA="0x1049304", Offset="0x1049304")]
	public class Lazy<T> : ILazy
	{
		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x0")]
		private readonly InjectContext _context;

		[FieldOffset(Offset="0x0")]
		private bool _hasValue;

		[FieldOffset(Offset="0x0")]
		private Zenject.T _value;

		public Zenject.T Value
		{
			[Address(RVA="0x23538E8", Offset="0x23538E8", VA="0x23538E8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x23537D8", Offset="0x23537D8", VA="0x23537D8")]
		public Lazy(DiContainer container, InjectContext context)
		{
		}

		[Address(RVA="0x23538B4", Offset="0x23538B4", VA="0x23538B4", Slot="4")]
		private void Zenject.ILazy.Validate()
		{
		}
	}
}