using Il2CppDummyDll;
using Serverproto;
using System;

public struct DHomeDailyActivityButtonAction
{
	[FieldOffset(Offset="0x0")]
	public readonly HomeDailyActivityButton Button;

	[FieldOffset(Offset="0x8")]
	public readonly DHomeDailyActivityButtonAction.Type ActionType;

	[FieldOffset(Offset="0x10")]
	public readonly PlayerActivity Activity;

	[Address(RVA="0xEFD860", Offset="0xEFD860", VA="0xEFD860")]
	public DHomeDailyActivityButtonAction(HomeDailyActivityButton button, DHomeDailyActivityButtonAction.Type actionType, PlayerActivity activity)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		GoToActivityList,
		[FieldOffset(Offset="0x0")]
		GoToActivity,
		[FieldOffset(Offset="0x0")]
		Claim
	}
}