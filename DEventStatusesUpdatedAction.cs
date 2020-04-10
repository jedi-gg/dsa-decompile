using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DEventStatusesUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly IList<EventStatus> Statuses;

	[Address(RVA="0xF050E8", Offset="0xF050E8", VA="0xF050E8")]
	public DEventStatusesUpdatedAction(IList<EventStatus> statuses)
	{
	}
}