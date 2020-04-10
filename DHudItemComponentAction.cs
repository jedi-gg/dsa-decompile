using Gamedata;
using Il2CppDummyDll;
using System;

public struct DHudItemComponentAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong ItemContentId;

	[FieldOffset(Offset="0x8")]
	public readonly InventoryItemType ItemType;

	[Address(RVA="0xEFDB54", Offset="0xEFDB54", VA="0xEFDB54")]
	public DHudItemComponentAction(ulong itemContentId, InventoryItemType itemType)
	{
	}
}