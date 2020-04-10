using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleStateTransitionViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleStateTransitionView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1294C50", Offset="0x1294C50", VA="0x1294C50", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1294C58", Offset="0x1294C58", VA="0x1294C58")]
	public BattleStateTransitionViewMonoBehaviour()
	{
	}
}