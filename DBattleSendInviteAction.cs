using Il2CppDummyDll;
using System;

public struct DBattleSendInviteAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleSendInviteAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly string FriendPublicId;

	[Address(RVA="0xF02EF0", Offset="0xF02EF0", VA="0xF02EF0")]
	public DBattleSendInviteAction(DBattleSendInviteAction.Type actionType, string friendPublicId)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		InviteFriend
	}
}