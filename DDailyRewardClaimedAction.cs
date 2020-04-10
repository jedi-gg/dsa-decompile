using Il2CppDummyDll;
using Serverproto;
using System;

public struct DDailyRewardClaimedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.DailyReward DailyReward;

	[Address(RVA="0xF04AFC", Offset="0xF04AFC", VA="0xF04AFC")]
	public DDailyRewardClaimedAction(Serverproto.DailyReward dailyReward)
	{
	}
}