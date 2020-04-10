using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitTrainingViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitTrainingView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1518404", Offset="0x1518404", VA="0x1518404", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x151840C", Offset="0x151840C", VA="0x151840C")]
	public UnitTrainingViewMonoBehaviour()
	{
	}
}