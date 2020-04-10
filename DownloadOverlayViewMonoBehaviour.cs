using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DownloadOverlayViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private DownloadOverlayView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1205CE8", Offset="0x1205CE8", VA="0x1205CE8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1205CF0", Offset="0x1205CF0", VA="0x1205CF0")]
	public DownloadOverlayViewMonoBehaviour()
	{
	}
}