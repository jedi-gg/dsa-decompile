using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TowerSelectViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TowerSelectView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x143AAF8", Offset="0x143AAF8", VA="0x143AAF8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143AB00", Offset="0x143AB00", VA="0x143AB00")]
	public TowerSelectViewMonoBehaviour()
	{
	}
}