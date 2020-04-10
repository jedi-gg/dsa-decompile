using Il2CppDummyDll;
using System;

public struct DFriendsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DFriendsViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string FriendId;

	[Address(RVA="0xF05578", Offset="0xF05578", VA="0xF05578")]
	public DFriendsViewAction(DFriendsViewAction.Type actionType, string friendId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		InviteLink
	}
}