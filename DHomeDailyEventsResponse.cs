using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeDailyEventsResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong AvailableBattles;

	[FieldOffset(Offset="0x8")]
	public readonly ulong TotalBattles;

	[Address(RVA="0xEFD870", Offset="0xEFD870", VA="0xEFD870")]
	public DHomeDailyEventsResponse(HomeDailyEventsResponse dailyEvents)
	{
	}
}