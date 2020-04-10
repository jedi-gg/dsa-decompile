using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public struct DClubDungeonRewardGroup
{
	[FieldOffset(Offset="0x0")]
	public readonly string Name;

	[FieldOffset(Offset="0x8")]
	public readonly bool IsCurrent;

	[FieldOffset(Offset="0x10")]
	public List<DClubDungeonRewardItem> Rewards;

	[Address(RVA="0xF03994", Offset="0xF03994", VA="0xF03994")]
	public DClubDungeonRewardGroup(string name, bool isCurrent, List<DClubDungeonRewardItem> rewards)
	{
	}
}