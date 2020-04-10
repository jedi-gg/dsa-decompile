using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DailyActivityViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private DailyActivityView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12AD71C", Offset="0x12AD71C", VA="0x12AD71C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12AD724", Offset="0x12AD724", VA="0x12AD724")]
	public DailyActivityViewMonoBehaviour()
	{
	}
}