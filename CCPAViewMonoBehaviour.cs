using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class CCPAViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private CCPAView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1123DE8", Offset="0x1123DE8", VA="0x1123DE8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1123DF0", Offset="0x1123DF0", VA="0x1123DF0")]
	public CCPAViewMonoBehaviour()
	{
	}
}