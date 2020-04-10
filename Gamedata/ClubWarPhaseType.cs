using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum ClubWarPhaseType : sbyte
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		Registration,
		[FieldOffset(Offset="0x0")]
		Matchmaking,
		[FieldOffset(Offset="0x0")]
		Battle,
		[FieldOffset(Offset="0x0")]
		Downtime,
		[FieldOffset(Offset="0x0")]
		Tally,
		[FieldOffset(Offset="0x0")]
		Planning
	}
}