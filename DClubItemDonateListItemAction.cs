using Il2CppDummyDll;
using System;

public struct DClubItemDonateListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubItemDonateListItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ClubItemDonateController.ClubItemRequestModel ItemRequest;

	[Address(RVA="0xF03D8C", Offset="0xF03D8C", VA="0xF03D8C")]
	public DClubItemDonateListItemAction(DClubItemDonateListItemAction.Type actionType, ClubItemDonateController.ClubItemRequestModel itemRequest)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Clicked,
		[FieldOffset(Offset="0x0")]
		Expired,
		[FieldOffset(Offset="0x0")]
		Find
	}
}