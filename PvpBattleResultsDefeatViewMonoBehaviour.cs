using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpBattleResultsDefeatViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpBattleResultsDefeatView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x128481C", Offset="0x128481C", VA="0x128481C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1284824", Offset="0x1284824", VA="0x1284824")]
	public PvpBattleResultsDefeatViewMonoBehaviour()
	{
	}
}