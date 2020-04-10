using Il2CppDummyDll;
using System;

public struct DPlayerProfileAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DPlayerProfileAction.Type ActionType;

	[Address(RVA="0xEFE91C", Offset="0xEFE91C", VA="0xEFE91C")]
	public DPlayerProfileAction(DPlayerProfileAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Edit,
		[FieldOffset(Offset="0x0")]
		UsernameChanged,
		[FieldOffset(Offset="0x0")]
		AvatarChanged,
		[FieldOffset(Offset="0x0")]
		GoToClub,
		[FieldOffset(Offset="0x0")]
		VipBgChanged,
		[FieldOffset(Offset="0x0")]
		AddFriend
	}
}