using Il2CppDummyDll;
using System;

public struct DBattleCatchupAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleCatchupAction.Type ActionType;

	[Address(RVA="0xF02B24", Offset="0xF02B24", VA="0xF02B24")]
	public DBattleCatchupAction(DBattleCatchupAction.Type actionType)
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