using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DevOverlayViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private DevOverlayView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x120323C", Offset="0x120323C", VA="0x120323C", Slot="4")]
		get
		{
			return null;
		}
	}

	public override bool UseFontMapping
	{
		[Address(RVA="0x1203244", Offset="0x1203244", VA="0x1203244", Slot="5")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x120324C", Offset="0x120324C", VA="0x120324C")]
	public DevOverlayViewMonoBehaviour()
	{
	}
}