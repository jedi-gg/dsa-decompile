using Il2CppDummyDll;
using Serverproto;
using System;

public class FriendGiftListItemData : PlayerListItemData
{
	[FieldOffset(Offset="0x48")]
	public readonly Serverproto.Friend Friend;

	[FieldOffset(Offset="0x50")]
	public FriendStatus Status;

	[Address(RVA="0x12CAF84", Offset="0x12CAF84", VA="0x12CAF84")]
	public FriendGiftListItemData(Serverproto.Friend friend)
	{
	}
}