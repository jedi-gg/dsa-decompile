using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitListViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitListView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x150B34C", Offset="0x150B34C", VA="0x150B34C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x150B354", Offset="0x150B354", VA="0x150B354")]
	public UnitListViewMonoBehaviour()
	{
	}
}