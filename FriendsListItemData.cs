using Il2CppDummyDll;
using Serverproto;
using System;

public class FriendsListItemData : PlayerListItemData
{
	[FieldOffset(Offset="0x48")]
	public readonly Serverproto.Friend Friend;

	[FieldOffset(Offset="0x50")]
	public FriendStatus Status;

	[Address(RVA="0x15E94C0", Offset="0x15E94C0", VA="0x15E94C0")]
	public FriendsListItemData(Serverproto.Friend friend)
	{
	}
}