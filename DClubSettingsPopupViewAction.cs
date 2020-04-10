using Il2CppDummyDll;
using System;

public struct DClubSettingsPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DClubSettingsPopupViewAction.Type ActionType;

	[Address(RVA="0xF04110", Offset="0xF04110", VA="0xF04110")]
	public DClubSettingsPopupViewAction(DClubSettingsPopupViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		EditAvatar,
		[FieldOffset(Offset="0x0")]
		Submit,
		[FieldOffset(Offset="0x0")]
		Cancel
	}
}