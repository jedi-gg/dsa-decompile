using Il2CppDummyDll;
using System;

namespace Polybrush
{
	public struct z_ColorMask
	{
		[FieldOffset(Offset="0x0")]
		public bool r;

		[FieldOffset(Offset="0x1")]
		public bool g;

		[FieldOffset(Offset="0x2")]
		public bool b;

		[FieldOffset(Offset="0x3")]
		public bool a;

		[Address(RVA="0xF003D8", Offset="0xF003D8", VA="0xF003D8")]
		public z_ColorMask(bool r, bool g, bool b, bool a)
		{
		}
	}
}