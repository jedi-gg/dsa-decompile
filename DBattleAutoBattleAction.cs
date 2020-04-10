using Il2CppDummyDll;
using System;

public struct DBattleAutoBattleAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleAutoBattleAction.Type ActionType;

	[FieldOffset(Offset="0x4")]
	public readonly bool? IsPlayOn;

	[Address(RVA="0xF02A54", Offset="0xF02A54", VA="0xF02A54")]
	public DBattleAutoBattleAction(DBattleAutoBattleAction.Type actionType, bool? isPlayOn)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ToggleSpeed,
		[FieldOffset(Offset="0x0")]
		TogglePlay
	}
}