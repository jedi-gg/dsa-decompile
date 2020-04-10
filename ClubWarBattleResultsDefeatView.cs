using Il2CppDummyDll;
using System;

public class ClubWarBattleResultsDefeatView : AClubWarBattleResultsView
{
	[Address(RVA="0x126A078", Offset="0x126A078", VA="0x126A078")]
	public ClubWarBattleResultsDefeatView()
	{
	}

	[Serializable]
	public class SerializedFields : AClubWarBattleResultsView.ClubWarBattleResultsViewSerializedFields
	{
		[Address(RVA="0x126A080", Offset="0x126A080", VA="0x126A080")]
		public SerializedFields()
		{
		}
	}
}