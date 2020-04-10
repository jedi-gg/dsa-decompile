using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class StoreItemOddsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private StoreItemOddsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1310A68", Offset="0x1310A68", VA="0x1310A68", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1310A70", Offset="0x1310A70", VA="0x1310A70")]
	public StoreItemOddsPopupViewMonoBehaviour()
	{
	}
}