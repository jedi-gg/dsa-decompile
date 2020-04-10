using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarBattleResultsVictoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarBattleResultsVictoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x126A524", Offset="0x126A524", VA="0x126A524", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x126A52C", Offset="0x126A52C", VA="0x126A52C")]
	public ClubWarBattleResultsVictoryViewMonoBehaviour()
	{
	}
}