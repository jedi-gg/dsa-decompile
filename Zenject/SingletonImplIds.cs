using Il2CppDummyDll;
using System;

namespace Zenject
{
	public static class SingletonImplIds
	{
		public class ToGetter
		{
			[FieldOffset(Offset="0x10")]
			private readonly Delegate _method;

			[FieldOffset(Offset="0x18")]
			private readonly object _identifier;

			[Address(RVA="0x2332CD8", Offset="0x2332CD8", VA="0x2332CD8")]
			public ToGetter(object identifier, Delegate method)
			{
			}

			[Address(RVA="0x2332D74", Offset="0x2332D74", VA="0x2332D74", Slot="0")]
			public override bool Equals(object otherObj)
			{
				return new bool();
			}

			[Address(RVA="0x2332D10", Offset="0x2332D10", VA="0x2332D10", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}
		}

		public class ToMethod
		{
			[FieldOffset(Offset="0x10")]
			private readonly Delegate _method;

			[Address(RVA="0x2332EA4", Offset="0x2332EA4", VA="0x2332EA4")]
			public ToMethod(Delegate method)
			{
			}

			[Address(RVA="0x2332F0C", Offset="0x2332F0C", VA="0x2332F0C", Slot="0")]
			public override bool Equals(object otherObj)
			{
				return new bool();
			}

			[Address(RVA="0x2332ED0", Offset="0x2332ED0", VA="0x2332ED0", Slot="2")]
			public override int GetHashCode()
			{
				return new int();
			}
		}
	}
}