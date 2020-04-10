using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum Recurrence : byte
	{
		[FieldOffset(Offset="0x0")]
		NONE,
		[FieldOffset(Offset="0x0")]
		WeeklyRecurrence,
		[FieldOffset(Offset="0x0")]
		MonthlyRecurrence
	}
}