using Il2CppDummyDll;
using System;

public struct DFriendsGiftCelebrationViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DFriendsGiftCelebrationViewAction.Type ActionType;

	[Address(RVA="0xF05494", Offset="0xF05494", VA="0xF05494")]
	public DFriendsGiftCelebrationViewAction(DFriendsGiftCelebrationViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue
	}
}