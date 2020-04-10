using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public struct DEmoteInventoryItemSelectAction
{
	[FieldOffset(Offset="0x0")]
	public readonly RawImage IconImage;

	[FieldOffset(Offset="0x8")]
	public readonly bool Owned;

	[FieldOffset(Offset="0x10")]
	public readonly ulong EmoteItemId;

	[Address(RVA="0xF04DE4", Offset="0xF04DE4", VA="0xF04DE4")]
	public DEmoteInventoryItemSelectAction(RawImage iconImage, bool owned, ulong emoteItemId)
	{
	}
}