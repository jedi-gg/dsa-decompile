using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class KothBattleResultsVictoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private KothBattleResultsVictoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11CD048", Offset="0x11CD048", VA="0x11CD048", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CD050", Offset="0x11CD050", VA="0x11CD050")]
	public KothBattleResultsVictoryViewMonoBehaviour()
	{
	}
}