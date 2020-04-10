using Il2CppDummyDll;
using System;

public class PvpBattleResultsDefeatView : APvpBattleResultsView
{
	[Address(RVA="0x128480C", Offset="0x128480C", VA="0x128480C")]
	public PvpBattleResultsDefeatView()
	{
	}

	[Serializable]
	public class SerializedFields : APvpBattleResultsView.PvpBattleResultViewSerializedFields
	{
		[Address(RVA="0x1284814", Offset="0x1284814", VA="0x1284814")]
		public SerializedFields()
		{
		}
	}
}