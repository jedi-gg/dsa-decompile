using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DScheduledEventListUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<EventGroup> EventGroups;

	[FieldOffset(Offset="0x8")]
	public readonly IList<Event> Events;

	[Address(RVA="0xEFF008", Offset="0xEFF008", VA="0xEFF008")]
	public DScheduledEventListUpdatedAction(IList<EventGroup> eventGroups, IList<Event> events)
	{
	}
}