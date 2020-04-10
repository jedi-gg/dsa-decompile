using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitRoleDetailViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitRoleDetailView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x150CC0C", Offset="0x150CC0C", VA="0x150CC0C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x150CC14", Offset="0x150CC14", VA="0x150CC14")]
	public UnitRoleDetailViewMonoBehaviour()
	{
	}
}