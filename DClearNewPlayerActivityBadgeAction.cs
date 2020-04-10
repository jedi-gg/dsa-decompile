using Il2CppDummyDll;
using System;

public struct DClearNewPlayerActivityBadgeAction
{
	[FieldOffset(Offset="0x0")]
	public BadgingSource BadgingType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong ActivityId;

	[Address(RVA="0xF03664", Offset="0xF03664", VA="0xF03664")]
	public DClearNewPlayerActivityBadgeAction(BadgingSource badgingType, ulong activityId)
	{
	}
}