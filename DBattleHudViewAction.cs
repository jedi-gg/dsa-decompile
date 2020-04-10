using Il2CppDummyDll;
using System;

public struct DBattleHudViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleHudViewAction.Type ActionType;

	[Address(RVA="0xF02D28", Offset="0xF02D28", VA="0xF02D28")]
	public DBattleHudViewAction(DBattleHudViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		ShowMenu
	}
}