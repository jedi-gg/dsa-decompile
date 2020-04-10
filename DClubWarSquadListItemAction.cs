using Il2CppDummyDll;
using System;

public struct DClubWarSquadListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarSquadListItemAction.ActionType Type;

	[FieldOffset(Offset="0x8")]
	public readonly object OwnerIdentifier;

	[FieldOffset(Offset="0x10")]
	public readonly string SquadId;

	[Address(RVA="0xF04680", Offset="0xF04680", VA="0xF04680")]
	public DClubWarSquadListItemAction(DClubWarSquadListItemAction.ActionType type, object ownerIdentifier, string squadId)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Remove,
		[FieldOffset(Offset="0x0")]
		Edit,
		[FieldOffset(Offset="0x0")]
		NewForRebuild,
		[FieldOffset(Offset="0x0")]
		Assign,
		[FieldOffset(Offset="0x0")]
		Battle,
		[FieldOffset(Offset="0x0")]
		GotoNode
	}
}