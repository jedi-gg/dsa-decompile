using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpBattleResultsRankViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpBattleResultsRankView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1284B5C", Offset="0x1284B5C", VA="0x1284B5C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1284B64", Offset="0x1284B64", VA="0x1284B64")]
	public PvpBattleResultsRankViewMonoBehaviour()
	{
	}
}