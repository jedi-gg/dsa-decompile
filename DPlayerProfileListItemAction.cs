using Il2CppDummyDll;
using Serverproto;
using System;

public struct DPlayerProfileListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPlayerProfileListItemAction.ActionType Type;

	[FieldOffset(Offset="0x8")]
	public readonly PlayerProfileSimple Player;

	[FieldOffset(Offset="0x10")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x18")]
	public readonly int ListItemDataIndex;

	[Address(RVA="0xEFEA80", Offset="0xEFEA80", VA="0xEFEA80")]
	public DPlayerProfileListItemAction(DPlayerProfileListItemAction.ActionType type, PlayerProfileSimple player, object ownerIdentifier, int dataIndex)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Clicked
	}
}