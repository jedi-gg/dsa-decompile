using Il2CppDummyDll;
using Serverproto;
using System;

public struct DPlayerActivityClaimedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ActivityId;

	[FieldOffset(Offset="0x8")]
	public readonly Serverproto.InventoryDelta InventoryDelta;

	[Address(RVA="0xEFE78C", Offset="0xEFE78C", VA="0xEFE78C")]
	public DPlayerActivityClaimedAction(ulong activityId, Serverproto.InventoryDelta delta)
	{
	}
}