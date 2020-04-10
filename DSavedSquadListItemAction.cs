using Il2CppDummyDll;
using System;

public struct DSavedSquadListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSavedSquadListItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x10")]
	public readonly int SquadSlot;

	[Address(RVA="0xEFEFAC", Offset="0xEFEFAC", VA="0xEFEFAC")]
	public DSavedSquadListItemAction(DSavedSquadListItemAction.Type type, object ownerIdentifier, int squadSlot)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Load,
		[FieldOffset(Offset="0x0")]
		Save,
		[FieldOffset(Offset="0x0")]
		Vip
	}
}