using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleBuffIconGlossaryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleBuffIconGlossaryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11379B4", Offset="0x11379B4", VA="0x11379B4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11379BC", Offset="0x11379BC", VA="0x11379BC")]
	public BattleBuffIconGlossaryViewMonoBehaviour()
	{
	}
}