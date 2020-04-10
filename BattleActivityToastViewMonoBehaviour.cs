using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleActivityToastViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleActivityToastView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1168984", Offset="0x1168984", VA="0x1168984", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116898C", Offset="0x116898C", VA="0x116898C")]
	public BattleActivityToastViewMonoBehaviour()
	{
	}
}