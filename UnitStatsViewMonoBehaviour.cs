using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitStatsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitStatsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1514F4C", Offset="0x1514F4C", VA="0x1514F4C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1514F54", Offset="0x1514F54", VA="0x1514F54")]
	public UnitStatsViewMonoBehaviour()
	{
	}
}