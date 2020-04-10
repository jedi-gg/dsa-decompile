using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class EventViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AEventView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12B95BC", Offset="0x12B95BC", VA="0x12B95BC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12B95C4", Offset="0x12B95C4", VA="0x12B95C4")]
	public EventViewMonoBehaviour()
	{
	}
}