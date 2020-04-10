using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClaimDailyEnergyGiftAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong EnergyItemId;

	[FieldOffset(Offset="0x8")]
	public readonly RepeatedField<PlayerEnergyDailyGifts> DailyGifts;

	[Address(RVA="0xF0365C", Offset="0xF0365C", VA="0xF0365C")]
	public DClaimDailyEnergyGiftAction(ulong energyItemId, RepeatedField<PlayerEnergyDailyGifts> dailyGifts)
	{
	}
}