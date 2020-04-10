using Il2CppDummyDll;
using System;

public struct DClubWarViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarViewAction.Type ActionType;

	[Address(RVA="0xF0477C", Offset="0xF0477C", VA="0xF0477C")]
	public DClubWarViewAction(DClubWarViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		MemberRegister,
		[FieldOffset(Offset="0x0")]
		MemberUnregister,
		[FieldOffset(Offset="0x0")]
		RegisteredMembersClicked,
		[FieldOffset(Offset="0x0")]
		SquadRoster,
		[FieldOffset(Offset="0x0")]
		Rewards,
		[FieldOffset(Offset="0x0")]
		ShowShipments,
		[FieldOffset(Offset="0x0")]
		ShowInfo,
		[FieldOffset(Offset="0x0")]
		HideInfo
	}
}