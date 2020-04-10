using Il2CppDummyDll;
using System;

public struct DFriendListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly FriendListItem Item;

	[FieldOffset(Offset="0x8")]
	public readonly DFriendListItemAction.Type ActionType;

	[Address(RVA="0xF053EC", Offset="0xF053EC", VA="0xF053EC")]
	public DFriendListItemAction(FriendListItem item, DFriendListItemAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		CancelFriendRequest,
		[FieldOffset(Offset="0x0")]
		RejectFriendInvite,
		[FieldOffset(Offset="0x0")]
		AcceptFriendInvite
	}
}