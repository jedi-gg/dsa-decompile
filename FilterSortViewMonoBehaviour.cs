using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class FilterSortViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private FilterSortView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12C9318", Offset="0x12C9318", VA="0x12C9318", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12C9320", Offset="0x12C9320", VA="0x12C9320")]
	public FilterSortViewMonoBehaviour()
	{
	}
}