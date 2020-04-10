using Il2CppDummyDll;
using System;

public struct DItemFindEventBattleAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ulong EventId;

	[FieldOffset(Offset="0x8")]
	public readonly DItemFindEventBattleAction.Type EventType;

	[Address(RVA="0xEFE12C", Offset="0xEFE12C", VA="0xEFE12C")]
	public DItemFindEventBattleAction(ulong eventId, DItemFindEventBattleAction.Type eventType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Daily,
		[FieldOffset(Offset="0x0")]
		Scheduled
	}
}