using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum BattleRuleset : byte
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		StandardPve,
		[FieldOffset(Offset="0x0")]
		StandardPvp,
		[FieldOffset(Offset="0x0")]
		CoopPve,
		[FieldOffset(Offset="0x0")]
		Tutorial,
		[FieldOffset(Offset="0x0")]
		Tower
	}
}