using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum CardProgressTrackerStrategy : sbyte
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		Closest,
		[FieldOffset(Offset="0x0")]
		Available,
		[FieldOffset(Offset="0x0")]
		Any
	}
}