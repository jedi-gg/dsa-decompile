using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class EventUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x1058340", Offset="0x1058340")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058350", Offset="0x1058350")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058360", Offset="0x1058360")]
	[FieldOffset(Offset="0x20")]
	private EventDomainController _eventDc;

	[Address(RVA="0x12B95B4", Offset="0x12B95B4", VA="0x12B95B4")]
	public EventUtility()
	{
	}

	[Address(RVA="0x12B87B8", Offset="0x12B87B8", VA="0x12B87B8")]
	public int GetCountOfPlayableScheduledEvents()
	{
		return new int();
	}

	[Address(RVA="0x12B8DF4", Offset="0x12B8DF4", VA="0x12B8DF4")]
	public int GetCountOfPlayableScheduledEventsWithinEventGroup(ulong eventGroupId)
	{
		return new int();
	}

	[Address(RVA="0x12B90D4", Offset="0x12B90D4", VA="0x12B90D4")]
	public int GetNextOpenLifetimeEventTier(Event e)
	{
		return new int();
	}

	[Address(RVA="0x12B91CC", Offset="0x12B91CC", VA="0x12B91CC")]
	public ulong GetPlayableBattlesRemaining(ulong eventContentId)
	{
		return new ulong();
	}

	[Address(RVA="0x12B92B0", Offset="0x12B92B0", VA="0x12B92B0")]
	public bool HasAnyEventTierAvailableToInstantBattle(List<IEventModel> events)
	{
		return new bool();
	}

	[Address(RVA="0x12B8A64", Offset="0x12B8A64", VA="0x12B8A64")]
	public bool HasPlayableEventTier(Event evt)
	{
		return new bool();
	}
}