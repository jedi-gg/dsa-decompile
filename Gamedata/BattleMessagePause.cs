using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum BattleMessagePause : sbyte
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Instant,
		[FieldOffset(Offset="0x0")]
		Smooth
	}
}