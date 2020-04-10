using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AgeGateViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AgeGateView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1159084", Offset="0x1159084", VA="0x1159084", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115908C", Offset="0x115908C", VA="0x115908C")]
	public AgeGateViewMonoBehaviour()
	{
	}
}