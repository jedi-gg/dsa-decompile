using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class StoreItemDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private StoreItemDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x130E4C8", Offset="0x130E4C8", VA="0x130E4C8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x130E4D0", Offset="0x130E4D0", VA="0x130E4D0")]
	public StoreItemDetailsViewMonoBehaviour()
	{
	}
}