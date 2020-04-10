using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleUnitDetailPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleUnitDetailPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x129E7A0", Offset="0x129E7A0", VA="0x129E7A0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x129E7A8", Offset="0x129E7A8", VA="0x129E7A8")]
	public BattleUnitDetailPopupViewMonoBehaviour()
	{
	}
}