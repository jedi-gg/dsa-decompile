using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public struct DUnitDisplayData
	{
		[FieldOffset(Offset="0x0")]
		public string Name;

		[FieldOffset(Offset="0x8")]
		public int VertCount;

		[FieldOffset(Offset="0xC")]
		public int TriCount;
	}
}