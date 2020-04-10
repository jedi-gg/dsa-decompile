using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubDungeonRewardItem
{
	[FieldOffset(Offset="0x0")]
	public readonly Gamedata.InventoryItem Item;

	[FieldOffset(Offset="0x10")]
	public readonly Serverproto.ItemCount ItemCount;

	[Address(RVA="0xF039F4", Offset="0xF039F4", VA="0xF039F4")]
	public DClubDungeonRewardItem(Gamedata.InventoryItem item, Serverproto.ItemCount itemCount)
	{
	}
}