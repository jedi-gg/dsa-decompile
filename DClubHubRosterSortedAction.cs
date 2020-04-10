using Il2CppDummyDll;
using System;

public struct DClubHubRosterSortedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubHubRosterSortMode SortMode;

	[FieldOffset(Offset="0x8")]
	public readonly string SortNameKey;

	[Address(RVA="0xF03B38", Offset="0xF03B38", VA="0xF03B38")]
	public DClubHubRosterSortedAction(ClubHubRosterSortMode sortMode, string sortNameKey)
	{
	}
}