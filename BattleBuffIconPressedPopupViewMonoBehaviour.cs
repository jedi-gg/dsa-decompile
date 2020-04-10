using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleBuffIconPressedPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleBuffIconPressedPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1137F20", Offset="0x1137F20", VA="0x1137F20", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1137F28", Offset="0x1137F28", VA="0x1137F28")]
	public BattleBuffIconPressedPopupViewMonoBehaviour()
	{
	}
}