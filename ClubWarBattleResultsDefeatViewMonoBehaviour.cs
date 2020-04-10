using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarBattleResultsDefeatViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarBattleResultsDefeatView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x126A088", Offset="0x126A088", VA="0x126A088", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x126A090", Offset="0x126A090", VA="0x126A090")]
	public ClubWarBattleResultsDefeatViewMonoBehaviour()
	{
	}
}