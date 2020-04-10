using Il2CppDummyDll;
using System;

public struct DPlayerListItemClickedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly PlayerListItem Item;

	[FieldOffset(Offset="0x8")]
	public readonly DPlayerListItemClickedAction.Type ActionType;

	[Address(RVA="0xEFE908", Offset="0xEFE908", VA="0xEFE908")]
	public DPlayerListItemClickedAction(PlayerListItem item, DPlayerListItemClickedAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Tapped,
		[FieldOffset(Offset="0x0")]
		Unblock
	}
}