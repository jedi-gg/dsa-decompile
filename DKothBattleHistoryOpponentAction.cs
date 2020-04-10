using Il2CppDummyDll;
using System;

public struct DKothBattleHistoryOpponentAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DKothBattleHistoryOpponentAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string PlayerId;

	[FieldOffset(Offset="0x10")]
	public readonly ulong PlayerRank;

	[Address(RVA="0xEFE1E8", Offset="0xEFE1E8", VA="0xEFE1E8")]
	public DKothBattleHistoryOpponentAction(DKothBattleHistoryOpponentAction.Type actionType, string playerId, ulong playerRank)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Profile
	}
}