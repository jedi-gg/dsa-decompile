using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubItemDonatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubItemRequest ItemRequest;

	[FieldOffset(Offset="0x8")]
	public readonly InventoryDelta Reward;

	[Address(RVA="0xF03DEC", Offset="0xF03DEC", VA="0xF03DEC")]
	public DClubItemDonatedAction(ClubItemRequest itemRequest, InventoryDelta reward)
	{
	}
}