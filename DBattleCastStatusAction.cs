using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleCastStatusAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleCastStatusAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly DBattleAbilityId BattleAbilityId;

	[FieldOffset(Offset="0x14")]
	public readonly ushort CastId;

	[FieldOffset(Offset="0x18")]
	public readonly BattleLib_UpdateResult.Types.CastEnd.Types.Reason EndReason;

	[Address(RVA="0xF02AF0", Offset="0xF02AF0", VA="0xF02AF0")]
	public DBattleCastStatusAction(DBattleCastStatusAction.Type actionType, DBattleAbilityId battleAbilityId, ushort castId)
	{
	}

	[Address(RVA="0xF02B0C", Offset="0xF02B0C", VA="0xF02B0C")]
	public DBattleCastStatusAction(DBattleCastStatusAction.Type actionType, DBattleAbilityId battleAbilityId, ushort castId, BattleLib_UpdateResult.Types.CastEnd.Types.Reason reason)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Start,
		[FieldOffset(Offset="0x0")]
		End
	}
}