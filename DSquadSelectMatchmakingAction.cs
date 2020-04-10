using Il2CppDummyDll;
using System;

public struct DSquadSelectMatchmakingAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DSquadSelectMatchmakingAction.Type ActionType;

	[Address(RVA="0xEFF778", Offset="0xEFF778", VA="0xEFF778")]
	public DSquadSelectMatchmakingAction(DSquadSelectMatchmakingAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		MatchmakingFailed,
		[FieldOffset(Offset="0x0")]
		MatchmakingCanceled
	}
}