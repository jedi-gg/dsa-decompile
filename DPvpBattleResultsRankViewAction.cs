using Il2CppDummyDll;
using System;

public struct DPvpBattleResultsRankViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPvpBattleResultsRankViewAction.Type ActionType;

	[Address(RVA="0xEFEB28", Offset="0xEFEB28", VA="0xEFEB28")]
	public DPvpBattleResultsRankViewAction(DPvpBattleResultsRankViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue
	}
}