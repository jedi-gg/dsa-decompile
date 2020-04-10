using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BonusLootDetailsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BonusLootDetailsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x112022C", Offset="0x112022C", VA="0x112022C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1120234", Offset="0x1120234", VA="0x1120234")]
	public BonusLootDetailsPopupViewMonoBehaviour()
	{
	}
}