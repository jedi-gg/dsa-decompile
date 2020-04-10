using Il2CppDummyDll;
using System;

public struct DEmoteWidgetAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DEmoteWidgetAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly object OwnerIdentifier;

	[Address(RVA="0xF04F4C", Offset="0xF04F4C", VA="0xF04F4C")]
	public DEmoteWidgetAction(DEmoteWidgetAction.Type action, object ownerIdentifier)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Played,
		[FieldOffset(Offset="0x0")]
		Stopped
	}
}