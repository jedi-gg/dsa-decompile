using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubActivityTierData
{
	[FieldOffset(Offset="0x0")]
	public readonly ClubActivity Activity;

	[FieldOffset(Offset="0x8")]
	public readonly ClubActivityTier Tier;

	[FieldOffset(Offset="0x10")]
	public readonly ulong CurrentValue;

	[Address(RVA="0xF036C4", Offset="0xF036C4", VA="0xF036C4")]
	public DClubActivityTierData(ClubActivity activity, ClubActivityTier tier, ulong currentValue)
	{
	}
}