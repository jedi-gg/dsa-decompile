using Il2CppDummyDll;
using System;

public struct DClubWarViewNodeAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubWarViewNodeAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string NodeId;

	[Address(RVA="0xF0480C", Offset="0xF0480C", VA="0xF0480C")]
	public DClubWarViewNodeAction(DClubWarViewNodeAction.Type actionType, string nodeId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Clicked
	}
}