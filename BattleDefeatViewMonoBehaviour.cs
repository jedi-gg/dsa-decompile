using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleDefeatViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleDefeatView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1140B28", Offset="0x1140B28", VA="0x1140B28", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1140B30", Offset="0x1140B30", VA="0x1140B30")]
	public BattleDefeatViewMonoBehaviour()
	{
	}
}