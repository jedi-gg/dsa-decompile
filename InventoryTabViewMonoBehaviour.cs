using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InventoryTabViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ATabView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1371AB0", Offset="0x1371AB0", VA="0x1371AB0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1371AB8", Offset="0x1371AB8", VA="0x1371AB8")]
	public InventoryTabViewMonoBehaviour()
	{
	}
}