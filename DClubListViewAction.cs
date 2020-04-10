using Il2CppDummyDll;
using System;

public struct DClubListViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubListViewAction.Type ActionType;

	[Address(RVA="0xF04008", Offset="0xF04008", VA="0xF04008")]
	public DClubListViewAction(DClubListViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		PlayerClub,
		[FieldOffset(Offset="0x0")]
		CreateClub,
		[FieldOffset(Offset="0x0")]
		NextPage,
		[FieldOffset(Offset="0x0")]
		PrevPage
	}
}