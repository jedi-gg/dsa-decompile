using Il2CppDummyDll;
using System;

public struct DInventoryItemListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemId;

	[FieldOffset(Offset="0x8")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x10")]
	public readonly bool IsVipExclusive;

	[Address(RVA="0xEFE0C0", Offset="0xEFE0C0", VA="0xEFE0C0")]
	public DInventoryItemListItemAction(ulong itemId, object ownerIdentifier, bool isVipExclusive)
	{
	}
}