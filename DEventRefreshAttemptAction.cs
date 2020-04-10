using Il2CppDummyDll;
using Serverproto;
using System;

public struct DEventRefreshAttemptAction
{
	[FieldOffset(Offset="0x0")]
	public readonly Event SelectedEvent;

	[Address(RVA="0xF05040", Offset="0xF05040", VA="0xF05040")]
	public DEventRefreshAttemptAction(Event selectedEvent)
	{
	}
}