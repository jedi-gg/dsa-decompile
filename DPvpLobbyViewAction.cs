using Il2CppDummyDll;
using System;

public struct DPvpLobbyViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPvpLobbyViewAction.Type ActionType;

	[Address(RVA="0xEFEB38", Offset="0xEFEB38", VA="0xEFEB38")]
	public DPvpLobbyViewAction(DPvpLobbyViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		WeeklyRewards,
		[FieldOffset(Offset="0x0")]
		SeasonRewards,
		[FieldOffset(Offset="0x0")]
		Inventory,
		[FieldOffset(Offset="0x0")]
		Shipments,
		[FieldOffset(Offset="0x0")]
		Passport
	}
}