using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum ClubStat : ushort
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		DungeonNodesCompleted,
		[FieldOffset(Offset="0x0")]
		DungeonMapsCompleted
	}
}