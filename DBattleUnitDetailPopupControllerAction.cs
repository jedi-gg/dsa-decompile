using Il2CppDummyDll;
using System;

public struct DBattleUnitDetailPopupControllerAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleUnitDetailPopupControllerAction.ActionType Action;

	[Address(RVA="0xF02FB0", Offset="0xF02FB0", VA="0xF02FB0")]
	public DBattleUnitDetailPopupControllerAction(DBattleUnitDetailPopupControllerAction.ActionType action)
	{
	}

	public enum ActionType
	{
		[FieldOffset(Offset="0x0")]
		Close
	}
}