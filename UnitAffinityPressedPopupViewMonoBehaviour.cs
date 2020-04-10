using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitAffinityPressedPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitAffinityPressedPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11DEE84", Offset="0x11DEE84", VA="0x11DEE84", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11DEE8C", Offset="0x11DEE8C", VA="0x11DEE8C")]
	public UnitAffinityPressedPopupViewMonoBehaviour()
	{
	}
}