using Il2CppDummyDll;
using System;

public struct DBattleCinematicAction
{
	[FieldOffset(Offset="0x0")]
	public DBattleCinematicAction.Type ActionType;

	[Address(RVA="0xF02B2C", Offset="0xF02B2C", VA="0xF02B2C")]
	public DBattleCinematicAction(DBattleCinematicAction.Type type)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Started,
		[FieldOffset(Offset="0x0")]
		Ended
	}
}