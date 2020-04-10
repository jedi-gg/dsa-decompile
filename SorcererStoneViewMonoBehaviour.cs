using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SorcererStoneViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SorcererStoneView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1240AF8", Offset="0x1240AF8", VA="0x1240AF8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1240B00", Offset="0x1240B00", VA="0x1240B00")]
	public SorcererStoneViewMonoBehaviour()
	{
	}
}