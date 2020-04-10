using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubWarRewardsChestListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarRewardsChestListItemAction.ActionType Type;

	[FieldOffset(Offset="0x8")]
	public readonly ClubWarReward Chest;

	[Address(RVA="0xF04520", Offset="0xF04520", VA="0xF04520")]
	public DClubWarRewardsChestListItemAction(DClubWarRewardsChestListItemAction.ActionType type, ClubWarReward chest)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Open,
		[FieldOffset(Offset="0x0")]
		Inspect
	}
}