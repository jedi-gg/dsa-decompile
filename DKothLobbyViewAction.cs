using Il2CppDummyDll;
using System;

public struct DKothLobbyViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DKothLobbyViewAction.Type ActionType;

	[Address(RVA="0xEFE2B0", Offset="0xEFE2B0", VA="0xEFE2B0")]
	public DKothLobbyViewAction(DKothLobbyViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Rewards,
		[FieldOffset(Offset="0x0")]
		Inventory,
		[FieldOffset(Offset="0x0")]
		Leaderboard,
		[FieldOffset(Offset="0x0")]
		RefreshOpponents,
		[FieldOffset(Offset="0x0")]
		RefreshCooldown,
		[FieldOffset(Offset="0x0")]
		SetDefense,
		[FieldOffset(Offset="0x0")]
		ShowInfo,
		[FieldOffset(Offset="0x0")]
		HideInfo,
		[FieldOffset(Offset="0x0")]
		BattleHistory,
		[FieldOffset(Offset="0x0")]
		Shipment,
		[FieldOffset(Offset="0x0")]
		RefreshCooldownForAd
	}
}