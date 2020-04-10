using Il2CppDummyDll;
using System;

public struct DPlayerListItemUtilityAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPlayerListItemUtilityAction.Type ActionType;

	[Address(RVA="0xEFE914", Offset="0xEFE914", VA="0xEFE914")]
	public DPlayerListItemUtilityAction(DPlayerListItemUtilityAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		SendFriendGift
	}
}