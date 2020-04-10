using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ItemFindViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ItemFindView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11C7884", Offset="0x11C7884", VA="0x11C7884", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11C788C", Offset="0x11C788C", VA="0x11C788C")]
	public ItemFindViewMonoBehaviour()
	{
	}
}