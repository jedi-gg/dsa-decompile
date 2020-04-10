using Il2CppDummyDll;
using System;

public struct DBattleInviteViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DBattleInviteViewAction.Type ActionType;

	[Address(RVA="0xF02DE0", Offset="0xF02DE0", VA="0xF02DE0")]
	public DBattleInviteViewAction(DBattleInviteViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		AcceptInvite,
		[FieldOffset(Offset="0x0")]
		DeclineInvite
	}
}