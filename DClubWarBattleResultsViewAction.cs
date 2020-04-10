using Il2CppDummyDll;
using System;

public struct DClubWarBattleResultsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarBattleResultsViewAction.Type ActionType;

	[Address(RVA="0xF04394", Offset="0xF04394", VA="0xF04394")]
	public DClubWarBattleResultsViewAction(DClubWarBattleResultsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue,
		[FieldOffset(Offset="0x0")]
		Inventory,
		[FieldOffset(Offset="0x0")]
		DailyActivities
	}
}