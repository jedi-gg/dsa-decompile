using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ItemConversionPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ItemConversionPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x137F460", Offset="0x137F460", VA="0x137F460", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x137F468", Offset="0x137F468", VA="0x137F468")]
	public ItemConversionPopupViewMonoBehaviour()
	{
	}
}