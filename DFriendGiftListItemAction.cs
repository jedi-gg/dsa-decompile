using Il2CppDummyDll;
using System;

public struct DFriendGiftListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DFriendGiftListItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly FriendGiftListItem Item;

	[Address(RVA="0xF05394", Offset="0xF05394", VA="0xF05394")]
	public DFriendGiftListItemAction(DFriendGiftListItemAction.Type actionType, FriendGiftListItem item)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		SelectFriend
	}
}