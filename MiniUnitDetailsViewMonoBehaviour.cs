using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class MiniUnitDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private MiniUnitDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12F4064", Offset="0x12F4064", VA="0x12F4064", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12F406C", Offset="0x12F406C", VA="0x12F406C")]
	public MiniUnitDetailsViewMonoBehaviour()
	{
	}
}