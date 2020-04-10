using Il2CppDummyDll;
using Serverproto;
using System;

public struct DBattleInviteAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleInviteAction.Type ActionType;

	[FieldOffset(Offset="0x8")]
	public readonly BattleInvite Invite;

	[Address(RVA="0xF02D7C", Offset="0xF02D7C", VA="0xF02D7C")]
	public DBattleInviteAction(DBattleInviteAction.Type actionType, BattleInvite invite)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Accept,
		[FieldOffset(Offset="0x0")]
		Remove
	}
}