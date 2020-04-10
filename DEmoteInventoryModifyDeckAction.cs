using Il2CppDummyDll;
using System;

public struct DEmoteInventoryModifyDeckAction
{
	[FieldOffset(Offset="0x0")]
	public readonly int SlotIndex;

	[FieldOffset(Offset="0x8")]
	public readonly ulong EmoteId;

	[Address(RVA="0xF04DF8", Offset="0xF04DF8", VA="0xF04DF8")]
	public DEmoteInventoryModifyDeckAction(int slotIndex, ulong emoteId)
	{
	}
}