using Il2CppDummyDll;
using System;

public struct DBattleResultsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleResultsViewAction.Type ActionType;

	[Address(RVA="0xF02E04", Offset="0xF02E04", VA="0xF02E04")]
	public DBattleResultsViewAction(DBattleResultsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue,
		[FieldOffset(Offset="0x0")]
		Inventory,
		[FieldOffset(Offset="0x0")]
		DailyActivities,
		[FieldOffset(Offset="0x0")]
		NextBattle,
		[FieldOffset(Offset="0x0")]
		ReplayBattle
	}
}