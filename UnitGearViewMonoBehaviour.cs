using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitGearViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitGearView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x15018F0", Offset="0x15018F0", VA="0x15018F0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15018F8", Offset="0x15018F8", VA="0x15018F8")]
	public UnitGearViewMonoBehaviour()
	{
	}
}