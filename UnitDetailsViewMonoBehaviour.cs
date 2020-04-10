using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11EBE54", Offset="0x11EBE54", VA="0x11EBE54", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11EBE5C", Offset="0x11EBE5C", VA="0x11EBE5C")]
	public UnitDetailsViewMonoBehaviour()
	{
	}
}