using Il2CppDummyDll;
using System;

public struct DInventoryItemBuyViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x8")]
	public readonly DInventoryItemBuyViewAction.Type ActionType;

	[Address(RVA="0xEFDF68", Offset="0xEFDF68", VA="0xEFDF68")]
	public DInventoryItemBuyViewAction(ulong itemId, DInventoryItemBuyViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Buy,
		[FieldOffset(Offset="0x0")]
		Go
	}
}