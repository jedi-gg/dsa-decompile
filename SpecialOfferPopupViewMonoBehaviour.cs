using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SpecialOfferPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SpecialOfferPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1241784", Offset="0x1241784", VA="0x1241784", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x124178C", Offset="0x124178C", VA="0x124178C")]
	public SpecialOfferPopupViewMonoBehaviour()
	{
	}
}