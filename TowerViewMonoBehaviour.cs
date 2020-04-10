using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TowerViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TowerView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x143BFEC", Offset="0x143BFEC", VA="0x143BFEC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143BFF4", Offset="0x143BFF4", VA="0x143BFF4")]
	public TowerViewMonoBehaviour()
	{
	}
}