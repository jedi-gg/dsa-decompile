using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpBattleResultsBackdropViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpBattleResultsBackdropView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1282E04", Offset="0x1282E04", VA="0x1282E04", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1282E0C", Offset="0x1282E0C", VA="0x1282E0C")]
	public PvpBattleResultsBackdropViewMonoBehaviour()
	{
	}
}