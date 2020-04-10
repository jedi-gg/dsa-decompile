using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SeekerViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SeekerView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x2C4254C", Offset="0x2C4254C", VA="0x2C4254C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C42554", Offset="0x2C42554", VA="0x2C42554")]
	public SeekerViewMonoBehaviour()
	{
	}
}