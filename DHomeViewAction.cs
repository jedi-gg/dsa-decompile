using Il2CppDummyDll;
using System;

public struct DHomeViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DHomeViewAction.Type ActionType;

	[Address(RVA="0xEFD9D0", Offset="0xEFD9D0", VA="0xEFD9D0")]
	public DHomeViewAction(DHomeViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Battle,
		[FieldOffset(Offset="0x0")]
		Inventory,
		[FieldOffset(Offset="0x0")]
		DailyActivity,
		[FieldOffset(Offset="0x0")]
		PassportActivity,
		[FieldOffset(Offset="0x0")]
		Social,
		[FieldOffset(Offset="0x0")]
		ClubDungeon,
		[FieldOffset(Offset="0x0")]
		Inbox,
		[FieldOffset(Offset="0x0")]
		Store,
		[FieldOffset(Offset="0x0")]
		Shipments,
		[FieldOffset(Offset="0x0")]
		DailyEvents,
		[FieldOffset(Offset="0x0")]
		ScheduledEvents,
		[FieldOffset(Offset="0x0")]
		Tower,
		[FieldOffset(Offset="0x0")]
		Koth,
		[FieldOffset(Offset="0x0")]
		ClubWar,
		[FieldOffset(Offset="0x0")]
		SpecialOffer,
		[FieldOffset(Offset="0x0")]
		ClubSupport
	}
}