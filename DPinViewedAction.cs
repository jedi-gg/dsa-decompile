using Il2CppDummyDll;
using System;

public struct DPinViewedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong PinId;

	[FieldOffset(Offset="0x8")]
	public readonly bool ImmediatelyUpdateAllBadges;

	[Address(RVA="0xEFE6D0", Offset="0xEFE6D0", VA="0xEFE6D0")]
	public DPinViewedAction(ulong pinId, bool immediatelyUpdateAllBadges = false)
	{
	}
}