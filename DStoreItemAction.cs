using Il2CppDummyDll;
using System;

public struct DStoreItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DStoreItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly StoreItemData ItemData;

	[FieldOffset(Offset="0x10")]
	public readonly string GiftId;

	[FieldOffset(Offset="0x18")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x20")]
	public readonly string TelemetryItemLocation;

	[FieldOffset(Offset="0x28")]
	public readonly ulong CostItemId;

	[Address(RVA="0xEFF854", Offset="0xEFF854", VA="0xEFF854")]
	public DStoreItemAction(DStoreItemAction.Type actionType, StoreItemData itemData, object ownerIdentifier, string giftId = "", string telemetryItemLocation = "", ulong costItemId = 0L)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Buy,
		[FieldOffset(Offset="0x0")]
		ShowDetails,
		[FieldOffset(Offset="0x0")]
		Gift
	}
}