using Il2CppDummyDll;
using System;

public struct DBattlePlayEmoteAction
{
	[FieldOffset(Offset="0x0")]
	public readonly uint PlayerId;

	[FieldOffset(Offset="0x8")]
	public readonly ulong EmoteId;

	[Address(RVA="0xF02DF8", Offset="0xF02DF8", VA="0xF02DF8")]
	public DBattlePlayEmoteAction(uint playerId, ulong emoteId)
	{
	}
}