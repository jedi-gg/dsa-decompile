using Il2CppDummyDll;
using System;

public struct DEmoteInventorySelectedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DEmoteInventorySelectedAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ulong EmoteId;

	[Address(RVA="0xF04E0C", Offset="0xF04E0C", VA="0xF04E0C")]
	public DEmoteInventorySelectedAction(DEmoteInventorySelectedAction.Type actionType, ulong emoteId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Find,
		[FieldOffset(Offset="0x0")]
		BeginEquipFlow
	}
}