using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubActivityViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubActivityView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1467B40", Offset="0x1467B40", VA="0x1467B40", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1467B48", Offset="0x1467B48", VA="0x1467B48")]
	public ClubActivityViewMonoBehaviour()
	{
	}
}