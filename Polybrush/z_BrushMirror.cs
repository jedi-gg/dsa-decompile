using Il2CppDummyDll;
using System;

namespace Polybrush
{
	[Flags]
	public enum z_BrushMirror
	{
		[FieldOffset(Offset="0x0")]
		None = 0,
		[FieldOffset(Offset="0x0")]
		X = 1,
		[FieldOffset(Offset="0x0")]
		Y = 2,
		[FieldOffset(Offset="0x0")]
		Z = 4
	}
}