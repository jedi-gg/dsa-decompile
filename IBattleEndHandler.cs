using Serverproto;
using System;

public interface IBattleEndHandler
{
	void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded);

	void HandleBattleQuit();
}