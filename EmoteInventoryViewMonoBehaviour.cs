using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class EmoteInventoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private EmoteInventoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x120AE48", Offset="0x120AE48", VA="0x120AE48", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x120AE50", Offset="0x120AE50", VA="0x120AE50")]
	public EmoteInventoryViewMonoBehaviour()
	{
	}
}