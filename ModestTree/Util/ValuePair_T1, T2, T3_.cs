using Il2CppDummyDll;
using System;

namespace ModestTree.Util
{
	public class ValuePair<T1, T2, T3>
	{
		[FieldOffset(Offset="0x0")]
		public readonly T1 First;

		[FieldOffset(Offset="0x0")]
		public readonly T2 Second;

		[FieldOffset(Offset="0x0")]
		public readonly T3 Third;

		[Address(RVA="0x1D9AD44", Offset="0x1D9AD44", VA="0x1D9AD44")]
		public ValuePair()
		{
		}

		[Address(RVA="0x1D9AD7C", Offset="0x1D9AD7C", VA="0x1D9AD7C")]
		public ValuePair(T1 first, T2 second, T3 third)
		{
		}

		[Address(RVA="0x1D9ADC8", Offset="0x1D9ADC8", VA="0x1D9ADC8", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x1D9AE58", Offset="0x1D9AE58", VA="0x1D9AE58")]
		public bool Equals(ValuePair<T1, T2, T3> that)
		{
			return new bool();
		}

		[Address(RVA="0x1D9AEC0", Offset="0x1D9AEC0", VA="0x1D9AEC0", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}
	}
}