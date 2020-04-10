using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitStatsDescriptionViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitStatsDescriptionView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1513D18", Offset="0x1513D18", VA="0x1513D18", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1513D20", Offset="0x1513D20", VA="0x1513D20")]
	public UnitStatsDescriptionViewMonoBehaviour()
	{
	}
}