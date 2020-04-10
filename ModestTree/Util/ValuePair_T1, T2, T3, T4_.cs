using Il2CppDummyDll;
using System;

namespace ModestTree.Util
{
	public class ValuePair<T1, T2, T3, T4>
	{
		[FieldOffset(Offset="0x0")]
		public readonly T1 First;

		[FieldOffset(Offset="0x0")]
		public readonly T2 Second;

		[FieldOffset(Offset="0x0")]
		public readonly T3 Third;

		[FieldOffset(Offset="0x0")]
		public readonly T4 Fourth;

		[Address(RVA="0x1D9AF40", Offset="0x1D9AF40", VA="0x1D9AF40")]
		public ValuePair()
		{
		}

		[Address(RVA="0x1D9AF78", Offset="0x1D9AF78", VA="0x1D9AF78")]
		public ValuePair(T1 first, T2 second, T3 third, T4 fourth)
		{
		}

		[Address(RVA="0x1D9AFD0", Offset="0x1D9AFD0", VA="0x1D9AFD0", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x1D9B060", Offset="0x1D9B060", VA="0x1D9B060")]
		public bool Equals(ValuePair<T1, T2, T3, T4> that)
		{
			return new bool();
		}

		[Address(RVA="0x1D9B0DC", Offset="0x1D9B0DC", VA="0x1D9B0DC", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}
	}
}