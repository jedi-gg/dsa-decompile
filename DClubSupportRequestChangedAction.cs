using Il2CppDummyDll;
using Serverproto;
using System;

public struct DClubSupportRequestChangedAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubSupportRequestChangedAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly ClubSupportRequest SupportRequest;

	[Address(RVA="0xF04330", Offset="0xF04330", VA="0xF04330")]
	public DClubSupportRequestChangedAction(DClubSupportRequestChangedAction.Type actionType, ClubSupportRequest supportRequest)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Added,
		[FieldOffset(Offset="0x0")]
		Updated,
		[FieldOffset(Offset="0x0")]
		Remove,
		[FieldOffset(Offset="0x0")]
		RemoveAll
	}
}