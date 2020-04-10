using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum PlayerActivityType : sbyte
	{
		[FieldOffset(Offset="0x0")]
		INVALID,
		[FieldOffset(Offset="0x0")]
		Lifetime,
		[FieldOffset(Offset="0x0")]
		Daily,
		[FieldOffset(Offset="0x0")]
		DailyCompleteAll,
		[FieldOffset(Offset="0x0")]
		Seasonal,
		[FieldOffset(Offset="0x0")]
		Tutorial,
		[FieldOffset(Offset="0x0")]
		DailyPvp,
		[FieldOffset(Offset="0x0")]
		SeasonalFree,
		[FieldOffset(Offset="0x0")]
		LifetimeChooseReward,
		[FieldOffset(Offset="0x0")]
		DailyWatchAd,
		[FieldOffset(Offset="0x0")]
		DailyOptional
	}
}