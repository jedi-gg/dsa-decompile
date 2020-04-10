using Glunies;
using Il2CppDummyDll;
using System;

public class EventGameStateContext : GameStateTransitionContext
{
	[FieldOffset(Offset="0x20")]
	public readonly ulong EventContentId;

	[FieldOffset(Offset="0x28")]
	public readonly bool EnterEvent;

	[Address(RVA="0x1202594", Offset="0x1202594", VA="0x1202594")]
	public EventGameStateContext(ulong eventContentId, bool enterEvent = true)
	{
	}

	public enum EventType
	{
		[FieldOffset(Offset="0x0")]
		Daily,
		[FieldOffset(Offset="0x0")]
		Scheduled
	}
}