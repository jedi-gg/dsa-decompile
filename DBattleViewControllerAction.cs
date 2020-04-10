using Il2CppDummyDll;
using System;

public struct DBattleViewControllerAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleViewControllerAction.ActionType Action;

	[Address(RVA="0xF03068", Offset="0xF03068", VA="0xF03068")]
	public DBattleViewControllerAction(DBattleViewControllerAction.ActionType action)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		FinishedLoading
	}
}