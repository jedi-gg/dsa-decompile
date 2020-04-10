using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubListClubAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubListClubAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly Serverproto.Club Club;

	[Address(RVA="0xF03F28", Offset="0xF03F28", VA="0xF03F28")]
	public DClubListClubAction(DClubListClubAction.Type actionType, Serverproto.Club club)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		GoToHub,
		[FieldOffset(Offset="0x0")]
		SendJoinRequest,
		[FieldOffset(Offset="0x0")]
		CancelJoinRequest
	}
}