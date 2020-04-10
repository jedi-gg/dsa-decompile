using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DClubHubRosterListItemClickedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubHubController.RosterEntry Player;

	[FieldOffset(Offset="0x8")]
	public readonly RectTransform ClickedTransform;

	[Address(RVA="0xF03AA8", Offset="0xF03AA8", VA="0xF03AA8")]
	public DClubHubRosterListItemClickedAction(ClubHubController.RosterEntry player, RectTransform clickedTransform)
	{
	}
}