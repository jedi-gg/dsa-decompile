using Il2CppDummyDll;
using System;

public struct DUnitListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DUnitListItemAction.ActionType Type;

	[FieldOffset(Offset="0x8")]
	public readonly ulong UnitDefinitionId;

	[FieldOffset(Offset="0x10")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x18")]
	public readonly int ListItemDataIndex;

	[Address(RVA="0xEFFEF0", Offset="0xEFFEF0", VA="0xEFFEF0")]
	public DUnitListItemAction(DUnitListItemAction.ActionType type, ulong unitDefinitionId, object ownerIdentifier, int dataIndex)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Clicked,
		[FieldOffset(Offset="0x0")]
		Pressed
	}
}