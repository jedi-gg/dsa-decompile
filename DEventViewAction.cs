using Il2CppDummyDll;
using System;

public struct DEventViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DEventViewAction.Type ActionType;

	[Address(RVA="0xF05148", Offset="0xF05148", VA="0xF05148")]
	public DEventViewAction(DEventViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		InstantWinAll
	}
}