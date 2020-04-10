using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class GenericActionPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GenericActionPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14EC644", Offset="0x14EC644", VA="0x14EC644", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14EC64C", Offset="0x14EC64C", VA="0x14EC64C")]
	public GenericActionPopupViewMonoBehaviour()
	{
	}
}