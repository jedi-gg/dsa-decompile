using Il2CppDummyDll;
using Serverproto;
using System;

public struct DEventProgressUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly EventIdentifier EventId;

	[FieldOffset(Offset="0x8")]
	public readonly ulong StarCount;

	[Address(RVA="0xF04FE4", Offset="0xF04FE4", VA="0xF04FE4")]
	public DEventProgressUpdatedAction(EventProgress progress)
	{
	}

	[Address(RVA="0xF04FEC", Offset="0xF04FEC", VA="0xF04FEC")]
	public DEventProgressUpdatedAction(EventIdentifier eventId, ulong starCount)
	{
	}
}