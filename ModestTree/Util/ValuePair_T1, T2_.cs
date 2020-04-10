using Il2CppDummyDll;
using System;

namespace ModestTree.Util
{
	public class ValuePair<T1, T2>
	{
		[FieldOffset(Offset="0x0")]
		public readonly T1 First;

		[FieldOffset(Offset="0x0")]
		public readonly T2 Second;

		[Address(RVA="0x1D9A960", Offset="0x1D9A960", VA="0x1D9A960")]
		public ValuePair()
		{
		}

		[Address(RVA="0x1D9A998", Offset="0x1D9A998", VA="0x1D9A998")]
		public ValuePair(T1 first, T2 second)
		{
		}

		[Address(RVA="0x1D9A9E0", Offset="0x1D9A9E0", VA="0x1D9A9E0", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x1D9AA70", Offset="0x1D9AA70", VA="0x1D9AA70")]
		public bool Equals(ValuePair<T1, T2> that)
		{
			return new bool();
		}

		[Address(RVA="0x1D9AB34", Offset="0x1D9AB34", VA="0x1D9AB34", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}
	}
}