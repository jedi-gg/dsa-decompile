using Il2CppDummyDll;
using System;

public struct DPackOpeningViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPackOpeningViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong CostItemId;

	[Address(RVA="0xEFE5E0", Offset="0xEFE5E0", VA="0xEFE5E0")]
	public DPackOpeningViewAction(DPackOpeningViewAction.Type actionType, ulong costItemId = 0L)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue,
		[FieldOffset(Offset="0x0")]
		ExitFinished,
		[FieldOffset(Offset="0x0")]
		BuyAgain
	}
}