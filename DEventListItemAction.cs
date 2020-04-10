using Il2CppDummyDll;
using System;

public struct DEventListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DEventListItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong EventContentId;

	[Address(RVA="0xF04F8C", Offset="0xF04F8C", VA="0xF04F8C")]
	public DEventListItemAction(DEventListItemAction.Type actionType, ulong eventContentId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		EnterBattle,
		[FieldOffset(Offset="0x0")]
		EventExpired
	}
}