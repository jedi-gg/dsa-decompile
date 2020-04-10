using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InventoryItemDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InventoryItemDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x136FF18", Offset="0x136FF18", VA="0x136FF18", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136FF20", Offset="0x136FF20", VA="0x136FF20")]
	public InventoryItemDetailsViewMonoBehaviour()
	{
	}
}