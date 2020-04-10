using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitInventoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitInventoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1507E68", Offset="0x1507E68", VA="0x1507E68", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1507E70", Offset="0x1507E70", VA="0x1507E70")]
	public UnitInventoryViewMonoBehaviour()
	{
	}
}