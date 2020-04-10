using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class StoreItemGrantOddsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private StoreItemGrantOddsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x130F418", Offset="0x130F418", VA="0x130F418", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x130F420", Offset="0x130F420", VA="0x130F420")]
	public StoreItemGrantOddsPopupViewMonoBehaviour()
	{
	}
}