using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerProfileEditPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PlayerProfileEditPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1340CBC", Offset="0x1340CBC", VA="0x1340CBC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1340CC4", Offset="0x1340CC4", VA="0x1340CC4")]
	public PlayerProfileEditPopupViewMonoBehaviour()
	{
	}
}