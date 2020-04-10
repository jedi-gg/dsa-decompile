using Il2CppDummyDll;
using System;

public struct DBattleMenuViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleMenuViewAction.Type ActionType;

	[Address(RVA="0xF02DE8", Offset="0xF02DE8", VA="0xF02DE8")]
	public DBattleMenuViewAction(DBattleMenuViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Quit,
		[FieldOffset(Offset="0x0")]
		StatusEffects
	}
}