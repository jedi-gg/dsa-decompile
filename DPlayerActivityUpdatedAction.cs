using Il2CppDummyDll;
using Serverproto;
using System;

public struct DPlayerActivityUpdatedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly PlayerActivityType ActivityType;

	[FieldOffset(Offset="0x4")]
	public readonly DPlayerActivityUpdatedAction.Type UpdateType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong ActivityId;

	[Address(RVA="0xEFE7E8", Offset="0xEFE7E8", VA="0xEFE7E8")]
	public DPlayerActivityUpdatedAction(PlayerActivityType activityType, DPlayerActivityUpdatedAction.Type updateType, ulong activityId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Added,
		[FieldOffset(Offset="0x0")]
		UpdatedProgress,
		[FieldOffset(Offset="0x0")]
		Removed
	}
}