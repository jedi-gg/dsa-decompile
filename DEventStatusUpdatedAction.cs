using Il2CppDummyDll;
using Serverproto;
using System;

public struct DEventStatusUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly EventStatus Status;

	[Address(RVA="0xF05094", Offset="0xF05094", VA="0xF05094")]
	public DEventStatusUpdatedAction(EventStatus status)
	{
	}
}