using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DFriendsListFetchedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<Friend> Friends;

	[Address(RVA="0xF054E8", Offset="0xF054E8", VA="0xF054E8")]
	public DFriendsListFetchedAction(IList<Friend> friends)
	{
	}
}