using Il2CppDummyDll;
using System;

[Flags]
public enum FetchableContent
{
	[FieldOffset(Offset="0x0")]
	All = -1,
	[FieldOffset(Offset="0x0")]
	None = 0,
	[FieldOffset(Offset="0x0")]
	Gamedata = 1,
	[FieldOffset(Offset="0x0")]
	Loc = 2,
	[FieldOffset(Offset="0x0")]
	Assets = 4
}