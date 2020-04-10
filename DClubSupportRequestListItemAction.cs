using Il2CppDummyDll;
using System;

public struct DClubSupportRequestListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubSupportRequestListItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ClubItemDonateController.ClubSupportRequestModel SupportRequest;

	[Address(RVA="0xF04388", Offset="0xF04388", VA="0xF04388")]
	public DClubSupportRequestListItemAction(DClubSupportRequestListItemAction.Type actionType, ClubItemDonateController.ClubSupportRequestModel supportRequest)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Fulfill,
		[FieldOffset(Offset="0x0")]
		Expired
	}
}