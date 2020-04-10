using Il2CppDummyDll;
using System;

public struct DAboutGameViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DAboutGameViewAction.Type ActionType;

	[Address(RVA="0xF02354", Offset="0xF02354", VA="0xF02354")]
	public DAboutGameViewAction(DAboutGameViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		AttributionClicked
	}
}