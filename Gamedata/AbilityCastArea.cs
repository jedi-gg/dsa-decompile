using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum AbilityCastArea : sbyte
	{
		[FieldOffset(Offset="0x0")]
		Default,
		[FieldOffset(Offset="0x0")]
		AllySide,
		[FieldOffset(Offset="0x0")]
		EnemySide,
		[FieldOffset(Offset="0x0")]
		AllySideWithPush,
		[FieldOffset(Offset="0x0")]
		EnemySideWithPush,
		[FieldOffset(Offset="0x0")]
		UnitMoveDist
	}
}