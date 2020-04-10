using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubItemRequestedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubItemRequest ItemRequest;

	[FieldOffset(Offset="0x8")]
	public readonly DateTime NextItemRequestTime;

	[Address(RVA="0xF03E40", Offset="0xF03E40", VA="0xF03E40")]
	public DClubItemRequestedAction(RequestClubItemResponse response)
	{
	}
}