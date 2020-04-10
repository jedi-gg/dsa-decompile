using Il2CppDummyDll;
using System;

public struct DRevSdkLogAppTrackingEventAction
{
	[FieldOffset(Offset="0x0")]
	public readonly RevSdkAppTrackingEvent Event;

	[FieldOffset(Offset="0x4")]
	public readonly int Value;

	[Address(RVA="0xEFEB94", Offset="0xEFEB94", VA="0xEFEB94")]
	public DRevSdkLogAppTrackingEventAction(RevSdkAppTrackingEvent e, int value = 0)
	{
	}
}