using Il2CppDummyDll;
using System;

public struct DClubActivityViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubActivityViewAction.Type ActionType;

	[Address(RVA="0xF036D0", Offset="0xF036D0", VA="0xF036D0")]
	public DClubActivityViewAction(DClubActivityViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		FindClub
	}
}