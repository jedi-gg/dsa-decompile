using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpBattleResultsVictoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpBattleResultsVictoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1284DC0", Offset="0x1284DC0", VA="0x1284DC0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1284DC8", Offset="0x1284DC8", VA="0x1284DC8")]
	public PvpBattleResultsVictoryViewMonoBehaviour()
	{
	}
}