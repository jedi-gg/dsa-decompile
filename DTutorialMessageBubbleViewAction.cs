using Il2CppDummyDll;
using System;

public struct DTutorialMessageBubbleViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DTutorialMessageBubbleViewAction.Type ActionType;

	[Address(RVA="0xEFFB0C", Offset="0xEFFB0C", VA="0xEFFB0C")]
	public DTutorialMessageBubbleViewAction(DTutorialMessageBubbleViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue
	}
}