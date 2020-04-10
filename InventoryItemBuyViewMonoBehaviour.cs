using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InventoryItemBuyViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InventoryItemBuyView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x136DED8", Offset="0x136DED8", VA="0x136DED8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136DEE0", Offset="0x136DEE0", VA="0x136DEE0")]
	public InventoryItemBuyViewMonoBehaviour()
	{
	}
}