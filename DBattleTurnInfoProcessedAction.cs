using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public struct DBattleTurnInfoProcessedAction
{
	[FieldOffset(Offset="0x0")]
	public IList<BattleLib_UpdateResult.Types.UnitTurnInfo> UnitTurnInfos;

	[Address(RVA="0xF02F50", Offset="0xF02F50", VA="0xF02F50")]
	public DBattleTurnInfoProcessedAction(IList<BattleLib_UpdateResult.Types.UnitTurnInfo> unitTurnInfos)
	{
	}
}