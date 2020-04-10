using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Polybrush
{
	public struct z_CommonEdge : IEquatable<z_CommonEdge>
	{
		[FieldOffset(Offset="0x0")]
		public z_Edge edge;

		[FieldOffset(Offset="0x8")]
		public z_Edge common;

		public int cx
		{
			[Address(RVA="0xF0040C", Offset="0xF0040C", VA="0xF0040C")]
			get
			{
				return new int();
			}
		}

		public int cy
		{
			[Address(RVA="0xF00414", Offset="0xF00414", VA="0xF00414")]
			get
			{
				return new int();
			}
		}

		public int x
		{
			[Address(RVA="0xF003FC", Offset="0xF003FC", VA="0xF003FC")]
			get
			{
				return new int();
			}
		}

		public int y
		{
			[Address(RVA="0xF00404", Offset="0xF00404", VA="0xF00404")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0041C", Offset="0xF0041C", VA="0xF0041C")]
		public z_CommonEdge(int _x, int _y, int _cx, int _cy)
		{
		}

		[Address(RVA="0xF00424", Offset="0xF00424", VA="0xF00424", Slot="4")]
		public bool Equals(z_CommonEdge b)
		{
			return new bool();
		}

		[Address(RVA="0xF00434", Offset="0xF00434", VA="0xF00434", Slot="0")]
		public override bool Equals(object b)
		{
			return new bool();
		}

		[Address(RVA="0xF0043C", Offset="0xF0043C", VA="0xF0043C", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1347210", Offset="0x1347210", VA="0x1347210")]
		public static bool operator ==(z_CommonEdge a, z_CommonEdge b)
		{
			return new bool();
		}

		[Address(RVA="0x1347244", Offset="0x1347244", VA="0x1347244")]
		public static bool operator !=(z_CommonEdge a, z_CommonEdge b)
		{
			return new bool();
		}

		[Address(RVA="0x1347784", Offset="0x1347784", VA="0x1347784")]
		public static HashSet<int> ToHashSet(IEnumerable<z_CommonEdge> edges)
		{
			return null;
		}

		[Address(RVA="0x13474A0", Offset="0x13474A0", VA="0x13474A0")]
		public static List<int> ToList(IEnumerable<z_CommonEdge> edges)
		{
			return null;
		}

		[Address(RVA="0xF00448", Offset="0xF00448", VA="0xF00448", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}