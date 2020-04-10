using Il2CppDummyDll;
using System;

public struct DInventoryItemDetailsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x8")]
	public readonly DInventoryItemDetailsViewAction.Type ActionType;

	[Address(RVA="0xEFDF74", Offset="0xEFDF74", VA="0xEFDF74")]
	public DInventoryItemDetailsViewAction(ulong itemId, DInventoryItemDetailsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Find,
		[FieldOffset(Offset="0x0")]
		Request,
		[FieldOffset(Offset="0x0")]
		Go,
		[FieldOffset(Offset="0x0")]
		Vip
	}
}