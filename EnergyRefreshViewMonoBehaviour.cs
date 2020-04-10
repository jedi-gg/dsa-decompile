using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class EnergyRefreshViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private EnergyRefreshView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12123C0", Offset="0x12123C0", VA="0x12123C0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12123C8", Offset="0x12123C8", VA="0x12123C8")]
	public EnergyRefreshViewMonoBehaviour()
	{
	}
}