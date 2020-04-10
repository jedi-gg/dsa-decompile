using Il2CppDummyDll;
using System;

public struct DBattleStateTransitionViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleStateTransitionViewAction.Type ActionType;

	[Address(RVA="0xF02EFC", Offset="0xF02EFC", VA="0xF02EFC")]
	public DBattleStateTransitionViewAction(DBattleStateTransitionViewAction.Type action)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShowCompleted,
		[FieldOffset(Offset="0x0")]
		HideCompleted
	}
}