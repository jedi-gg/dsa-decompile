using Il2CppDummyDll;
using Serverproto;
using System;

public struct DFriendListModifyAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string FriendPlayerId;

	[FieldOffset(Offset="0x8")]
	public readonly FriendsListModifyAction Action;

	[Address(RVA="0xF05488", Offset="0xF05488", VA="0xF05488")]
	public DFriendListModifyAction(string friendPlayerId, FriendsListModifyAction action)
	{
	}
}