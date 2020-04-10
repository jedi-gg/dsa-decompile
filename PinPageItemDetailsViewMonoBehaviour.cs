using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PinPageItemDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PinPageItemDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1412738", Offset="0x1412738", VA="0x1412738", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1412740", Offset="0x1412740", VA="0x1412740")]
	public PinPageItemDetailsViewMonoBehaviour()
	{
	}
}