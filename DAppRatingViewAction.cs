using Il2CppDummyDll;
using System;

public struct DAppRatingViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DAppRatingViewAction.Type ActionType;

	[Address(RVA="0xF02530", Offset="0xF02530", VA="0xF02530")]
	public DAppRatingViewAction(DAppRatingViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Go,
		[FieldOffset(Offset="0x0")]
		Cancel
	}
}