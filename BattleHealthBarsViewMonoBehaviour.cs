using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleHealthBarsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleHealthBarsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x10FD030", Offset="0x10FD030", VA="0x10FD030", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10FD038", Offset="0x10FD038", VA="0x10FD038")]
	public BattleHealthBarsViewMonoBehaviour()
	{
	}
}