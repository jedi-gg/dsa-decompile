using Il2CppDummyDll;
using System;

namespace Polybrush
{
	[Flags]
	public enum z_MeshChannel
	{
		[FieldOffset(Offset="0x0")]
		Null = 0,
		[FieldOffset(Offset="0x0")]
		Position = 0,
		[FieldOffset(Offset="0x0")]
		Normal = 1,
		[FieldOffset(Offset="0x0")]
		Color = 2,
		[FieldOffset(Offset="0x0")]
		Tangent = 4,
		[FieldOffset(Offset="0x0")]
		UV0 = 8,
		[FieldOffset(Offset="0x0")]
		UV2 = 16,
		[FieldOffset(Offset="0x0")]
		UV3 = 32,
		[FieldOffset(Offset="0x0")]
		UV4 = 64,
		[FieldOffset(Offset="0x0")]
		All = 255
	}
}