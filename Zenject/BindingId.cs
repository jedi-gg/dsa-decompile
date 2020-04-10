using Il2CppDummyDll;
using System;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public class BindingId : IEquatable<BindingId>
	{
		[FieldOffset(Offset="0x10")]
		public readonly System.Type Type;

		[FieldOffset(Offset="0x18")]
		public readonly object Identifier;

		[Address(RVA="0x15AC4A8", Offset="0x15AC4A8", VA="0x15AC4A8")]
		public BindingId(System.Type type, object identifier)
		{
		}

		[Address(RVA="0x15AC544", Offset="0x15AC544", VA="0x15AC544", Slot="0")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x15AC6A0", Offset="0x15AC6A0", VA="0x15AC6A0", Slot="4")]
		public bool Equals(BindingId that)
		{
			return new bool();
		}

		[Address(RVA="0x15AC4E0", Offset="0x15AC4E0", VA="0x15AC4E0", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x15AC5E0", Offset="0x15AC5E0", VA="0x15AC5E0")]
		public static bool operator ==(BindingId left, BindingId right)
		{
			return new bool();
		}

		[Address(RVA="0x15AC6A4", Offset="0x15AC6A4", VA="0x15AC6A4")]
		public static bool operator !=(BindingId left, BindingId right)
		{
			return new bool();
		}
	}
}