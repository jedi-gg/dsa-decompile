using Il2CppDummyDll;
using Serverproto;
using System;

public struct DEventTierListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DEventTierListItemAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly EventIdentifier EventId;

	[Address(RVA="0xF0513C", Offset="0xF0513C", VA="0xF0513C")]
	public DEventTierListItemAction(DEventTierListItemAction.Type actionType, EventIdentifier eventId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		EnterBattle,
		[FieldOffset(Offset="0x0")]
		InstantBattle
	}
}