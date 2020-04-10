using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleVictoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleVictoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12A3AC8", Offset="0x12A3AC8", VA="0x12A3AC8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12A3AD0", Offset="0x12A3AD0", VA="0x12A3AD0")]
	public BattleVictoryViewMonoBehaviour()
	{
	}
}