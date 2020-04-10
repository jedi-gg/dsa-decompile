using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class StoreViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private StoreView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x131A7EC", Offset="0x131A7EC", VA="0x131A7EC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x131A7F4", Offset="0x131A7F4", VA="0x131A7F4")]
	public StoreViewMonoBehaviour()
	{
	}
}