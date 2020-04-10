using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DSquadSelectedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly PlayerSquadSelection SquadSelection;

	[Address(RVA="0xEFF7E4", Offset="0xEFF7E4", VA="0xEFF7E4")]
	public DSquadSelectedAction(Gamedata.GameMode gameMode, ulong slot, IReadOnlyList<ulong> unitIds, IReadOnlyList<ulong> spellIds, ulong leaderUnitId)
	{
	}
}