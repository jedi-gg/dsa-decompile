using Il2CppDummyDll;
using System;

public struct DSendFriendAGiftAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSendFriendAGiftAction.Type ActionType;

	[Address(RVA="0xEFF080", Offset="0xEFF080", VA="0xEFF080")]
	public DSendFriendAGiftAction(DSendFriendAGiftAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		SendFriendAGift
	}
}