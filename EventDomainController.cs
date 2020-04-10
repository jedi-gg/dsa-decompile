using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class EventDomainController : IDispatchHandler<DHomeScheduledEventsResponse>, IDispatchHandler, IDispatchHandler<DScheduledEventListUpdatedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1057E84", Offset="0x1057E84")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x18")]
	private List<EventGroup> _scheduledEventGroups;

	[FieldOffset(Offset="0x20")]
	private List<Event> _scheduledEvents;

	[Address(RVA="0x1214388", Offset="0x1214388", VA="0x1214388")]
	public EventDomainController()
	{
	}

	[Address(RVA="0x1213E14", Offset="0x1213E14", VA="0x1213E14")]
	public DateTime GetEarliestEventGroupStartTime(EventGroup eventGroup)
	{
		return new DateTime();
	}

	[Address(RVA="0x1214040", Offset="0x1214040", VA="0x1214040")]
	public DateTime GetFurthestEventGroupEndTime(EventGroup eventGroup)
	{
		return new DateTime();
	}

	[Address(RVA="0x1213B8C", Offset="0x1213B8C", VA="0x1213B8C")]
	public Event GetScheduledEvent(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1213CD4", Offset="0x1213CD4", VA="0x1213CD4")]
	public EventGroup GetScheduledEventGroup(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1213CCC", Offset="0x1213CCC", VA="0x1213CCC")]
	public IEnumerable<EventGroup> GetScheduledEventGroups()
	{
		return null;
	}

	[Address(RVA="0x1213B84", Offset="0x1213B84", VA="0x1213B84")]
	public IEnumerable<Event> GetScheduledEvents()
	{
		return null;
	}

	[Address(RVA="0x121426C", Offset="0x121426C", VA="0x121426C", Slot="4")]
	public void HandleDispatchAction(DHomeScheduledEventsResponse action)
	{
	}

	[Address(RVA="0x1214384", Offset="0x1214384", VA="0x1214384", Slot="5")]
	public void HandleDispatchAction(DScheduledEventListUpdatedAction action)
	{
	}

	[Address(RVA="0x1213B14", Offset="0x1213B14", VA="0x1213B14")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1213B4C", Offset="0x1213B4C", VA="0x1213B4C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1214270", Offset="0x1214270", VA="0x1214270")]
	private void UpdateScheduledEvents(IList<EventGroup> eventGroups, IList<Event> events)
	{
	}
}