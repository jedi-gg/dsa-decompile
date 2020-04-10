using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DailyLoginViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private DailyLoginView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12B24A0", Offset="0x12B24A0", VA="0x12B24A0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12B24A8", Offset="0x12B24A8", VA="0x12B24A8")]
	public DailyLoginViewMonoBehaviour()
	{
	}
}