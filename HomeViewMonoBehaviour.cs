using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class HomeViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private HomeView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11769B4", Offset="0x11769B4", VA="0x11769B4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11769BC", Offset="0x11769BC", VA="0x11769BC")]
	public HomeViewMonoBehaviour()
	{
	}
}