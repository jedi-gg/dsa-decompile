using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SavedSquadsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SavedSquadsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x2C3E97C", Offset="0x2C3E97C", VA="0x2C3E97C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C3E984", Offset="0x2C3E984", VA="0x2C3E984")]
	public SavedSquadsPopupViewMonoBehaviour()
	{
	}
}