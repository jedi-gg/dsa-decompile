using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum BonusLootGameMode : sbyte
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		Campaign,
		[FieldOffset(Offset="0x0")]
		Tower,
		[FieldOffset(Offset="0x0")]
		ClubDungeon,
		[FieldOffset(Offset="0x0")]
		DailyEvent,
		[FieldOffset(Offset="0x0")]
		ScheduledEvent,
		[FieldOffset(Offset="0x0")]
		Pvp
	}
}