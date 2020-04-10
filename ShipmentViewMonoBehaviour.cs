using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ShipmentViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ShipmentView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14C36D8", Offset="0x14C36D8", VA="0x14C36D8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14C36E0", Offset="0x14C36E0", VA="0x14C36E0")]
	public ShipmentViewMonoBehaviour()
	{
	}
}