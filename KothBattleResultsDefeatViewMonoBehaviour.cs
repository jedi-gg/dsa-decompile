using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class KothBattleResultsDefeatViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private KothBattleResultsDefeatView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11CB548", Offset="0x11CB548", VA="0x11CB548", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CB550", Offset="0x11CB550", VA="0x11CB550")]
	public KothBattleResultsDefeatViewMonoBehaviour()
	{
	}
}