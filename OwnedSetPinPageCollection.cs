using Gamedata;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class OwnedSetPinPageCollection
{
	[FieldOffset(Offset="0x10")]
	public List<InventoryItem?> OwnedPins;

	[FieldOffset(Offset="0x18")]
	public ulong PinPageId;

	[Address(RVA="0x12FF9DC", Offset="0x12FF9DC", VA="0x12FF9DC")]
	public OwnedSetPinPageCollection()
	{
	}
}