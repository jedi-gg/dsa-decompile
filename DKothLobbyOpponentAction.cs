using Il2CppDummyDll;
using System;

public struct DKothLobbyOpponentAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DKothLobbyOpponentAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string PlayerId;

	[FieldOffset(Offset="0x10")]
	public readonly ulong PlayerRank;

	[Address(RVA="0xEFE2A4", Offset="0xEFE2A4", VA="0xEFE2A4")]
	public DKothLobbyOpponentAction(DKothLobbyOpponentAction.Type actionType, string playerId, ulong playerRank)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Profile,
		[FieldOffset(Offset="0x0")]
		Battle
	}
}