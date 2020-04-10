using Il2CppDummyDll;
using System;

public struct DKothBattleResultsViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly DKothBattleResultsViewAction.Type ActionType;

	[Address(RVA="0xEFE1FC", Offset="0xEFE1FC", VA="0xEFE1FC")]
	public DKothBattleResultsViewAction(DKothBattleResultsViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Continue
	}
}