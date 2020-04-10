using Il2CppDummyDll;
using System;

public class KothBattleResultsDefeatView : AKothBattleResultsView
{
	[Address(RVA="0x11CB538", Offset="0x11CB538", VA="0x11CB538")]
	public KothBattleResultsDefeatView()
	{
	}

	[Serializable]
	public class SerializedFields : AKothBattleResultsView.KothBattleResultsViewSerializedFields
	{
		[Address(RVA="0x11CB540", Offset="0x11CB540", VA="0x11CB540")]
		public SerializedFields()
		{
		}
	}
}