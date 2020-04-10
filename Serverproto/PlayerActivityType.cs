using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum PlayerActivityType
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x106210C", Offset="0x106210C")]
		[FieldOffset(Offset="0x0")]
		InvalidPlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062144", Offset="0x1062144")]
		[FieldOffset(Offset="0x0")]
		LifetimePlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106217C", Offset="0x106217C")]
		[FieldOffset(Offset="0x0")]
		DailyPlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10621B4", Offset="0x10621B4")]
		[FieldOffset(Offset="0x0")]
		DailyCompleteAll,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10621EC", Offset="0x10621EC")]
		[FieldOffset(Offset="0x0")]
		SeasonalPlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062224", Offset="0x1062224")]
		[FieldOffset(Offset="0x0")]
		TutorialPlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106225C", Offset="0x106225C")]
		[FieldOffset(Offset="0x0")]
		DailyPvpActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062294", Offset="0x1062294")]
		[FieldOffset(Offset="0x0")]
		SeasonalFreePlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x10622CC", Offset="0x10622CC")]
		[FieldOffset(Offset="0x0")]
		LifetimeChooseRewardPlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1062304", Offset="0x1062304")]
		[FieldOffset(Offset="0x0")]
		DailyWatchAdPlayerActivity,
		[Attribute(Name="OriginalNameAttribute", RVA="0x106233C", Offset="0x106233C")]
		[FieldOffset(Offset="0x0")]
		DailyOptionalActivity
	}
}