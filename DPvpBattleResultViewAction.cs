using Il2CppDummyDll;
using System;

public struct DPvpBattleResultViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPvpBattleResultViewAction.Type ActionType;

	[Address(RVA="0xEFEB20", Offset="0xEFEB20", VA="0xEFEB20")]
	public DPvpBattleResultViewAction(DPvpBattleResultViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue
	}
}