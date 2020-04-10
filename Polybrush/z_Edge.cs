using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Polybrush
{
	public struct z_Edge : IEquatable<z_Edge>
	{
		[FieldOffset(Offset="0x0")]
		public int x;

		[FieldOffset(Offset="0x4")]
		public int y;

		[Address(RVA="0xEFD124", Offset="0xEFD124", VA="0xEFD124")]
		public z_Edge(int _x, int _y)
		{
		}

		[Address(RVA="0xEFD12C", Offset="0xEFD12C", VA="0xEFD12C", Slot="4")]
		public bool Equals(z_Edge p)
		{
			return new bool();
		}

		[Address(RVA="0xEFD214", Offset="0xEFD214", VA="0xEFD214", Slot="0")]
		public override bool Equals(object b)
		{
			return new bool();
		}

		[Address(RVA="0xEFD21C", Offset="0xEFD21C", VA="0xEFD21C", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x126DA30", Offset="0x126DA30", VA="0x126DA30")]
		public static bool operator ==(z_Edge a, z_Edge b)
		{
			return new bool();
		}

		[Address(RVA="0x126DA68", Offset="0x126DA68", VA="0x126DA68")]
		public static bool operator !=(z_Edge a, z_Edge b)
		{
			return new bool();
		}

		[Address(RVA="0x126DEB0", Offset="0x126DEB0", VA="0x126DEB0")]
		public static HashSet<int> ToHashSet(IEnumerable<z_Edge> edges)
		{
			return null;
		}

		[Address(RVA="0x126DBCC", Offset="0x126DBCC", VA="0x126DBCC")]
		public static List<int> ToList(IEnumerable<z_Edge> edges)
		{
			return null;
		}

		[Address(RVA="0xEFD224", Offset="0xEFD224", VA="0xEFD224", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}