using Il2CppDummyDll;
using System;

public struct DClubDungeonViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubDungeonViewAction.Type ActionType;

	[Address(RVA="0xF03A00", Offset="0xF03A00", VA="0xF03A00")]
	public DClubDungeonViewAction(DClubDungeonViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShowShipments,
		[FieldOffset(Offset="0x0")]
		BonusAttempt,
		[FieldOffset(Offset="0x0")]
		ShowEventDetails
	}
}