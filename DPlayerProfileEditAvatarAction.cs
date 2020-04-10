using Gamedata;
using Il2CppDummyDll;
using System;

public struct DPlayerProfileEditAvatarAction
{
	[FieldOffset(Offset="0x0")]
	public readonly InventoryItem? Avatar;

	[Address(RVA="0xEFE970", Offset="0xEFE970", VA="0xEFE970")]
	public DPlayerProfileEditAvatarAction(InventoryItem? avatar)
	{
	}
}