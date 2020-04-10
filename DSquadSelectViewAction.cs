using Il2CppDummyDll;
using System;

public struct DSquadSelectViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSquadSelectViewAction.Type ActionType;

	[Address(RVA="0xEFF790", Offset="0xEFF790", VA="0xEFF790")]
	public DSquadSelectViewAction(DSquadSelectViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Battle,
		[FieldOffset(Offset="0x0")]
		ClearAll,
		[FieldOffset(Offset="0x0")]
		AutoFillAll,
		[FieldOffset(Offset="0x0")]
		InviteFriend,
		[FieldOffset(Offset="0x0")]
		SetSquad,
		[FieldOffset(Offset="0x0")]
		SavedSquads
	}
}