using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AlertTextViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AlertTextView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x115A044", Offset="0x115A044", VA="0x115A044", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115A04C", Offset="0x115A04C", VA="0x115A04C")]
	public AlertTextViewMonoBehaviour()
	{
	}
}