using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DHomeScheduledEventsResponse
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<EventGroup> ScheduledEventGroups;

	[FieldOffset(Offset="0x8")]
	public readonly IList<Event> ScheduledEvents;

	[Address(RVA="0xEFD96C", Offset="0xEFD96C", VA="0xEFD96C")]
	public DHomeScheduledEventsResponse(HomeScheduledEventsResponse response)
	{
	}
}