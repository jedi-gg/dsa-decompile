using Il2CppDummyDll;
using System;

public struct DPackOpeningCardAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPackOpeningCardAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly PackOpeningCardWidget CardWidget;

	[Address(RVA="0xEFE514", Offset="0xEFE514", VA="0xEFE514")]
	public DPackOpeningCardAction(DPackOpeningCardAction.Type actionType, PackOpeningCardWidget cardWidget)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		RevealBegan,
		[FieldOffset(Offset="0x0")]
		RevealFinished
	}
}