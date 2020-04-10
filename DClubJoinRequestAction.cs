using Il2CppDummyDll;
using System;

public struct DClubJoinRequestAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubJoinRequestAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string ClubId;

	[Address(RVA="0xF03ED0", Offset="0xF03ED0", VA="0xF03ED0")]
	public DClubJoinRequestAction(string clubId, DClubJoinRequestAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Sent,
		[FieldOffset(Offset="0x0")]
		Canceled
	}
}