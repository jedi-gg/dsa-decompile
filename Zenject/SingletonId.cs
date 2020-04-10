using Il2CppDummyDll;
using System;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public class SingletonId : IEquatable<SingletonId>
	{
		[FieldOffset(Offset="0x10")]
		public readonly Type ConcreteType;

		[FieldOffset(Offset="0x18")]
		public readonly object ConcreteIdentifier;

		[Address(RVA="0x2332AA0", Offset="0x2332AA0", VA="0x2332AA0")]
		public SingletonId(Type concreteType, object concreteIdentifier)
		{
		}

		[Address(RVA="0x2332B3C", Offset="0x2332B3C", VA="0x2332B3C", Slot="0")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2332C98", Offset="0x2332C98", VA="0x2332C98", Slot="4")]
		public bool Equals(SingletonId that)
		{
			return new bool();
		}

		[Address(RVA="0x2332AD8", Offset="0x2332AD8", VA="0x2332AD8", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2332BD8", Offset="0x2332BD8", VA="0x2332BD8")]
		public static bool operator ==(SingletonId left, SingletonId right)
		{
			return new bool();
		}

		[Address(RVA="0x2332C9C", Offset="0x2332C9C", VA="0x2332C9C")]
		public static bool operator !=(SingletonId left, SingletonId right)
		{
			return new bool();
		}
	}
}