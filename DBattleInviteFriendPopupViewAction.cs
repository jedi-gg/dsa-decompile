using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleInviteFriendPopupViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleInviteFriendPopupViewAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly PlayerProfileSimple SelectedFriend;

	[Address(RVA="0xF02DD4", Offset="0xF02DD4", VA="0xF02DD4")]
	public DBattleInviteFriendPopupViewAction(DBattleInviteFriendPopupViewAction.Type actionType, PlayerProfileSimple friend)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		InviteFriend,
		[FieldOffset(Offset="0x0")]
		InviteClub
	}
}