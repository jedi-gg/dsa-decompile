using Il2CppDummyDll;
using System;

public struct DClubCreateViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubCreateViewAction.Type ActionType;

	[Address(RVA="0xF03734", Offset="0xF03734", VA="0xF03734")]
	public DClubCreateViewAction(DClubCreateViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Create,
		[FieldOffset(Offset="0x0")]
		EditAvatar
	}
}