using Il2CppDummyDll;
using System;

public struct DClubWarTeamHudWidgetAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarTeamHudWidgetAction.ActionType Type;

	[FieldOffset(Offset="0x8")]
	public readonly string ClubId;

	[Address(RVA="0xF0471C", Offset="0xF0471C", VA="0xF0471C")]
	public DClubWarTeamHudWidgetAction(DClubWarTeamHudWidgetAction.ActionType type, string clubId)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Clicked
	}
}